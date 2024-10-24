using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace RoommateAppLibrary
{
    public class AccountLoginInfo
    {
        private string _password;

        private string _recovery;

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

        public string Password {  get; set; }

        public string Recovery {  get; set; }

        public AccountLoginInfo(string username, string password,
                                    string recovery = null,
                                    string firstname = null,
                                    string lastname = null)
        {
            Username = username;
            Password = Hash(password);

            if (!string.IsNullOrEmpty(recovery))
            {
                Recovery = Hash(recovery);
            }

            FirstName = firstname;
            LastName = lastname;
        }

        private static string Hash(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Convert password to byte array
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

                // Compute the hash
                byte[] hashBytes = sha256.ComputeHash(passwordBytes);

                // Convert the byte array to a hexadecimal string and return
                StringBuilder hashString = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    hashString.Append(b.ToString("x2")); // Convert byte to hex
                }

                return hashString.ToString();
            }
        }
    }
}
