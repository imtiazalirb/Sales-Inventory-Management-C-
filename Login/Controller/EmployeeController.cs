using Project.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Controller
{
    class EmployeeController
    {
        static Database db = new Database();
        public static ArrayList GetAllEmployees()
        {
            return db.Employees.GetAllEmployees();
        }
        public static void AddEmployee(string name, string username, string password, string gender, string bloodgroup, string phonenumber, string email, string dob, string address, string salary, string designation, string usertype)

        {
            Employee e = new Employee()
            {
                Name = name,
                Username = username,
                Password = password,
                Gender = gender,
                Bloodgroup = bloodgroup,
                Phonenumber = Int32.Parse(phonenumber),
                Email = email,
                DOB = dob,
                Address = address,
                Salary = Int32.Parse(salary),
                Designation = designation,
                Usertype = usertype,
            };
            db.Employees.AddEmployee(e);
        }
        public static void SearchEmployee(string username)
        {
            Employee e = new Employee()
            {
                Username = username,
            };
            db.Employees.SearchEmployee(e);
            MessageBox.Show("Success on Controller");

        }
        public static void UpdateEmployee(string id, string username, string bloodgroup, string phonenumber, string email, string dob, string address, string salary, string designation, string usertype)
        {
            Employee e = new Employee()
            {
                Id = Int32.Parse(id),
                Username = username,
                Bloodgroup = bloodgroup,
                Phonenumber = Int32.Parse(phonenumber),
                Email = email,
                DOB = dob,
                Address = address,
                Salary = Int32.Parse(salary),
                Designation = designation,
                Usertype = usertype,
            };
            db.Employees.UpdateEmployee(e);
        }
        public static void DeleteEmployee(string id)
        {
            Employee e = new Employee()
            {
                Id = Int32.Parse(id),
            };
            db.Employees.DeleteEmployee(e);
        }
        /* public static User GetUser(string id)
         {
             return db.Users.GetUser(id);
         }*/
    }
}
