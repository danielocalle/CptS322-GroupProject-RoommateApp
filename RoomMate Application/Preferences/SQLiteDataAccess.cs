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
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool VerifyLogin(AccountLoginInfo accountInfo)
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
