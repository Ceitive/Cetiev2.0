using IronXL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Windows.UI.Xaml.Controls;
using NPOI.SS.Formula.Functions;
using Aspose.Cells;
using Microsoft.Office.Interop.Excel;

namespace Cetiev2._0
{
    public partial class Clean : Form
    {
        public Clean()
        {
            InitializeComponent();
        }
        private System.Data.DataTable ReadExcel(string fileName)
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
                        System.Data.DataTable dtExcel = ReadExcel(file.FileName); //read excel file
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

        private List<string> getQuantity()
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].Name = dataGridView1.Columns[i].Name.Trim();
            }

            var QuantitwColumn = dataGridView1.Columns["Quantity"];
            int quantityiIndex = dataGridView1.Columns.IndexOf(QuantitwColumn);

            
            List<string> list = dataGridView1.Rows
                       .OfType<DataGridViewRow>()
                       .Where(x => x.Cells[quantityiIndex].Value != null)
                       .Select(x => x.Cells[quantityiIndex].Value.ToString())
                       .ToList();
            return list;
        }

        private List<string> getRef()
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].Name = dataGridView1.Columns[i].Name.Trim();
            }
            var QuantitwColumn = dataGridView1.Columns["Reference PSA"];
            int quantityiIndex = dataGridView1.Columns.IndexOf(QuantitwColumn);

            List<string> list = dataGridView1.Rows
                       .OfType<DataGridViewRow>()
                       .Where(x => x.Cells[quantityiIndex].Value != null)
                       .Select(x => x.Cells[quantityiIndex].Value.ToString())
                       .ToList();
            return list;
        }

        private List<string> getDescription()
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].Name = dataGridView1.Columns[i].Name.Trim();
            }
            var QuantitwColumn = dataGridView1.Columns["Description EN"];
            int quantityiIndex = dataGridView1.Columns.IndexOf(QuantitwColumn);

            List<string> list = dataGridView1.Rows
                       .OfType<DataGridViewRow>()
                       .Where(x => x.Cells[quantityiIndex].Value != null)
                       .Select(x => x.Cells[quantityiIndex].Value.ToString())
                       .ToList();
            return list;
        }
        private string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        private void Button_Upload_Click(object sender, EventArgs e)
        {
            // Duplicate ref
            //string removeduplicate = dataGridView2.Rows[0].Cells[0].Text;
            //for (int i = 1; 1 < dataGridView2.Rows.Count; i++)
            //{
            //    if (dataGridView2.Rows[i].Cells[0].Text == removeduplicate)
            //    {
            //        dataGridView2.Rows[i].Cells[0].Text = string.Empty;
            //    }
            //    else
            //    {
            //        removeduplicate = dataGridView2.Rows[i].Cells[0].Text;  
            //    }
            //}

            List<string> Quantlist = getQuantity();
            List<string> refList = getRef();
            List<string> descList = getDescription();
            List<string> resteList = Quantlist;
            List<string> consumerList = resteList;


            //refList = refList.Distinct().ToList<string>();
            //descList = descList.Distinct().ToList<string>();

            dataGridView2.RowCount = refList.Count;
            for (int i = 0; i < refList.Count; i++)
            {
                dataGridView2[0, i].Value = refList[i];
            }

            dataGridView2.RowCount = Quantlist.Count;
            for (int i = 0; i < Quantlist.Count; i++)
            {
                dataGridView2[1, i].Value = Quantlist[i];
            }
            for (int i = 0; i < resteList.Count; i++)
            {
                dataGridView2[5, i].Value = resteList[i];
            }
            // replaceto 0
            for (int i = 0; i < consumerList.Count; i++)
            {
                
                if (!String.IsNullOrEmpty(dataGridView2[0, i].Value as String))
                {
                    consumerList[i] = "0"; 
                }
                else
                {
                    break;
                }
                
            }

            for (int i = 0; i < descList.Count; i++)
            {
                dataGridView2[2, i].Value = descList[i];
            }
            for (int i = 0; i < consumerList.Count; i++) 
            {
                dataGridView2[4, i].Value = consumerList[i];
            }

            for (int i = 0; i < dataGridView2.RowCount - 1; i++) //compare data
            {
                var Row = dataGridView2.Rows[i];
                string abc = Row.Cells[0].Value.ToString();

                for (int j = i + 1; j < dataGridView2.RowCount; j++)
                {
                    var Row2 = dataGridView2.Rows[j];
                    string def = Row2.Cells[0].Value.ToString();
                    if (abc != "" && def != "")
                    {
                        if (abc == def)
                        {
                            int result = int.Parse(Row.Cells[1].Value.ToString()) + int.Parse(Row2.Cells[1].Value.ToString());
                            Row.Cells[1].Value = result.ToString();
                            Row.Cells[5].Value = result.ToString();
                            dataGridView2.Rows.Remove(Row2);
                            j--;
                        }
                    }
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button_back_clean_Click(object sender, EventArgs e)
        {
            this.Close();
            Browse back = new Browse();
            back.Show(); 
        }

        private void RemoveDupBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
    public static class DataGridHelper
    {
        public static object GetCellValueFromColumnHeader(this DataGridViewCellCollection CellCollection, string HeaderText)
        {
            return CellCollection.Cast<DataGridViewCell>().First(c => c.OwningColumn.HeaderText == HeaderText).Value;
        }
    }
}
