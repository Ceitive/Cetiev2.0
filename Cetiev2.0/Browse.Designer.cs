
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
            this.ckeanData.Location = new System.Drawing.Point(279, 233);
            this.ckeanData.Name = "ckeanData";
            this.ckeanData.Size = new System.Drawing.Size(177, 45);
            this.ckeanData.TabIndex = 0;
            this.ckeanData.Text = "Add Project";
            this.ckeanData.UseVisualStyleBackColor = true;
            this.ckeanData.Click += new System.EventHandler(this.ckeanData_Click);
            // 
            // dataManipulation
            // 
            this.dataManipulation.Location = new System.Drawing.Point(600, 233);
            this.dataManipulation.Name = "dataManipulation";
            this.dataManipulation.Size = new System.Drawing.Size(184, 45);
            this.dataManipulation.TabIndex = 1;
            this.dataManipulation.Text = "Work on projects";
            this.dataManipulation.UseVisualStyleBackColor = true;
            this.dataManipulation.Click += new System.EventHandler(this.dataManipulation_Click);
            // 
            // Browse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 591);
            this.Controls.Add(this.dataManipulation);
            this.Controls.Add(this.ckeanData);
            this.Name = "Browse";
            this.Text = "Browse";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ckeanData;
        private System.Windows.Forms.Button dataManipulation;
    }
}