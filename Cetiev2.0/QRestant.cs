using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cetiev2._0
{
    public partial class QRestant : Form
    {
        //private Rectangle label2OriginalRect;
        //private Rectangle dateTimePicker1OriginalRect;
        //private Rectangle dataGridView1OriginalRect;
        //private Rectangle Label_Recherche_par_référenceOriginalRect;
        //private Rectangle Label_Entrez_la_référenceOriginalRect;
        //private Rectangle TextBox_Entrez_REFOriginalRect;
        //private Rectangle Button_Rechercher_REF_QRestantOriginalRect;
        //private Rectangle button_Imprimer_QRestantOriginalRect;
        //private Rectangle button_back_QReastantOriginalRect;

        //private Size formOriginalSize;
        public QRestant()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Home back = new Home();
            back.Show();
        }

        private void QRestant_Load(object sender, EventArgs e)
        {
            //formOriginalSize = this.Size;
            //label2OriginalRect = new Rectangle(label2.Location.X, label2.Location.Y, label2.Width, label2.Height);
            //dateTimePicker1OriginalRect = new Rectangle(dateTimePicker1.Location.X, dateTimePicker1.Location.Y, dateTimePicker1.Width, dateTimePicker1.Height);
            //dataGridView1OriginalRect = new Rectangle(dataGridView1.Location.X, dataGridView1.Location.Y, dataGridView1.Width, dataGridView1.Height);
            //Label_Recherche_par_référenceOriginalRect = new Rectangle(Label_Recherche_par_référence.Location.X, Label_Recherche_par_référence.Location.Y, Label_Recherche_par_référence.Width, Label_Recherche_par_référence.Height);
            //Label_Entrez_la_référenceOriginalRect = new Rectangle(Label_Entrez_la_référence.Location.X, Label_Entrez_la_référence.Location.Y, Label_Entrez_la_référence.Width, Label_Entrez_la_référence.Height);
            //TextBox_Entrez_REFOriginalRect = new Rectangle(TextBox_Entrez_REF.Location.X, TextBox_Entrez_REF.Location.Y, TextBox_Entrez_REF.Width, TextBox_Entrez_REF.Height);
            //Button_Rechercher_REF_QRestantOriginalRect = new Rectangle(Button_Rechercher_REF_QRestant.Location.X, Button_Rechercher_REF_QRestant.Location.Y, Button_Rechercher_REF_QRestant.Width, Button_Rechercher_REF_QRestant.Height);
            //button_Imprimer_QRestantOriginalRect = new Rectangle(button_Imprimer_QRestant.Location.X, button_Imprimer_QRestant.Location.Y, button_Imprimer_QRestant.Width, button_Imprimer_QRestant.Height);
            //button_back_QReastantOriginalRect = new Rectangle(button_back_QReastant.Location.X, button_back_QReastant.Location.Y, button_back_QReastant.Width, button_back_QReastant.Height);

            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db");
            DataTable table = new DataTable();
            conn.Open();
            comboBox1.DisplayMember = "Reference";
            SQLiteDataAdapter sda = new SQLiteDataAdapter("Select distinct Reference From Consume", conn);
            sda.Fill(table);
            comboBox1.DataSource = table;
            conn.Close();
        }

        //private void resizeChildrenControls()
        //{
        //    resizeControls(label2OriginalRect, label2);
        //    resizeControls(dateTimePicker1OriginalRect, dateTimePicker1);
        //    resizeControls(dataGridView1OriginalRect, dataGridView1);
        //    resizeControls(Label_Recherche_par_référenceOriginalRect, Label_Recherche_par_référence);
        //    resizeControls(Label_Entrez_la_référenceOriginalRect, Label_Entrez_la_référence);
        //    resizeControls(TextBox_Entrez_REFOriginalRect, TextBox_Entrez_REF);
        //    resizeControls(Button_Rechercher_REF_QRestantOriginalRect, Button_Rechercher_REF_QRestant);
        //    resizeControls(button_Imprimer_QRestantOriginalRect, button_Imprimer_QRestant);
        //    resizeControls(button_back_QReastantOriginalRect, button_back_QReastant);
        //}

        //private void resizeControls(Rectangle OriginalControlRect, Control control)
        //{
        //    float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
        //    float yRatio = (float)(this.Width) / (float)(formOriginalSize.Height);

        //    int newX = (int)(OriginalControlRect.X * xRatio);
        //    int newY = (int)(OriginalControlRect.Y);

        //    int newWidth = (int)(OriginalControlRect.Width * xRatio);
        //    int newHeight = (int)(OriginalControlRect.Height * xRatio);

        //    control.Location = new Point(newX, newY);
        //    control.Size = new Size(newWidth, newHeight);

        //}

        private void button_Imprimer_QRestant_Click(object sender, EventArgs e)
        {
           
        }

        private void QRestant_Resize(object sender, EventArgs e)
        {
            //resizeChildrenControls();
        }

        private void Button_Rechercher_REF_QRestant_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db");
            conn.Open();
            SQLiteCommand comm = new SQLiteCommand("Select * From Consume as t1 join ProjectDetails as t2 on t1.Reference = t2.Reference where t1.Reference=@Ref", conn);
            //System.Windows.Forms.ComboBox typeItem = (System.Windows.Forms.ComboBox)comboBox2.SelectedItem;
            comm.Parameters.AddWithValue("@Ref", comboBox1.Text);
            dataGridView1.Rows.Clear();
            using (SQLiteDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[]
                    {
                    //read.GetValue(0),  // U can use column index
                    read.GetValue(read.GetOrdinal("Reference")),  // Or column name like this
                    read.GetValue(read.GetOrdinal("Desciption")),
                    read.GetValue(read.GetOrdinal("Rest")),
                    read.GetValue(read.GetOrdinal("Rayonnage")),
                    });
                }
            }
        }

        private void actualiserBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db");
            conn.Open();
            SQLiteCommand comm = new SQLiteCommand("Select * From Consume join ProjectDetails on Consume.Reference = ProjectDetails.Reference", conn);
            using (SQLiteDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[]
                    {
                    //read.GetValue(0),  // U can use column index
                    read.GetValue(read.GetOrdinal("Reference")),  // Or column name like this
                    read.GetValue(read.GetOrdinal("Desciption")),
                    read.GetValue(read.GetOrdinal("Rest")),
                    read.GetValue(read.GetOrdinal("Rayonnage")),
                    });
                }
            }
        }

        //private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        //{

        //}
    }
}
