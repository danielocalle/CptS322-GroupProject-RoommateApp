using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Dapper;

namespace RoommateAppLibrary
{
    public class SQLiteDataAccess
    {
        public static bool CreateAccount(AccountLoginInfo newAccountInfo)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                // Query to find if their is someone already with the specific username
                var output = cnn.QueryFirstOrDefault<AccountLoginInfo>(
                "select * from LoginInfo where username = @Username",
                    new { Username = newAccountInfo.Username }); // Passing parameters

                if (output == null)
                {
                    cnn.Execute("insert into LoginInfo " +
                        "(username, password, recovery, firstname, lastname) values " +
                        "(@Username, @Password, @Recovery, @FirstName, @LastName)", newAccountInfo);
                    cnn.Execute("insert into UserInfo " +
                        "(username, firstname, lastname) values " +
                        "(@Username, @FirstName, @LastName)", newAccountInfo);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        // this saves the users preferences to the database
        public static void SavePreferences(UserInfoWithInt user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string preferences = user.User.prefs.ConvertPreferencesToString();
                try
                {

                    cnn.Execute(
                            "UPDATE UserInfo SET aboutme = @NewAboutme, preferences = @NewPref WHERE username = @Username",
                            new { NewAboutme = user.User.aboutMe, NewPref = preferences, Username = user.User.account.Username });
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error:" + ex.ToString());
                }

            }

        }
        // this function gets a singular user (we use the single user to have access to that users info so we can display it in our matches page)
        public static UserInfoWithInt GetUserInfo (string username)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                // Query to get user data
                var query = "SELECT username, firstname, lastname, aboutme, preferences FROM UserInfo Where username = @Username";
                var userInfo = cnn.QueryFirstOrDefault<dynamic>(query, new { Username = username });

                if (userInfo != null)
                {
                    var account = new AccountLoginInfo(userInfo.username, "placeholder", null, userInfo.firstname, userInfo.lastname);
                    
                    var preferences = new Preferences
                    {
                        isQuiet = userInfo.preferences[0] == '1',
                        hasPets = userInfo.preferences[1] == '1',
                        earlyRiser = userInfo.preferences[2] == '1',
                        stayUpLate = userInfo.preferences[3] == '1',
                        spentTimeRoommate = userInfo.preferences[4] == '1',
                        CommonAreaTidy = userInfo.preferences[5] == '1'
                    };

                    var user = new UserInfo(account, preferences, userInfo.aboutme);




                    return new UserInfoWithInt(user, 0);
                }
                return null;
            }


        }




        // function for getting list of users from the database
        public static List<UserInfoWithInt> GetListOfUsers()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                // Query to get user data
                var query = "SELECT username, firstname, lastname, aboutme, preferences FROM UserInfo";
                var userInfos = cnn.Query<dynamic>(query).ToList();

                var userInfoWithIntList = userInfos.Select(row =>
                {
                    var account = new AccountLoginInfo(row.username, "placeholder", null, row.firstname, row.lastname); 
                    var preferences = new Preferences
                    {
                        isQuiet = row.preferences[0] == '1',
                        hasPets = row.preferences[1] == '1',
                        earlyRiser = row.preferences[2] == '1',
                        stayUpLate = row.preferences[3] == '1',
                        spentTimeRoommate = row.preferences[4] == '1',
                        CommonAreaTidy = row.preferences[5] == '1'
                    };

                    var userInfo = new UserInfo(account, preferences, row.aboutme)
                    {
                        firstname = row.firstname,
                        lastname = row.lastname
                    };

                    
                    return new UserInfoWithInt(userInfo, 0);
                }).ToList();

                return userInfoWithIntList;
            }
        }

        




        public static bool VerifyLogin(ref AccountLoginInfo accountInfo)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                // Query to find the person with the specific username and password
                var output = cnn.QueryFirstOrDefault<AccountLoginInfo>(
                    "select * from LoginInfo where username = @Username and password = @Password",
                    new { Username = accountInfo.Username, Password = accountInfo.Password }); // Passing parameters

                if (output == null)
                {
                    return false;
                }
                else
                {
                    accountInfo = output;
                    return true;
                }
            }
        }

        public static bool ChangePassword(AccountLoginInfo accountInfo)
        {
            // Query to find the person with the specific username and recovery string
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                // Query to find the person with the specific username and recovery string
                var output = cnn.QueryFirstOrDefault<AccountLoginInfo>(
                    "select * from LoginInfo where username = @Username and recovery = @Recovery",
                    new { Username = accountInfo.Username, Recovery = accountInfo.Recovery }); // Passing parameters

                if (output != null)
                {
                    cnn.Execute(
                        "update LoginInfo set password = @NewPassword where username = @Username and recovery = @Recovery",
                        new { NewPassword = accountInfo.Password, Username = accountInfo.Username, Recovery = accountInfo.Recovery });

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
