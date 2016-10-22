namespace AnimalFileImporter
{
    partial class AnimalFileImporter
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
            this.lbImportedAnimals = new System.Windows.Forms.ListBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.ofdGetAnimals = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lbImportedAnimals
            // 
            this.lbImportedAnimals.FormattingEnabled = true;
            this.lbImportedAnimals.Location = new System.Drawing.Point(12, 12);
            this.lbImportedAnimals.Name = "lbImportedAnimals";
            this.lbImportedAnimals.Size = new System.Drawing.Size(144, 225);
            this.lbImportedAnimals.TabIndex = 0;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(186, 12);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // ofdGetAnimals
            // 
            this.ofdGetAnimals.FileName = "openFileDialog1";
            // 
            // AnimalFileImporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.lbImportedAnimals);
            this.Name = "AnimalFileImporter";
            this.Text = "Animal File Importer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbImportedAnimals;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.OpenFileDialog ofdGetAnimals;
    }
}

