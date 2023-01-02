using DocumentFormat.OpenXml.Spreadsheet;
using IronXL;
using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SQLite;
using Windows.UI.Xaml.Controls;
using Application = System.Windows.Forms.Application;
using Excel = Microsoft.Office.Interop.Excel;

namespace Cetiev2._0
{
    public partial class Home : Form
    {        
        public Home()
        {
            InitializeComponent();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Label_Recherche_par_référence_Click(object sender, EventArgs e)
        {

        }

        private void Button_Rechercher_REF_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Label_Entrez_la_référence_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void File_path_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Browse back = new Browse();
            back.Show();
        }

        private void button_Quantité_restante_de_piéces_Click(object sender, EventArgs e)
        {
            this.Hide();
            QRestant h = new QRestant();
            h.Show();
        }

        private void button_Quantité_de_pièces_consommées_Click(object sender, EventArgs e)
        {
            this.Hide();
            QConsume h = new QConsume();
            h.Show();
        }
        private void ActualiserBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db");
            conn.Open();
            SQLiteCommand comm = new SQLiteCommand("Select * From ProjectDetails", conn);
            using (SQLiteDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[] {
            //read.GetValue(0),  // U can use column index
            read.GetValue(read.GetOrdinal("Reference")),  // Or column name like this
            read.GetValue(read.GetOrdinal("Desciption")),
            read.GetValue(read.GetOrdinal("Quantity")),
            read.GetValue(read.GetOrdinal("Rayonnage")),
            read.GetValue(read.GetOrdinal("Consummation")),
            read.GetValue(read.GetOrdinal("Rest")),
            read.GetValue(read.GetOrdinal("ProjectName"))
            });
                }
            }
        }

        private void searchByRef(object sender, EventArgs e)
        {
            //SQLiteConnection conn = new SQLiteConnection("Data Source=database.db");
            //conn.Open();
            //SQLiteCommand comm = new SQLiteCommand("Select * From ProjectDetails WHERE Reference=@Ref", conn);
            //comm.Parameters.AddWithValue("@Ref", comboBox1.SelectedItem.ToString());
            //using (SQLiteDataReader read = comm.ExecuteReader())
            //{
            //    while (read.Read())
            //    {
            //        dataGridView1.Rows.Add(new object[] {
            ////read.GetValue(0),  // U can use column index
            //read.GetValue(read.GetOrdinal("Reference")),  // Or column name like this
            //read.GetValue(read.GetOrdinal("Desciption")),
            //read.GetValue(read.GetOrdinal("Quantity")),
            //read.GetValue(read.GetOrdinal("Rayonnage")),
            //read.GetValue(read.GetOrdinal("Consummation")),
            //read.GetValue(read.GetOrdinal("Rest")),
            //read.GetValue(read.GetOrdinal("ProjectName"))
            //});
            //    }
            //}
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db");
            DataTable table = new DataTable();
            if (comboBox1.SelectedItem.ToString() == "Ref")
            {
                conn.Open();
                comboBox2.DisplayMember = "Reference";
                SQLiteDataAdapter sda = new SQLiteDataAdapter("Select Reference From ProjectDetails", conn);
                sda.Fill(table);
                comboBox2.DataSource = table;
                conn.Close();
            }
            else if (comboBox1.SelectedItem.ToString() == "Project")
            {
                conn.Open();
                comboBox2.DisplayMember = "ProjectName";
                SQLiteDataAdapter sda = new SQLiteDataAdapter("Select ProjectName From ProjectDetails", conn);           
                sda.Fill(table);
                comboBox2.DataSource = table;
                conn.Close();
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Ref")
            {
                SQLiteConnection conn = new SQLiteConnection("Data Source=database.db");
                conn.Open();
                SQLiteCommand comm = new SQLiteCommand("Select * From ProjectDetails WHERE Reference=@Ref", conn);
                //System.Windows.Forms.ComboBox typeItem = (System.Windows.Forms.ComboBox)comboBox2.SelectedItem;
                comm.Parameters.AddWithValue("@Ref", comboBox2.Text);
                dataGridView1.Rows.Clear();
                using (SQLiteDataReader read = comm.ExecuteReader())
                {
                    while (read.Read())
                    {
                        dataGridView1.Rows.Add(new object[] {
            //read.GetValue(0),  // U can use column index
            read.GetValue(read.GetOrdinal("Reference")),  // Or column name like this
            read.GetValue(read.GetOrdinal("Desciption")),
            read.GetValue(read.GetOrdinal("Quantity")),
            read.GetValue(read.GetOrdinal("Rayonnage")),
            read.GetValue(read.GetOrdinal("Consummation")),
            read.GetValue(read.GetOrdinal("Rest")),
            read.GetValue(read.GetOrdinal("ProjectName"))
            });
                    }
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Project")
            {
                SQLiteConnection conn = new SQLiteConnection("Data Source=database.db");
                conn.Open();
                SQLiteCommand comm = new SQLiteCommand("Select * From ProjectDetails WHERE ProjectName=@ProjectName", conn);
                comm.Parameters.AddWithValue("@ProjectName", comboBox2.Text);
                dataGridView1.Rows.Clear();
                using (SQLiteDataReader read = comm.ExecuteReader())
                {
                    while (read.Read())
                    {
                        dataGridView1.Rows.Add(new object[] {
                        //read.GetValue(0),  // U can use column index
                        read.GetValue(read.GetOrdinal("Reference")),  // Or column name like this
                        read.GetValue(read.GetOrdinal("Desciption")),
                        read.GetValue(read.GetOrdinal("Quantity")),
                        read.GetValue(read.GetOrdinal("Rayonnage")),
                        read.GetValue(read.GetOrdinal("Consummation")),
                        read.GetValue(read.GetOrdinal("Rest")),
                        read.GetValue(read.GetOrdinal("ProjectName"))
                        });
                    }
                }
            }
        }
        private void copyAlltoClipboard()
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
        private void Export_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {

                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }
    }
}
