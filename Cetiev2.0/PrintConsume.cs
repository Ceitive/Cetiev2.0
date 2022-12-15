using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cetiev2._0
{
    public partial class PrintConsume : Form
    {
        public PrintConsume()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
            QConsume back = new QConsume();
            back.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
