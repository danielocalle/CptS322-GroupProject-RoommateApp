using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoommateAppLibrary
{
    
    public class RoommateApp
    {
        public UserInfo userInfo;
        public RoommateApp app = new RoommateApp();
        public List<UserInfoWithInt> userList = new List<UserInfoWithInt>();
        

        // we're gonna have a static method evaluate that will deal with match points

        public void GetListofUsers()
        {
            userList = SQLiteDataAccess.GetListofUsers();

        }

        public int Evaluate(UserInfoWithInt mainUser, List<UserInfoWithInt> List)
        {
            //    GetListofUsers();
            // still implementing this
            int num = 0;
            return num;

        }


    }
}
