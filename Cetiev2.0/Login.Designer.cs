
namespace Cetiev2._0
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1_effacer = new System.Windows.Forms.Button();
            this.ShowMotdepasse = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtUtilisateur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.QuitterBtn = new System.Windows.Forms.Button();
            this.SeConnecter = new System.Windows.Forms.Button();
            this.txtMotdepasse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            //this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // button1_effacer
            // 
            this.button1_effacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1_effacer.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1_effacer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1_effacer.Location = new System.Drawing.Point(549, 563);
            this.button1_effacer.Name = "button1_effacer";
            this.button1_effacer.Size = new System.Drawing.Size(162, 46);
            this.button1_effacer.TabIndex = 10;
            this.button1_effacer.Text = "Effacer";
            this.button1_effacer.UseVisualStyleBackColor = false;
            this.button1_effacer.Click += new System.EventHandler(this.button1_effacer_Click);
            // 
            // ShowMotdepasse
            // 
            this.ShowMotdepasse.AutoSize = true;
            this.ShowMotdepasse.Font = new System.Drawing.Font("Segoe UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowMotdepasse.Location = new System.Drawing.Point(719, 522);
            this.ShowMotdepasse.Name = "ShowMotdepasse";
            this.ShowMotdepasse.Size = new System.Drawing.Size(73, 25);
            this.ShowMotdepasse.TabIndex = 9;
            this.ShowMotdepasse.Text = "Show";
            this.ShowMotdepasse.UseVisualStyleBackColor = true;
            this.ShowMotdepasse.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Cetiev2._0.Properties.Resources._1638892306970;
            this.pictureBox2.Location = new System.Drawing.Point(666, 309);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 70);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // txtUtilisateur
            // 
            this.txtUtilisateur.Location = new System.Drawing.Point(719, 406);
            this.txtUtilisateur.Name = "txtUtilisateur";
            this.txtUtilisateur.Size = new System.Drawing.Size(163, 45);
            this.txtUtilisateur.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(549, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Utilisateur :";
            // 
            // QuitterBtn
            // 
            this.QuitterBtn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.QuitterBtn.Location = new System.Drawing.Point(549, 639);
            this.QuitterBtn.Name = "QuitterBtn";
            this.QuitterBtn.Size = new System.Drawing.Size(333, 42);
            this.QuitterBtn.TabIndex = 6;
            this.QuitterBtn.Text = "Quitter";
            this.QuitterBtn.UseVisualStyleBackColor = true;
            this.QuitterBtn.Click += new System.EventHandler(this.QuitterBtn_Click);
            // 
            // SeConnecter
            // 
            this.SeConnecter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SeConnecter.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.SeConnecter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SeConnecter.Location = new System.Drawing.Point(720, 563);
            this.SeConnecter.Name = "SeConnecter";
            this.SeConnecter.Size = new System.Drawing.Size(162, 46);
            this.SeConnecter.TabIndex = 5;
            this.SeConnecter.Text = "Se connecter";
            this.SeConnecter.UseVisualStyleBackColor = false;
            this.SeConnecter.Click += new System.EventHandler(this.SeConnecter_Click);
            // 
            // txtMotdepasse
            // 
            this.txtMotdepasse.Location = new System.Drawing.Point(719, 470);
            this.txtMotdepasse.Name = "txtMotdepasse";
            this.txtMotdepasse.Size = new System.Drawing.Size(163, 45);
            this.txtMotdepasse.TabIndex = 4;
            this.txtMotdepasse.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(549, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mot de passe :";
            //this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(549, 235);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenue M. Chouaib AABAR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cetiev2._0.Properties.Resources._1554374594171_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(520, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.button1_effacer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ShowMotdepasse);
            this.Controls.Add(this.txtUtilisateur);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QuitterBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SeConnecter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMotdepasse);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Login_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMotdepasse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SeConnecter;
        private System.Windows.Forms.Button QuitterBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtUtilisateur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox ShowMotdepasse;
        private System.Windows.Forms.Button button1_effacer;
    }
}

