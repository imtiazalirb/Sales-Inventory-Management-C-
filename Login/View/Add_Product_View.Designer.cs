namespace Project.View
{
    partial class Add_Product_View
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Namebox = new MetroFramework.Controls.MetroTextBox();
            this.ButtonAdd = new MetroFramework.Controls.MetroButton();
            this.ButtonCancel = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.Batchbox = new MetroFramework.Controls.MetroTextBox();
            this.Buypricebox = new MetroFramework.Controls.MetroTextBox();
            this.Sellpricebox = new MetroFramework.Controls.MetroTextBox();
            this.Manufacturedatebox = new MetroFramework.Controls.MetroDateTime();
            this.Expirydatebox = new MetroFramework.Controls.MetroDateTime();
            this.Quantitybox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.DescriptionBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroGrid = new MetroFramework.Controls.MetroGrid();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(578, 95);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(99, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Product Name";
            // 
            // Namebox
            // 
            // 
            // 
            // 
            this.Namebox.CustomButton.Image = null;
            this.Namebox.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.Namebox.CustomButton.Name = "";
            this.Namebox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.Namebox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Namebox.CustomButton.TabIndex = 1;
            this.Namebox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Namebox.CustomButton.UseSelectable = true;
            this.Namebox.CustomButton.Visible = false;
            this.Namebox.Lines = new string[0];
            this.Namebox.Location = new System.Drawing.Point(761, 90);
            this.Namebox.MaxLength = 32767;
            this.Namebox.Name = "Namebox";
            this.Namebox.PasswordChar = '\0';
            this.Namebox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Namebox.SelectedText = "";
            this.Namebox.SelectionLength = 0;
            this.Namebox.SelectionStart = 0;
            this.Namebox.ShortcutsEnabled = true;
            this.Namebox.Size = new System.Drawing.Size(200, 30);
            this.Namebox.TabIndex = 2;
            this.Namebox.UseSelectable = true;
            this.Namebox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Namebox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(420, 637);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 30);
            this.ButtonAdd.TabIndex = 10;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseSelectable = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(528, 637);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 30);
            this.ButtonCancel.TabIndex = 11;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseSelectable = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(578, 157);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(95, 20);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Product Batch";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(578, 274);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(119, 20);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Product Buy Price";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(579, 337);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(117, 20);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Product Sell Price";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(578, 395);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(136, 20);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Date of Manufacture";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(578, 453);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(118, 20);
            this.metroLabel6.TabIndex = 9;
            this.metroLabel6.Text = "Date of Expiration";
            // 
            // Batchbox
            // 
            // 
            // 
            // 
            this.Batchbox.CustomButton.Image = null;
            this.Batchbox.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.Batchbox.CustomButton.Name = "";
            this.Batchbox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.Batchbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Batchbox.CustomButton.TabIndex = 1;
            this.Batchbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Batchbox.CustomButton.UseSelectable = true;
            this.Batchbox.CustomButton.Visible = false;
            this.Batchbox.Lines = new string[0];
            this.Batchbox.Location = new System.Drawing.Point(761, 152);
            this.Batchbox.MaxLength = 32767;
            this.Batchbox.Name = "Batchbox";
            this.Batchbox.PasswordChar = '\0';
            this.Batchbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Batchbox.SelectedText = "";
            this.Batchbox.SelectionLength = 0;
            this.Batchbox.SelectionStart = 0;
            this.Batchbox.ShortcutsEnabled = true;
            this.Batchbox.Size = new System.Drawing.Size(200, 30);
            this.Batchbox.TabIndex = 3;
            this.Batchbox.UseSelectable = true;
            this.Batchbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Batchbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Buypricebox
            // 
            // 
            // 
            // 
            this.Buypricebox.CustomButton.Image = null;
            this.Buypricebox.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.Buypricebox.CustomButton.Name = "";
            this.Buypricebox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.Buypricebox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Buypricebox.CustomButton.TabIndex = 1;
            this.Buypricebox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Buypricebox.CustomButton.UseSelectable = true;
            this.Buypricebox.CustomButton.Visible = false;
            this.Buypricebox.Lines = new string[0];
            this.Buypricebox.Location = new System.Drawing.Point(761, 269);
            this.Buypricebox.MaxLength = 32767;
            this.Buypricebox.Name = "Buypricebox";
            this.Buypricebox.PasswordChar = '\0';
            this.Buypricebox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Buypricebox.SelectedText = "";
            this.Buypricebox.SelectionLength = 0;
            this.Buypricebox.SelectionStart = 0;
            this.Buypricebox.ShortcutsEnabled = true;
            this.Buypricebox.Size = new System.Drawing.Size(200, 30);
            this.Buypricebox.TabIndex = 5;
            this.Buypricebox.UseSelectable = true;
            this.Buypricebox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Buypricebox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Sellpricebox
            // 
            // 
            // 
            // 
            this.Sellpricebox.CustomButton.Image = null;
            this.Sellpricebox.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.Sellpricebox.CustomButton.Name = "";
            this.Sellpricebox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.Sellpricebox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Sellpricebox.CustomButton.TabIndex = 1;
            this.Sellpricebox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Sellpricebox.CustomButton.UseSelectable = true;
            this.Sellpricebox.CustomButton.Visible = false;
            this.Sellpricebox.Lines = new string[0];
            this.Sellpricebox.Location = new System.Drawing.Point(761, 332);
            this.Sellpricebox.MaxLength = 32767;
            this.Sellpricebox.Name = "Sellpricebox";
            this.Sellpricebox.PasswordChar = '\0';
            this.Sellpricebox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Sellpricebox.SelectedText = "";
            this.Sellpricebox.SelectionLength = 0;
            this.Sellpricebox.SelectionStart = 0;
            this.Sellpricebox.ShortcutsEnabled = true;
            this.Sellpricebox.Size = new System.Drawing.Size(200, 30);
            this.Sellpricebox.TabIndex = 6;
            this.Sellpricebox.UseSelectable = true;
            this.Sellpricebox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Sellpricebox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Manufacturedatebox
            // 
            this.Manufacturedatebox.Cursor = System.Windows.Forms.Cursors.Default;
            this.Manufacturedatebox.CustomFormat = "";
            this.Manufacturedatebox.Location = new System.Drawing.Point(761, 390);
            this.Manufacturedatebox.MinimumSize = new System.Drawing.Size(0, 30);
            this.Manufacturedatebox.Name = "Manufacturedatebox";
            this.Manufacturedatebox.Size = new System.Drawing.Size(200, 30);
            this.Manufacturedatebox.TabIndex = 7;
            // 
            // Expirydatebox
            // 
            this.Expirydatebox.CustomFormat = "DD-MM-YYYY";
            this.Expirydatebox.Location = new System.Drawing.Point(761, 448);
            this.Expirydatebox.MinimumSize = new System.Drawing.Size(0, 30);
            this.Expirydatebox.Name = "Expirydatebox";
            this.Expirydatebox.Size = new System.Drawing.Size(200, 30);
            this.Expirydatebox.TabIndex = 8;
            // 
            // Quantitybox
            // 
            // 
            // 
            // 
            this.Quantitybox.CustomButton.Image = null;
            this.Quantitybox.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.Quantitybox.CustomButton.Name = "";
            this.Quantitybox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.Quantitybox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Quantitybox.CustomButton.TabIndex = 1;
            this.Quantitybox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Quantitybox.CustomButton.UseSelectable = true;
            this.Quantitybox.CustomButton.Visible = false;
            this.Quantitybox.Lines = new string[0];
            this.Quantitybox.Location = new System.Drawing.Point(761, 211);
            this.Quantitybox.MaxLength = 32767;
            this.Quantitybox.Name = "Quantitybox";
            this.Quantitybox.PasswordChar = '\0';
            this.Quantitybox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Quantitybox.SelectedText = "";
            this.Quantitybox.SelectionLength = 0;
            this.Quantitybox.SelectionStart = 0;
            this.Quantitybox.ShortcutsEnabled = true;
            this.Quantitybox.Size = new System.Drawing.Size(200, 30);
            this.Quantitybox.TabIndex = 4;
            this.Quantitybox.UseSelectable = true;
            this.Quantitybox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Quantitybox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(578, 216);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(113, 20);
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "Product Quantity";
            // 
            // DescriptionBox
            // 
            // 
            // 
            // 
            this.DescriptionBox.CustomButton.Image = null;
            this.DescriptionBox.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.DescriptionBox.CustomButton.Name = "";
            this.DescriptionBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.DescriptionBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DescriptionBox.CustomButton.TabIndex = 1;
            this.DescriptionBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DescriptionBox.CustomButton.UseSelectable = true;
            this.DescriptionBox.CustomButton.Visible = false;
            this.DescriptionBox.Lines = new string[0];
            this.DescriptionBox.Location = new System.Drawing.Point(761, 506);
            this.DescriptionBox.MaxLength = 32767;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.PasswordChar = '\0';
            this.DescriptionBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DescriptionBox.SelectedText = "";
            this.DescriptionBox.SelectionLength = 0;
            this.DescriptionBox.SelectionStart = 0;
            this.DescriptionBox.ShortcutsEnabled = true;
            this.DescriptionBox.Size = new System.Drawing.Size(200, 30);
            this.DescriptionBox.TabIndex = 9;
            this.DescriptionBox.UseSelectable = true;
            this.DescriptionBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DescriptionBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(578, 511);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(131, 20);
            this.metroLabel9.TabIndex = 13;
            this.metroLabel9.Text = "Product Description";
            // 
            // metroGrid
            // 
            this.metroGrid.AllowUserToResizeRows = false;
            this.metroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid.EnableHeadersVisualStyles = false;
            this.metroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid.Location = new System.Drawing.Point(23, 63);
            this.metroGrid.Name = "metroGrid";
            this.metroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid.RowTemplate.Height = 24;
            this.metroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid.Size = new System.Drawing.Size(510, 520);
            this.metroGrid.TabIndex = 14;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel13.Location = new System.Drawing.Point(227, 586);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(82, 17);
            this.metroLabel13.TabIndex = 85;
            this.metroLabel13.Text = "Inventory List";
            // 
            // Add_Product_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroGrid);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.Quantitybox);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.Manufacturedatebox);
            this.Controls.Add(this.Sellpricebox);
            this.Controls.Add(this.Buypricebox);
            this.Controls.Add(this.Batchbox);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.Expirydatebox);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.Namebox);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Add_Product_View";
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.AddProductView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox Namebox;
        private MetroFramework.Controls.MetroButton ButtonAdd;
        private MetroFramework.Controls.MetroButton ButtonCancel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox Batchbox;
        private MetroFramework.Controls.MetroTextBox Buypricebox;
        private MetroFramework.Controls.MetroTextBox Sellpricebox;
        private MetroFramework.Controls.MetroDateTime Manufacturedatebox;
        private MetroFramework.Controls.MetroDateTime Expirydatebox;
        private MetroFramework.Controls.MetroTextBox Quantitybox;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox DescriptionBox;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroGrid metroGrid;
        private MetroFramework.Controls.MetroLabel metroLabel13;
    }
}