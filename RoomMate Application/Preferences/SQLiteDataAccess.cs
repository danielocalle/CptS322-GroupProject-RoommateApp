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
using System.Runtime.InteropServices;

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

        public static UserInfo GetUserInfo(AccountLoginInfo account)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var query = @"
                    SELECT username, firstname, lastname, aboutme, preferences 
                    FROM UserInfo 
                    WHERE username = @Username";

                var result = cnn.QueryFirstOrDefault(query, new { Username = account.Username });

                var preferences = new Preferences(result.preferences);

                UserInfo userInfo;

                userInfo = new UserInfo(account, preferences, result.firstname, result.lastname, result.aboutme);

                return userInfo;
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

        public static void CreateRoommateRequestsTable()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string query = @"
            CREATE TABLE IF NOT EXISTS RoommateRequests (
                RequestId INTEGER PRIMARY KEY AUTOINCREMENT,
                SenderUsername TEXT NOT NULL,
                ReceiverUsername TEXT NOT NULL,
                Status TEXT NOT NULL -- 'Pending', 'Accepted', or 'Rejected'
            )";
                cnn.Execute(query);
            }
        }

        public static bool SendRoommateRequest(string senderUsername, string receiverUsername)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                // Check if a request already exists between the sender and receiver
                var existingRequest = cnn.QueryFirstOrDefault<RoommateRequest>(
                    "SELECT * FROM RoommateRequests WHERE SenderUsername = @Sender AND ReceiverUsername = @Receiver AND Status = 'Pending'",
                    new { Sender = senderUsername, Receiver = receiverUsername });

                if (existingRequest != null)
                {
                    return false; // A request already exists
                }

                // Insert the new request as 'Pending'
                cnn.Execute(
                    "INSERT INTO RoommateRequests (SenderUsername, ReceiverUsername, Status) VALUES (@Sender, @Receiver, 'Pending')",
                    new { Sender = senderUsername, Receiver = receiverUsername });

                return true; // Request successfully sent
            }
        }

        

        public static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

      

    }
}
