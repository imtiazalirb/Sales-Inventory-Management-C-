using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Controller;

namespace Project.View
{
    public partial class Add_Employee_View : MetroFramework.Forms.MetroForm
    {
        public Add_Employee_View()
        {
            InitializeComponent();
        }
        private void Add_Button_Click(object sender, EventArgs e)
        {

            {
                dynamic u = Usertype_Combobox.SelectedItem;
                dynamic g = Gender_Combobox.SelectedItem;
                dynamic b = Bloodgroup_Combobox.SelectedItem;
                dynamic i = metroDateTime.Value.ToString();
                EmployeeController.AddEmployee(Name_Box.Text, Username_Box.Text, Password_Box.Text, g, b, Phone_Number_Box.Text, Email_Box.Text, i, Address_Box.Text, Salary_Box.Text, Designation_Box.Text, u);
                LoginController.AddLogin(Username_Box.Text, Password_Box.Text, u);
                metroGrid.DataSource = EmployeeController.GetAllEmployees();

                MessageBox.Show("Success");
            }
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {           
            new Manager_View().Show();
            this.Close();
        }
        private void AddEmployeeView_Load(object sender, EventArgs e)
        {
            metroGrid.DataSource = EmployeeController.GetAllEmployees();
        }
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            new Manager_View().Show();
            this.Close();
        }

        private void Add_Employee_View_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
