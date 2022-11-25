
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
            this.SuspendLayout();
            // 
            // ckeanData
            // 
            this.ckeanData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ckeanData.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ckeanData.ForeColor = System.Drawing.Color.White;
            this.ckeanData.Location = new System.Drawing.Point(67, 60);
            this.ckeanData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckeanData.Name = "ckeanData";
            this.ckeanData.Size = new System.Drawing.Size(815, 885);
            this.ckeanData.TabIndex = 0;
            this.ckeanData.Text = "Add Project";
            this.ckeanData.UseVisualStyleBackColor = false;
            this.ckeanData.Click += new System.EventHandler(this.ckeanData_Click);
            // 
            // dataManipulation
            // 
            this.dataManipulation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataManipulation.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.dataManipulation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataManipulation.Location = new System.Drawing.Point(1060, 60);
            this.dataManipulation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataManipulation.Name = "dataManipulation";
            this.dataManipulation.Size = new System.Drawing.Size(794, 885);
            this.dataManipulation.TabIndex = 1;
            this.dataManipulation.Text = "Work on projects";
            this.dataManipulation.UseVisualStyleBackColor = false;
            this.dataManipulation.Click += new System.EventHandler(this.dataManipulation_Click);
            // 
            // Browse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1761, 985);
            this.Controls.Add(this.dataManipulation);
            this.Controls.Add(this.ckeanData);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Browse";
            this.Text = "Browse";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ckeanData;
        private System.Windows.Forms.Button dataManipulation;
    }
}