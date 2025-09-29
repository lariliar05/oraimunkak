
namespace _20231024_15.fel
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
            this.btn1Kilep = new System.Windows.Forms.Button();
            this.btn2cser = new System.Windows.Forms.Button();
            this.btn3tor = new System.Windows.Forms.Button();
            this.ltb1 = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btn1Kilep
            // 
            this.btn1Kilep.Location = new System.Drawing.Point(686, 396);
            this.btn1Kilep.Name = "btn1Kilep";
            this.btn1Kilep.Size = new System.Drawing.Size(102, 42);
            this.btn1Kilep.TabIndex = 0;
            this.btn1Kilep.Text = "Kilép";
            this.btn1Kilep.UseVisualStyleBackColor = true;
            this.btn1Kilep.Click += new System.EventHandler(this.btn1Kilep_Click);
            // 
            // btn2cser
            // 
            this.btn2cser.Location = new System.Drawing.Point(372, 220);
            this.btn2cser.Name = "btn2cser";
            this.btn2cser.Size = new System.Drawing.Size(169, 106);
            this.btn2cser.TabIndex = 1;
            this.btn2cser.Text = "Csere";
            this.btn2cser.UseVisualStyleBackColor = true;
            this.btn2cser.Click += new System.EventHandler(this.btn2cser_Click);
            // 
            // btn3tor
            // 
            this.btn3tor.Location = new System.Drawing.Point(372, 44);
            this.btn3tor.Name = "btn3tor";
            this.btn3tor.Size = new System.Drawing.Size(169, 105);
            this.btn3tor.TabIndex = 2;
            this.btn3tor.Text = "Törlés";
            this.btn3tor.UseVisualStyleBackColor = true;
            this.btn3tor.Click += new System.EventHandler(this.btn3tor_Click);
            // 
            // ltb1
            // 
            this.ltb1.FormattingEnabled = true;
            this.ltb1.Location = new System.Drawing.Point(48, 12);
            this.ltb1.Name = "ltb1";
            this.ltb1.Size = new System.Drawing.Size(200, 420);
            this.ltb1.TabIndex = 3;
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
            this.Controls.Add(this.ltb1);
            this.Controls.Add(this.btn3tor);
            this.Controls.Add(this.btn2cser);
            this.Controls.Add(this.btn1Kilep);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1Kilep;
        private System.Windows.Forms.Button btn2cser;
        private System.Windows.Forms.Button btn3tor;
        private System.Windows.Forms.ListBox ltb1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

