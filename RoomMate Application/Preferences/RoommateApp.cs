using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoommateAppLibrary
{
    
    public class RoommateApp
    {
        public List<UserInfoWithInt> user = new List<UserInfoWithInt>();


        // we're gonna have a static method evaluate that will deal with match points

        public static int CalculateScore(Preferences preferences)
        {
            // Example scoring: count the number of true preferences
            return (preferences.isQuiet ? 1 : 0) +
                   (preferences.hasPets ? 1 : 0) +
                   (preferences.earlyRiser ? 1 : 0) +
                   (preferences.stayUpLate ? 1 : 0) +
                   (preferences.spentTimeRoommate ? 1 : 0) +
                   (preferences.CommonAreaTidy ? 1 : 0);
        }

        public static List<UserInfoWithInt> RankUsers(List<UserInfoWithInt> users, string loggedInUsername)
        {
            // Exclude the logged-in user
            var filteredUsers = users
                .Where(user => user.User.account.Username != loggedInUsername)
                .OrderByDescending(user => user.Score)
                .ToList();

            return filteredUsers;
        }

       

       
    }
}
