using RoommateAppLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomMateAppLibrary
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public Preferences userPreferences { get; set; }
        public User(int userid, string name, Preferences preferences)
        {
            UserId = userid;
            Name = name;
            userPreferences = preferences;
        }
    }

    public class MatchHandler
    {
        public static int CalculateValue(User firstUser, User secondUser)
        {
            int matchingValue = 0;

            if (firstUser.userPreferences.isQuiet == secondUser.userPreferences.isQuiet)
            {
                matchingValue++;
            }

            if (firstUser.userPreferences.hasPets == secondUser.userPreferences.hasPets)
            {
                matchingValue++;
            }

            if (firstUser.userPreferences.earlyRiser == secondUser.userPreferences.earlyRiser)
            {
                matchingValue++;
            }

            if (firstUser.userPreferences.stayUpLate == secondUser.userPreferences.stayUpLate)
            {
                matchingValue++;
            }

            if (firstUser.userPreferences.spentTimeRoommate == secondUser.userPreferences.spentTimeRoommate)
            {
                matchingValue++;
            }

            if (firstUser.userPreferences.CommonAreaTidy == secondUser.userPreferences.CommonAreaTidy)
            {
                matchingValue++;
            }

            // Check if there are 5 or more matching preferences it is an automatic match
            if (matchingValue >= 5)
            {
                return -1;
            }

            // Otherwise, return the matching value
            return matchingValue;
        }
    }
}