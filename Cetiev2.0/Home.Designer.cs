
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
            this.Button_browse = new System.Windows.Forms.Button();
            this.Button_Upload = new System.Windows.Forms.Button();
            this.Button_Clean = new System.Windows.Forms.Button();
            this.textBox_file_path = new System.Windows.Forms.TextBox();
            this.label_File_path = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Titre_de_projet = new System.Windows.Forms.Label();
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
            this.label_Ajouter_et_nettoyer_un_prjt = new System.Windows.Forms.Label();
            this.label_entrez_nom_de_prjt = new System.Windows.Forms.Label();
            this.textBox_entrez_nom_de_prjt = new System.Windows.Forms.TextBox();
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
            // Button_browse
            // 
            this.Button_browse.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Button_browse.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Button_browse.Location = new System.Drawing.Point(716, 975);
            this.Button_browse.Name = "Button_browse";
            this.Button_browse.Size = new System.Drawing.Size(133, 42);
            this.Button_browse.TabIndex = 0;
            this.Button_browse.Text = "Browse";
            this.Button_browse.UseVisualStyleBackColor = false;
            this.Button_browse.Click += new System.EventHandler(this.button1_Click);
            // 
            // Button_Upload
            // 
            this.Button_Upload.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Button_Upload.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Button_Upload.Location = new System.Drawing.Point(876, 975);
            this.Button_Upload.Name = "Button_Upload";
            this.Button_Upload.Size = new System.Drawing.Size(129, 42);
            this.Button_Upload.TabIndex = 1;
            this.Button_Upload.Text = "Upload";
            this.Button_Upload.UseVisualStyleBackColor = false;
            // 
            // Button_Clean
            // 
            this.Button_Clean.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Button_Clean.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Button_Clean.Location = new System.Drawing.Point(1031, 975);
            this.Button_Clean.Name = "Button_Clean";
            this.Button_Clean.Size = new System.Drawing.Size(121, 42);
            this.Button_Clean.TabIndex = 2;
            this.Button_Clean.Text = "Clean";
            this.Button_Clean.UseVisualStyleBackColor = false;
            // 
            // textBox_file_path
            // 
            this.textBox_file_path.Location = new System.Drawing.Point(843, 897);
            this.textBox_file_path.Name = "textBox_file_path";
            this.textBox_file_path.Size = new System.Drawing.Size(310, 31);
            this.textBox_file_path.TabIndex = 3;
            // 
            // label_File_path
            // 
            this.label_File_path.AutoSize = true;
            this.label_File_path.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_File_path.Location = new System.Drawing.Point(716, 897);
            this.label_File_path.Name = "label_File_path";
            this.label_File_path.Size = new System.Drawing.Size(106, 30);
            this.label_File_path.TabIndex = 4;
            this.label_File_path.Text = "File path :";
            this.label_File_path.Click += new System.EventHandler(this.File_path_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1866, 432);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Titre_de_projet
            // 
            this.Titre_de_projet.AutoSize = true;
            this.Titre_de_projet.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Titre_de_projet.Location = new System.Drawing.Point(790, 22);
            this.Titre_de_projet.Name = "Titre_de_projet";
            this.Titre_de_projet.Size = new System.Drawing.Size(311, 52);
            this.Titre_de_projet.TabIndex = 7;
            this.Titre_de_projet.Text = "Titre de Projet";
            this.Titre_de_projet.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(41, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(315, 31);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // Label_Recherche_par_référence
            // 
            this.Label_Recherche_par_référence.AutoSize = true;
            this.Label_Recherche_par_référence.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Label_Recherche_par_référence.Location = new System.Drawing.Point(64, 545);
            this.Label_Recherche_par_référence.Name = "Label_Recherche_par_référence";
            this.Label_Recherche_par_référence.Size = new System.Drawing.Size(362, 45);
            this.Label_Recherche_par_référence.TabIndex = 9;
            this.Label_Recherche_par_référence.Text = "Recherche par référence";
            this.Label_Recherche_par_référence.Click += new System.EventHandler(this.Label_Recherche_par_référence_Click);
            // 
            // Label_Entrez_la_référence
            // 
            this.Label_Entrez_la_référence.AutoSize = true;
            this.Label_Entrez_la_référence.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Entrez_la_référence.Location = new System.Drawing.Point(24, 625);
            this.Label_Entrez_la_référence.Name = "Label_Entrez_la_référence";
            this.Label_Entrez_la_référence.Size = new System.Drawing.Size(205, 30);
            this.Label_Entrez_la_référence.TabIndex = 10;
            this.Label_Entrez_la_référence.Text = "Entrez la référence :";
            this.Label_Entrez_la_référence.Click += new System.EventHandler(this.Label_Entrez_la_référence_Click);
            // 
            // TextBox_Entrez_REF
            // 
            this.TextBox_Entrez_REF.Location = new System.Drawing.Point(234, 627);
            this.TextBox_Entrez_REF.Name = "TextBox_Entrez_REF";
            this.TextBox_Entrez_REF.Size = new System.Drawing.Size(247, 31);
            this.TextBox_Entrez_REF.TabIndex = 11;
            // 
            // Button_Rechercher_REF
            // 
            this.Button_Rechercher_REF.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Button_Rechercher_REF.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Button_Rechercher_REF.Location = new System.Drawing.Point(24, 682);
            this.Button_Rechercher_REF.Name = "Button_Rechercher_REF";
            this.Button_Rechercher_REF.Size = new System.Drawing.Size(459, 42);
            this.Button_Rechercher_REF.TabIndex = 12;
            this.Button_Rechercher_REF.Text = "Chercher";
            this.Button_Rechercher_REF.UseVisualStyleBackColor = false;
            this.Button_Rechercher_REF.Click += new System.EventHandler(this.Button_Rechercher_REF_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 727);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 45);
            this.label1.TabIndex = 13;
            this.label1.Text = "___________________________________";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_recherche_par_prjt
            // 
            this.label_recherche_par_prjt.AutoSize = true;
            this.label_recherche_par_prjt.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_recherche_par_prjt.Location = new System.Drawing.Point(64, 783);
            this.label_recherche_par_prjt.Name = "label_recherche_par_prjt";
            this.label_recherche_par_prjt.Size = new System.Drawing.Size(313, 45);
            this.label_recherche_par_prjt.TabIndex = 14;
            this.label_recherche_par_prjt.Text = "Recherche par projet";
            // 
            // label_Entrez_le_prjt
            // 
            this.label_Entrez_le_prjt.AutoSize = true;
            this.label_Entrez_le_prjt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Entrez_le_prjt.Location = new System.Drawing.Point(24, 860);
            this.label_Entrez_le_prjt.Name = "label_Entrez_le_prjt";
            this.label_Entrez_le_prjt.Size = new System.Drawing.Size(171, 30);
            this.label_Entrez_le_prjt.TabIndex = 15;
            this.label_Entrez_le_prjt.Text = "Entrez le projet :";
            // 
            // textBox_Entrez_le_prjt
            // 
            this.textBox_Entrez_le_prjt.Location = new System.Drawing.Point(234, 862);
            this.textBox_Entrez_le_prjt.Name = "textBox_Entrez_le_prjt";
            this.textBox_Entrez_le_prjt.Size = new System.Drawing.Size(247, 31);
            this.textBox_Entrez_le_prjt.TabIndex = 16;
            // 
            // button_chercher_prjt
            // 
            this.button_chercher_prjt.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button_chercher_prjt.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button_chercher_prjt.Location = new System.Drawing.Point(24, 933);
            this.button_chercher_prjt.Name = "button_chercher_prjt";
            this.button_chercher_prjt.Size = new System.Drawing.Size(459, 42);
            this.button_chercher_prjt.TabIndex = 17;
            this.button_chercher_prjt.Text = "Chercher";
            this.button_chercher_prjt.UseVisualStyleBackColor = false;
            // 
            // Ajouter_Modifier_un_rayonnage
            // 
            this.Ajouter_Modifier_un_rayonnage.AutoSize = true;
            this.Ajouter_Modifier_un_rayonnage.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Ajouter_Modifier_un_rayonnage.Location = new System.Drawing.Point(694, 545);
            this.Ajouter_Modifier_un_rayonnage.Name = "Ajouter_Modifier_un_rayonnage";
            this.Ajouter_Modifier_un_rayonnage.Size = new System.Drawing.Size(507, 45);
            this.Ajouter_Modifier_un_rayonnage.TabIndex = 18;
            this.Ajouter_Modifier_un_rayonnage.Text = "Ajouter / Modifier Un Rayonnage ";
            this.Ajouter_Modifier_un_rayonnage.Click += new System.EventHandler(this.label4_Click);
            // 
            // Ajouter_une_rayonnage
            // 
            this.Ajouter_une_rayonnage.AutoSize = true;
            this.Ajouter_une_rayonnage.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ajouter_une_rayonnage.Location = new System.Drawing.Point(716, 623);
            this.Ajouter_une_rayonnage.Name = "Ajouter_une_rayonnage";
            this.Ajouter_une_rayonnage.Size = new System.Drawing.Size(204, 30);
            this.Ajouter_une_rayonnage.TabIndex = 19;
            this.Ajouter_une_rayonnage.Text = "Ajouter rayonnage :";
            // 
            // textBox_Ajouter_rayonnage
            // 
            this.textBox_Ajouter_rayonnage.Location = new System.Drawing.Point(929, 623);
            this.textBox_Ajouter_rayonnage.Name = "textBox_Ajouter_rayonnage";
            this.textBox_Ajouter_rayonnage.Size = new System.Drawing.Size(224, 31);
            this.textBox_Ajouter_rayonnage.TabIndex = 20;
            // 
            // button_Ajouter_rayonnage
            // 
            this.button_Ajouter_rayonnage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button_Ajouter_rayonnage.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button_Ajouter_rayonnage.Location = new System.Drawing.Point(716, 682);
            this.button_Ajouter_rayonnage.Name = "button_Ajouter_rayonnage";
            this.button_Ajouter_rayonnage.Size = new System.Drawing.Size(206, 42);
            this.button_Ajouter_rayonnage.TabIndex = 21;
            this.button_Ajouter_rayonnage.Text = "Ajouter";
            this.button_Ajouter_rayonnage.UseVisualStyleBackColor = false;
            this.button_Ajouter_rayonnage.Click += new System.EventHandler(this.button2_Click);
            // 
            // Button_modifier_rayonnage
            // 
            this.Button_modifier_rayonnage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Button_modifier_rayonnage.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Button_modifier_rayonnage.Location = new System.Drawing.Point(947, 682);
            this.Button_modifier_rayonnage.Name = "Button_modifier_rayonnage";
            this.Button_modifier_rayonnage.Size = new System.Drawing.Size(206, 42);
            this.Button_modifier_rayonnage.TabIndex = 22;
            this.Button_modifier_rayonnage.Text = "Modifier";
            this.Button_modifier_rayonnage.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(704, 727);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(475, 45);
            this.label6.TabIndex = 23;
            this.label6.Text = "___________________________________";
            // 
            // label_Ajouter_et_nettoyer_un_prjt
            // 
            this.label_Ajouter_et_nettoyer_un_prjt.AutoSize = true;
            this.label_Ajouter_et_nettoyer_un_prjt.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_Ajouter_et_nettoyer_un_prjt.Location = new System.Drawing.Point(716, 783);
            this.label_Ajouter_et_nettoyer_un_prjt.Name = "label_Ajouter_et_nettoyer_un_prjt";
            this.label_Ajouter_et_nettoyer_un_prjt.Size = new System.Drawing.Size(428, 45);
            this.label_Ajouter_et_nettoyer_un_prjt.TabIndex = 24;
            this.label_Ajouter_et_nettoyer_un_prjt.Text = "Ajouter et nettoyer un projet";
            // 
            // label_entrez_nom_de_prjt
            // 
            this.label_entrez_nom_de_prjt.AutoSize = true;
            this.label_entrez_nom_de_prjt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_entrez_nom_de_prjt.Location = new System.Drawing.Point(716, 843);
            this.label_entrez_nom_de_prjt.Name = "label_entrez_nom_de_prjt";
            this.label_entrez_nom_de_prjt.Size = new System.Drawing.Size(229, 30);
            this.label_entrez_nom_de_prjt.TabIndex = 25;
            this.label_entrez_nom_de_prjt.Text = "Entrez nom de projet :";
            // 
            // textBox_entrez_nom_de_prjt
            // 
            this.textBox_entrez_nom_de_prjt.Location = new System.Drawing.Point(961, 843);
            this.textBox_entrez_nom_de_prjt.Name = "textBox_entrez_nom_de_prjt";
            this.textBox_entrez_nom_de_prjt.Size = new System.Drawing.Size(191, 31);
            this.textBox_entrez_nom_de_prjt.TabIndex = 26;
            // 
            // label_information_consommateurs
            // 
            this.label_information_consommateurs.AutoSize = true;
            this.label_information_consommateurs.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_information_consommateurs.Location = new System.Drawing.Point(1404, 545);
            this.label_information_consommateurs.Name = "label_information_consommateurs";
            this.label_information_consommateurs.Size = new System.Drawing.Size(441, 45);
            this.label_information_consommateurs.TabIndex = 27;
            this.label_information_consommateurs.Text = "Informations consommateurs";
            // 
            // label_entrez_REF
            // 
            this.label_entrez_REF.AutoSize = true;
            this.label_entrez_REF.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_entrez_REF.Location = new System.Drawing.Point(1404, 758);
            this.label_entrez_REF.Name = "label_entrez_REF";
            this.label_entrez_REF.Size = new System.Drawing.Size(125, 30);
            this.label_entrez_REF.TabIndex = 28;
            this.label_entrez_REF.Text = "Entrez REF :";
            // 
            // label_Nombre_des_pcs
            // 
            this.label_Nombre_des_pcs.AutoSize = true;
            this.label_Nombre_des_pcs.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Nombre_des_pcs.Location = new System.Drawing.Point(1404, 708);
            this.label_Nombre_des_pcs.Name = "label_Nombre_des_pcs";
            this.label_Nombre_des_pcs.Size = new System.Drawing.Size(183, 30);
            this.label_Nombre_des_pcs.TabIndex = 29;
            this.label_Nombre_des_pcs.Text = "Nombre des pcs :";
            // 
            // label_entrez_IE_IU
            // 
            this.label_entrez_IE_IU.AutoSize = true;
            this.label_entrez_IE_IU.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_entrez_IE_IU.Location = new System.Drawing.Point(1404, 660);
            this.label_entrez_IE_IU.Name = "label_entrez_IE_IU";
            this.label_entrez_IE_IU.Size = new System.Drawing.Size(149, 30);
            this.label_entrez_IE_IU.TabIndex = 30;
            this.label_entrez_IE_IU.Text = "Entrez IE / IU :";
            // 
            // label_entrez_nom_complet
            // 
            this.label_entrez_nom_complet.AutoSize = true;
            this.label_entrez_nom_complet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_entrez_nom_complet.Location = new System.Drawing.Point(1404, 613);
            this.label_entrez_nom_complet.Name = "label_entrez_nom_complet";
            this.label_entrez_nom_complet.Size = new System.Drawing.Size(219, 30);
            this.label_entrez_nom_complet.TabIndex = 31;
            this.label_entrez_nom_complet.Text = "Entrez nom complet :";
            // 
            // button_Valider
            // 
            this.button_Valider.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button_Valider.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button_Valider.Location = new System.Drawing.Point(1404, 812);
            this.button_Valider.Name = "button_Valider";
            this.button_Valider.Size = new System.Drawing.Size(459, 42);
            this.button_Valider.TabIndex = 32;
            this.button_Valider.Text = "Valider";
            this.button_Valider.UseVisualStyleBackColor = false;
            // 
            // button_Quantité_restante_de_piéces
            // 
            this.button_Quantité_restante_de_piéces.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button_Quantité_restante_de_piéces.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button_Quantité_restante_de_piéces.Location = new System.Drawing.Point(1404, 863);
            this.button_Quantité_restante_de_piéces.Name = "button_Quantité_restante_de_piéces";
            this.button_Quantité_restante_de_piéces.Size = new System.Drawing.Size(224, 112);
            this.button_Quantité_restante_de_piéces.TabIndex = 33;
            this.button_Quantité_restante_de_piéces.Text = "Quantité restante de pièces";
            this.button_Quantité_restante_de_piéces.UseVisualStyleBackColor = false;
            // 
            // button_Quantité_de_pièces_consommées
            // 
            this.button_Quantité_de_pièces_consommées.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button_Quantité_de_pièces_consommées.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button_Quantité_de_pièces_consommées.Location = new System.Drawing.Point(1657, 863);
            this.button_Quantité_de_pièces_consommées.Name = "button_Quantité_de_pièces_consommées";
            this.button_Quantité_de_pièces_consommées.Size = new System.Drawing.Size(206, 112);
            this.button_Quantité_de_pièces_consommées.TabIndex = 34;
            this.button_Quantité_de_pièces_consommées.Text = "Quantité de pièces consommées";
            this.button_Quantité_de_pièces_consommées.UseVisualStyleBackColor = false;
            // 
            // textBox_Entrez_REF_pour_cons
            // 
            this.textBox_Entrez_REF_pour_cons.Location = new System.Drawing.Point(1621, 758);
            this.textBox_Entrez_REF_pour_cons.Name = "textBox_Entrez_REF_pour_cons";
            this.textBox_Entrez_REF_pour_cons.Size = new System.Drawing.Size(224, 31);
            this.textBox_Entrez_REF_pour_cons.TabIndex = 35;
            // 
            // textBox_Nombre_des_pcs
            // 
            this.textBox_Nombre_des_pcs.Location = new System.Drawing.Point(1621, 710);
            this.textBox_Nombre_des_pcs.Name = "textBox_Nombre_des_pcs";
            this.textBox_Nombre_des_pcs.Size = new System.Drawing.Size(224, 31);
            this.textBox_Nombre_des_pcs.TabIndex = 36;
            // 
            // textBox_entrez_IE_IU
            // 
            this.textBox_entrez_IE_IU.Location = new System.Drawing.Point(1621, 662);
            this.textBox_entrez_IE_IU.Name = "textBox_entrez_IE_IU";
            this.textBox_entrez_IE_IU.Size = new System.Drawing.Size(224, 31);
            this.textBox_entrez_IE_IU.TabIndex = 37;
            // 
            // textBox_Entrez_nom_complet
            // 
            this.textBox_Entrez_nom_complet.Location = new System.Drawing.Point(1621, 615);
            this.textBox_Entrez_nom_complet.Name = "textBox_Entrez_nom_complet";
            this.textBox_Entrez_nom_complet.Size = new System.Drawing.Size(224, 31);
            this.textBox_Entrez_nom_complet.TabIndex = 38;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
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
            this.Controls.Add(this.textBox_entrez_nom_de_prjt);
            this.Controls.Add(this.label_entrez_nom_de_prjt);
            this.Controls.Add(this.label_Ajouter_et_nettoyer_un_prjt);
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
            this.Controls.Add(this.Titre_de_projet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_File_path);
            this.Controls.Add(this.textBox_file_path);
            this.Controls.Add(this.Button_Clean);
            this.Controls.Add(this.Button_Upload);
            this.Controls.Add(this.Button_browse);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_browse;
        private System.Windows.Forms.Button Button_Upload;
        private System.Windows.Forms.Button Button_Clean;
        private System.Windows.Forms.TextBox textBox_file_path;
        private System.Windows.Forms.Label label_File_path;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Titre_de_projet;
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
        private System.Windows.Forms.Label label_Ajouter_et_nettoyer_un_prjt;
        private System.Windows.Forms.Label label_entrez_nom_de_prjt;
        private System.Windows.Forms.TextBox textBox_entrez_nom_de_prjt;
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