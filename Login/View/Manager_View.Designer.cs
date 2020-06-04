namespace Project.View
{
    partial class Manager_View
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager_View));
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.AllEmployee = new MetroFramework.Controls.MetroTile();
            this.RemoveEmployee = new MetroFramework.Controls.MetroTile();
            this.AddEmployee = new MetroFramework.Controls.MetroTile();
            this.RefundedProduct = new MetroFramework.Controls.MetroTile();
            this.RemoveProduct = new MetroFramework.Controls.MetroTile();
            this.AllProduct = new MetroFramework.Controls.MetroTile();
            this.ButtonLogout = new MetroFramework.Controls.MetroButton();
            this.Add_Product_Tile = new MetroFramework.Controls.MetroTile();
            this.Sales_Record_Tile = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(126, 411);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(221, 25);
            this.metroLabel2.TabIndex = 71;
            this.metroLabel2.Text = "Employee Management";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(126, 212);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(207, 25);
            this.metroLabel1.TabIndex = 70;
            this.metroLabel1.Text = "Product Management";
            // 
            // AllEmployee
            // 
            this.AllEmployee.ActiveControl = null;
            this.AllEmployee.Location = new System.Drawing.Point(418, 444);
            this.AllEmployee.Name = "AllEmployee";
            this.AllEmployee.Size = new System.Drawing.Size(140, 140);
            this.AllEmployee.TabIndex = 8;
            this.AllEmployee.Text = "All Employee";
            this.AllEmployee.UseSelectable = true;
            this.AllEmployee.Click += new System.EventHandler(this.AllEmployee_Click);
            // 
            // RemoveEmployee
            // 
            this.RemoveEmployee.ActiveControl = null;
            this.RemoveEmployee.Location = new System.Drawing.Point(272, 444);
            this.RemoveEmployee.Name = "RemoveEmployee";
            this.RemoveEmployee.Size = new System.Drawing.Size(140, 140);
            this.RemoveEmployee.TabIndex = 6;
            this.RemoveEmployee.Text = "Edit / Remove Employee";
            this.RemoveEmployee.UseSelectable = true;
            this.RemoveEmployee.UseTileImage = true;
            this.RemoveEmployee.Click += new System.EventHandler(this.RemoveEmployee_Click);
            // 
            // AddEmployee
            // 
            this.AddEmployee.ActiveControl = null;
            this.AddEmployee.Location = new System.Drawing.Point(126, 444);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(140, 140);
            this.AddEmployee.TabIndex = 5;
            this.AddEmployee.Text = "Add Employee";
            this.AddEmployee.UseSelectable = true;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // RefundedProduct
            // 
            this.RefundedProduct.ActiveControl = null;
            this.RefundedProduct.Location = new System.Drawing.Point(564, 245);
            this.RefundedProduct.Name = "RefundedProduct";
            this.RefundedProduct.Size = new System.Drawing.Size(140, 140);
            this.RefundedProduct.TabIndex = 3;
            this.RefundedProduct.Text = "Refund List";
            this.RefundedProduct.TileImage = ((System.Drawing.Image)(resources.GetObject("RefundedProduct.TileImage")));
            this.RefundedProduct.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RefundedProduct.UseSelectable = true;
            this.RefundedProduct.Click += new System.EventHandler(this.RefundedProduct_Click);
            // 
            // RemoveProduct
            // 
            this.RemoveProduct.ActiveControl = null;
            this.RemoveProduct.Location = new System.Drawing.Point(272, 245);
            this.RemoveProduct.Name = "RemoveProduct";
            this.RemoveProduct.Size = new System.Drawing.Size(140, 140);
            this.RemoveProduct.TabIndex = 2;
            this.RemoveProduct.Text = "Edit / Remove";
            this.RemoveProduct.TileImage = ((System.Drawing.Image)(resources.GetObject("RemoveProduct.TileImage")));
            this.RemoveProduct.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RemoveProduct.UseSelectable = true;
            this.RemoveProduct.Click += new System.EventHandler(this.RemoveProduct_Click);
            // 
            // AllProduct
            // 
            this.AllProduct.ActiveControl = null;
            this.AllProduct.Location = new System.Drawing.Point(418, 245);
            this.AllProduct.Name = "AllProduct";
            this.AllProduct.Size = new System.Drawing.Size(140, 140);
            this.AllProduct.TabIndex = 4;
            this.AllProduct.Text = "All Products list";
            this.AllProduct.UseSelectable = true;
            this.AllProduct.Click += new System.EventHandler(this.AllProduct_Click);
            // 
            // ButtonLogout
            // 
            this.ButtonLogout.Location = new System.Drawing.Point(882, 132);
            this.ButtonLogout.Name = "ButtonLogout";
            this.ButtonLogout.Size = new System.Drawing.Size(93, 24);
            this.ButtonLogout.TabIndex = 9;
            this.ButtonLogout.Text = "Logout";
            this.ButtonLogout.UseSelectable = true;
            this.ButtonLogout.Click += new System.EventHandler(this.ButtonLogout_Click);
            // 
            // Add_Product_Tile
            // 
            this.Add_Product_Tile.ActiveControl = null;
            this.Add_Product_Tile.Location = new System.Drawing.Point(126, 245);
            this.Add_Product_Tile.Name = "Add_Product_Tile";
            this.Add_Product_Tile.Size = new System.Drawing.Size(140, 140);
            this.Add_Product_Tile.TabIndex = 74;
            this.Add_Product_Tile.Text = "Add Product";
            this.Add_Product_Tile.UseSelectable = true;
            this.Add_Product_Tile.Click += new System.EventHandler(this.Add_Product_Tile_Click);
            // 
            // Sales_Record_Tile
            // 
            this.Sales_Record_Tile.ActiveControl = null;
            this.Sales_Record_Tile.Location = new System.Drawing.Point(710, 245);
            this.Sales_Record_Tile.Name = "Sales_Record_Tile";
            this.Sales_Record_Tile.Size = new System.Drawing.Size(140, 140);
            this.Sales_Record_Tile.TabIndex = 77;
            this.Sales_Record_Tile.Text = "Sales Rrecord";
            this.Sales_Record_Tile.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(882, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            // 
            // Manager_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Sales_Record_Tile);
            this.Controls.Add(this.Add_Product_Tile);
            this.Controls.Add(this.ButtonLogout);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.AllEmployee);
            this.Controls.Add(this.RemoveEmployee);
            this.Controls.Add(this.AddEmployee);
            this.Controls.Add(this.RefundedProduct);
            this.Controls.Add(this.RemoveProduct);
            this.Controls.Add(this.AllProduct);
            this.Name = "Manager_View";
            this.Text = "Admin Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Manager_View_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile AllEmployee;
        private MetroFramework.Controls.MetroTile RemoveEmployee;
        private MetroFramework.Controls.MetroTile AddEmployee;
        private MetroFramework.Controls.MetroTile RefundedProduct;
        private MetroFramework.Controls.MetroTile RemoveProduct;
        private MetroFramework.Controls.MetroTile AllProduct;
        private MetroFramework.Controls.MetroButton ButtonLogout;
        private MetroFramework.Controls.MetroTile Add_Product_Tile;
        private MetroFramework.Controls.MetroTile Sales_Record_Tile;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}