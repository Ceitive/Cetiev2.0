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
    public partial class Browse : Form
    {
        public Browse()
        {
            InitializeComponent();
        }

        private void ckeanData_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clean h = new Clean();
            h.Show();
        }
        private void dataManipulation_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.dataGridView1.Rows.Clear();
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db");
            conn.Open();
            SQLiteCommand comm = new SQLiteCommand("Select * From ProjectDetails", conn);
            using (SQLiteDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    h.dataGridView1.Rows.Add(new object[] 
                    {
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
            this.Hide();
            h.Show();
        }
    }
}
