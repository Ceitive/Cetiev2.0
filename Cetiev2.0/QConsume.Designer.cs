﻿
namespace Cetiev2._0
{
    partial class QConsume
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
            this.Consume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Imprimer_QConsume = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.Button_Rechercher_REF_QConume = new System.Windows.Forms.Button();
            this.Label_Entrez_la_référence = new System.Windows.Forms.Label();
            this.Label_Recherche_par_référence = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            this.Consume,
            this.Name,
            this.IE,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView1.Location = new System.Drawing.Point(8, 36);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1376, 365);
            this.dataGridView1.TabIndex = 7;
            // 
            // Reference
            // 
            this.Reference.HeaderText = "Reference";
            this.Reference.Name = "Reference";
            this.Reference.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Consume
            // 
            this.Consume.HeaderText = "Consume";
            this.Consume.Name = "Consume";
            this.Consume.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // IE
            // 
            this.IE.HeaderText = "IE";
            this.IE.Name = "IE";
            this.IE.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Project Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // button_Imprimer_QConsume
            // 
            this.button_Imprimer_QConsume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Imprimer_QConsume.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button_Imprimer_QConsume.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Imprimer_QConsume.Location = new System.Drawing.Point(569, 506);
            this.button_Imprimer_QConsume.Margin = new System.Windows.Forms.Padding(2);
            this.button_Imprimer_QConsume.Name = "button_Imprimer_QConsume";
            this.button_Imprimer_QConsume.Size = new System.Drawing.Size(192, 25);
            this.button_Imprimer_QConsume.TabIndex = 47;
            this.button_Imprimer_QConsume.Text = "Imprimer vers excel";
            this.button_Imprimer_QConsume.UseVisualStyleBackColor = false;
            this.button_Imprimer_QConsume.Click += new System.EventHandler(this.button_Imprimer_QConsume_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_back.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_back.Location = new System.Drawing.Point(8, 562);
            this.button_back.Margin = new System.Windows.Forms.Padding(2);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(129, 25);
            this.button_back.TabIndex = 46;
            this.button_back.Text = "Retour";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // Button_Rechercher_REF_QConume
            // 
            this.Button_Rechercher_REF_QConume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Rechercher_REF_QConume.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Button_Rechercher_REF_QConume.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Rechercher_REF_QConume.Location = new System.Drawing.Point(522, 468);
            this.Button_Rechercher_REF_QConume.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Rechercher_REF_QConume.Name = "Button_Rechercher_REF_QConume";
            this.Button_Rechercher_REF_QConume.Size = new System.Drawing.Size(286, 25);
            this.Button_Rechercher_REF_QConume.TabIndex = 45;
            this.Button_Rechercher_REF_QConume.Text = "Chercher";
            this.Button_Rechercher_REF_QConume.UseVisualStyleBackColor = false;
            this.Button_Rechercher_REF_QConume.Click += new System.EventHandler(this.Button_Rechercher_REF_QConume_Click);
            // 
            // Label_Entrez_la_référence
            // 
            this.Label_Entrez_la_référence.AutoSize = true;
            this.Label_Entrez_la_référence.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Entrez_la_référence.Location = new System.Drawing.Point(522, 439);
            this.Label_Entrez_la_référence.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Entrez_la_référence.Name = "Label_Entrez_la_référence";
            this.Label_Entrez_la_référence.Size = new System.Drawing.Size(99, 21);
            this.Label_Entrez_la_référence.TabIndex = 43;
            this.Label_Entrez_la_référence.Text = "Entrez le réf :";
            // 
            // Label_Recherche_par_référence
            // 
            this.Label_Recherche_par_référence.AutoSize = true;
            this.Label_Recherche_par_référence.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Label_Recherche_par_référence.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label_Recherche_par_référence.Location = new System.Drawing.Point(539, 406);
            this.Label_Recherche_par_référence.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Recherche_par_référence.Name = "Label_Recherche_par_référence";
            this.Label_Recherche_par_référence.Size = new System.Drawing.Size(255, 30);
            this.Label_Recherche_par_référence.TabIndex = 42;
            this.Label_Recherche_par_référence.Text = "Recherche par référence";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 7);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(222, 23);
            this.dateTimePicker1.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(480, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 21);
            this.label2.TabIndex = 49;
            this.label2.Text = "Tableau Quantité Consumé";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(626, 440);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 23);
            this.comboBox1.TabIndex = 50;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // actualiserBtn
            // 
            this.actualiserBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.actualiserBtn.Location = new System.Drawing.Point(1238, 7);
            this.actualiserBtn.Name = "actualiserBtn";
            this.actualiserBtn.Size = new System.Drawing.Size(75, 23);
            this.actualiserBtn.TabIndex = 51;
            this.actualiserBtn.Text = "Actualiser";
            this.actualiserBtn.UseVisualStyleBackColor = false;
            this.actualiserBtn.Click += new System.EventHandler(this.actualiserBtn_Click);
            // 
            // QConsume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 611);
            this.Controls.Add(this.actualiserBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button_Imprimer_QConsume);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.Button_Rechercher_REF_QConume);
            this.Controls.Add(this.Label_Entrez_la_référence);
            this.Controls.Add(this.Label_Recherche_par_référence);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Text = "QConsumé";
            this.Load += new System.EventHandler(this.QConsume_Load);
            this.Resize += new System.EventHandler(this.QConsume_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Imprimer_QConsume;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button Button_Rechercher_REF_QConume;
        private System.Windows.Forms.Label Label_Entrez_la_référence;
        private System.Windows.Forms.Label Label_Recherche_par_référence;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn IE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button actualiserBtn;
    }
}