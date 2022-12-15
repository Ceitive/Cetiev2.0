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
    }
}
