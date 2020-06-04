using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Project.Model
{
    class Employees
    {

        SqlConnection conn;

        public Employees()
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-DQILLPK\SQLEXPRESS;Initial Catalog=Sales;User ID=sa;Password=1234;");
        }
        public ArrayList GetAllEmployees()
        {
            ArrayList employees = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Employee";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Employee p = new Employee()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Username = reader.GetString(reader.GetOrdinal("Username")),
                    // Password = reader.GetString(reader.GetOrdinal("Password")),    //Password will be shown in Login Database only
                    Gender = reader.GetString(reader.GetOrdinal("Gender")),
                    Bloodgroup = reader.GetString(reader.GetOrdinal("Bloodgroup")),
                    Phonenumber = reader.GetInt32(reader.GetOrdinal("Phonenumber")),
                    Email = reader.GetString(reader.GetOrdinal("Email")),
                    DOB = reader.GetString(reader.GetOrdinal("DOB")),
                    Address = reader.GetString(reader.GetOrdinal("Address")),
                    Salary = reader.GetInt32(reader.GetOrdinal("Salary")),
                    Designation = reader.GetString(reader.GetOrdinal("Designation")),
                    Usertype = reader.GetString(reader.GetOrdinal("Usertype")),
                };
                employees.Add(p);
            }
            conn.Close();
            return employees;
        }
        public void AddEmployee(Employee e)
        {                        
            //add Employee to the database
            conn.Open();
            string query = "INSERT INTO Employee (Name,Username,Password,Gender,Bloodgroup,Phonenumber,Email,DOB,Address,Salary,Designation,Usertype) VALUES ('" + e.Name + "','" + e.Username + "','" + e.Password + "','" + e.Gender + "','" + e.Bloodgroup + "','" + e.Phonenumber + "','" + e.Email + "','" + e.DOB + "','" + e.Address + "','" + e.Salary + "','" + e.Designation + "','" + e.Usertype + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
           // SqlDataReader reader= cmd.ExecuteReader();
            conn.Close();            
        }       
        public void DeleteEmployee(Employee e)
        {
            conn.Open();
            string query = "DELETE FROM Employee WHERE Id = " + e.Id;
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Deleted");
            conn.Close();
        }
        public void UpdateEmployee(Employee e)
        {
            conn.Open();
            string query = "UPDATE Employee SET Bloodgroup='" + e.Bloodgroup + "', Phonenumber='" + e.Phonenumber + "', Email='" + e.Email + "', DOB='" + e.DOB + "', Address='" + e.Address + "', Salary='" + e.Salary+ "', Designation = '" + e.Designation + "', Usertype ='" + e.Usertype + "' WHERE Id= " + e.Id;
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Updated");
            conn.Close();
        }
        public void SearchEmployee(Employee e)
        {
            conn.Open();
            string query = "SELECT * FROM Employee where Username like '" + e.Username + "%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            SqlDataReader reader= cmd.ExecuteReader();

            conn.Close();
        }
    }
}
