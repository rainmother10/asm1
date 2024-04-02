using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM1
{
    internal class Appdata
    {
        public const int ROLE_User = 2;
        public const int ROLE_ADmin = 1;
        
        public static bool islogin = false;
        public static string username;
        public static string password;
        public static int role;
        public static int userid;
        
    }
}
