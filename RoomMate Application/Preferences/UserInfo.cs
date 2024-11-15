using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoommateAppLibrary
{
    public class UserInfo
    {
        public AccountLoginInfo account;
        public Preferences prefs;
        public string firstname;
        public string lastname;
        public string aboutMe;




        // the users roommate info that we want to display

        public UserInfo(AccountLoginInfo userName, Preferences Pref, string Aboutme)
        {
            this.account = userName;

            this.prefs = Pref;
            this.aboutMe = Aboutme;

        }


        // will get the data from a database

        // i think with this we want to find the specific roommate and store it in the object and display it on the users page

        // this takes the dictionary full of users and when someone clicks on a profile
        // we would have a function that will display their info

    }
}
