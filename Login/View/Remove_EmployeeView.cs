using Project.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.View
{
    public partial class Remove_EmployeeView : MetroFramework.Forms.MetroForm
    {
        public DataSet Ds { get; set; }
        DataAccess Da { get; set; }
        public Remove_EmployeeView()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        void PopulateGridView(string sql)
        {
            this.metroGrid.AutoGenerateColumns = false;
            this.Ds = this.Da.ExecuteQuery(sql);
            this.metroGrid.DataSource = this.Ds.Tables[0];
        }
        private void RemoveEmployeeView_Load(object sender, EventArgs e)
        {
            metroGrid.DataSource = EmployeeController.GetAllEmployees();
        }
        private void Username_Text_Change(object sender, EventArgs e)
        {
            DataAccess DA = new DataAccess();
            string Username = this.Username_Box.Text;
            {
                string sql = "select * from Employee where Username like '" + Username + "%'; ";
                this.PopulateGridView(sql);
            }
        }
        private void Id_Text_Change(object sender, EventArgs e)
        {
            DataAccess DA = new DataAccess();
            string Id = this.Id_Box.Text;
            {
                string sql = "select * from Employee where Id like '" + Id + "%'; ";
                this.PopulateGridView(sql);
            }
        }
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            new Manager_View().Show();
            this.Close();
        }
        private void Update_Button_Click(object sender, EventArgs e)
        {
            this.Id_Box.Text = this.metroGrid.CurrentRow.Cells["Id"].Value.ToString();
            EmployeeController.UpdateEmployee(Id_Box.Text, Username_Box.Text, Bloodgroup_Combobox.Text, Phone_Number_Box.Text, Email_Box.Text, DOB_Datetime.Text, Address_Box.Text, Salary_Box.Text, Designation_Box.Text, Usertype_Combobox.Text);
            metroGrid.DataSource = EmployeeController.GetAllEmployees();
        }
        private void Grid_View_Click(object sender, DataGridViewCellEventArgs e)
        {
            this.Id_Box.Text = this.metroGrid.CurrentRow.Cells["Id"].Value.ToString();
            this.Username_Box.Text = this.metroGrid.CurrentRow.Cells["Username"].Value.ToString();
            this.Bloodgroup_Combobox.Text = this.metroGrid.CurrentRow.Cells["Bloodgroup"].Value.ToString();
            this.Phone_Number_Box.Text = this.metroGrid.CurrentRow.Cells["Phonenumber"].Value.ToString();
            this.Email_Box.Text = this.metroGrid.CurrentRow.Cells["Email"].Value.ToString();
            this.DOB_Datetime.Text = this.metroGrid.CurrentRow.Cells["DOB"].Value.ToString();
            this.Address_Box.Text = this.metroGrid.CurrentRow.Cells["Address"].Value.ToString();
            this.Salary_Box.Text = this.metroGrid.CurrentRow.Cells["Salary"].Value.ToString();
            this.Designation_Box.Text = this.metroGrid.CurrentRow.Cells["Designation"].Value.ToString();
            this.Usertype_Combobox.Text = this.metroGrid.CurrentRow.Cells["Usertype"].Value.ToString();
        }
        private void Delete_Button_Click(object sender, EventArgs e)
        {
            this.Id_Box.Text = this.metroGrid.CurrentRow.Cells["Id"].Value.ToString();
            this.Username_Box.Text = this.metroGrid.CurrentRow.Cells["Username"].Value.ToString();
            EmployeeController.DeleteEmployee(Id_Box.Text);
            LoginController.DeleteLogin(Username_Box.Text);
            metroGrid.DataSource = EmployeeController.GetAllEmployees();
        }
    }
}
