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
        // Risize
        private Rectangle panel1OriginalRect;
        private Rectangle panel2OriginalRect;
        private Rectangle ckeanDataOriginalRect;
        private Rectangle dataManipulationOriginalRect;

        private Size formOriginalSize;
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

        private void Browse_Load(object sender, EventArgs e)
        {   // Resize
            formOriginalSize = this.Size;
            panel1OriginalRect = new Rectangle(panel1.Location.X, panel1.Location.Y, panel1.Width, panel1.Height);
            panel2OriginalRect = new Rectangle(panel2.Location.X, panel2.Location.Y, panel2.Width, panel2.Height);
            ckeanDataOriginalRect = new Rectangle(ckeanData.Location.X, ckeanData.Location.Y, ckeanData.Width, ckeanData.Height);
            dataManipulationOriginalRect = new Rectangle(dataManipulation.Location.X, dataManipulation.Location.Y, dataManipulation.Width, dataManipulation.Height);
        }

        private void resizeChildrenControls()
        {   // Resize
            resizeControls(panel1OriginalRect, panel1);
            resizeControls(panel2OriginalRect, panel2);
            resizeControls(ckeanDataOriginalRect, ckeanData);
            resizeControls(dataManipulationOriginalRect, dataManipulation);
        }

        private void resizeControls(Rectangle OriginalControlRect, Control control)
        {   // Resize
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Width) / (float)(formOriginalSize.Height);

            int newX = (int)(OriginalControlRect.X * xRatio);
            int newY = (int)(OriginalControlRect.Y);

            int newWidth = (int)(OriginalControlRect.Width * xRatio);
            int newHeight = (int)(OriginalControlRect.Height * xRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);

        }

        private void Browse_Resize(object sender, EventArgs e)
        {    //Resize
            resizeChildrenControls();
        }
    }
}
