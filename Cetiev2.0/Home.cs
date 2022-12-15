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
    }
}
