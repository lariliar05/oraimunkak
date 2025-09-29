
namespace _20231002_feladat_9
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
            this.btn1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txb1 = new System.Windows.Forms.TextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.lsb1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(291, 147);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(97, 65);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Másolás";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Szöveg";
            // 
            // txb1
            // 
            this.txb1.Location = new System.Drawing.Point(321, 107);
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(169, 20);
            this.txb1.TabIndex = 2;
            this.txb1.TextChanged += new System.EventHandler(this.txb1_TextChanged);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(423, 147);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(97, 65);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "Beillesztés";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // lsb1
            // 
            this.lsb1.FormattingEnabled = true;
            this.lsb1.Location = new System.Drawing.Point(321, 235);
            this.lsb1.Name = "lsb1";
            this.lsb1.Size = new System.Drawing.Size(169, 121);
            this.lsb1.TabIndex = 4;
            this.lsb1.SelectedIndexChanged += new System.EventHandler(this.lsb1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsb1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.txb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Feladat 9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.ListBox lsb1;
    }
}

