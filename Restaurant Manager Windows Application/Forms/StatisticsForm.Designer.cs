namespace Restaurant_Manager_Windows_Application.Forms
{
    partial class StatisticsForm
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
            this.barChartUserControl1 = new Restaurant_Manager_Windows_Application.Custom_User_Control.BarChartUserControl();
            this.SuspendLayout();
            // 
            // barChartUserControl1
            // 
            this.barChartUserControl1.Location = new System.Drawing.Point(24, 147);
            this.barChartUserControl1.Name = "barChartUserControl1";
            this.barChartUserControl1.Size = new System.Drawing.Size(738, 369);
            this.barChartUserControl1.TabIndex = 0;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 539);
            this.Controls.Add(this.barChartUserControl1);
            this.MaximizeBox = false;
            this.Name = "StatisticsForm";
            this.Resizable = false;
            this.Text = "Statistics";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Statistics_FormClosed);
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Custom_User_Control.BarChartUserControl barChartUserControl1;
    }
}