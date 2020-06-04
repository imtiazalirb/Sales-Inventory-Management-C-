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
    public partial class All_Employee_View : MetroFramework.Forms.MetroForm
    {
        public DataSet Ds { get; set; }
        DataAccess Da { get; set; }
        public All_Employee_View()
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
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            new Manager_View().Show();
            this.Close();
        }
        private void All_EmployeeView_Load(object sender, EventArgs e)
        {
            metroGrid.DataSource = EmployeeController.GetAllEmployees();
        }
        private void Search_Box_Text_Change(object sender, EventArgs e)
        {
            DataAccess DA = new DataAccess();
            string Username = this.Search_Box.Text;
            {
                string sql = "select [Id], [Name], [Username], [Gender], [Bloodgroup], [Phonenumber], [Email], [DOB], [Address], [Salary], [Designation], [Usertype] from Employee where Username like '" + Username + "%'; ";
                this.PopulateGridView(sql);
            }
        }
    }
}
