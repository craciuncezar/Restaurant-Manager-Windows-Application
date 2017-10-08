namespace Restaurant_Manager_Windows_Applictaion.Forms
{
    partial class RestaurantMenuUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.descriptionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.priceTextBox = new MetroFramework.Controls.MetroTextBox();
            this.gramsTextBox = new MetroFramework.Controls.MetroTextBox();
            this.categoryTextBox = new MetroFramework.Controls.MetroTextBox();
            this.foodNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.addFoodItemButton = new MetroFramework.Controls.MetroButton();
            this.editButton = new MetroFramework.Controls.MetroButton();
            this.deleteButton = new MetroFramework.Controls.MetroButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.editButton1 = new MetroFramework.Controls.MetroButton();
            this.metroGrid2 = new MetroFramework.Controls.MetroGrid();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.cancelEditBtn = new MetroFramework.Controls.MetroButton();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.cancelEditBtn);
            this.metroTabPage1.Controls.Add(this.descriptionTextBox);
            this.metroTabPage1.Controls.Add(this.priceTextBox);
            this.metroTabPage1.Controls.Add(this.gramsTextBox);
            this.metroTabPage1.Controls.Add(this.categoryTextBox);
            this.metroTabPage1.Controls.Add(this.foodNameTextBox);
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.Controls.Add(this.metroLabel7);
            this.metroTabPage1.Controls.Add(this.metroLabel8);
            this.metroTabPage1.Controls.Add(this.metroLabel9);
            this.metroTabPage1.Controls.Add(this.metroLabel10);
            this.metroTabPage1.Controls.Add(this.addFoodItemButton);
            this.metroTabPage1.Controls.Add(this.editButton);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(754, 468);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "  Add New Menu Item  ";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.descriptionTextBox.Lines = new string[0];
            this.descriptionTextBox.Location = new System.Drawing.Point(298, 256);
            this.descriptionTextBox.MaxLength = 32767;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.PasswordChar = '\0';
            this.descriptionTextBox.PromptText = "Description and ingredients";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descriptionTextBox.SelectedText = "";
            this.descriptionTextBox.Size = new System.Drawing.Size(271, 61);
            this.descriptionTextBox.TabIndex = 22;
            this.descriptionTextBox.UseSelectable = true;
            // 
            // priceTextBox
            // 
            this.priceTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.priceTextBox.Lines = new string[0];
            this.priceTextBox.Location = new System.Drawing.Point(298, 208);
            this.priceTextBox.MaxLength = 32767;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.PasswordChar = '\0';
            this.priceTextBox.PromptText = "Price";
            this.priceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.priceTextBox.SelectedText = "";
            this.priceTextBox.Size = new System.Drawing.Size(163, 30);
            this.priceTextBox.TabIndex = 21;
            this.priceTextBox.UseSelectable = true;
            // 
            // gramsTextBox
            // 
            this.gramsTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.gramsTextBox.Lines = new string[0];
            this.gramsTextBox.Location = new System.Drawing.Point(298, 160);
            this.gramsTextBox.MaxLength = 32767;
            this.gramsTextBox.Name = "gramsTextBox";
            this.gramsTextBox.PasswordChar = '\0';
            this.gramsTextBox.PromptText = "Grams";
            this.gramsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gramsTextBox.SelectedText = "";
            this.gramsTextBox.Size = new System.Drawing.Size(163, 30);
            this.gramsTextBox.TabIndex = 20;
            this.gramsTextBox.UseSelectable = true;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.categoryTextBox.Lines = new string[0];
            this.categoryTextBox.Location = new System.Drawing.Point(298, 115);
            this.categoryTextBox.MaxLength = 32767;
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.PasswordChar = '\0';
            this.categoryTextBox.PromptText = "Category";
            this.categoryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.categoryTextBox.SelectedText = "";
            this.categoryTextBox.Size = new System.Drawing.Size(163, 30);
            this.categoryTextBox.TabIndex = 19;
            this.categoryTextBox.UseSelectable = true;
            // 
            // foodNameTextBox
            // 
            this.foodNameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.foodNameTextBox.Lines = new string[0];
            this.foodNameTextBox.Location = new System.Drawing.Point(298, 70);
            this.foodNameTextBox.MaxLength = 32767;
            this.foodNameTextBox.Name = "foodNameTextBox";
            this.foodNameTextBox.PasswordChar = '\0';
            this.foodNameTextBox.PromptText = "Food Name";
            this.foodNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.foodNameTextBox.SelectedText = "";
            this.foodNameTextBox.Size = new System.Drawing.Size(163, 30);
            this.foodNameTextBox.TabIndex = 18;
            this.foodNameTextBox.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(210, 256);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(82, 20);
            this.metroLabel6.TabIndex = 17;
            this.metroLabel6.Text = "Description:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(249, 208);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(43, 20);
            this.metroLabel7.TabIndex = 16;
            this.metroLabel7.Text = "Price:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(240, 160);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(52, 20);
            this.metroLabel8.TabIndex = 15;
            this.metroLabel8.Text = "Grams:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(223, 115);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(69, 20);
            this.metroLabel9.TabIndex = 14;
            this.metroLabel9.Text = "Category:";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(207, 70);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(85, 20);
            this.metroLabel10.TabIndex = 13;
            this.metroLabel10.Text = "Food Name:";
            // 
            // addFoodItemButton
            // 
            this.addFoodItemButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.addFoodItemButton.Location = new System.Drawing.Point(574, 402);
            this.addFoodItemButton.Name = "addFoodItemButton";
            this.addFoodItemButton.Size = new System.Drawing.Size(106, 31);
            this.addFoodItemButton.TabIndex = 23;
            this.addFoodItemButton.Text = "Add";
            this.addFoodItemButton.UseSelectable = true;
            this.addFoodItemButton.Click += new System.EventHandler(this.addFoodItemBtn_click);
            // 
            // editButton
            // 
            this.editButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.editButton.Location = new System.Drawing.Point(574, 402);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(106, 31);
            this.editButton.TabIndex = 24;
            this.editButton.Text = "Edit";
            this.editButton.UseSelectable = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.deleteButton.Location = new System.Drawing.Point(438, 402);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(106, 31);
            this.deleteButton.TabIndex = 25;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseSelectable = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.deleteButton);
            this.metroTabPage2.Controls.Add(this.editButton1);
            this.metroTabPage2.Controls.Add(this.metroGrid2);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(754, 468);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "  Menu Items  ";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // editButton1
            // 
            this.editButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.editButton1.Location = new System.Drawing.Point(574, 402);
            this.editButton1.Name = "editButton1";
            this.editButton1.Size = new System.Drawing.Size(106, 31);
            this.editButton1.TabIndex = 24;
            this.editButton1.Text = "Edit";
            this.editButton1.UseSelectable = true;
            this.editButton1.Click += new System.EventHandler(this.editButton1_Click);
            // 
            // metroGrid2
            // 
            this.metroGrid2.AllowUserToAddRows = false;
            this.metroGrid2.AllowUserToDeleteRows = false;
            this.metroGrid2.AllowUserToResizeRows = false;
            this.metroGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid2.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid2.EnableHeadersVisualStyles = false;
            this.metroGrid2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.Location = new System.Drawing.Point(0, 3);
            this.metroGrid2.Name = "metroGrid2";
            this.metroGrid2.ReadOnly = true;
            this.metroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid2.RowTemplate.Height = 24;
            this.metroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid2.Size = new System.Drawing.Size(751, 393);
            this.metroGrid2.TabIndex = 3;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(762, 516);
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // cancelEditBtn
            // 
            this.cancelEditBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.cancelEditBtn.Location = new System.Drawing.Point(438, 402);
            this.cancelEditBtn.Name = "cancelEditBtn";
            this.cancelEditBtn.Size = new System.Drawing.Size(106, 31);
            this.cancelEditBtn.TabIndex = 25;
            this.cancelEditBtn.Text = "Cancel";
            this.cancelEditBtn.UseSelectable = true;
            this.cancelEditBtn.Visible = false;
            this.cancelEditBtn.Click += new System.EventHandler(this.cancelEditBtn_Click);
            // 
            // RestaurantMenuUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl1);
            this.Name = "RestaurantMenuUserControl";
            this.Size = new System.Drawing.Size(762, 516);
            this.Load += new System.EventHandler(this.RestaurantMenuUserControl_Load);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTextBox descriptionTextBox;
        private MetroFramework.Controls.MetroTextBox priceTextBox;
        private MetroFramework.Controls.MetroTextBox gramsTextBox;
        private MetroFramework.Controls.MetroTextBox categoryTextBox;
        private MetroFramework.Controls.MetroTextBox foodNameTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroButton addFoodItemButton;
        private MetroFramework.Controls.MetroButton editButton;
        private MetroFramework.Controls.MetroButton deleteButton;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton editButton1;
        private MetroFramework.Controls.MetroGrid metroGrid2;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroButton cancelEditBtn;
    }
}
