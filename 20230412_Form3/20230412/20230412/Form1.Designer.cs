
namespace _20230412
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
            this.btnszamol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtoldal = new System.Windows.Forms.TextBox();
            this.lblkerulet = new System.Windows.Forms.Label();
            this.lblterulet = new System.Windows.Forms.Label();
            this.btntorles = new System.Windows.Forms.Button();
            this.btnkilepes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnszamol
            // 
            this.btnszamol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnszamol.Location = new System.Drawing.Point(45, 124);
            this.btnszamol.Name = "btnszamol";
            this.btnszamol.Size = new System.Drawing.Size(192, 45);
            this.btnszamol.TabIndex = 0;
            this.btnszamol.Text = "Számolás";
            this.btnszamol.UseVisualStyleBackColor = true;
            this.btnszamol.Click += new System.EventHandler(this.btnszamol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "A Négyzet Oldala:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtoldal
            // 
            this.txtoldal.Location = new System.Drawing.Point(137, 76);
            this.txtoldal.Name = "txtoldal";
            this.txtoldal.Size = new System.Drawing.Size(100, 20);
            this.txtoldal.TabIndex = 2;
            // 
            // lblkerulet
            // 
            this.lblkerulet.AutoSize = true;
            this.lblkerulet.Location = new System.Drawing.Point(45, 199);
            this.lblkerulet.Name = "lblkerulet";
            this.lblkerulet.Size = new System.Drawing.Size(49, 13);
            this.lblkerulet.TabIndex = 3;
            this.lblkerulet.Text = "Kerülete:";
            this.lblkerulet.Visible = false;
            // 
            // lblterulet
            // 
            this.lblterulet.AutoSize = true;
            this.lblterulet.Location = new System.Drawing.Point(45, 225);
            this.lblterulet.Name = "lblterulet";
            this.lblterulet.Size = new System.Drawing.Size(49, 13);
            this.lblterulet.TabIndex = 4;
            this.lblterulet.Text = "Területe:";
            this.lblterulet.Visible = false;
            // 
            // btntorles
            // 
            this.btntorles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btntorles.Location = new System.Drawing.Point(48, 295);
            this.btntorles.Name = "btntorles";
            this.btntorles.Size = new System.Drawing.Size(75, 32);
            this.btntorles.TabIndex = 5;
            this.btntorles.Text = "Törlés";
            this.btntorles.UseVisualStyleBackColor = true;
            this.btntorles.Click += new System.EventHandler(this.btntorles_Click);
            // 
            // btnkilepes
            // 
            this.btnkilepes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnkilepes.Location = new System.Drawing.Point(162, 295);
            this.btnkilepes.Name = "btnkilepes";
            this.btnkilepes.Size = new System.Drawing.Size(75, 32);
            this.btnkilepes.TabIndex = 6;
            this.btnkilepes.Text = "Kilépés";
            this.btnkilepes.UseVisualStyleBackColor = true;
            this.btnkilepes.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 513);
            this.Controls.Add(this.btnkilepes);
            this.Controls.Add(this.btntorles);
            this.Controls.Add(this.lblterulet);
            this.Controls.Add(this.lblkerulet);
            this.Controls.Add(this.txtoldal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnszamol);
            this.Name = "Form1";
            this.Text = "A Négyzet kerülete, területe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnszamol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtoldal;
        private System.Windows.Forms.Label lblkerulet;
        private System.Windows.Forms.Label lblterulet;
        private System.Windows.Forms.Button btntorles;
        private System.Windows.Forms.Button btnkilepes;
    }
}

