
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Label_Recherche_par_référence = new System.Windows.Forms.Label();
            this.Label_Entrez_la_référence = new System.Windows.Forms.Label();
            this.TextBox_Entrez_REF = new System.Windows.Forms.TextBox();
            this.Button_Rechercher_REF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_recherche_par_prjt = new System.Windows.Forms.Label();
            this.label_Entrez_le_prjt = new System.Windows.Forms.Label();
            this.textBox_Entrez_le_prjt = new System.Windows.Forms.TextBox();
            this.button_chercher_prjt = new System.Windows.Forms.Button();
            this.Ajouter_Modifier_un_rayonnage = new System.Windows.Forms.Label();
            this.Ajouter_une_rayonnage = new System.Windows.Forms.Label();
            this.textBox_Ajouter_rayonnage = new System.Windows.Forms.TextBox();
            this.button_Ajouter_rayonnage = new System.Windows.Forms.Button();
            this.Button_modifier_rayonnage = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 29);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1306, 290);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(29, 7);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(222, 23);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // Label_Recherche_par_référence
            // 
            this.Label_Recherche_par_référence.AutoSize = true;
            this.Label_Recherche_par_référence.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Label_Recherche_par_référence.Location = new System.Drawing.Point(85, 345);
            this.Label_Recherche_par_référence.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Recherche_par_référence.Name = "Label_Recherche_par_référence";
            this.Label_Recherche_par_référence.Size = new System.Drawing.Size(247, 30);
            this.Label_Recherche_par_référence.TabIndex = 9;
            this.Label_Recherche_par_référence.Text = "Recherche par référence";
            this.Label_Recherche_par_référence.Click += new System.EventHandler(this.Label_Recherche_par_référence_Click);
            // 
            // Label_Entrez_la_référence
            // 
            this.Label_Entrez_la_référence.AutoSize = true;
            this.Label_Entrez_la_référence.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Entrez_la_référence.Location = new System.Drawing.Point(57, 393);
            this.Label_Entrez_la_référence.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Entrez_la_référence.Name = "Label_Entrez_la_référence";
            this.Label_Entrez_la_référence.Size = new System.Drawing.Size(139, 20);
            this.Label_Entrez_la_référence.TabIndex = 10;
            this.Label_Entrez_la_référence.Text = "Entrez la référence :";
            this.Label_Entrez_la_référence.Click += new System.EventHandler(this.Label_Entrez_la_référence_Click);
            // 
            // TextBox_Entrez_REF
            // 
            this.TextBox_Entrez_REF.Location = new System.Drawing.Point(204, 394);
            this.TextBox_Entrez_REF.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_Entrez_REF.Name = "TextBox_Entrez_REF";
            this.TextBox_Entrez_REF.Size = new System.Drawing.Size(174, 23);
            this.TextBox_Entrez_REF.TabIndex = 11;
            // 
            // Button_Rechercher_REF
            // 
            this.Button_Rechercher_REF.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Button_Rechercher_REF.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Button_Rechercher_REF.Location = new System.Drawing.Point(57, 427);
            this.Button_Rechercher_REF.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Rechercher_REF.Name = "Button_Rechercher_REF";
            this.Button_Rechercher_REF.Size = new System.Drawing.Size(321, 25);
            this.Button_Rechercher_REF.TabIndex = 12;
            this.Button_Rechercher_REF.Text = "Chercher";
            this.Button_Rechercher_REF.UseVisualStyleBackColor = false;
            this.Button_Rechercher_REF.Click += new System.EventHandler(this.Button_Rechercher_REF_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 454);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "___________________________________";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_recherche_par_prjt
            // 
            this.label_recherche_par_prjt.AutoSize = true;
            this.label_recherche_par_prjt.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_recherche_par_prjt.Location = new System.Drawing.Point(85, 488);
            this.label_recherche_par_prjt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_recherche_par_prjt.Name = "label_recherche_par_prjt";
            this.label_recherche_par_prjt.Size = new System.Drawing.Size(214, 30);
            this.label_recherche_par_prjt.TabIndex = 14;
            this.label_recherche_par_prjt.Text = "Recherche par projet";
            // 
            // label_Entrez_le_prjt
            // 
            this.label_Entrez_le_prjt.AutoSize = true;
            this.label_Entrez_le_prjt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Entrez_le_prjt.Location = new System.Drawing.Point(57, 534);
            this.label_Entrez_le_prjt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Entrez_le_prjt.Name = "label_Entrez_le_prjt";
            this.label_Entrez_le_prjt.Size = new System.Drawing.Size(117, 20);
            this.label_Entrez_le_prjt.TabIndex = 15;
            this.label_Entrez_le_prjt.Text = "Entrez le projet :";
            // 
            // textBox_Entrez_le_prjt
            // 
            this.textBox_Entrez_le_prjt.Location = new System.Drawing.Point(204, 535);
            this.textBox_Entrez_le_prjt.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Entrez_le_prjt.Name = "textBox_Entrez_le_prjt";
            this.textBox_Entrez_le_prjt.Size = new System.Drawing.Size(174, 23);
            this.textBox_Entrez_le_prjt.TabIndex = 16;
            // 
            // button_chercher_prjt
            // 
            this.button_chercher_prjt.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button_chercher_prjt.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button_chercher_prjt.Location = new System.Drawing.Point(57, 578);
            this.button_chercher_prjt.Margin = new System.Windows.Forms.Padding(2);
            this.button_chercher_prjt.Name = "button_chercher_prjt";
            this.button_chercher_prjt.Size = new System.Drawing.Size(321, 25);
            this.button_chercher_prjt.TabIndex = 17;
            this.button_chercher_prjt.Text = "Chercher";
            this.button_chercher_prjt.UseVisualStyleBackColor = false;
            // 
            // Ajouter_Modifier_un_rayonnage
            // 
            this.Ajouter_Modifier_un_rayonnage.AutoSize = true;
            this.Ajouter_Modifier_un_rayonnage.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Ajouter_Modifier_un_rayonnage.Location = new System.Drawing.Point(544, 414);
            this.Ajouter_Modifier_un_rayonnage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Ajouter_Modifier_un_rayonnage.Name = "Ajouter_Modifier_un_rayonnage";
            this.Ajouter_Modifier_un_rayonnage.Size = new System.Drawing.Size(344, 30);
            this.Ajouter_Modifier_un_rayonnage.TabIndex = 18;
            this.Ajouter_Modifier_un_rayonnage.Text = "Ajouter / Modifier Un Rayonnage ";
            this.Ajouter_Modifier_un_rayonnage.Click += new System.EventHandler(this.label4_Click);
            // 
            // Ajouter_une_rayonnage
            // 
            this.Ajouter_une_rayonnage.AutoSize = true;
            this.Ajouter_une_rayonnage.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ajouter_une_rayonnage.Location = new System.Drawing.Point(559, 461);
            this.Ajouter_une_rayonnage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Ajouter_une_rayonnage.Name = "Ajouter_une_rayonnage";
            this.Ajouter_une_rayonnage.Size = new System.Drawing.Size(139, 20);
            this.Ajouter_une_rayonnage.TabIndex = 19;
            this.Ajouter_une_rayonnage.Text = "Ajouter rayonnage :";
            // 
            // textBox_Ajouter_rayonnage
            // 
            this.textBox_Ajouter_rayonnage.Location = new System.Drawing.Point(708, 461);
            this.textBox_Ajouter_rayonnage.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Ajouter_rayonnage.Name = "textBox_Ajouter_rayonnage";
            this.textBox_Ajouter_rayonnage.Size = new System.Drawing.Size(158, 23);
            this.textBox_Ajouter_rayonnage.TabIndex = 20;
            // 
            // button_Ajouter_rayonnage
            // 
            this.button_Ajouter_rayonnage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button_Ajouter_rayonnage.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button_Ajouter_rayonnage.Location = new System.Drawing.Point(559, 496);
            this.button_Ajouter_rayonnage.Margin = new System.Windows.Forms.Padding(2);
            this.button_Ajouter_rayonnage.Name = "button_Ajouter_rayonnage";
            this.button_Ajouter_rayonnage.Size = new System.Drawing.Size(144, 25);
            this.button_Ajouter_rayonnage.TabIndex = 21;
            this.button_Ajouter_rayonnage.Text = "Ajouter";
            this.button_Ajouter_rayonnage.UseVisualStyleBackColor = false;
            this.button_Ajouter_rayonnage.Click += new System.EventHandler(this.button2_Click);
            // 
            // Button_modifier_rayonnage
            // 
            this.Button_modifier_rayonnage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Button_modifier_rayonnage.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Button_modifier_rayonnage.Location = new System.Drawing.Point(721, 496);
            this.Button_modifier_rayonnage.Margin = new System.Windows.Forms.Padding(2);
            this.Button_modifier_rayonnage.Name = "Button_modifier_rayonnage";
            this.Button_modifier_rayonnage.Size = new System.Drawing.Size(144, 25);
            this.Button_modifier_rayonnage.TabIndex = 22;
            this.Button_modifier_rayonnage.Text = "Modifier";
            this.Button_modifier_rayonnage.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(551, 523);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(328, 30);
            this.label6.TabIndex = 23;
            this.label6.Text = "___________________________________";
            // 
            // label_information_consommateurs
            // 
            this.label_information_consommateurs.AutoSize = true;
            this.label_information_consommateurs.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_information_consommateurs.Location = new System.Drawing.Point(1036, 345);
            this.label_information_consommateurs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_information_consommateurs.Name = "label_information_consommateurs";
            this.label_information_consommateurs.Size = new System.Drawing.Size(299, 30);
            this.label_information_consommateurs.TabIndex = 27;
            this.label_information_consommateurs.Text = "Informations consommateurs";
            // 
            // label_entrez_REF
            // 
            this.label_entrez_REF.AutoSize = true;
            this.label_entrez_REF.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_entrez_REF.Location = new System.Drawing.Point(1036, 473);
            this.label_entrez_REF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_entrez_REF.Name = "label_entrez_REF";
            this.label_entrez_REF.Size = new System.Drawing.Size(85, 20);
            this.label_entrez_REF.TabIndex = 28;
            this.label_entrez_REF.Text = "Entrez REF :";
            // 
            // label_Nombre_des_pcs
            // 
            this.label_Nombre_des_pcs.AutoSize = true;
            this.label_Nombre_des_pcs.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Nombre_des_pcs.Location = new System.Drawing.Point(1036, 443);
            this.label_Nombre_des_pcs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Nombre_des_pcs.Name = "label_Nombre_des_pcs";
            this.label_Nombre_des_pcs.Size = new System.Drawing.Size(124, 20);
            this.label_Nombre_des_pcs.TabIndex = 29;
            this.label_Nombre_des_pcs.Text = "Nombre des pcs :";
            // 
            // label_entrez_IE_IU
            // 
            this.label_entrez_IE_IU.AutoSize = true;
            this.label_entrez_IE_IU.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_entrez_IE_IU.Location = new System.Drawing.Point(1036, 414);
            this.label_entrez_IE_IU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_entrez_IE_IU.Name = "label_entrez_IE_IU";
            this.label_entrez_IE_IU.Size = new System.Drawing.Size(101, 20);
            this.label_entrez_IE_IU.TabIndex = 30;
            this.label_entrez_IE_IU.Text = "Entrez IE / IU :";
            // 
            // label_entrez_nom_complet
            // 
            this.label_entrez_nom_complet.AutoSize = true;
            this.label_entrez_nom_complet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_entrez_nom_complet.Location = new System.Drawing.Point(1036, 386);
            this.label_entrez_nom_complet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_entrez_nom_complet.Name = "label_entrez_nom_complet";
            this.label_entrez_nom_complet.Size = new System.Drawing.Size(150, 20);
            this.label_entrez_nom_complet.TabIndex = 31;
            this.label_entrez_nom_complet.Text = "Entrez nom complet :";
            // 
            // button_Valider
            // 
            this.button_Valider.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button_Valider.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button_Valider.Location = new System.Drawing.Point(1036, 505);
            this.button_Valider.Margin = new System.Windows.Forms.Padding(2);
            this.button_Valider.Name = "button_Valider";
            this.button_Valider.Size = new System.Drawing.Size(321, 25);
            this.button_Valider.TabIndex = 32;
            this.button_Valider.Text = "Valider";
            this.button_Valider.UseVisualStyleBackColor = false;
            // 
            // button_Quantité_restante_de_piéces
            // 
            this.button_Quantité_restante_de_piéces.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button_Quantité_restante_de_piéces.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button_Quantité_restante_de_piéces.Location = new System.Drawing.Point(1036, 536);
            this.button_Quantité_restante_de_piéces.Margin = new System.Windows.Forms.Padding(2);
            this.button_Quantité_restante_de_piéces.Name = "button_Quantité_restante_de_piéces";
            this.button_Quantité_restante_de_piéces.Size = new System.Drawing.Size(157, 67);
            this.button_Quantité_restante_de_piéces.TabIndex = 33;
            this.button_Quantité_restante_de_piéces.Text = "Quantité restante de pièces";
            this.button_Quantité_restante_de_piéces.UseVisualStyleBackColor = false;
            // 
            // button_Quantité_de_pièces_consommées
            // 
            this.button_Quantité_de_pièces_consommées.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button_Quantité_de_pièces_consommées.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button_Quantité_de_pièces_consommées.Location = new System.Drawing.Point(1213, 536);
            this.button_Quantité_de_pièces_consommées.Margin = new System.Windows.Forms.Padding(2);
            this.button_Quantité_de_pièces_consommées.Name = "button_Quantité_de_pièces_consommées";
            this.button_Quantité_de_pièces_consommées.Size = new System.Drawing.Size(144, 67);
            this.button_Quantité_de_pièces_consommées.TabIndex = 34;
            this.button_Quantité_de_pièces_consommées.Text = "Quantité de pièces consommées";
            this.button_Quantité_de_pièces_consommées.UseVisualStyleBackColor = false;
            // 
            // textBox_Entrez_REF_pour_cons
            // 
            this.textBox_Entrez_REF_pour_cons.Location = new System.Drawing.Point(1188, 473);
            this.textBox_Entrez_REF_pour_cons.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Entrez_REF_pour_cons.Name = "textBox_Entrez_REF_pour_cons";
            this.textBox_Entrez_REF_pour_cons.Size = new System.Drawing.Size(158, 23);
            this.textBox_Entrez_REF_pour_cons.TabIndex = 35;
            // 
            // textBox_Nombre_des_pcs
            // 
            this.textBox_Nombre_des_pcs.Location = new System.Drawing.Point(1188, 444);
            this.textBox_Nombre_des_pcs.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Nombre_des_pcs.Name = "textBox_Nombre_des_pcs";
            this.textBox_Nombre_des_pcs.Size = new System.Drawing.Size(158, 23);
            this.textBox_Nombre_des_pcs.TabIndex = 36;
            // 
            // textBox_entrez_IE_IU
            // 
            this.textBox_entrez_IE_IU.Location = new System.Drawing.Point(1188, 415);
            this.textBox_entrez_IE_IU.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_entrez_IE_IU.Name = "textBox_entrez_IE_IU";
            this.textBox_entrez_IE_IU.Size = new System.Drawing.Size(158, 23);
            this.textBox_entrez_IE_IU.TabIndex = 37;
            // 
            // textBox_Entrez_nom_complet
            // 
            this.textBox_Entrez_nom_complet.Location = new System.Drawing.Point(1188, 387);
            this.textBox_Entrez_nom_complet.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Entrez_nom_complet.Name = "textBox_Entrez_nom_complet";
            this.textBox_Entrez_nom_complet.Size = new System.Drawing.Size(158, 23);
            this.textBox_Entrez_nom_complet.TabIndex = 38;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 660);
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
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Button_modifier_rayonnage);
            this.Controls.Add(this.button_Ajouter_rayonnage);
            this.Controls.Add(this.textBox_Ajouter_rayonnage);
            this.Controls.Add(this.Ajouter_une_rayonnage);
            this.Controls.Add(this.Ajouter_Modifier_un_rayonnage);
            this.Controls.Add(this.button_chercher_prjt);
            this.Controls.Add(this.textBox_Entrez_le_prjt);
            this.Controls.Add(this.label_Entrez_le_prjt);
            this.Controls.Add(this.label_recherche_par_prjt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Rechercher_REF);
            this.Controls.Add(this.TextBox_Entrez_REF);
            this.Controls.Add(this.Label_Entrez_la_référence);
            this.Controls.Add(this.Label_Recherche_par_référence);
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Label_Recherche_par_référence;
        private System.Windows.Forms.Label Label_Entrez_la_référence;
        private System.Windows.Forms.TextBox TextBox_Entrez_REF;
        private System.Windows.Forms.Button Button_Rechercher_REF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_recherche_par_prjt;
        private System.Windows.Forms.Label label_Entrez_le_prjt;
        private System.Windows.Forms.TextBox textBox_Entrez_le_prjt;
        private System.Windows.Forms.Button button_chercher_prjt;
        private System.Windows.Forms.Label Ajouter_Modifier_un_rayonnage;
        private System.Windows.Forms.Label Ajouter_une_rayonnage;
        private System.Windows.Forms.TextBox textBox_Ajouter_rayonnage;
        private System.Windows.Forms.Button button_Ajouter_rayonnage;
        private System.Windows.Forms.Button Button_modifier_rayonnage;
        private System.Windows.Forms.Label label6;
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
    }
}