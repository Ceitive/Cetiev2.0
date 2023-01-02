
namespace Cetiev2._0
{
    partial class Home
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
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rayonnage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consummation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label_recherche_par_prjt = new System.Windows.Forms.Label();
            this.label_information_consommateurs = new System.Windows.Forms.Label();
            this.label_entrez_REF = new System.Windows.Forms.Label();
            this.label_Nombre_des_pcs = new System.Windows.Forms.Label();
            this.label_entrez_IE_IU = new System.Windows.Forms.Label();
            this.label_entrez_nom_complet = new System.Windows.Forms.Label();
            this.button_Valider = new System.Windows.Forms.Button();
            this.button_Quantité_restante_de_piéces = new System.Windows.Forms.Button();
            this.button_Quantité_de_pièces_consommées = new System.Windows.Forms.Button();
            this.textBox_Entrez_REF_pour_cons = new System.Windows.Forms.TextBox();
            this.textBox_Nombre_des_pcs = new System.Windows.Forms.TextBox();
            this.textBox_entrez_IE_IU = new System.Windows.Forms.TextBox();
            this.textBox_Entrez_nom_complet = new System.Windows.Forms.TextBox();
            this.button_back = new System.Windows.Forms.Button();
            this.ActualiserBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Reference,
            this.Description,
            this.Quantity,
            this.Rayonnage,
            this.Consummation,
            this.Rest,
            this.ProjectName});
            this.dataGridView1.Location = new System.Drawing.Point(11, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1894, 463);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 8;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 150;
            // 
            // Rayonnage
            // 
            this.Rayonnage.HeaderText = "Rayonnage";
            this.Rayonnage.MinimumWidth = 8;
            this.Rayonnage.Name = "Rayonnage";
            this.Rayonnage.Width = 150;
            // 
            // Consummation
            // 
            this.Consummation.HeaderText = "Consummation";
            this.Consummation.MinimumWidth = 8;
            this.Consummation.Name = "Consummation";
            this.Consummation.ReadOnly = true;
            this.Consummation.Width = 150;
            // 
            // Rest
            // 
            this.Rest.HeaderText = "Rest";
            this.Rest.MinimumWidth = 8;
            this.Rest.Name = "Rest";
            this.Rest.ReadOnly = true;
            this.Rest.Width = 150;
            // 
            // ProjectName
            // 
            this.ProjectName.HeaderText = "Project Name";
            this.ProjectName.MinimumWidth = 8;
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            this.ProjectName.Width = 150;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(315, 31);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label_recherche_par_prjt
            // 
            this.label_recherche_par_prjt.AutoSize = true;
            this.label_recherche_par_prjt.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_recherche_par_prjt.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_recherche_par_prjt.Location = new System.Drawing.Point(111, 627);
            this.label_recherche_par_prjt.Name = "label_recherche_par_prjt";
            this.label_recherche_par_prjt.Size = new System.Drawing.Size(313, 45);
            this.label_recherche_par_prjt.TabIndex = 14;
            this.label_recherche_par_prjt.Text = "Recherche par projet";
            // 
            // label_information_consommateurs
            // 
            this.label_information_consommateurs.AutoSize = true;
            this.label_information_consommateurs.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_information_consommateurs.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_information_consommateurs.Location = new System.Drawing.Point(1119, 517);
            this.label_information_consommateurs.Name = "label_information_consommateurs";
            this.label_information_consommateurs.Size = new System.Drawing.Size(441, 45);
            this.label_information_consommateurs.TabIndex = 27;
            this.label_information_consommateurs.Text = "Informations consommateurs";
            // 
            // label_entrez_REF
            // 
            this.label_entrez_REF.AutoSize = true;
            this.label_entrez_REF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_entrez_REF.Location = new System.Drawing.Point(1097, 718);
            this.label_entrez_REF.Name = "label_entrez_REF";
            this.label_entrez_REF.Size = new System.Drawing.Size(137, 32);
            this.label_entrez_REF.TabIndex = 28;
            this.label_entrez_REF.Text = "Entrez RÉF :";
            // 
            // label_Nombre_des_pcs
            // 
            this.label_Nombre_des_pcs.AutoSize = true;
            this.label_Nombre_des_pcs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Nombre_des_pcs.Location = new System.Drawing.Point(1097, 672);
            this.label_Nombre_des_pcs.Name = "label_Nombre_des_pcs";
            this.label_Nombre_des_pcs.Size = new System.Drawing.Size(200, 32);
            this.label_Nombre_des_pcs.TabIndex = 29;
            this.label_Nombre_des_pcs.Text = "Nombre des pcs :";
            // 
            // label_entrez_IE_IU
            // 
            this.label_entrez_IE_IU.AutoSize = true;
            this.label_entrez_IE_IU.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_entrez_IE_IU.Location = new System.Drawing.Point(1097, 623);
            this.label_entrez_IE_IU.Name = "label_entrez_IE_IU";
            this.label_entrez_IE_IU.Size = new System.Drawing.Size(162, 32);
            this.label_entrez_IE_IU.TabIndex = 30;
            this.label_entrez_IE_IU.Text = "Entrez IE / IU :";
            // 
            // label_entrez_nom_complet
            // 
            this.label_entrez_nom_complet.AutoSize = true;
            this.label_entrez_nom_complet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_entrez_nom_complet.Location = new System.Drawing.Point(1097, 577);
            this.label_entrez_nom_complet.Name = "label_entrez_nom_complet";
            this.label_entrez_nom_complet.Size = new System.Drawing.Size(242, 32);
            this.label_entrez_nom_complet.TabIndex = 31;
            this.label_entrez_nom_complet.Text = "Entrez nom complet :";
            // 
            // button_Valider
            // 
            this.button_Valider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Valider.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button_Valider.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Valider.Location = new System.Drawing.Point(1097, 760);
            this.button_Valider.Name = "button_Valider";
            this.button_Valider.Size = new System.Drawing.Size(477, 42);
            this.button_Valider.TabIndex = 32;
            this.button_Valider.Text = "Valider";
            this.button_Valider.UseVisualStyleBackColor = false;
            // 
            // button_Quantité_restante_de_piéces
            // 
            this.button_Quantité_restante_de_piéces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Quantité_restante_de_piéces.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button_Quantité_restante_de_piéces.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Quantité_restante_de_piéces.Location = new System.Drawing.Point(1097, 808);
            this.button_Quantité_restante_de_piéces.Name = "button_Quantité_restante_de_piéces";
            this.button_Quantité_restante_de_piéces.Size = new System.Drawing.Size(241, 142);
            this.button_Quantité_restante_de_piéces.TabIndex = 33;
            this.button_Quantité_restante_de_piéces.Text = "Quantité restante de pièces";
            this.button_Quantité_restante_de_piéces.UseVisualStyleBackColor = false;
            this.button_Quantité_restante_de_piéces.Click += new System.EventHandler(this.button_Quantité_restante_de_piéces_Click);
            // 
            // button_Quantité_de_pièces_consommées
            // 
            this.button_Quantité_de_pièces_consommées.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Quantité_de_pièces_consommées.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button_Quantité_de_pièces_consommées.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Quantité_de_pièces_consommées.Location = new System.Drawing.Point(1350, 808);
            this.button_Quantité_de_pièces_consommées.Name = "button_Quantité_de_pièces_consommées";
            this.button_Quantité_de_pièces_consommées.Size = new System.Drawing.Size(224, 142);
            this.button_Quantité_de_pièces_consommées.TabIndex = 34;
            this.button_Quantité_de_pièces_consommées.Text = "Quantité de pièces consommées";
            this.button_Quantité_de_pièces_consommées.UseVisualStyleBackColor = false;
            this.button_Quantité_de_pièces_consommées.Click += new System.EventHandler(this.button_Quantité_de_pièces_consommées_Click);
            // 
            // textBox_Entrez_REF_pour_cons
            // 
            this.textBox_Entrez_REF_pour_cons.Location = new System.Drawing.Point(1350, 723);
            this.textBox_Entrez_REF_pour_cons.Name = "textBox_Entrez_REF_pour_cons";
            this.textBox_Entrez_REF_pour_cons.Size = new System.Drawing.Size(224, 31);
            this.textBox_Entrez_REF_pour_cons.TabIndex = 35;
            // 
            // textBox_Nombre_des_pcs
            // 
            this.textBox_Nombre_des_pcs.Location = new System.Drawing.Point(1350, 675);
            this.textBox_Nombre_des_pcs.Name = "textBox_Nombre_des_pcs";
            this.textBox_Nombre_des_pcs.Size = new System.Drawing.Size(224, 31);
            this.textBox_Nombre_des_pcs.TabIndex = 36;
            // 
            // textBox_entrez_IE_IU
            // 
            this.textBox_entrez_IE_IU.Location = new System.Drawing.Point(1350, 627);
            this.textBox_entrez_IE_IU.Name = "textBox_entrez_IE_IU";
            this.textBox_entrez_IE_IU.Size = new System.Drawing.Size(224, 31);
            this.textBox_entrez_IE_IU.TabIndex = 37;
            // 
            // textBox_Entrez_nom_complet
            // 
            this.textBox_Entrez_nom_complet.Location = new System.Drawing.Point(1350, 578);
            this.textBox_Entrez_nom_complet.Name = "textBox_Entrez_nom_complet";
            this.textBox_Entrez_nom_complet.Size = new System.Drawing.Size(224, 31);
            this.textBox_Entrez_nom_complet.TabIndex = 38;
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_back.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_back.Location = new System.Drawing.Point(11, 943);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(184, 42);
            this.button_back.TabIndex = 39;
            this.button_back.Text = "Retour";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // ActualiserBtn
            // 
            this.ActualiserBtn.BackColor = System.Drawing.Color.Lime;
            this.ActualiserBtn.Location = new System.Drawing.Point(1748, 551);
            this.ActualiserBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ActualiserBtn.Name = "ActualiserBtn";
            this.ActualiserBtn.Size = new System.Drawing.Size(131, 58);
            this.ActualiserBtn.TabIndex = 40;
            this.ActualiserBtn.Text = "Synchroniser";
            this.ActualiserBtn.UseVisualStyleBackColor = false;
            this.ActualiserBtn.Click += new System.EventHandler(this.ActualiserBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ref",
            "Project"});
            this.comboBox1.Location = new System.Drawing.Point(171, 706);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 33);
            this.comboBox1.TabIndex = 41;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.searchByRef);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.searchByRef);
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(529, 706);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(171, 33);
            this.comboBox2.TabIndex = 42;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchBtn.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.SearchBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SearchBtn.Location = new System.Drawing.Point(171, 785);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(529, 51);
            this.SearchBtn.TabIndex = 43;
            this.SearchBtn.Text = "Rechercher";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // Export
            // 
            this.Export.AutoSize = true;
            this.Export.Location = new System.Drawing.Point(803, 537);
            this.Export.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(63, 25);
            this.Export.TabIndex = 44;
            this.Export.Text = "Export";
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(480, 627);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 45);
            this.label1.TabIndex = 45;
            this.label1.Text = "Recherche par RÉF";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ActualiserBtn);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.textBox_Entrez_nom_complet);
            this.Controls.Add(this.textBox_entrez_IE_IU);
            this.Controls.Add(this.textBox_Nombre_des_pcs);
            this.Controls.Add(this.textBox_Entrez_REF_pour_cons);
            this.Controls.Add(this.button_Quantité_de_pièces_consommées);
            this.Controls.Add(this.button_Quantité_restante_de_piéces);
            this.Controls.Add(this.button_Valider);
            this.Controls.Add(this.label_entrez_nom_complet);
            this.Controls.Add(this.label_entrez_IE_IU);
            this.Controls.Add(this.label_Nombre_des_pcs);
            this.Controls.Add(this.label_entrez_REF);
            this.Controls.Add(this.label_information_consommateurs);
            this.Controls.Add(this.label_recherche_par_prjt);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_recherche_par_prjt;
        private System.Windows.Forms.Label label_information_consommateurs;
        private System.Windows.Forms.Label label_entrez_REF;
        private System.Windows.Forms.Label label_Nombre_des_pcs;
        private System.Windows.Forms.Label label_entrez_IE_IU;
        private System.Windows.Forms.Label label_entrez_nom_complet;
        private System.Windows.Forms.Button button_Valider;
        private System.Windows.Forms.Button button_Quantité_restante_de_piéces;
        private System.Windows.Forms.Button button_Quantité_de_pièces_consommées;
        private System.Windows.Forms.TextBox textBox_Entrez_REF_pour_cons;
        private System.Windows.Forms.TextBox textBox_Nombre_des_pcs;
        private System.Windows.Forms.TextBox textBox_entrez_IE_IU;
        private System.Windows.Forms.TextBox textBox_Entrez_nom_complet;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button ActualiserBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rayonnage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consummation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rest;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button SearchBtn;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Export;
        private System.Windows.Forms.Label label1;
    }
}