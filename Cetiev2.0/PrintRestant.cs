using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cetiev2._0
{
    public partial class PrintRestant : Form
    {
        public PrintRestant()
        {
            InitializeComponent();
        }

        private void button_back_PrintConsume_Click(object sender, EventArgs e)
        {
            this.Close();
            QRestant back = new QRestant();
            back.Show();
        }

        private void Button_Confirm_Printing_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objBmp = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(objBmp, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(objBmp, 250, 200);

            //e.Graphics.DrawString(dataGridView1.Text, new Font("Verdana", 20, FontStyle.Bold), Brushes.Black, new Point(300, 30));
            //e.Graphics.DrawString(panel2.Text, new Font("Verdana", 20, FontStyle.Bold), Brushes.Black, new Point(300, 30));
            //e.Graphics.DrawString(label6.Text, new Font("Verdana", 10, FontStyle.Bold), Brushes.Black, new Point(300, 30));
            //e.Graphics.DrawString(label5.Text, new Font("Verdana", 20, FontStyle.Bold), Brushes.Black, new Point(300, 30));
            //e.Graphics.DrawString(label4.Text, new Font("Verdana", 20, FontStyle.Bold), Brushes.Black, new Point(300, 30));
            //e.Graphics.DrawString("CETIEV".Text, new Font("Verdana", 20, FontStyle.Bold), Brushes.Black, new Point(300, 30));
            

        }

        private void PrintRestant_Load(object sender, EventArgs e)
        {

        }
    }
}
