
namespace Cetiev2._0
{
    partial class Clean
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
            this.textBoxProjectName = new System.Windows.Forms.TextBox();
            this.label_entrez_nom_de_prjt = new System.Windows.Forms.Label();
            this.label_Ajouter_et_nettoyer_un_prjt = new System.Windows.Forms.Label();
            this.label_File_path = new System.Windows.Forms.Label();
            this.textBox_file_path = new System.Windows.Forms.TextBox();
            this.Button_Save = new System.Windows.Forms.Button();
            this.Button_Upload = new System.Windows.Forms.Button();
            this.Button_browse = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rayonnage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consumation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeReste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_back_clean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxProjectName
            // 
            this.textBoxProjectName.Location = new System.Drawing.Point(1021, 762);
            this.textBoxProjectName.Name = "textBoxProjectName";
            this.textBoxProjectName.Size = new System.Drawing.Size(188, 31);
            this.textBoxProjectName.TabIndex = 34;
            // 
            // label_entrez_nom_de_prjt
            // 
            this.label_entrez_nom_de_prjt.AutoSize = true;
            this.label_entrez_nom_de_prjt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_entrez_nom_de_prjt.Location = new System.Drawing.Point(774, 762);
            this.label_entrez_nom_de_prjt.Name = "label_entrez_nom_de_prjt";
            this.label_entrez_nom_de_prjt.Size = new System.Drawing.Size(252, 32);
            this.label_entrez_nom_de_prjt.TabIndex = 33;
            this.label_entrez_nom_de_prjt.Text = "Entrez nom de projet :";
            // 
            // label_Ajouter_et_nettoyer_un_prjt
            // 
            this.label_Ajouter_et_nettoyer_un_prjt.AutoSize = true;
            this.label_Ajouter_et_nettoyer_un_prjt.BackColor = System.Drawing.SystemColors.Control;
            this.label_Ajouter_et_nettoyer_un_prjt.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_Ajouter_et_nettoyer_un_prjt.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_Ajouter_et_nettoyer_un_prjt.Location = new System.Drawing.Point(784, 700);
            this.label_Ajouter_et_nettoyer_un_prjt.Name = "label_Ajouter_et_nettoyer_un_prjt";
            this.label_Ajouter_et_nettoyer_un_prjt.Size = new System.Drawing.Size(428, 45);
            this.label_Ajouter_et_nettoyer_un_prjt.TabIndex = 32;
            this.label_Ajouter_et_nettoyer_un_prjt.Text = "Ajouter et nettoyer un projet";
            // 
            // label_File_path
            // 
            this.label_File_path.AutoSize = true;
            this.label_File_path.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_File_path.Location = new System.Drawing.Point(774, 817);
            this.label_File_path.Name = "label_File_path";
            this.label_File_path.Size = new System.Drawing.Size(118, 32);
            this.label_File_path.TabIndex = 31;
            this.label_File_path.Text = "File path :";
            // 
            // textBox_file_path
            // 
            this.textBox_file_path.Location = new System.Drawing.Point(899, 817);
            this.textBox_file_path.Name = "textBox_file_path";
            this.textBox_file_path.Size = new System.Drawing.Size(313, 31);
            this.textBox_file_path.TabIndex = 30;
            // 
            // Button_Save
            // 
            this.Button_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Save.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Button_Save.ForeColor = System.Drawing.Color.White;
            this.Button_Save.Location = new System.Drawing.Point(1071, 868);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(141, 42);
            this.Button_Save.TabIndex = 29;
            this.Button_Save.Text = "Save";
            this.Button_Save.UseVisualStyleBackColor = false;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // Button_Upload
            // 
            this.Button_Upload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Upload.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Button_Upload.ForeColor = System.Drawing.Color.White;
            this.Button_Upload.Location = new System.Drawing.Point(926, 868);
            this.Button_Upload.Name = "Button_Upload";
            this.Button_Upload.Size = new System.Drawing.Size(140, 42);
            this.Button_Upload.TabIndex = 28;
            this.Button_Upload.Text = "Clean";
            this.Button_Upload.UseVisualStyleBackColor = false;
            this.Button_Upload.Click += new System.EventHandler(this.Button_Upload_Click);
            // 
            // Button_browse
            // 
            this.Button_browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_browse.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Button_browse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_browse.Location = new System.Drawing.Point(774, 868);
            this.Button_browse.Name = "Button_browse";
            this.Button_browse.Size = new System.Drawing.Size(141, 42);
            this.Button_browse.TabIndex = 27;
            this.Button_browse.Text = "Browse";
            this.Button_browse.UseVisualStyleBackColor = false;
            this.Button_browse.Click += new System.EventHandler(this.Button_browse_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(963, 598);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1799, 1048);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 50);
            this.button1.TabIndex = 36;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Reference,
            this.Quantity,
            this.Description,
            this.Rayonnage,
            this.Consumation,
            this.LeReste});
            this.dataGridView2.Location = new System.Drawing.Point(1007, 42);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(921, 598);
            this.dataGridView2.TabIndex = 37;
            // 
            // Reference
            // 
            this.Reference.HeaderText = "Reference";
            this.Reference.MinimumWidth = 8;
            this.Reference.Name = "Reference";
            this.Reference.Width = 150;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 8;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 150;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 8;
            this.Description.Name = "Description";
            this.Description.Width = 150;
            // 
            // Rayonnage
            // 
            this.Rayonnage.HeaderText = "Rayonnage";
            this.Rayonnage.MinimumWidth = 8;
            this.Rayonnage.Name = "Rayonnage";
            this.Rayonnage.Width = 150;
            // 
            // Consumation
            // 
            this.Consumation.HeaderText = "Consumé";
            this.Consumation.MinimumWidth = 8;
            this.Consumation.Name = "Consumation";
            this.Consumation.Width = 150;
            // 
            // LeReste
            // 
            this.LeReste.HeaderText = "Le reste";
            this.LeReste.MinimumWidth = 8;
            this.LeReste.Name = "LeReste";
            this.LeReste.Width = 150;
            // 
            // button_back_clean
            // 
            this.button_back_clean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_back_clean.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button_back_clean.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_back_clean.Location = new System.Drawing.Point(11, 937);
            this.button_back_clean.Name = "button_back_clean";
            this.button_back_clean.Size = new System.Drawing.Size(133, 42);
            this.button_back_clean.TabIndex = 38;
            this.button_back_clean.Text = "Back";
            this.button_back_clean.UseVisualStyleBackColor = false;
            this.button_back_clean.Click += new System.EventHandler(this.button_back_clean_Click);
            // 
            // Clean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1941, 1050);
            this.Controls.Add(this.button_back_clean);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxProjectName);
            this.Controls.Add(this.label_entrez_nom_de_prjt);
            this.Controls.Add(this.label_Ajouter_et_nettoyer_un_prjt);
            this.Controls.Add(this.label_File_path);
            this.Controls.Add(this.textBox_file_path);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.Button_Upload);
            this.Controls.Add(this.Button_browse);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Clean";
            this.Text = "Clean";
            this.Load += new System.EventHandler(this.Clean_Load);
            this.Resize += new System.EventHandler(this.Clean_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxProjectName;
        private System.Windows.Forms.Label label_entrez_nom_de_prjt;
        private System.Windows.Forms.Label label_Ajouter_et_nettoyer_un_prjt;
        private System.Windows.Forms.Label label_File_path;
        private System.Windows.Forms.TextBox textBox_file_path;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.Button Button_Upload;
        private System.Windows.Forms.Button Button_browse;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button_back_clean;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rayonnage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consumation;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeReste;
    }
}