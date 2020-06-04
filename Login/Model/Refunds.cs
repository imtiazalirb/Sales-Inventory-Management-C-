using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
    class Refunds
    {
        System.Data.SqlClient.SqlConnection conn;

        public Refunds()
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-DQILLPK\SQLEXPRESS;Initial Catalog=Sales;User ID=sa;Password=1234;");
        }
        public void AddRefund(Refund r)
        {
            conn.Open();
            string query = "INSERT INTO Refund (Id, Name, Batch, Dateofrefund, Customername, Customerphone, Reasonofrefund) VALUES ('" + r.Id + "','" + r.Name + "','" + r.Batch + "','" + r.Dateofrefund + "','" + r.Customername + "','" + r.Customerphone + "','" + r.Reasonofrefund + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
           // SqlDataReader reader = cmd.ExecuteReader();
            conn.Close();
        }
        public ArrayList GetAllRefunds()
        {
            ArrayList refunds = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Refund";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Refund r = new Refund()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Batch = reader.GetString(reader.GetOrdinal("Batch")),
                    Dateofrefund = reader.GetString(reader.GetOrdinal("Dateofrefund")),
                    Customername = reader.GetString(reader.GetOrdinal("Customername")),
                    Customerphone = reader.GetInt32(reader.GetOrdinal("Customerphone")),
                    Reasonofrefund = reader.GetString(reader.GetOrdinal("Reasonofrefund")),
                };
                refunds.Add(r);
            }
            conn.Close();
            return refunds;
        }
    }
}
