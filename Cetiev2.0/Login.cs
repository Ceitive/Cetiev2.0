using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Cetiev2._0
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Size = new Size(3000, 2500);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtMotdepasse.UseSystemPasswordChar = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SeConnecter_Click(object sender, EventArgs e)
        {
            string username = txtUtilisateur.Text;
            string password = txtMotdepasse.Text;
            //if (username == "aze" && password == "aze")
            //{
            //    this.Hide();
            //    Home h = new Home();
            //    h.Show();
            //}
            //else
            //{
            //    MessageBox.Show("error !");
            //}
            if (username == "" || password == "")
            {
                MessageBox.Show("Empty fields !");
            }
            else
            {
                SQLiteConnection con = new SQLiteConnection("Data Source=database.db");
                con.Open();
                string query = "SELECT AdminName,Password FROM UserAdmin WHERE AdminName=@username AND Password=@password";
                SQLiteCommand cmd = new SQLiteCommand(query,con);
                cmd.Parameters.AddWithValue("@username", txtUtilisateur.Text);
                cmd.Parameters.AddWithValue("@password", txtMotdepasse.Text);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                //SQLiteAuthorizerActionCode con = new SQLiteAuthorizerActionCode("data source");
                if(dt.Rows.Count > 0)
                {
                    this.Hide();
                    Home h = new Home();
                    h.Show();
                }
                else
                {
                    MessageBox.Show("Wrong name or password !");
                }
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
 
        private void button3_Click(object sender, EventArgs e)
        {
              
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (ShowMotdepasse.Checked)
            {
                txtMotdepasse.UseSystemPasswordChar = false;
            }
            else
            {
                txtMotdepasse.UseSystemPasswordChar = true;
            }            
        }

        private void QuitterBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
