namespace Project.View
{
    partial class Employee_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_View));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Message_Tile = new MetroFramework.Controls.MetroTile();
            this.Refund_Product_Tile = new MetroFramework.Controls.MetroTile();
            this.All_Product_Tile = new MetroFramework.Controls.MetroTile();
            this.Sell_Product_Tile = new MetroFramework.Controls.MetroTile();
            this.Logout_Button = new MetroFramework.Controls.MetroButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(204, 279);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(207, 25);
            this.metroLabel1.TabIndex = 49;
            this.metroLabel1.Text = "Product Management";
            // 
            // Message_Tile
            // 
            this.Message_Tile.ActiveControl = null;
            this.Message_Tile.Location = new System.Drawing.Point(642, 312);
            this.Message_Tile.Name = "Message_Tile";
            this.Message_Tile.Size = new System.Drawing.Size(140, 140);
            this.Message_Tile.TabIndex = 44;
            this.Message_Tile.Text = "Sales Record";
            this.Message_Tile.UseSelectable = true;
            this.Message_Tile.Click += new System.EventHandler(this.Message_Tile_Click);
            // 
            // Refund_Product_Tile
            // 
            this.Refund_Product_Tile.ActiveControl = null;
            this.Refund_Product_Tile.Location = new System.Drawing.Point(496, 312);
            this.Refund_Product_Tile.Name = "Refund_Product_Tile";
            this.Refund_Product_Tile.Size = new System.Drawing.Size(140, 140);
            this.Refund_Product_Tile.TabIndex = 43;
            this.Refund_Product_Tile.Text = "Refund Products";
            this.Refund_Product_Tile.UseSelectable = true;
            this.Refund_Product_Tile.Click += new System.EventHandler(this.Refund_Product_Tile_Click);
            // 
            // All_Product_Tile
            // 
            this.All_Product_Tile.ActiveControl = null;
            this.All_Product_Tile.Location = new System.Drawing.Point(350, 312);
            this.All_Product_Tile.Name = "All_Product_Tile";
            this.All_Product_Tile.Size = new System.Drawing.Size(140, 140);
            this.All_Product_Tile.TabIndex = 42;
            this.All_Product_Tile.Text = "All Products";
            this.All_Product_Tile.UseSelectable = true;
            this.All_Product_Tile.Click += new System.EventHandler(this.All_Product_Tile_Click);
            // 
            // Sell_Product_Tile
            // 
            this.Sell_Product_Tile.ActiveControl = null;
            this.Sell_Product_Tile.Location = new System.Drawing.Point(204, 312);
            this.Sell_Product_Tile.Name = "Sell_Product_Tile";
            this.Sell_Product_Tile.Size = new System.Drawing.Size(140, 140);
            this.Sell_Product_Tile.TabIndex = 41;
            this.Sell_Product_Tile.Text = "Sell Products";
            this.Sell_Product_Tile.UseSelectable = true;
            this.Sell_Product_Tile.Click += new System.EventHandler(this.Sell_Product_Tile_Click);
            // 
            // Logout_Button
            // 
            this.Logout_Button.Location = new System.Drawing.Point(882, 131);
            this.Logout_Button.Name = "Logout_Button";
            this.Logout_Button.Size = new System.Drawing.Size(95, 23);
            this.Logout_Button.TabIndex = 77;
            this.Logout_Button.Text = "Logout";
            this.Logout_Button.UseSelectable = true;
            this.Logout_Button.Click += new System.EventHandler(this.Logout_Button_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(882, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(95, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 78;
            this.pictureBox2.TabStop = false;
            // 
            // Employee_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.Logout_Button);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Message_Tile);
            this.Controls.Add(this.Refund_Product_Tile);
            this.Controls.Add(this.All_Product_Tile);
            this.Controls.Add(this.Sell_Product_Tile);
            this.Name = "Employee_View";
            this.Text = "Employee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Employee_View_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile Message_Tile;
        private MetroFramework.Controls.MetroTile Refund_Product_Tile;
        private MetroFramework.Controls.MetroTile All_Product_Tile;
        private MetroFramework.Controls.MetroTile Sell_Product_Tile;
        private MetroFramework.Controls.MetroButton Logout_Button;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}