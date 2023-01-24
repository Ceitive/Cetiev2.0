
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
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Reference,
            this.Description,
            this.Consume,
            this.Name,
            this.IE,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(11, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1901, 608);
            this.dataGridView1.TabIndex = 7;
            // 
            // Reference
            // 
            this.Reference.HeaderText = "Référence PSA";
            this.Reference.MinimumWidth = 8;
            this.Reference.Name = "Reference";
            this.Reference.ReadOnly = true;
            this.Reference.Width = 150;
            // 
            // Description
            // 
            this.Description.HeaderText = "Déscription";
            this.Description.MinimumWidth = 8;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 150;
            // 
            // Consume
            // 
            this.Consume.HeaderText = "La Quantité Consommée";
            this.Consume.MinimumWidth = 8;
            this.Consume.Name = "Consume";
            this.Consume.ReadOnly = true;
            this.Consume.Width = 150;
            // 
            // Name
            // 
            this.Name.HeaderText = "Le Nom de Consommateur";
            this.Name.MinimumWidth = 8;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 150;
            // 
            // IE
            // 
            this.IE.HeaderText = "IE / IU de Consommateur";
            this.IE.MinimumWidth = 8;
            this.IE.Name = "IE";
            this.IE.ReadOnly = true;
            this.IE.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Le Nom de projet";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.Red;
            this.button_back.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_back.Location = new System.Drawing.Point(11, 937);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(184, 42);
            this.button_back.TabIndex = 46;
            this.button_back.Text = "Retour";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // Button_Rechercher_REF_QConume
            // 
            this.Button_Rechercher_REF_QConume.BackColor = System.Drawing.Color.Teal;
            this.Button_Rechercher_REF_QConume.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Button_Rechercher_REF_QConume.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Rechercher_REF_QConume.Location = new System.Drawing.Point(746, 801);
            this.Button_Rechercher_REF_QConume.Name = "Button_Rechercher_REF_QConume";
            this.Button_Rechercher_REF_QConume.Size = new System.Drawing.Size(409, 47);
            this.Button_Rechercher_REF_QConume.TabIndex = 45;
            this.Button_Rechercher_REF_QConume.Text = "Chercher";
            this.Button_Rechercher_REF_QConume.UseVisualStyleBackColor = false;
            this.Button_Rechercher_REF_QConume.Click += new System.EventHandler(this.Button_Rechercher_REF_QConume_Click);
            // 
            // Label_Entrez_la_référence
            // 
            this.Label_Entrez_la_référence.AutoSize = true;
            this.Label_Entrez_la_référence.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Entrez_la_référence.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label_Entrez_la_référence.Location = new System.Drawing.Point(746, 751);
            this.Label_Entrez_la_référence.Name = "Label_Entrez_la_référence";
            this.Label_Entrez_la_référence.Size = new System.Drawing.Size(177, 27);
            this.Label_Entrez_la_référence.TabIndex = 43;
            this.Label_Entrez_la_référence.Text = "Entrez le réf :";
            // 
            // Label_Recherche_par_référence
            // 
            this.Label_Recherche_par_référence.AutoSize = true;
            this.Label_Recherche_par_référence.Font = new System.Drawing.Font("Cooper Black", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Label_Recherche_par_référence.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label_Recherche_par_référence.Location = new System.Drawing.Point(746, 692);
            this.Label_Recherche_par_référence.Name = "Label_Recherche_par_référence";
            this.Label_Recherche_par_référence.Size = new System.Drawing.Size(412, 36);
            this.Label_Recherche_par_référence.TabIndex = 42;
            this.Label_Recherche_par_référence.Text = "Recherche par référence";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(315, 31);
            this.dateTimePicker1.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(725, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(451, 36);
            this.label2.TabIndex = 49;
            this.label2.Text = "Tableau Quantité Consumé";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(917, 751);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 33);
            this.comboBox1.TabIndex = 50;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // actualiserBtn
            // 
            this.actualiserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.actualiserBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.actualiserBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.actualiserBtn.Location = new System.Drawing.Point(1795, 14);
            this.actualiserBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.actualiserBtn.Name = "actualiserBtn";
            this.actualiserBtn.Size = new System.Drawing.Size(116, 38);
            this.actualiserBtn.TabIndex = 51;
            this.actualiserBtn.Text = "Actualiser";
            this.actualiserBtn.UseVisualStyleBackColor = false;
            this.actualiserBtn.Click += new System.EventHandler(this.actualiserBtn_Click);
            // 
            // QConsume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1924, 1018);
            this.Controls.Add(this.actualiserBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.Button_Rechercher_REF_QConume);
            this.Controls.Add(this.Label_Entrez_la_référence);
            this.Controls.Add(this.Label_Recherche_par_référence);
            this.Controls.Add(this.dataGridView1);
            
            this.Text = "QConsumé";
            this.Load += new System.EventHandler(this.QConsume_Load);
            this.Resize += new System.EventHandler(this.QConsume_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button Button_Rechercher_REF_QConume;
        private System.Windows.Forms.Label Label_Entrez_la_référence;
        private System.Windows.Forms.Label Label_Recherche_par_référence;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button actualiserBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn IE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}