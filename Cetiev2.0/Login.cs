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
        private Rectangle pictureBox1OriginalRect;
        private Rectangle pictureBox2OriginalRect;
        private Rectangle label1OriginalRect;
        private Rectangle label2OriginalRect;
        private Rectangle label3OriginalRect;
        private Rectangle txtUtilisateurOriginalRect;
        private Rectangle txtMotdepasseOriginalRect;
        private Rectangle ShowMotdepasseOriginalRect;
        private Rectangle button1_effacerOriginalRect;
        private Rectangle SeConnecterOriginalRect;
        private Rectangle QuitterBtnOriginalRect;

        private Size formOriginalSize;
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formOriginalSize = this.Size;
            pictureBox1OriginalRect = new Rectangle(pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.Width, pictureBox1.Height);
            pictureBox2OriginalRect = new Rectangle(pictureBox2.Location.X, pictureBox2.Location.Y, pictureBox2.Width, pictureBox2.Height);
            label1OriginalRect = new Rectangle(label1.Location.X, label1.Location.Y, label1.Width, label1.Height);
            label2OriginalRect = new Rectangle(label2.Location.X, label2.Location.Y, label2.Width, label2.Height);
            label3OriginalRect = new Rectangle(label3.Location.X, label3.Location.Y, label3.Width, label3.Height);
            txtUtilisateurOriginalRect = new Rectangle(txtUtilisateur.Location.X, txtUtilisateur.Location.Y, txtUtilisateur.Width, txtUtilisateur.Height);
            txtMotdepasseOriginalRect = new Rectangle(txtMotdepasse.Location.X, txtMotdepasse.Location.Y, txtMotdepasse.Width, txtMotdepasse.Height);
            ShowMotdepasseOriginalRect = new Rectangle(ShowMotdepasse.Location.X, ShowMotdepasse.Location.Y, ShowMotdepasse.Width, ShowMotdepasse.Height);
            button1_effacerOriginalRect = new Rectangle(button1_effacer.Location.X, button1_effacer.Location.Y, button1_effacer.Width, button1_effacer.Height);
            SeConnecterOriginalRect = new Rectangle(SeConnecter.Location.X, SeConnecter.Location.Y, SeConnecter.Width, SeConnecter.Height);
            QuitterBtnOriginalRect = new Rectangle(QuitterBtn.Location.X, QuitterBtn.Location.Y, QuitterBtn.Width, QuitterBtn.Height);
        }

        private void resizeChildrenControls()
        {
            resizeControls(pictureBox1OriginalRect, pictureBox1);
            resizeControls(pictureBox2OriginalRect, pictureBox2);
            resizeControls(label1OriginalRect, label1);
            resizeControls(label2OriginalRect, label2);
            resizeControls(label3OriginalRect, label3);
            resizeControls(txtUtilisateurOriginalRect, txtUtilisateur);
            resizeControls(txtMotdepasseOriginalRect, txtMotdepasse);
            resizeControls(ShowMotdepasseOriginalRect, ShowMotdepasse);
            resizeControls(button1_effacerOriginalRect, button1_effacer);
            resizeControls(SeConnecterOriginalRect, SeConnecter);
            resizeControls(QuitterBtnOriginalRect, QuitterBtn);
        }

        private void resizeControls(Rectangle OriginalControlRect, Control control)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Width) / (float)(formOriginalSize.Height);

            int newX = (int)(OriginalControlRect.X * xRatio);
            int newY = (int)(OriginalControlRect.Y);

            int newWidth = (int)(OriginalControlRect.Width * xRatio);
            int newHeight = (int)(OriginalControlRect.Height * xRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtMotdepasse.UseSystemPasswordChar = true;
        }

        private void SeConnecter_Click(object sender, EventArgs e)
        {
            string username = txtUtilisateur.Text;
            string password = txtMotdepasse.Text;
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
                    Browse h = new Browse();
                    h.Show();
                }
                else
                {
                    MessageBox.Show("Wrong name or password !");
                }
            } 
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

        private void button1_effacer_Click(object sender, EventArgs e)
        {
            txtUtilisateur.Text = "";
            txtMotdepasse.Text = "";
        }

        private void Login_Resize(object sender, EventArgs e)
        {
            resizeChildrenControls();
        }
    }
}
