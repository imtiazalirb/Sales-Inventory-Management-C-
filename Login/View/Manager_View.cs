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
    public partial class Manager_View : MetroFramework.Forms.MetroForm
    {
        public Manager_View()
        {
            InitializeComponent();
        }
        private void Add_Product_Tile_Click(object sender, EventArgs e)
        {
            new Add_Product_View().Show();
        }
        private void AddEmployee_Click(object sender, EventArgs e)
        {
            new Add_Employee_View().Show();
        }
        private void AllEmployee_Click(object sender, EventArgs e)
        {
            new All_Employee_View().Show();
        }
        private void AllProduct_Click(object sender, EventArgs e)
        {
            new All_Product_View().Show();
        }
        private void RemoveEmployee_Click(object sender, EventArgs e)
        {
            new Remove_EmployeeView().Show();
        }
        private void RemoveProduct_Click(object sender, EventArgs e)
        {
            new Remove_Product_View().Show();
        }
        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login_View lv = new Login_View();
            lv.Visible = true;
            this.Hide();

        }
        private void Manager_View_FormClosing(object sender, FormClosingEventArgs e)
        {
            new Login_View().Show();
        }

        private void RefundedProduct_Click(object sender, EventArgs e)
        {
            new All_Refund_Products_View().Show();
        }
    }
}
