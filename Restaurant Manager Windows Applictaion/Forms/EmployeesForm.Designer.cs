namespace Restaurant_Manager_Windows_Application
{
    partial class EmployeesForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.femaleRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.maleRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.positionComboBox = new MetroFramework.Controls.MetroComboBox();
            this.wageTextBox = new MetroFramework.Controls.MetroTextBox();
            this.birthDateTime = new MetroFramework.Controls.MetroDateTime();
            this.lastNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.firstNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.AddEmployeeButton = new MetroFramework.Controls.MetroButton();
            this.editButton = new MetroFramework.Controls.MetroButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroGrid2 = new MetroFramework.Controls.MetroGrid();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.Location = new System.Drawing.Point(24, 64);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(714, 503);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroLabel7);
            this.metroTabPage1.Controls.Add(this.metroLabel8);
            this.metroTabPage1.Controls.Add(this.metroLabel9);
            this.metroTabPage1.Controls.Add(this.metroLabel10);
            this.metroTabPage1.Controls.Add(this.metroLabel11);
            this.metroTabPage1.Controls.Add(this.metroLabel12);
            this.metroTabPage1.Controls.Add(this.metroPanel2);
            this.metroTabPage1.Controls.Add(this.positionComboBox);
            this.metroTabPage1.Controls.Add(this.wageTextBox);
            this.metroTabPage1.Controls.Add(this.birthDateTime);
            this.metroTabPage1.Controls.Add(this.lastNameTextBox);
            this.metroTabPage1.Controls.Add(this.firstNameTextBox);
            this.metroTabPage1.Controls.Add(this.AddEmployeeButton);
            this.metroTabPage1.Controls.Add(this.editButton);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(706, 455);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Add New Employee   ";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(213, 280);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(47, 20);
            this.metroLabel7.TabIndex = 36;
            this.metroLabel7.Text = "Wage:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(201, 237);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(59, 20);
            this.metroLabel8.TabIndex = 35;
            this.metroLabel8.Text = "Position:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(201, 193);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(60, 20);
            this.metroLabel9.TabIndex = 34;
            this.metroLabel9.Text = "Gender:";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(196, 148);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(68, 20);
            this.metroLabel10.TabIndex = 33;
            this.metroLabel10.Text = "Birthdate:";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(186, 105);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(78, 20);
            this.metroLabel11.TabIndex = 32;
            this.metroLabel11.Text = "Last Name:";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(181, 61);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(79, 20);
            this.metroLabel12.TabIndex = 31;
            this.metroLabel12.Text = "First Name:";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.femaleRadioButton);
            this.metroPanel2.Controls.Add(this.maleRadioButton);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(267, 193);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(197, 24);
            this.metroPanel2.TabIndex = 30;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.femaleRadioButton.Location = new System.Drawing.Point(104, 3);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(73, 20);
            this.femaleRadioButton.TabIndex = 13;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseSelectable = true;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.maleRadioButton.Location = new System.Drawing.Point(3, 3);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(58, 20);
            this.maleRadioButton.TabIndex = 12;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseSelectable = true;
            // 
            // positionComboBox
            // 
            this.positionComboBox.FormattingEnabled = true;
            this.positionComboBox.ItemHeight = 24;
            this.positionComboBox.Location = new System.Drawing.Point(267, 237);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.PromptText = "Select a position";
            this.positionComboBox.Size = new System.Drawing.Size(197, 30);
            this.positionComboBox.TabIndex = 28;
            this.positionComboBox.UseSelectable = true;
            // 
            // wageTextBox
            // 
            this.wageTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.wageTextBox.Lines = new string[0];
            this.wageTextBox.Location = new System.Drawing.Point(267, 280);
            this.wageTextBox.MaxLength = 32767;
            this.wageTextBox.Name = "wageTextBox";
            this.wageTextBox.PasswordChar = '\0';
            this.wageTextBox.PromptText = "Wage";
            this.wageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.wageTextBox.SelectedText = "";
            this.wageTextBox.Size = new System.Drawing.Size(197, 30);
            this.wageTextBox.TabIndex = 27;
            this.wageTextBox.UseSelectable = true;
            // 
            // birthDateTime
            // 
            this.birthDateTime.Location = new System.Drawing.Point(267, 148);
            this.birthDateTime.MinimumSize = new System.Drawing.Size(0, 30);
            this.birthDateTime.Name = "birthDateTime";
            this.birthDateTime.Size = new System.Drawing.Size(200, 30);
            this.birthDateTime.TabIndex = 26;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.lastNameTextBox.Lines = new string[0];
            this.lastNameTextBox.Location = new System.Drawing.Point(270, 105);
            this.lastNameTextBox.MaxLength = 32767;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.PasswordChar = '\0';
            this.lastNameTextBox.PromptText = "Last Name";
            this.lastNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lastNameTextBox.SelectedText = "";
            this.lastNameTextBox.Size = new System.Drawing.Size(197, 30);
            this.lastNameTextBox.TabIndex = 25;
            this.lastNameTextBox.UseSelectable = true;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.firstNameTextBox.Lines = new string[0];
            this.firstNameTextBox.Location = new System.Drawing.Point(270, 61);
            this.firstNameTextBox.MaxLength = 32767;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.PasswordChar = '\0';
            this.firstNameTextBox.PromptText = "First Name";
            this.firstNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.firstNameTextBox.SelectedText = "";
            this.firstNameTextBox.Size = new System.Drawing.Size(197, 30);
            this.firstNameTextBox.TabIndex = 24;
            this.firstNameTextBox.UseSelectable = true;
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.DisplayFocus = true;
            this.AddEmployeeButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.AddEmployeeButton.Highlight = true;
            this.AddEmployeeButton.Location = new System.Drawing.Point(487, 370);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(112, 33);
            this.AddEmployeeButton.TabIndex = 29;
            this.AddEmployeeButton.Text = "Add";
            this.AddEmployeeButton.UseSelectable = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // editButton
            // 
            this.editButton.DisplayFocus = true;
            this.editButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.editButton.Highlight = true;
            this.editButton.Location = new System.Drawing.Point(487, 370);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(112, 33);
            this.editButton.TabIndex = 37;
            this.editButton.Text = "Edit";
            this.editButton.UseSelectable = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroButton3);
            this.metroTabPage2.Controls.Add(this.metroButton1);
            this.metroTabPage2.Controls.Add(this.metroGrid2);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(706, 455);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = " All Employee";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroButton3
            // 
            this.metroButton3.DisplayFocus = true;
            this.metroButton3.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton3.Highlight = true;
            this.metroButton3.Location = new System.Drawing.Point(536, 412);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(112, 33);
            this.metroButton3.TabIndex = 31;
            this.metroButton3.Text = "Edit";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.DisplayFocus = true;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(382, 412);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(112, 33);
            this.metroButton1.TabIndex = 30;
            this.metroButton1.Text = "Delete";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid2.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid2.EnableHeadersVisualStyles = false;
            this.metroGrid2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.Location = new System.Drawing.Point(0, 3);
            this.metroGrid2.MultiSelect = false;
            this.metroGrid2.Name = "metroGrid2";
            this.metroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid2.RowTemplate.Height = 24;
            this.metroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid2.Size = new System.Drawing.Size(703, 403);
            this.metroGrid2.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 590);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.Name = "EmployeesForm";
            this.Resizable = false;
            this.Text = "Employees";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Employees_FormClosed);
            this.Load += new System.EventHandler(this.Employees_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroRadioButton femaleRadioButton;
        private MetroFramework.Controls.MetroRadioButton maleRadioButton;
        private MetroFramework.Controls.MetroButton AddEmployeeButton;
        private MetroFramework.Controls.MetroComboBox positionComboBox;
        private MetroFramework.Controls.MetroTextBox wageTextBox;
        private MetroFramework.Controls.MetroDateTime birthDateTime;
        private MetroFramework.Controls.MetroTextBox lastNameTextBox;
        private MetroFramework.Controls.MetroTextBox firstNameTextBox;
        private MetroFramework.Controls.MetroGrid metroGrid2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton editButton;
    }
}