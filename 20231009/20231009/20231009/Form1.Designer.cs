
namespace _20231009
{
    partial class Form1
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
            this.lstBered1 = new System.Windows.Forms.ListBox();
            this.btnSzam = new System.Windows.Forms.Button();
            this.btn2Kilep = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lstBered1
            // 
            this.lstBered1.FormattingEnabled = true;
            this.lstBered1.Location = new System.Drawing.Point(314, 180);
            this.lstBered1.Name = "lstBered1";
            this.lstBered1.Size = new System.Drawing.Size(170, 121);
            this.lstBered1.TabIndex = 0;
            this.lstBered1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnSzam
            // 
            this.btnSzam.Location = new System.Drawing.Point(314, 107);
            this.btnSzam.Name = "btnSzam";
            this.btnSzam.Size = new System.Drawing.Size(170, 67);
            this.btnSzam.TabIndex = 1;
            this.btnSzam.Text = "Számlálás";
            this.btnSzam.UseVisualStyleBackColor = true;
            this.btnSzam.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn2Kilep
            // 
            this.btn2Kilep.Location = new System.Drawing.Point(509, 12);
            this.btn2Kilep.Name = "btn2Kilep";
            this.btn2Kilep.Size = new System.Drawing.Size(279, 426);
            this.btn2Kilep.TabIndex = 2;
            this.btn2Kilep.Text = "Kilépés";
            this.btn2Kilep.UseVisualStyleBackColor = true;
            this.btn2Kilep.Click += new System.EventHandler(this.btn2Kilep_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn2Kilep);
            this.Controls.Add(this.btnSzam);
            this.Controls.Add(this.lstBered1);
            this.Name = "Form1";
            this.Text = "11.Feladat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBered1;
        private System.Windows.Forms.Button btnSzam;
        private System.Windows.Forms.Button btn2Kilep;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

