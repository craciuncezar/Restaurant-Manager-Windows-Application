namespace Restaurant_Manager_Windows_Application
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.reservationsBtn = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tablesBtn = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.employeesBtn = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuBtn = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.receiptBtn = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.statisticsBtn = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.barChartUserControl1 = new Restaurant_Manager_Windows_Application.Custom_User_Control.BarChartUserControl();
            this.restaurantMenuUserControl1 = new Restaurant_Manager_Windows_Applictaion.Forms.RestaurantMenuUserControl();
            this.reservationsUserControl1 = new Restaurant_Manager_Windows_Applictaion.Forms.ReservationsUserControl();
            this.tablesUserControl1 = new Restaurant_Manager_Windows_Applictaion.Custom_User_Control.TablesUserControl();
            this.employeesUserControl1 = new Restaurant_Manager_Windows_Applictaion.Custom_User_Control.EmployeesUserControl();
            this.receiptUserControl1 = new Restaurant_Manager_Windows_Applictaion.Custom_User_Control.ReceiptUserControl();
            this.flowLayoutPanel1.SuspendLayout();
            this.reservationsBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tablesBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.employeesBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.receiptBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.statisticsBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.reservationsBtn);
            this.flowLayoutPanel1.Controls.Add(this.tablesBtn);
            this.flowLayoutPanel1.Controls.Add(this.employeesBtn);
            this.flowLayoutPanel1.Controls.Add(this.menuBtn);
            this.flowLayoutPanel1.Controls.Add(this.receiptBtn);
            this.flowLayoutPanel1.Controls.Add(this.statisticsBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 80);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(264, 486);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // reservationsBtn
            // 
            this.reservationsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.reservationsBtn.Controls.Add(this.pictureBox1);
            this.reservationsBtn.Controls.Add(this.label4);
            this.reservationsBtn.Location = new System.Drawing.Point(0, 0);
            this.reservationsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.reservationsBtn.Name = "reservationsBtn";
            this.reservationsBtn.Size = new System.Drawing.Size(265, 81);
            this.reservationsBtn.TabIndex = 14;
            this.reservationsBtn.Click += new System.EventHandler(this.displayReservationsClick);
            this.reservationsBtn.MouseEnter += new System.EventHandler(this.menuButtons_MouseEnter);
            this.reservationsBtn.MouseLeave += new System.EventHandler(this.menuButtons_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::Restaurant_Manager_Windows_Applictaion.Properties.Resources.reservation_icon;
            this.pictureBox1.Location = new System.Drawing.Point(5, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(78, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Reservations";
            this.label4.Click += new System.EventHandler(this.displayReservationsClick);
            this.label4.MouseEnter += new System.EventHandler(this.menuButtons_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.menuButtons_MouseLeave);
            // 
            // tablesBtn
            // 
            this.tablesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.tablesBtn.Controls.Add(this.pictureBox3);
            this.tablesBtn.Controls.Add(this.label5);
            this.tablesBtn.Location = new System.Drawing.Point(0, 81);
            this.tablesBtn.Margin = new System.Windows.Forms.Padding(0);
            this.tablesBtn.Name = "tablesBtn";
            this.tablesBtn.Size = new System.Drawing.Size(265, 81);
            this.tablesBtn.TabIndex = 14;
            this.tablesBtn.Click += new System.EventHandler(this.tablesBtnClick);
            this.tablesBtn.MouseEnter += new System.EventHandler(this.menuButtons_MouseEnter);
            this.tablesBtn.MouseLeave += new System.EventHandler(this.menuButtons_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = global::Restaurant_Manager_Windows_Applictaion.Properties.Resources.tables_icon;
            this.pictureBox3.Location = new System.Drawing.Point(5, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(78, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tables";
            this.label5.Click += new System.EventHandler(this.tablesBtnClick);
            this.label5.MouseEnter += new System.EventHandler(this.menuButtons_MouseEnter);
            this.label5.MouseLeave += new System.EventHandler(this.menuButtons_MouseLeave);
            // 
            // employeesBtn
            // 
            this.employeesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.employeesBtn.Controls.Add(this.pictureBox2);
            this.employeesBtn.Controls.Add(this.label3);
            this.employeesBtn.Location = new System.Drawing.Point(0, 162);
            this.employeesBtn.Margin = new System.Windows.Forms.Padding(0);
            this.employeesBtn.Name = "employeesBtn";
            this.employeesBtn.Size = new System.Drawing.Size(265, 81);
            this.employeesBtn.TabIndex = 14;
            this.employeesBtn.Click += new System.EventHandler(this.employeesBtnClick);
            this.employeesBtn.MouseEnter += new System.EventHandler(this.menuButtons_MouseEnter);
            this.employeesBtn.MouseLeave += new System.EventHandler(this.menuButtons_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = global::Restaurant_Manager_Windows_Applictaion.Properties.Resources.employee_icon;
            this.pictureBox2.Location = new System.Drawing.Point(5, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(78, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Employees";
            this.label3.Click += new System.EventHandler(this.employeesBtnClick);
            this.label3.MouseEnter += new System.EventHandler(this.menuButtons_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.menuButtons_MouseLeave);
            // 
            // menuBtn
            // 
            this.menuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.menuBtn.Controls.Add(this.pictureBox4);
            this.menuBtn.Controls.Add(this.label6);
            this.menuBtn.Location = new System.Drawing.Point(0, 243);
            this.menuBtn.Margin = new System.Windows.Forms.Padding(0);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(265, 81);
            this.menuBtn.TabIndex = 14;
            this.menuBtn.Click += new System.EventHandler(this.menuBtnClick);
            this.menuBtn.MouseEnter += new System.EventHandler(this.menuButtons_MouseEnter);
            this.menuBtn.MouseLeave += new System.EventHandler(this.menuButtons_MouseLeave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Image = global::Restaurant_Manager_Windows_Applictaion.Properties.Resources.menupicture;
            this.pictureBox4.Location = new System.Drawing.Point(5, 14);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(78, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Menu";
            this.label6.Click += new System.EventHandler(this.menuBtnClick);
            this.label6.MouseEnter += new System.EventHandler(this.menuButtons_MouseEnter);
            this.label6.MouseLeave += new System.EventHandler(this.menuButtons_MouseLeave);
            // 
            // receiptBtn
            // 
            this.receiptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.receiptBtn.Controls.Add(this.label1);
            this.receiptBtn.Controls.Add(this.pictureBox6);
            this.receiptBtn.Location = new System.Drawing.Point(0, 324);
            this.receiptBtn.Margin = new System.Windows.Forms.Padding(0);
            this.receiptBtn.Name = "receiptBtn";
            this.receiptBtn.Size = new System.Drawing.Size(265, 81);
            this.receiptBtn.TabIndex = 13;
            this.receiptBtn.Click += new System.EventHandler(this.receiptBtnClick);
            this.receiptBtn.MouseEnter += new System.EventHandler(this.menuButtons_MouseEnter);
            this.receiptBtn.MouseLeave += new System.EventHandler(this.menuButtons_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Receipt";
            this.label1.Click += new System.EventHandler(this.receiptBtnClick);
            this.label1.MouseEnter += new System.EventHandler(this.menuButtons_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.menuButtons_MouseLeave);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Enabled = false;
            this.pictureBox6.Image = global::Restaurant_Manager_Windows_Applictaion.Properties.Resources.recipt_icon;
            this.pictureBox6.Location = new System.Drawing.Point(5, 14);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(60, 45);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // statisticsBtn
            // 
            this.statisticsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.statisticsBtn.Controls.Add(this.pictureBox5);
            this.statisticsBtn.Controls.Add(this.label2);
            this.statisticsBtn.Location = new System.Drawing.Point(0, 405);
            this.statisticsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.statisticsBtn.Name = "statisticsBtn";
            this.statisticsBtn.Size = new System.Drawing.Size(265, 81);
            this.statisticsBtn.TabIndex = 14;
            this.statisticsBtn.Click += new System.EventHandler(this.statisticsBtn_Click);
            this.statisticsBtn.MouseEnter += new System.EventHandler(this.menuButtons_MouseEnter);
            this.statisticsBtn.MouseLeave += new System.EventHandler(this.menuButtons_MouseLeave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Enabled = false;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(5, 14);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(60, 45);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Statistics";
            this.label2.Click += new System.EventHandler(this.statisticsBtn_Click);
            this.label2.MouseEnter += new System.EventHandler(this.menuButtons_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.menuButtons_MouseLeave);
            // 
            // barChartUserControl1
            // 
            this.barChartUserControl1.Location = new System.Drawing.Point(291, 94);
            this.barChartUserControl1.Name = "barChartUserControl1";
            this.barChartUserControl1.Size = new System.Drawing.Size(694, 446);
            this.barChartUserControl1.TabIndex = 18;
            this.barChartUserControl1.Visible = false;
            // 
            // restaurantMenuUserControl1
            // 
            this.restaurantMenuUserControl1.Location = new System.Drawing.Point(267, 39);
            this.restaurantMenuUserControl1.Name = "restaurantMenuUserControl1";
            this.restaurantMenuUserControl1.Size = new System.Drawing.Size(765, 527);
            this.restaurantMenuUserControl1.TabIndex = 17;
            this.restaurantMenuUserControl1.Visible = false;
            // 
            // reservationsUserControl1
            // 
            this.reservationsUserControl1.Location = new System.Drawing.Point(267, 39);
            this.reservationsUserControl1.Name = "reservationsUserControl1";
            this.reservationsUserControl1.Size = new System.Drawing.Size(765, 527);
            this.reservationsUserControl1.TabIndex = 13;
            // 
            // tablesUserControl1
            // 
            this.tablesUserControl1.BackColor = System.Drawing.Color.White;
            this.tablesUserControl1.Location = new System.Drawing.Point(270, 80);
            this.tablesUserControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tablesUserControl1.Name = "tablesUserControl1";
            this.tablesUserControl1.Size = new System.Drawing.Size(765, 486);
            this.tablesUserControl1.TabIndex = 16;
            this.tablesUserControl1.Visible = false;
            // 
            // employeesUserControl1
            // 
            this.employeesUserControl1.BackColor = System.Drawing.Color.White;
            this.employeesUserControl1.Location = new System.Drawing.Point(267, 39);
            this.employeesUserControl1.Name = "employeesUserControl1";
            this.employeesUserControl1.Size = new System.Drawing.Size(765, 527);
            this.employeesUserControl1.TabIndex = 15;
            this.employeesUserControl1.Visible = false;
            // 
            // receiptUserControl1
            // 
            this.receiptUserControl1.BackColor = System.Drawing.Color.White;
            this.receiptUserControl1.Location = new System.Drawing.Point(267, 39);
            this.receiptUserControl1.Name = "receiptUserControl1";
            this.receiptUserControl1.Size = new System.Drawing.Size(765, 519);
            this.receiptUserControl1.TabIndex = 14;
            this.receiptUserControl1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1035, 566);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.reservationsUserControl1);
            this.Controls.Add(this.tablesUserControl1);
            this.Controls.Add(this.employeesUserControl1);
            this.Controls.Add(this.receiptUserControl1);
            this.Controls.Add(this.barChartUserControl1);
            this.Controls.Add(this.restaurantMenuUserControl1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 80, 0, 0);
            this.Resizable = false;
            this.Text = "Restaurant Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.reservationsBtn.ResumeLayout(false);
            this.reservationsBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tablesBtn.ResumeLayout(false);
            this.tablesBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.employeesBtn.ResumeLayout(false);
            this.employeesBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuBtn.ResumeLayout(false);
            this.menuBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.receiptBtn.ResumeLayout(false);
            this.receiptBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.statisticsBtn.ResumeLayout(false);
            this.statisticsBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel receiptBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel reservationsBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel statisticsBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel tablesBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel employeesBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel menuBtn;
        private System.Windows.Forms.Label label6;
        private Restaurant_Manager_Windows_Applictaion.Forms.ReservationsUserControl reservationsUserControl1;
        private Restaurant_Manager_Windows_Applictaion.Custom_User_Control.ReceiptUserControl receiptUserControl1;
        private Restaurant_Manager_Windows_Applictaion.Custom_User_Control.EmployeesUserControl employeesUserControl1;
        private Restaurant_Manager_Windows_Applictaion.Custom_User_Control.TablesUserControl tablesUserControl1;
        private Restaurant_Manager_Windows_Applictaion.Forms.RestaurantMenuUserControl restaurantMenuUserControl1;
        private Custom_User_Control.BarChartUserControl barChartUserControl1;
    }
}

