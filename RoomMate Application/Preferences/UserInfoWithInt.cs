using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoommateAppLibrary
{
    public class UserInfoWithInt
    {
       public UserInfo User { get; set; }
        public int Score { get; set; }

        public UserInfoWithInt(UserInfo user, int score) { 
        
            this.User = user;
            this.Score = score; 
        
        
        }   
    }
}
