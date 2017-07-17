namespace Restaurant_Manager_Windows_Application.Forms
{
    partial class TablesForm
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.tableNumberTextBox = new MetroFramework.Controls.MetroTextBox();
            this.maxSeatsTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroGrid = new MetroFramework.Controls.MetroGrid();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.deleteButton = new MetroFramework.Controls.MetroButton();
            this.warningText = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(389, 117);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 20);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Max Seats:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(361, 75);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(101, 20);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Table Number:";
            // 
            // metroButton1
            // 
            this.metroButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.Location = new System.Drawing.Point(544, 184);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(79, 30);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Add";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // tableNumberTextBox
            // 
            this.tableNumberTextBox.Lines = new string[0];
            this.tableNumberTextBox.Location = new System.Drawing.Point(468, 75);
            this.tableNumberTextBox.MaxLength = 32767;
            this.tableNumberTextBox.Name = "tableNumberTextBox";
            this.tableNumberTextBox.PasswordChar = '\0';
            this.tableNumberTextBox.ReadOnly = true;
            this.tableNumberTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tableNumberTextBox.SelectedText = "";
            this.tableNumberTextBox.Size = new System.Drawing.Size(155, 30);
            this.tableNumberTextBox.TabIndex = 7;
            this.tableNumberTextBox.UseSelectable = true;
            // 
            // maxSeatsTextBox
            // 
            this.maxSeatsTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.maxSeatsTextBox.Lines = new string[0];
            this.maxSeatsTextBox.Location = new System.Drawing.Point(468, 117);
            this.maxSeatsTextBox.MaxLength = 32767;
            this.maxSeatsTextBox.Name = "maxSeatsTextBox";
            this.maxSeatsTextBox.PasswordChar = '\0';
            this.maxSeatsTextBox.PromptText = "Max Number of Seats";
            this.maxSeatsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.maxSeatsTextBox.SelectedText = "";
            this.maxSeatsTextBox.Size = new System.Drawing.Size(155, 30);
            this.maxSeatsTextBox.TabIndex = 8;
            this.maxSeatsTextBox.UseSelectable = true;
            // 
            // metroGrid
            // 
            this.metroGrid.AllowUserToAddRows = false;
            this.metroGrid.AllowUserToDeleteRows = false;
            this.metroGrid.AllowUserToOrderColumns = true;
            this.metroGrid.AllowUserToResizeRows = false;
            this.metroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.metroGrid.Location = new System.Drawing.Point(13, 75);
            this.metroGrid.MaximumSize = new System.Drawing.Size(20000, 20000);
            this.metroGrid.MultiSelect = false;
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
            this.metroGrid.Size = new System.Drawing.Size(342, 249);
            this.metroGrid.TabIndex = 9;
            this.metroGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid_CellEndEdit);
            this.metroGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.metroGrid_CellValidating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // deleteButton
            // 
            this.deleteButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.deleteButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.deleteButton.Location = new System.Drawing.Point(413, 184);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(79, 30);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseSelectable = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // warningText
            // 
            this.warningText.AutoSize = true;
            this.warningText.BackColor = System.Drawing.Color.Transparent;
            this.warningText.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.warningText.ForeColor = System.Drawing.Color.Black;
            this.warningText.Location = new System.Drawing.Point(23, 355);
            this.warningText.Name = "warningText";
            this.warningText.Size = new System.Drawing.Size(451, 20);
            this.warningText.TabIndex = 32;
            this.warningText.Text = "Info: To edit the tables max seats double click on the table column!";
            this.warningText.UseCustomBackColor = true;
            this.warningText.UseCustomForeColor = true;
            // 
            // TablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 395);
            this.Controls.Add(this.warningText);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.metroGrid);
            this.Controls.Add(this.maxSeatsTextBox);
            this.Controls.Add(this.tableNumberTextBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton1);
            this.MaximizeBox = false;
            this.Name = "TablesForm";
            this.Resizable = false;
            this.Text = "Tables";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TablesForm_FormClosed);
            this.Load += new System.EventHandler(this.TablesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox tableNumberTextBox;
        private MetroFramework.Controls.MetroTextBox maxSeatsTextBox;
        private MetroFramework.Controls.MetroGrid metroGrid;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroButton deleteButton;
        private MetroFramework.Controls.MetroLabel warningText;
    }
}