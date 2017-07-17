namespace Restaurant_Manager_Windows_Application
{
    partial class ReservationsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.warningText = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.phoneNumberTextBox = new MetroFramework.Controls.MetroTextBox();
            this.emailTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.guestsTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroDateTime = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.nameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.tablesComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.AddReservationButton = new MetroFramework.Controls.MetroButton();
            this.editButton1 = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.addTableButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.editButton = new MetroFramework.Controls.MetroButton();
            this.deleteButton = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.todayEditButton = new MetroFramework.Controls.MetroButton();
            this.tdaydeleteButton = new MetroFramework.Controls.MetroButton();
            this.metroGrid2 = new MetroFramework.Controls.MetroGrid();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.metroTabPage3.SuspendLayout();
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
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.Location = new System.Drawing.Point(23, 64);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(700, 506);
            this.metroTabControl1.TabIndex = 9;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl_SelectedIndexChanged);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.panel2);
            this.metroTabPage1.Controls.Add(this.panel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(692, 458);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Add New Reservation ";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.warningText);
            this.panel2.Controls.Add(this.metroLabel12);
            this.panel2.Controls.Add(this.phoneNumberTextBox);
            this.panel2.Controls.Add(this.emailTextBox);
            this.panel2.Controls.Add(this.metroLabel11);
            this.panel2.Controls.Add(this.metroLabel7);
            this.panel2.Controls.Add(this.guestsTextBox);
            this.panel2.Controls.Add(this.metroDateTime);
            this.panel2.Controls.Add(this.metroLabel10);
            this.panel2.Controls.Add(this.metroLabel8);
            this.panel2.Controls.Add(this.nameTextBox);
            this.panel2.Controls.Add(this.tablesComboBox);
            this.panel2.Controls.Add(this.metroLabel9);
            this.panel2.Controls.Add(this.AddReservationButton);
            this.panel2.Controls.Add(this.editButton1);
            this.panel2.Location = new System.Drawing.Point(0, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(696, 455);
            this.panel2.TabIndex = 31;
            // 
            // warningText
            // 
            this.warningText.AutoSize = true;
            this.warningText.BackColor = System.Drawing.Color.Transparent;
            this.warningText.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.warningText.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.warningText.ForeColor = System.Drawing.Color.Red;
            this.warningText.Location = new System.Drawing.Point(230, 10);
            this.warningText.Name = "warningText";
            this.warningText.Size = new System.Drawing.Size(129, 25);
            this.warningText.TabIndex = 31;
            this.warningText.Text = "Warning text";
            this.warningText.UseCustomBackColor = true;
            this.warningText.UseCustomForeColor = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(221, 59);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(50, 20);
            this.metroLabel12.TabIndex = 25;
            this.metroLabel12.Text = "Name:";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.phoneNumberTextBox.Lines = new string[0];
            this.phoneNumberTextBox.Location = new System.Drawing.Point(278, 236);
            this.phoneNumberTextBox.MaxLength = 32767;
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.PasswordChar = '\0';
            this.phoneNumberTextBox.PromptText = "Phone Number";
            this.phoneNumberTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.phoneNumberTextBox.SelectedText = "";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(200, 30);
            this.phoneNumberTextBox.TabIndex = 24;
            this.phoneNumberTextBox.UseSelectable = true;
            // 
            // emailTextBox
            // 
            this.emailTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.emailTextBox.Lines = new string[0];
            this.emailTextBox.Location = new System.Drawing.Point(278, 283);
            this.emailTextBox.MaxLength = 32767;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.PromptText = "Email";
            this.emailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.Size = new System.Drawing.Size(200, 30);
            this.emailTextBox.TabIndex = 23;
            this.emailTextBox.UseSelectable = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(217, 100);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(54, 20);
            this.metroLabel11.TabIndex = 26;
            this.metroLabel11.Text = "Guests:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(161, 283);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(110, 20);
            this.metroLabel7.TabIndex = 30;
            this.metroLabel7.Text = "Email (optional) :";
            // 
            // guestsTextBox
            // 
            this.guestsTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.guestsTextBox.Lines = new string[0];
            this.guestsTextBox.Location = new System.Drawing.Point(280, 100);
            this.guestsTextBox.MaxLength = 32767;
            this.guestsTextBox.Name = "guestsTextBox";
            this.guestsTextBox.PasswordChar = '\0';
            this.guestsTextBox.PromptText = "Number of Guests";
            this.guestsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.guestsTextBox.SelectedText = "";
            this.guestsTextBox.Size = new System.Drawing.Size(198, 30);
            this.guestsTextBox.TabIndex = 21;
            this.guestsTextBox.UseSelectable = true;
            this.guestsTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.guestsTextBox_Validating);
            // 
            // metroDateTime
            // 
            this.metroDateTime.Location = new System.Drawing.Point(278, 145);
            this.metroDateTime.MinimumSize = new System.Drawing.Size(0, 30);
            this.metroDateTime.Name = "metroDateTime";
            this.metroDateTime.Size = new System.Drawing.Size(200, 30);
            this.metroDateTime.TabIndex = 18;
            this.metroDateTime.ValueChanged += new System.EventHandler(this.metroDateTime_ValueChanged);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(230, 145);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(41, 20);
            this.metroLabel10.TabIndex = 27;
            this.metroLabel10.Text = "Date:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(162, 236);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(109, 20);
            this.metroLabel8.TabIndex = 29;
            this.metroLabel8.Text = "Phone Number:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.nameTextBox.Lines = new string[0];
            this.nameTextBox.Location = new System.Drawing.Point(280, 59);
            this.nameTextBox.MaxLength = 32767;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.PromptText = "Full Name";
            this.nameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.Size = new System.Drawing.Size(198, 30);
            this.nameTextBox.TabIndex = 20;
            this.nameTextBox.UseSelectable = true;
            // 
            // tablesComboBox
            // 
            this.tablesComboBox.FormattingEnabled = true;
            this.tablesComboBox.ItemHeight = 24;
            this.tablesComboBox.Location = new System.Drawing.Point(278, 187);
            this.tablesComboBox.Name = "tablesComboBox";
            this.tablesComboBox.PromptText = "Available Tables";
            this.tablesComboBox.Size = new System.Drawing.Size(201, 30);
            this.tablesComboBox.TabIndex = 19;
            this.tablesComboBox.UseSelectable = true;
            this.tablesComboBox.SelectedIndexChanged += new System.EventHandler(this.tablesComboBox_SelectedIndexChanged);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(227, 187);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(44, 20);
            this.metroLabel9.TabIndex = 28;
            this.metroLabel9.Text = "Table:";
            // 
            // AddReservationButton
            // 
            this.AddReservationButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.AddReservationButton.Location = new System.Drawing.Point(493, 337);
            this.AddReservationButton.Name = "AddReservationButton";
            this.AddReservationButton.Size = new System.Drawing.Size(120, 30);
            this.AddReservationButton.TabIndex = 22;
            this.AddReservationButton.Text = "Add";
            this.AddReservationButton.UseSelectable = true;
            this.AddReservationButton.Click += new System.EventHandler(this.AddReservationButton_Click);
            // 
            // editButton1
            // 
            this.editButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.editButton1.Location = new System.Drawing.Point(493, 337);
            this.editButton1.Name = "editButton1";
            this.editButton1.Size = new System.Drawing.Size(120, 30);
            this.editButton1.TabIndex = 32;
            this.editButton1.Text = "Edit";
            this.editButton1.UseSelectable = true;
            this.editButton1.Click += new System.EventHandler(this.editButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.addTableButton);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Location = new System.Drawing.Point(0, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 458);
            this.panel1.TabIndex = 5;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.Red;
            this.metroLabel1.Location = new System.Drawing.Point(230, 111);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(239, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "You dont have any tables.";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // addTableButton
            // 
            this.addTableButton.Location = new System.Drawing.Point(282, 214);
            this.addTableButton.Name = "addTableButton";
            this.addTableButton.Size = new System.Drawing.Size(150, 40);
            this.addTableButton.TabIndex = 4;
            this.addTableButton.Text = "Add Table";
            this.addTableButton.UseSelectable = true;
            this.addTableButton.Click += new System.EventHandler(this.addTableButton_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.Red;
            this.metroLabel2.Location = new System.Drawing.Point(86, 143);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(544, 25);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Please add a table in order to be able to assign reservations!";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.editButton);
            this.metroTabPage2.Controls.Add(this.deleteButton);
            this.metroTabPage2.Controls.Add(this.metroGrid1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(692, 458);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = " All Reservations ";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // editButton
            // 
            this.editButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.editButton.Location = new System.Drawing.Point(557, 410);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(120, 30);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Edit";
            this.editButton.UseSelectable = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.deleteButton.Location = new System.Drawing.Point(402, 410);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(120, 30);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseSelectable = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToOrderColumns = true;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle14;
            this.metroGrid1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.metroGrid1.Location = new System.Drawing.Point(0, 3);
            this.metroGrid1.MaximumSize = new System.Drawing.Size(20000, 20000);
            this.metroGrid1.MultiSelect = false;
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 24;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(686, 373);
            this.metroGrid1.TabIndex = 3;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.todayEditButton);
            this.metroTabPage3.Controls.Add(this.tdaydeleteButton);
            this.metroTabPage3.Controls.Add(this.metroGrid2);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(692, 458);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = " Today\'s Reservations";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // todayEditButton
            // 
            this.todayEditButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.todayEditButton.Location = new System.Drawing.Point(557, 410);
            this.todayEditButton.Name = "todayEditButton";
            this.todayEditButton.Size = new System.Drawing.Size(120, 30);
            this.todayEditButton.TabIndex = 8;
            this.todayEditButton.Text = "Edit";
            this.todayEditButton.UseSelectable = true;
            this.todayEditButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // tdaydeleteButton
            // 
            this.tdaydeleteButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.tdaydeleteButton.Location = new System.Drawing.Point(402, 410);
            this.tdaydeleteButton.Name = "tdaydeleteButton";
            this.tdaydeleteButton.Size = new System.Drawing.Size(120, 30);
            this.tdaydeleteButton.TabIndex = 7;
            this.tdaydeleteButton.Text = "Delete";
            this.tdaydeleteButton.UseSelectable = true;
            this.tdaydeleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // metroGrid2
            // 
            this.metroGrid2.AllowUserToAddRows = false;
            this.metroGrid2.AllowUserToDeleteRows = false;
            this.metroGrid2.AllowUserToOrderColumns = true;
            this.metroGrid2.AllowUserToResizeRows = false;
            this.metroGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.metroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid2.DefaultCellStyle = dataGridViewCellStyle17;
            this.metroGrid2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.metroGrid2.EnableHeadersVisualStyles = false;
            this.metroGrid2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.metroGrid2.Location = new System.Drawing.Point(0, 3);
            this.metroGrid2.MaximumSize = new System.Drawing.Size(20000, 20000);
            this.metroGrid2.MultiSelect = false;
            this.metroGrid2.Name = "metroGrid2";
            this.metroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.metroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid2.RowTemplate.Height = 24;
            this.metroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid2.Size = new System.Drawing.Size(686, 373);
            this.metroGrid2.TabIndex = 6;
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
            // ReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 593);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.Name = "ReservationsForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Reservations";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReservationsForm_FormClosed);
            this.Load += new System.EventHandler(this.ReservationsForm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
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
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox phoneNumberTextBox;
        private MetroFramework.Controls.MetroTextBox emailTextBox;
        private MetroFramework.Controls.MetroTextBox guestsTextBox;
        private MetroFramework.Controls.MetroButton AddReservationButton;
        private MetroFramework.Controls.MetroTextBox nameTextBox;
        private MetroFramework.Controls.MetroComboBox tablesComboBox;
        private MetroFramework.Controls.MetroDateTime metroDateTime;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton addTableButton;
        private MetroFramework.Controls.MetroLabel warningText;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroButton editButton;
        private MetroFramework.Controls.MetroButton deleteButton;
        private MetroFramework.Controls.MetroButton editButton1;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroButton todayEditButton;
        private MetroFramework.Controls.MetroButton tdaydeleteButton;
        private MetroFramework.Controls.MetroGrid metroGrid2;
    }
}