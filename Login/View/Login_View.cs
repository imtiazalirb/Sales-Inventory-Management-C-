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
    public partial class Login_View : MetroFramework.Forms.MetroForm
    {
        public DataSet ds { get; set; }
        public Login_View()
        {
            InitializeComponent();
            this.Usernamer_TextBox.Text = "";
            this.Password_TextBox.Text = "";
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            DataAccess DA = new DataAccess();
            string username = this.Usernamer_TextBox.Text;
            string password = this.Password_TextBox.Text;
            try
            {
                string sql = "SELECT Usertype FROM Login WHERE Username='" + username + "'and Password='" + password + "'";
                ds = DA.ExecuteQuery(sql);
                //MessageBox.Show(ds.Tables[0].Rows.Count.ToString());
                if (ds.Tables[0].Rows.Count > 0)
                {                    
                   // MessageBox.Show(ds.Tables[0].Rows[0]["Usertype"].ToString());
                    string usertype = ds.Tables[0].Rows[0]["Usertype"].ToString();
                    if (usertype == "Admin")
                    {
                        new Manager_View().Show();
                        this.Visible = false;
                    }
                    else if (usertype == "Employee")
                    {
                        new Employee_View().Show();
                        this.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid ID or Password");
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
        private void Login_View_Form_Closing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
    }
}
