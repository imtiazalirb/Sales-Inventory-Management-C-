using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
    class Logins
    {
        SqlConnection conn;
        public Logins()
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-DQILLPK\SQLEXPRESS;Initial Catalog=Sales;User ID=sa;Password=1234;");
        }
        public void AddLogin(Login l)
        {
            conn.Open();
            string query = "INSERT INTO Login (Username,Password,Usertype) VALUES('" + l.Username + "','" + l.Password + "','" + l.Usertype + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void DeleteLogin(Login l)
        {
            conn.Open();
            string query = "DELETE FROM [dbo].[Login] WHERE Username = '" + l.Username + "';";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
