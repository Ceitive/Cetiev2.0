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
        //private Rectangle dateTimePicker1OriginalRect;
        //private Rectangle dataGridView1OriginalRect;
        //private Rectangle label_recherche_par_prjtOriginalRect;
        //private Rectangle label1OriginalRect;
        //private Rectangle label_entrez_nom_completOriginalRect;
        //private Rectangle label_entrez_IE_IUOriginalRect;
        //private Rectangle label_Nombre_des_pcsOriginalRect;
        //private Rectangle label_entrez_REFOriginalRect;
        //private Rectangle comboBox1OriginalRect;
        //private Rectangle comboBox2OriginalRect;
        //private Rectangle SearchBtnOriginalRect;
        //private Rectangle button_backOriginalRect;
        //private Rectangle label_information_consommateursOriginalRect;
        //private Rectangle textBox_Entrez_nom_completOriginalRect;
        //private Rectangle textBox_entrez_IE_IUOriginalRect;
        //private Rectangle textBox_Nombre_des_pcsOriginalRect;
        //private Rectangle textBox_Entrez_REF_pour_consOriginalRect;
        //private Rectangle button_ValiderOriginalRect;
        //private Rectangle button_Quantité_restante_de_piécesOriginalRect;
        //private Rectangle button_Quantité_de_pièces_consomméesOriginalRect;
        //private Rectangle ActualiserBtnOriginalRect;
        //private Rectangle label2OriginalRect;
        //private Rectangle ExportOriginalRect;

        //private Size formOriginalSize;
        public Home()
        {
            InitializeComponent();
            
        }
        //private void button1_Click(object sender, EventArgs e)
        //{
         
        //}

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
            
        //}

        //private void label2_Click(object sender, EventArgs e)
        //{

        //}

        //private void Label_Recherche_par_référence_Click(object sender, EventArgs e)
        //{

        //}

        //private void Button_Rechercher_REF_Click(object sender, EventArgs e)
        //{

        //}

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        //private void Label_Entrez_la_référence_Click(object sender, EventArgs e)
        //{

        //}

        //private void label4_Click(object sender, EventArgs e)
        //{

        //}

        //private void button2_Click(object sender, EventArgs e)
        //{

        //}

        //private void File_path_Click(object sender, EventArgs e)
        //{

        //}

        //private void Home_Load(object sender, EventArgs e)
        //{
        //    formOriginalSize = this.Size;
        //    dateTimePicker1OriginalRect = new Rectangle(dateTimePicker1.Location.X, dateTimePicker1.Location.Y, dateTimePicker1.Width, dateTimePicker1.Height);
        //    dataGridView1OriginalRect = new Rectangle(dataGridView1.Location.X, dataGridView1.Location.Y, dataGridView1.Width, dataGridView1.Height);
        //    label_recherche_par_prjtOriginalRect = new Rectangle(label_recherche_par_prjt.Location.X, label_recherche_par_prjt.Location.Y, label_recherche_par_prjt.Width, label_recherche_par_prjt.Height);
        //    label1OriginalRect = new Rectangle(label1.Location.X, label1.Location.Y, label1.Width, label1.Height);
        //    label_entrez_nom_completOriginalRect = new Rectangle(label_entrez_nom_complet.Location.X, label_entrez_nom_complet.Location.Y, label_entrez_nom_complet.Width, label_entrez_nom_complet.Height);
        //    label_entrez_IE_IUOriginalRect = new Rectangle(label_entrez_IE_IU.Location.X, label_entrez_IE_IU.Location.Y, label_entrez_IE_IU.Width, label_entrez_IE_IU.Height);
        //    label_Nombre_des_pcsOriginalRect = new Rectangle(label_Nombre_des_pcs.Location.X, label_Nombre_des_pcs.Location.Y, label_Nombre_des_pcs.Width, label_Nombre_des_pcs.Height);
        //    label_entrez_REFOriginalRect = new Rectangle(label_entrez_REF.Location.X, label_entrez_REF.Location.Y, label_entrez_REF.Width, label_entrez_REF.Height);
        //    comboBox1OriginalRect = new Rectangle(comboBox1.Location.X, comboBox1.Location.Y, comboBox1.Width, comboBox1.Height);
        //    comboBox2OriginalRect = new Rectangle(comboBox2.Location.X, comboBox2.Location.Y, comboBox2.Width, comboBox2.Height);
        //    SearchBtnOriginalRect = new Rectangle(SearchBtn.Location.X, SearchBtn.Location.Y, SearchBtn.Width, SearchBtn.Height);
        //    label_information_consommateursOriginalRect = new Rectangle(button_back.Location.X, button_back.Location.Y, button_back.Width, button_back.Height);
        //    label_information_consommateursOriginalRect = new Rectangle(label_information_consommateurs.Location.X, label_information_consommateurs.Location.Y, label_information_consommateurs.Width, label_information_consommateurs.Height);
        //    textBox_Entrez_nom_completOriginalRect = new Rectangle(textBox_Entrez_nom_complet.Location.X, textBox_Entrez_nom_complet.Location.Y, textBox_Entrez_nom_complet.Width, textBox_Entrez_nom_complet.Height);
        //    textBox_entrez_IE_IUOriginalRect = new Rectangle(textBox_entrez_IE_IU.Location.X, textBox_entrez_IE_IU.Location.Y, textBox_entrez_IE_IU.Width, textBox_entrez_IE_IU.Height);
        //    textBox_Nombre_des_pcsOriginalRect = new Rectangle(textBox_Nombre_des_pcs.Location.X, textBox_Nombre_des_pcs.Location.Y, textBox_Nombre_des_pcs.Width, textBox_Nombre_des_pcs.Height);
        //    textBox_Entrez_REF_pour_consOriginalRect = new Rectangle(textBox_Entrez_REF_pour_cons.Location.X, textBox_Entrez_REF_pour_cons.Location.Y, textBox_Entrez_REF_pour_cons.Width, textBox_Entrez_REF_pour_cons.Height);
        //    button_ValiderOriginalRect = new Rectangle(button_Valider.Location.X, button_Valider.Location.Y, button_Valider.Width, button_Valider.Height);
        //    button_Quantité_restante_de_piécesOriginalRect = new Rectangle(button_Quantité_restante_de_piéces.Location.X, button_Quantité_restante_de_piéces.Location.Y, button_Quantité_restante_de_piéces.Width, button_Quantité_restante_de_piéces.Height);
        //    button_Quantité_de_pièces_consomméesOriginalRect = new Rectangle(button_Quantité_de_pièces_consommées.Location.X, button_Quantité_de_pièces_consommées.Location.Y, button_Quantité_de_pièces_consommées.Width, button_Quantité_de_pièces_consommées.Height);
        //    ActualiserBtnOriginalRect = new Rectangle(ActualiserBtn.Location.X, ActualiserBtn.Location.Y, ActualiserBtn.Width, ActualiserBtn.Height);
        //    label2OriginalRect = new Rectangle(label2.Location.X, label2.Location.Y, label2.Width, label2.Height);
        //    ExportOriginalRect = new Rectangle(Export.Location.X, Export.Location.Y, Export.Width, Export.Height);
        //    button_backOriginalRect = new Rectangle(button_back.Location.X, button_back.Location.Y, button_back.Width, button_back.Height);

        //}

        //private void resizeChildrenControls()
        //{
        //    resizeControls(dateTimePicker1OriginalRect, dateTimePicker1);
        //    resizeControls(dataGridView1OriginalRect, dataGridView1);
        //    resizeControls(label_recherche_par_prjtOriginalRect, label_recherche_par_prjt);
        //    resizeControls(label1OriginalRect, label1);
        //    resizeControls(label_entrez_nom_completOriginalRect, label_entrez_nom_complet);
        //    resizeControls(label_entrez_IE_IUOriginalRect, label_entrez_IE_IU);
        //    resizeControls(label_Nombre_des_pcsOriginalRect, label_Nombre_des_pcs);
        //    resizeControls(label_entrez_REFOriginalRect, label_entrez_REF);
        //    resizeControls(comboBox1OriginalRect, comboBox1);
        //    resizeControls(comboBox2OriginalRect, comboBox2);
        //    resizeControls(SearchBtnOriginalRect, SearchBtn);
        //    resizeControls(button_backOriginalRect, button_back);
        //    resizeControls(label_information_consommateursOriginalRect, label_information_consommateurs);
        //    resizeControls(textBox_Entrez_nom_completOriginalRect, textBox_Entrez_nom_complet);
        //    resizeControls(textBox_entrez_IE_IUOriginalRect, textBox_entrez_IE_IU);
        //    resizeControls(textBox_Nombre_des_pcsOriginalRect, textBox_Nombre_des_pcs);
        //    resizeControls(textBox_Entrez_REF_pour_consOriginalRect, textBox_Entrez_REF_pour_cons);
        //    resizeControls(button_ValiderOriginalRect, button_Valider);
        //    resizeControls(button_Quantité_restante_de_piécesOriginalRect, button_Quantité_restante_de_piéces);
        //    resizeControls(button_Quantité_de_pièces_consomméesOriginalRect, button_Quantité_de_pièces_consommées);
        //    resizeControls(ActualiserBtnOriginalRect, ActualiserBtn);
        //    resizeControls(label2OriginalRect, label2);
        //    resizeControls(ExportOriginalRect, Export);
        //}

        //private void resizeControls(Rectangle OriginalControlRect, System.Windows.Forms.Control control)
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
            h.dataGridView1.Rows.Clear();
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db");
            conn.Open();
            SQLiteCommand comm = new SQLiteCommand("Select * From Consume join ProjectDetails on Consume.Reference = ProjectDetails.Reference", conn);
            using (SQLiteDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    h.dataGridView1.Rows.Add(new object[]
                    {
                    //read.GetValue(0),  // U can use column index
                    read.GetValue(read.GetOrdinal("Reference")),  // Or column name like this
                    read.GetValue(read.GetOrdinal("Desciption")),
                    read.GetValue(read.GetOrdinal("Consummation")),
                    read.GetValue(read.GetOrdinal("Name")),
                    read.GetValue(read.GetOrdinal("IE")),
                    read.GetValue(read.GetOrdinal("ProjectName"))
                    });
                }
            }
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
                SQLiteDataAdapter sda = new SQLiteDataAdapter("Select distinct ProjectName From ProjectDetails", conn);       
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
            //if (dataGridView1.Rows.Count > 0)
            //{
            //    Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
            //    xcelApp.Application.Workbooks.Add(Type.Missing);

            //    for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            //    {
            //        xcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            //    }

            //    for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //    {
            //        for (int j = 0; j < dataGridView1.Columns.Count; j++)
            //        {
            //            xcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
            //        }
            //    }
            //    xcelApp.Columns.AutoFit();
            //    xcelApp.Visible = true;
            //}
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=database.db");
            SQLiteCommand cmmd = new SQLiteCommand(@"DELETE FROM ProjectDetails", con);
            con.Open();
            cmmd.ExecuteNonQuery();
            con.Close();

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                SQLiteConnection conn = new SQLiteConnection("Data Source=database.db");
                SQLiteCommand cmd = new SQLiteCommand(@"INSERT INTO ProjectDetails (Reference, Desciption, Quantity, Rayonnage, Consummation, Rest, ProjectName) 
                VALUES ('" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','"
                + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value +
                "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + dataGridView1.Rows[i].Cells[5].Value + "','" +
                dataGridView1.Rows[i].Cells[6].Value + "')", conn);
                
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            //SQLiteConnection conn = new SQLiteConnection("Data Source=database.db");
            //DataTable table = new DataTable();
            //conn.Open();
            //comboBox3.DisplayMember = "Reference";
            //SQLiteDataAdapter sda = new SQLiteDataAdapter("Select Reference From ProjectDetails", conn);
            //sda.Fill(table);
            //comboBox3.DataSource = table;
            //conn.Close();
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //if (e.RowIndex == dataGridView1.NewRowIndex)
            //    dataGridView1.Rows[e.RowIndex].Tag = true;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void validateData(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value == dataGridView1.Rows[i+1].Cells[0].Value)
                    {
                        MessageBox.Show("Duplicate ref is not allowed !");
                    }
                }

            }
        }

        private void textBox_Entrez_REF_pour_cons_TextChanged(object sender, EventArgs e)
        {

        }

        public List<string> getRefInfo(string reference)
        {
            string connectionString = "Data Source=database.db";
            List<string> results = new List<string>();
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            string query = "Select * From ProjectDetails WHERE Reference=@Reference";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@Reference", reference);
            SQLiteDataReader reader = command.ExecuteReader();
            if (!reader.HasRows)
            {
                MessageBox.Show("there is no such reference !");
            }
            // Insert the results into a list
            while (reader.Read())
            {
                results.Add(reader["Rest"].ToString());
            }
            return results;
        }
        private void button_Valider_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db");
            List<string> results = h.getRefInfo(comboBox3.Text);

            SQLiteCommand cmd = new SQLiteCommand(@"INSERT INTO Consume (Name, IE, QtyWanted, Reference) 
                VALUES ('" + textBox_Entrez_nom_complet.Text + "',' " + textBox_entrez_IE_IU.Text + "','"
            + textBox_Nombre_des_pcs.Text + "','" + comboBox3.Text + "')", conn);

            SQLiteCommand comm = new SQLiteCommand("Select * From ProjectDetails WHERE Reference=@Reference", conn);
            comm.Parameters.AddWithValue("@Reference", comboBox3.Text);

            SQLiteCommand updateCmd = new SQLiteCommand("Update ProjectDetails set Rest =:rest WHERE Reference=:Reference", conn);
            updateCmd.Parameters.Add("rest",DbType.String).Value = int.Parse(results[0]) - int.Parse(textBox_Nombre_des_pcs.Text);
            updateCmd.Parameters.Add("Reference", DbType.String).Value = comboBox3.Text;

            // insert the result of query into a tempo list


            if (textBox_Entrez_nom_complet.Text == "" || textBox_entrez_IE_IU.Text == "" || textBox_Nombre_des_pcs.Text == "" ||
                comboBox3.Text == "")
            {
                MessageBox.Show("fields cannot be empty !");
            }
           
            else if (textBox_Nombre_des_pcs.Text != "")
            {
                if (results.Count > 0)
                {
                    if (int.Parse(textBox_Nombre_des_pcs.Text) > int.Parse(results[0]))
                    {
                        MessageBox.Show("number of pieces is bigger than the rest quantity !");
                    }
                    else
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        updateCmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("your order has been validated !");
                    }

                }
            }
        }

        private void enterQty(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db");
            DataTable table = new DataTable();
            conn.Open();
            comboBox3.DisplayMember = "Reference";
            SQLiteDataAdapter sda = new SQLiteDataAdapter("Select Reference From ProjectDetails", conn);
            sda.Fill(table);
            comboBox3.DataSource = table;
            conn.Close();
        }


        //private void dataGridView1_Resize(object sender, EventArgs e)
        //{
        //    resizeChildrenControls();
        //}
    }
}
