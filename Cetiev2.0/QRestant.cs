﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cetiev2._0
{
    public partial class QRestant : Form
    {
        public QRestant()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Home back = new Home();
            back.Show();
        }

        private void QRestant_Load(object sender, EventArgs e)
        {
            
        }

        private void button_Imprimer_QRestant_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrintRestant h = new PrintRestant();
            h.Show();
        }
    }
}