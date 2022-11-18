using System;

namespace Corrupt_Your_Own_Files
{
    partial class fMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.bFile = new System.Windows.Forms.Button();
            this.bCorrrupt = new System.Windows.Forms.Button();
            this.bInfo = new System.Windows.Forms.Button();
            this.tFile = new System.Windows.Forms.TextBox();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // bFile
            // 
            this.bFile.Location = new System.Drawing.Point(12, 42);
            this.bFile.Name = "bFile";
            this.bFile.Size = new System.Drawing.Size(75, 23);
            this.bFile.TabIndex = 1;
            this.bFile.Text = "Select File";
            this.bFile.UseVisualStyleBackColor = true;
            this.bFile.Click += new System.EventHandler(this.bFile_Click);
            // 
            // bCorrrupt
            // 
            this.bCorrrupt.Location = new System.Drawing.Point(131, 42);
            this.bCorrrupt.Name = "bCorrrupt";
            this.bCorrrupt.Size = new System.Drawing.Size(75, 23);
            this.bCorrrupt.TabIndex = 1;
            this.bCorrrupt.Text = "Corrupt File";
            this.bCorrrupt.UseVisualStyleBackColor = true;
            this.bCorrrupt.Click += new System.EventHandler(this.bCorrrupt_Click);
            // 
            // bInfo
            // 
            this.bInfo.Location = new System.Drawing.Point(250, 41);
            this.bInfo.Name = "bInfo";
            this.bInfo.Size = new System.Drawing.Size(75, 23);
            this.bInfo.TabIndex = 2;
            this.bInfo.Text = "Information";
            this.bInfo.UseVisualStyleBackColor = true;
            this.bInfo.Click += new System.EventHandler(this.bInfo_Click);
            // 
            // tFile
            // 
            this.tFile.Location = new System.Drawing.Point(12, 13);
            this.tFile.Name = "tFile";
            this.tFile.Size = new System.Drawing.Size(315, 20);
            this.tFile.TabIndex = 3;
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(12, 71);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(313, 23);
            this.pBar.TabIndex = 4;
            // 
            // fMain
            // 
            this.ClientSize = new System.Drawing.Size(339, 98);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.tFile);
            this.Controls.Add(this.bInfo);
            this.Controls.Add(this.bCorrrupt);
            this.Controls.Add(this.bFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Corrupt Your OWN files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bFile;
        private System.Windows.Forms.Button bCorrrupt;
        private System.Windows.Forms.Button bInfo;
        private System.Windows.Forms.TextBox tFile;
        private System.Windows.Forms.ProgressBar pBar;
    }
}

