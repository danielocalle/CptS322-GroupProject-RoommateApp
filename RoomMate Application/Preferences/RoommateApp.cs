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

        // calculates the similarity scores between the logged in user and all the other users
        public static int CalculateScore(Preferences loggedInUserPreferences, Preferences otherUserPreferences)
        {
            int score = 0;

            if (loggedInUserPreferences.isQuiet == otherUserPreferences.isQuiet) score++;
            if (loggedInUserPreferences.hasPets == otherUserPreferences.hasPets) score++;
            if (loggedInUserPreferences.earlyRiser == otherUserPreferences.earlyRiser) score++;
            if (loggedInUserPreferences.stayUpLate == otherUserPreferences.stayUpLate) score++;
            if (loggedInUserPreferences.spentTimeRoommate == otherUserPreferences.spentTimeRoommate) score++;
            if (loggedInUserPreferences.CommonAreaTidy == otherUserPreferences.CommonAreaTidy) score++;

            return score;
        }

        // ranks the users from greatest to least by score
        public static IEnumerable<UserInfoWithInt> RankUsers(List<UserInfoWithInt> users, string loggedInUsername)
        {
            // Get the logged-in user's preferences
            var loggedInUser = users.FirstOrDefault(user => user.User.account.Username == loggedInUsername);
            if (loggedInUser == null) throw new ArgumentException("Logged-in user not found.");

            var loggedInPreferences = loggedInUser.User.prefs;

            // Calculate scores for all other users and exclude the logged-in user
            foreach (var user in users)
            {
                if (user.User.account.Username != loggedInUsername)
                {
                    user.Score = CalculateScore(loggedInPreferences, user.User.prefs);
                }
            }

            // Return the ranked list of users, sorted by score in descending order
            return users
                .Where(user => user.User.account.Username != loggedInUsername)
                .OrderByDescending(user => user.Score);

        }

       

       
    }
}
