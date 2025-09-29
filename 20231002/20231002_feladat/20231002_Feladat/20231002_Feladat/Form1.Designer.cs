
namespace _20231002_Feladat
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
            this.btn1novekvo = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txb1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn1novekvo
            // 
            this.btn1novekvo.Location = new System.Drawing.Point(298, 159);
            this.btn1novekvo.Name = "btn1novekvo";
            this.btn1novekvo.Size = new System.Drawing.Size(164, 46);
            this.btn1novekvo.TabIndex = 0;
            this.btn1novekvo.Text = "Növekvő sorrend";
            this.btn1novekvo.UseVisualStyleBackColor = true;
            this.btn1novekvo.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.Location = new System.Drawing.Point(320, 211);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(120, 95);
            this.lb1.TabIndex = 1;
            this.lb1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Számok szóközzel elválasztva";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txb1
            // 
            this.txb1.Location = new System.Drawing.Point(298, 133);
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(164, 20);
            this.txb1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btn1novekvo);
            this.Name = "Form1";
            this.Text = "Feladat 8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1novekvo;
        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb1;
    }
}

