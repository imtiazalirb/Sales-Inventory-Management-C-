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
    public partial class Employee_View : MetroFramework.Forms.MetroForm
    {
        public Employee_View()
        {
            InitializeComponent();
        }

        private void Sell_Product_Tile_Click(object sender, EventArgs e)
        {
            this.Close();
            new Sell_Product().Show();
        }

        private void All_Product_Tile_Click(object sender, EventArgs e)
        {
            new All_Product_View().Show();
        }

        private void Refund_Product_Tile_Click(object sender, EventArgs e)
        {
            new Add_Refund_Products_View().Show();
        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            Login_View lv = new Login_View();
            lv.Visible = true;
            this.Hide();
        }

        private void Employee_View_FormClosing(object sender, FormClosingEventArgs e)
        {
            new Login_View().Show();
        }

        private void Message_Tile_Click(object sender, EventArgs e)
        {
            new All_Sales_View().Show();
        }
    }
}
