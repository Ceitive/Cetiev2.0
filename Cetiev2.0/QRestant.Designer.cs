﻿
namespace Cetiev2._0
{
    partial class QRestant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rayonnage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Button_Rechercher_REF_QRestant = new System.Windows.Forms.Button();
            this.Label_Entrez_la_référence = new System.Windows.Forms.Label();
            this.Label_Recherche_par_référence = new System.Windows.Forms.Label();
            this.button_back_QReastant = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.actualiserBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Reference,
            this.Description,
            this.Rest,
            this.Rayonnage});
            this.dataGridView1.Location = new System.Drawing.Point(11, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1894, 617);
            this.dataGridView1.TabIndex = 6;
            // 
            // Reference
            // 
            this.Reference.HeaderText = "Reference";
            this.Reference.MinimumWidth = 8;
            this.Reference.Name = "Reference";
            this.Reference.ReadOnly = true;
            this.Reference.Width = 150;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 8;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 150;
            // 
            // Rest
            // 
            this.Rest.HeaderText = "Q.Restane";
            this.Rest.MinimumWidth = 8;
            this.Rest.Name = "Rest";
            this.Rest.ReadOnly = true;
            this.Rest.Width = 150;
            // 
            // Rayonnage
            // 
            this.Rayonnage.HeaderText = "Rayonnage";
            this.Rayonnage.MinimumWidth = 8;
            this.Rayonnage.Name = "Rayonnage";
            this.Rayonnage.ReadOnly = true;
            this.Rayonnage.Width = 150;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(315, 31);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // Button_Rechercher_REF_QRestant
            // 
            this.Button_Rechercher_REF_QRestant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Rechercher_REF_QRestant.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Button_Rechercher_REF_QRestant.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Rechercher_REF_QRestant.Location = new System.Drawing.Point(753, 792);
            this.Button_Rechercher_REF_QRestant.Name = "Button_Rechercher_REF_QRestant";
            this.Button_Rechercher_REF_QRestant.Size = new System.Drawing.Size(409, 42);
            this.Button_Rechercher_REF_QRestant.TabIndex = 16;
            this.Button_Rechercher_REF_QRestant.Text = "Chercher";
            this.Button_Rechercher_REF_QRestant.UseVisualStyleBackColor = false;
            this.Button_Rechercher_REF_QRestant.Click += new System.EventHandler(this.Button_Rechercher_REF_QRestant_Click);
            // 
            // Label_Entrez_la_référence
            // 
            this.Label_Entrez_la_référence.AutoSize = true;
            this.Label_Entrez_la_référence.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Entrez_la_référence.Location = new System.Drawing.Point(753, 743);
            this.Label_Entrez_la_référence.Name = "Label_Entrez_la_référence";
            this.Label_Entrez_la_référence.Size = new System.Drawing.Size(154, 32);
            this.Label_Entrez_la_référence.TabIndex = 14;
            this.Label_Entrez_la_référence.Text = "Entrez le réf :";
            // 
            // Label_Recherche_par_référence
            // 
            this.Label_Recherche_par_référence.AutoSize = true;
            this.Label_Recherche_par_référence.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Label_Recherche_par_référence.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label_Recherche_par_référence.Location = new System.Drawing.Point(779, 688);
            this.Label_Recherche_par_référence.Name = "Label_Recherche_par_référence";
            this.Label_Recherche_par_référence.Size = new System.Drawing.Size(362, 45);
            this.Label_Recherche_par_référence.TabIndex = 13;
            this.Label_Recherche_par_référence.Text = "Recherche par référence";
            // 
            // button_back_QReastant
            // 
            this.button_back_QReastant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_back_QReastant.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button_back_QReastant.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_back_QReastant.Location = new System.Drawing.Point(11, 937);
            this.button_back_QReastant.Name = "button_back_QReastant";
            this.button_back_QReastant.Size = new System.Drawing.Size(184, 42);
            this.button_back_QReastant.TabIndex = 40;
            this.button_back_QReastant.Text = "Retour";
            this.button_back_QReastant.UseVisualStyleBackColor = false;
            this.button_back_QReastant.Click += new System.EventHandler(this.button_back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(880, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 32);
            this.label2.TabIndex = 47;
            this.label2.Text = "Tableau Quantité Restante";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(903, 743);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 33);
            this.comboBox1.TabIndex = 51;
            // 
            // actualiserBtn
            // 
            this.actualiserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.actualiserBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.actualiserBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.actualiserBtn.Location = new System.Drawing.Point(1798, 9);
            this.actualiserBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.actualiserBtn.Name = "actualiserBtn";
            this.actualiserBtn.Size = new System.Drawing.Size(107, 38);
            this.actualiserBtn.TabIndex = 52;
            this.actualiserBtn.Text = "Actualiser";
            this.actualiserBtn.UseVisualStyleBackColor = false;
            this.actualiserBtn.Click += new System.EventHandler(this.actualiserBtn_Click);
            // 
            // QRestant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 918);
            this.Controls.Add(this.actualiserBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_back_QReastant);
            this.Controls.Add(this.Button_Rechercher_REF_QRestant);
            this.Controls.Add(this.Label_Entrez_la_référence);
            this.Controls.Add(this.Label_Recherche_par_référence);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "QRestant";
            this.Text = "QRestant";
            this.Load += new System.EventHandler(this.QRestant_Load);
            this.Resize += new System.EventHandler(this.QRestant_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Button_Rechercher_REF_QRestant;
        private System.Windows.Forms.Label Label_Entrez_la_référence;
        private System.Windows.Forms.Label Label_Recherche_par_référence;
        private System.Windows.Forms.Button button_back_QReastant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rayonnage;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button actualiserBtn;
    }
}