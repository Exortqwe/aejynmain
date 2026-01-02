using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aejynmain.Models
{
    internal class User
    {
        public static int UserID { get; private set; }
        public static string UserName { get; private set; }
        public static string Role { get; private set; }
        public static bool LoggedIn => UserID > 0;

        public static void SetUser(int userId, string userName, string role)
        {
            UserID = userId;
            UserName = userName;
            Role = role;
        }

        public static void Logout()
        {
            UserID = 0;
            UserName = null;
            Role = null;
        }
    }
}
    

