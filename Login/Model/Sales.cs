using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
    class Sales
    {
        SqlConnection conn;
        public Sales()
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-DQILLPK\SQLEXPRESS;Initial Catalog=Sales;User ID=sa;Password=1234;");

        }
        public void AddSales(Sale s)
        {
            conn.Open();
            string query = "INSERT INTO Sales (Id,Name,Batch,Quantity,UnitPrice) VALUES ('" + s.Id + "','" + s.Name + "','" + s.Batch + "','" + s.Quantity + "','" + s.UnitPrice + "')"; 
            SqlCommand cmd = new SqlCommand(query, conn);
             int result = cmd.ExecuteNonQuery();
            //  SqlDataReader reader = cmd.ExecuteReader();
            conn.Close();
        }
        public ArrayList GetAllSales()
        {
            ArrayList sales = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Sales";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Sale s = new Sale()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Batch = reader.GetString(reader.GetOrdinal("Batch")),
                    Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                    UnitPrice = reader.GetInt32(reader.GetOrdinal("Unitprice")),
                    TotalPrice = reader.GetInt32(reader.GetOrdinal("TotalPrice")),
                };
                sales.Add(s);
            }
            conn.Close();
            return sales;
        }
    }
}
