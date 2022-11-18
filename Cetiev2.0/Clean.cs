using IronXL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Cetiev2._0
{
    public partial class Clean : Form
    {
        public Clean()
        {
            InitializeComponent();
        }
        private DataTable ReadExcel(string fileName)
        {
            WorkBook workbook = WorkBook.Load(fileName);
            WorkSheet sheet = workbook.DefaultWorkSheet;
            return sheet.ToDataTable(true);
        }
        private void Button_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog(); //open dialog to choose file

            if (file.ShowDialog() == DialogResult.OK) //if there is a file chosen by the user
            {
                string fileExt = Path.GetExtension(file.FileName); //get the file extension
                if (fileExt.CompareTo(".xls") == 0 || fileExt.CompareTo(".xlsx") == 0)
                {
                    try
                    {
                        textBox_file_path.Text = file.FileName;
                        DataTable dtExcel = ReadExcel(file.FileName); //read excel file
                        dataGridView1.Visible = true;
                        dataGridView1.DataSource = dtExcel;
                        if (dataGridView1.DataSource != null)
                        {
                            dataGridView1.Refresh();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Please choose .xls or .xlsx file only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error); //custom messageBox to show error
                }
            }
        }

        private void Clean_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Browse h = new Browse();
            h.Show();
        }
    }
}
