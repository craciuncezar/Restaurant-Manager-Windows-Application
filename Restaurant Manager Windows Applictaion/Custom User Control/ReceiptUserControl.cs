using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;
using Entities;
using Restaurant_Manager_Windows_Application;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Restaurant_Manager_Windows_Applictaion.Custom_User_Control
{
    public partial class ReceiptUserControl : UserControl
    {
        public ReceiptUserControl()
        {
            InitializeComponent();
        }

        private void ReceiptUserControl_VisibleChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            metroComboBox1.DataSource = null;
            metroComboBox1.Items.Clear();
            metroComboBox1.DataSource = MainForm.Restaurant.Menu;
            metroComboBox1.DisplayMember = "FoodName";
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem listviewitem = new ListViewItem(metroComboBox1.Text);
                listviewitem.SubItems.Add("$" + ((FoodItem)metroComboBox1.SelectedItem).Price.ToString());
                listView1.Items.Add(listviewitem);
            }
            catch(Exception)
            {
                return;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printDialog = new PrintPreviewDialog();

            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument;

            printDialog.PrintPreviewControl.Zoom = 1.0;
            printDialog.StartPosition = FormStartPosition.CenterParent;
            printDialog.Height = 550;

            printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();

            }
        }

        private void CreateReceipt(object sender, PrintPageEventArgs e)
        {
            //this prints the reciept
            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 12); //must use a mono spaced font as the spaces need to line up

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString(" Restaurant Receipt", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);
            string top = "Item Name".PadRight(30) + "Price";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight; //make the spacing consistent
            graphic.DrawString("----------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5; //make the spacing consistent

            float totalprice = 0.00f;

            foreach (ListViewItem lvi in listView1.Items)
            {
                //create the string to print on the reciept
                string productDescription = lvi.Text;
                string productPriceTag = lvi.SubItems[1].Text;
                float productPrice = float.Parse((lvi.SubItems[1].Text).Substring(1));

                totalprice += productPrice;

                string productLine = productDescription.PadRight(30) + productPriceTag;

                graphic.DrawString(productLine, font, new SolidBrush(Color.Black), startX, startY + offset);

                offset = offset + (int)fontHeight + 5; //make the spacing consistent

            }

            //add the total

            offset = offset + 20; //make some room so that the total stands out.

            graphic.DrawString("Total to pay ".PadRight(30) + String.Format("{0:c}", totalprice), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + 30; //make some room so that the total stands out.
            graphic.DrawString("     Thank-you for your custom,", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 15;
            graphic.DrawString("       please come back soon!", font, new SolidBrush(Color.Black), startX, startY + offset);
        }
    }
}

