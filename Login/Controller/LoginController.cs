using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model;
using System.Collections;

namespace Project.Controller
{
    class LoginController
    {
        static Database db = new Database();
        public static void AddLogin(string username, string password, string usertype)
        {
            Login l = new Login()
            {
                Username = username,
                Password = password,
                Usertype = usertype,               
            };
            db.Logins.AddLogin(l);
        }
        public static void DeleteLogin(string username)
        {
            Login l = new Login()
            {
                Username = username,
            };
            db.Logins.DeleteLogin(l);
        }
    }
}
