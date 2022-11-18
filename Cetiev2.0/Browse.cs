using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            this.Hide();
            Home h = new Home();
            h.Show();
        }
    }
}
