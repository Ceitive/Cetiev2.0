
namespace Cetiev2._0
{
    partial class Browse
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
            this.ckeanData = new System.Windows.Forms.Button();
            this.dataManipulation = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckeanData
            // 
            this.ckeanData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckeanData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ckeanData.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ckeanData.ForeColor = System.Drawing.Color.White;
            this.ckeanData.Location = new System.Drawing.Point(105, 369);
            this.ckeanData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckeanData.Name = "ckeanData";
            this.ckeanData.Size = new System.Drawing.Size(387, 102);
            this.ckeanData.TabIndex = 0;
            this.ckeanData.Text = "Ajouter un nouveau projet";
            this.ckeanData.UseVisualStyleBackColor = false;
            this.ckeanData.Click += new System.EventHandler(this.ckeanData_Click);
            // 
            // dataManipulation
            // 
            this.dataManipulation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataManipulation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataManipulation.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.dataManipulation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataManipulation.Location = new System.Drawing.Point(702, 369);
            this.dataManipulation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataManipulation.Name = "dataManipulation";
            this.dataManipulation.Size = new System.Drawing.Size(387, 102);
            this.dataManipulation.TabIndex = 1;
            this.dataManipulation.Text = "Travailler sur un projet";
            this.dataManipulation.UseVisualStyleBackColor = false;
            this.dataManipulation.Click += new System.EventHandler(this.dataManipulation_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackgroundImage = global::Cetiev2._0.Properties.Resources.download__1__removebg_preview;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(105, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 269);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackgroundImage = global::Cetiev2._0.Properties.Resources._2413136_200;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(702, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 269);
            this.panel2.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ckeanData, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataManipulation, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(381, 233);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.57005F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.42995F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1195, 476);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // Browse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1887, 985);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Browse";
            this.Text = "Browse";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ckeanData;
        private System.Windows.Forms.Button dataManipulation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}