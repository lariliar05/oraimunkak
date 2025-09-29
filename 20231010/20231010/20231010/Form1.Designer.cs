
namespace _20231010
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
            this.btn1Szam = new System.Windows.Forms.Button();
            this.txtb1Szamjegy = new System.Windows.Forms.TextBox();
            this.txtb2Szamjegy = new System.Windows.Forms.TextBox();
            this.lstb1Eredmeny = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn2Kilep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1Szam
            // 
            this.btn1Szam.Location = new System.Drawing.Point(285, 295);
            this.btn1Szam.Name = "btn1Szam";
            this.btn1Szam.Size = new System.Drawing.Size(180, 53);
            this.btn1Szam.TabIndex = 0;
            this.btn1Szam.Text = "Számolás";
            this.btn1Szam.UseVisualStyleBackColor = true;
            this.btn1Szam.Click += new System.EventHandler(this.btn1Szam_Click);
            // 
            // txtb1Szamjegy
            // 
            this.txtb1Szamjegy.Location = new System.Drawing.Point(222, 111);
            this.txtb1Szamjegy.Name = "txtb1Szamjegy";
            this.txtb1Szamjegy.Size = new System.Drawing.Size(100, 20);
            this.txtb1Szamjegy.TabIndex = 1;
            this.txtb1Szamjegy.TextChanged += new System.EventHandler(this.txtb1Szamjegy_TextChanged);
            // 
            // txtb2Szamjegy
            // 
            this.txtb2Szamjegy.Location = new System.Drawing.Point(432, 111);
            this.txtb2Szamjegy.Name = "txtb2Szamjegy";
            this.txtb2Szamjegy.Size = new System.Drawing.Size(100, 20);
            this.txtb2Szamjegy.TabIndex = 2;
            this.txtb2Szamjegy.TextChanged += new System.EventHandler(this.txtb2Szamjegy_TextChanged);
            // 
            // lstb1Eredmeny
            // 
            this.lstb1Eredmeny.FormattingEnabled = true;
            this.lstb1Eredmeny.Location = new System.Drawing.Point(314, 194);
            this.lstb1Eredmeny.Name = "lstb1Eredmeny";
            this.lstb1Eredmeny.Size = new System.Drawing.Size(120, 95);
            this.lstb1Eredmeny.TabIndex = 3;
            this.lstb1Eredmeny.SelectedIndexChanged += new System.EventHandler(this.lstb1Eredmeny_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Adja meg a számokat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "__";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Eredmény";
            // 
            // btn2Kilep
            // 
            this.btn2Kilep.Location = new System.Drawing.Point(679, 403);
            this.btn2Kilep.Name = "btn2Kilep";
            this.btn2Kilep.Size = new System.Drawing.Size(109, 35);
            this.btn2Kilep.TabIndex = 7;
            this.btn2Kilep.Text = "Kilépés";
            this.btn2Kilep.UseVisualStyleBackColor = true;
            this.btn2Kilep.Click += new System.EventHandler(this.btn2Kilep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn2Kilep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstb1Eredmeny);
            this.Controls.Add(this.txtb2Szamjegy);
            this.Controls.Add(this.txtb1Szamjegy);
            this.Controls.Add(this.btn1Szam);
            this.Name = "Form1";
            this.Text = "12. Feladat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1Szam;
        private System.Windows.Forms.TextBox txtb1Szamjegy;
        private System.Windows.Forms.TextBox txtb2Szamjegy;
        private System.Windows.Forms.ListBox lstb1Eredmeny;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn2Kilep;
    }
}

