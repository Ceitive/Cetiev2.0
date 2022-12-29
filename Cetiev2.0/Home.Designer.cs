
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
            this.saveBtn = new System.Windows.Forms.Button();
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
            this.dataGridView1.Location = new System.Drawing.Point(8, 29);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1326, 278);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Rayonnage
            // 
            this.Rayonnage.HeaderText = "Rayonnage";
            this.Rayonnage.Name = "Rayonnage";
            // 
            // Consummation
            // 
            this.Consummation.HeaderText = "Consummation";
            this.Consummation.Name = "Consummation";
            this.Consummation.ReadOnly = true;
            // 
            // Rest
            // 
            this.Rest.HeaderText = "Rest";
            this.Rest.Name = "Rest";
            this.Rest.ReadOnly = true;
            // 
            // ProjectName
            // 
            this.ProjectName.HeaderText = "Project Name";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 7);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(222, 23);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label_recherche_par_prjt
            // 
            this.label_recherche_par_prjt.AutoSize = true;
            this.label_recherche_par_prjt.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_recherche_par_prjt.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_recherche_par_prjt.Location = new System.Drawing.Point(37, 330);
            this.label_recherche_par_prjt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_recherche_par_prjt.Name = "label_recherche_par_prjt";
            this.label_recherche_par_prjt.Size = new System.Drawing.Size(220, 30);
            this.label_recherche_par_prjt.TabIndex = 14;
            this.label_recherche_par_prjt.Text = "Recherche par projet";
            // 
            // label_information_consommateurs
            // 
            this.label_information_consommateurs.AutoSize = true;
            this.label_information_consommateurs.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_information_consommateurs.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_information_consommateurs.Location = new System.Drawing.Point(783, 310);
            this.label_information_consommateurs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_information_consommateurs.Name = "label_information_consommateurs";
            this.label_information_consommateurs.Size = new System.Drawing.Size(303, 30);
            this.label_information_consommateurs.TabIndex = 27;
            this.label_information_consommateurs.Text = "Informations consommateurs";
            // 
            // label_entrez_REF
            // 
            this.label_entrez_REF.AutoSize = true;
            this.label_entrez_REF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_entrez_REF.Location = new System.Drawing.Point(768, 431);
            this.label_entrez_REF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_entrez_REF.Name = "label_entrez_REF";
            this.label_entrez_REF.Size = new System.Drawing.Size(90, 21);
            this.label_entrez_REF.TabIndex = 28;
            this.label_entrez_REF.Text = "Entrez RÉF :";
            // 
            // label_Nombre_des_pcs
            // 
            this.label_Nombre_des_pcs.AutoSize = true;
            this.label_Nombre_des_pcs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Nombre_des_pcs.Location = new System.Drawing.Point(768, 403);
            this.label_Nombre_des_pcs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Nombre_des_pcs.Name = "label_Nombre_des_pcs";
            this.label_Nombre_des_pcs.Size = new System.Drawing.Size(130, 21);
            this.label_Nombre_des_pcs.TabIndex = 29;
            this.label_Nombre_des_pcs.Text = "Nombre des pcs :";
            // 
            // label_entrez_IE_IU
            // 
            this.label_entrez_IE_IU.AutoSize = true;
            this.label_entrez_IE_IU.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_entrez_IE_IU.Location = new System.Drawing.Point(768, 374);
            this.label_entrez_IE_IU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_entrez_IE_IU.Name = "label_entrez_IE_IU";
            this.label_entrez_IE_IU.Size = new System.Drawing.Size(105, 21);
            this.label_entrez_IE_IU.TabIndex = 30;
            this.label_entrez_IE_IU.Text = "Entrez IE / IU :";
            // 
            // label_entrez_nom_complet
            // 
            this.label_entrez_nom_complet.AutoSize = true;
            this.label_entrez_nom_complet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_entrez_nom_complet.Location = new System.Drawing.Point(768, 346);
            this.label_entrez_nom_complet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_entrez_nom_complet.Name = "label_entrez_nom_complet";
            this.label_entrez_nom_complet.Size = new System.Drawing.Size(156, 21);
            this.label_entrez_nom_complet.TabIndex = 31;
            this.label_entrez_nom_complet.Text = "Entrez nom complet :";
            // 
            // button_Valider
            // 
            this.button_Valider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Valider.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button_Valider.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Valider.Location = new System.Drawing.Point(768, 456);
            this.button_Valider.Margin = new System.Windows.Forms.Padding(2);
            this.button_Valider.Name = "button_Valider";
            this.button_Valider.Size = new System.Drawing.Size(334, 25);
            this.button_Valider.TabIndex = 32;
            this.button_Valider.Text = "Valider";
            this.button_Valider.UseVisualStyleBackColor = false;
            // 
            // button_Quantité_restante_de_piéces
            // 
            this.button_Quantité_restante_de_piéces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Quantité_restante_de_piéces.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button_Quantité_restante_de_piéces.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Quantité_restante_de_piéces.Location = new System.Drawing.Point(768, 485);
            this.button_Quantité_restante_de_piéces.Margin = new System.Windows.Forms.Padding(2);
            this.button_Quantité_restante_de_piéces.Name = "button_Quantité_restante_de_piéces";
            this.button_Quantité_restante_de_piéces.Size = new System.Drawing.Size(169, 85);
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
            this.button_Quantité_de_pièces_consommées.Location = new System.Drawing.Point(945, 485);
            this.button_Quantité_de_pièces_consommées.Margin = new System.Windows.Forms.Padding(2);
            this.button_Quantité_de_pièces_consommées.Name = "button_Quantité_de_pièces_consommées";
            this.button_Quantité_de_pièces_consommées.Size = new System.Drawing.Size(157, 85);
            this.button_Quantité_de_pièces_consommées.TabIndex = 34;
            this.button_Quantité_de_pièces_consommées.Text = "Quantité de pièces consommées";
            this.button_Quantité_de_pièces_consommées.UseVisualStyleBackColor = false;
            this.button_Quantité_de_pièces_consommées.Click += new System.EventHandler(this.button_Quantité_de_pièces_consommées_Click);
            // 
            // textBox_Entrez_REF_pour_cons
            // 
            this.textBox_Entrez_REF_pour_cons.Location = new System.Drawing.Point(945, 434);
            this.textBox_Entrez_REF_pour_cons.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Entrez_REF_pour_cons.Name = "textBox_Entrez_REF_pour_cons";
            this.textBox_Entrez_REF_pour_cons.Size = new System.Drawing.Size(158, 23);
            this.textBox_Entrez_REF_pour_cons.TabIndex = 35;
            // 
            // textBox_Nombre_des_pcs
            // 
            this.textBox_Nombre_des_pcs.Location = new System.Drawing.Point(945, 405);
            this.textBox_Nombre_des_pcs.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Nombre_des_pcs.Name = "textBox_Nombre_des_pcs";
            this.textBox_Nombre_des_pcs.Size = new System.Drawing.Size(158, 23);
            this.textBox_Nombre_des_pcs.TabIndex = 36;
            // 
            // textBox_entrez_IE_IU
            // 
            this.textBox_entrez_IE_IU.Location = new System.Drawing.Point(945, 376);
            this.textBox_entrez_IE_IU.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_entrez_IE_IU.Name = "textBox_entrez_IE_IU";
            this.textBox_entrez_IE_IU.Size = new System.Drawing.Size(158, 23);
            this.textBox_entrez_IE_IU.TabIndex = 37;
            // 
            // textBox_Entrez_nom_complet
            // 
            this.textBox_Entrez_nom_complet.Location = new System.Drawing.Point(945, 347);
            this.textBox_Entrez_nom_complet.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Entrez_nom_complet.Name = "textBox_Entrez_nom_complet";
            this.textBox_Entrez_nom_complet.Size = new System.Drawing.Size(158, 23);
            this.textBox_Entrez_nom_complet.TabIndex = 38;
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_back.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_back.Location = new System.Drawing.Point(8, 567);
            this.button_back.Margin = new System.Windows.Forms.Padding(2);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(129, 25);
            this.button_back.TabIndex = 39;
            this.button_back.Text = "Retour";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // ActualiserBtn
            // 
            this.ActualiserBtn.BackColor = System.Drawing.Color.Lime;
            this.ActualiserBtn.Location = new System.Drawing.Point(1239, 332);
            this.ActualiserBtn.Name = "ActualiserBtn";
            this.ActualiserBtn.Size = new System.Drawing.Size(96, 35);
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
            this.comboBox1.Location = new System.Drawing.Point(83, 376);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 41;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.searchByRef);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.searchByRef);
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(83, 420);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 42;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SearchBtn.Location = new System.Drawing.Point(93, 471);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(102, 42);
            this.SearchBtn.TabIndex = 43;
            this.SearchBtn.Text = "Rechercher";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // Export
            // 
            this.Export.AutoSize = true;
            this.Export.Location = new System.Drawing.Point(482, 330);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(41, 15);
            this.Export.TabIndex = 44;
            this.Export.Text = "Export";
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(1239, 388);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 45;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 630);
            this.Controls.Add(this.saveBtn);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button saveBtn;
    }
}