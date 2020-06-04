using System;
using Project.Controller;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Model
{
    class Products
    {
        SqlConnection conn;
        public Products()
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-DQILLPK\SQLEXPRESS;Initial Catalog=Sales;User ID=sa;Password=1234;");

        }
        public void AddProduct(Product p)
        {
            conn.Open();
            string query = "INSERT INTO Products (Name,Batch,Quantity,Buyprice,Sellprice,Manufacturedate,Expirydate,Description) VALUES ('" + p.Name + "','" + p.Batch + "','" + p.Quantity + "','" + p.Buyprice + "','" + p.Sellprice + "','" + p.Manufacturedate + "','" + p.Expirydate + "','" + p.Description + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
          //  SqlDataReader reader = cmd.ExecuteReader();
            conn.Close();
        }
        public ArrayList GetAllProducts()
        {
            ArrayList products = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Products";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Product q = new Product()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Batch = reader.GetString(reader.GetOrdinal("Batch")),
                    Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                    Buyprice = reader.GetInt32(reader.GetOrdinal("BuyPrice")),
                    Sellprice = reader.GetInt32(reader.GetOrdinal("Sellprice")),
                    Manufacturedate = reader.GetString(reader.GetOrdinal("Manufacturedate")),
                    Expirydate = reader.GetString(reader.GetOrdinal("Expirydate")),
                    Description = reader.GetString(reader.GetOrdinal("Description")),
                };
                 products.Add(q);
            }
            conn.Close();
            return products;
        }
        public void UpdateProduct(Product p)
        {
            conn.Open();
            string query = "UPDATE Products SET Quantity='" + p.Quantity + "', Sellprice='" + p.Sellprice + "', Description='" + p.Description + "' WHERE Id= " + p.Id;
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Updated");
            conn.Close();
        }
        public void DeleteProduct(Product p)
        {
            conn.Open();
            string query = "DELETE FROM products WHERE Id = " + p.Id;
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Deleted");
            conn.Close();
        }
        public void SellProduct(Product p)
        {
            conn.Open();
            string query = "UPDATE Products SET Quantity = Quantity - '" + (p.Quantity) + "' WHERE Id= " + p.Id;
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Sold Item");
            conn.Close();
        }

        /* public Products GetProduct(Product product)
         {
             //
             Product product = new Product();
             return product;
         }*/
    }
}
