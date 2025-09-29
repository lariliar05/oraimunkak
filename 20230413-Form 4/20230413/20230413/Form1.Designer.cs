
namespace _20230413
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtszoveg = new System.Windows.Forms.TextBox();
            this.lblszavak = new System.Windows.Forms.Label();
            this.lblkarakter = new System.Windows.Forms.Label();
            this.lblnagybetuk = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblmaganhangzok = new System.Windows.Forms.Label();
            this.lblnagybetuk2 = new System.Windows.Forms.Label();
            this.btnkilepes = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.lblbetutipus = new System.Windows.Forms.Label();
            this.lblbetustilus = new System.Windows.Forms.Label();
            this.lblbetumeret = new System.Windows.Forms.Label();
            this.btnfont = new System.Windows.Forms.Button();
            this.btnszin = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnmentes = new System.Windows.Forms.Button();
            this.btnbeolvas = new System.Windows.Forms.Button();
            this.lbxforras = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Szöveg";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtszoveg
            // 
            this.txtszoveg.Location = new System.Drawing.Point(173, 51);
            this.txtszoveg.Name = "txtszoveg";
            this.txtszoveg.Size = new System.Drawing.Size(375, 29);
            this.txtszoveg.TabIndex = 1;
            this.txtszoveg.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblszavak
            // 
            this.lblszavak.AutoSize = true;
            this.lblszavak.Location = new System.Drawing.Point(91, 168);
            this.lblszavak.Name = "lblszavak";
            this.lblszavak.Size = new System.Drawing.Size(141, 24);
            this.lblszavak.TabIndex = 2;
            this.lblszavak.Text = "Szavak Száma: ";
            // 
            // lblkarakter
            // 
            this.lblkarakter.AutoSize = true;
            this.lblkarakter.Location = new System.Drawing.Point(91, 131);
            this.lblkarakter.Name = "lblkarakter";
            this.lblkarakter.Size = new System.Drawing.Size(165, 24);
            this.lblkarakter.TabIndex = 3;
            this.lblkarakter.Text = "Karakterek Száma:";
            this.lblkarakter.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblnagybetuk
            // 
            this.lblnagybetuk.AutoSize = true;
            this.lblnagybetuk.Location = new System.Drawing.Point(91, 207);
            this.lblnagybetuk.Name = "lblnagybetuk";
            this.lblnagybetuk.Size = new System.Drawing.Size(174, 24);
            this.lblnagybetuk.TabIndex = 4;
            this.lblnagybetuk.Text = "Nagy betűk száma: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Magánhangzók:";
            // 
            // lblmaganhangzok
            // 
            this.lblmaganhangzok.AutoSize = true;
            this.lblmaganhangzok.Location = new System.Drawing.Point(242, 244);
            this.lblmaganhangzok.Name = "lblmaganhangzok";
            this.lblmaganhangzok.Size = new System.Drawing.Size(0, 24);
            this.lblmaganhangzok.TabIndex = 6;
            // 
            // lblnagybetuk2
            // 
            this.lblnagybetuk2.AutoSize = true;
            this.lblnagybetuk2.Location = new System.Drawing.Point(257, 207);
            this.lblnagybetuk2.Name = "lblnagybetuk2";
            this.lblnagybetuk2.Size = new System.Drawing.Size(0, 24);
            this.lblnagybetuk2.TabIndex = 7;
            // 
            // btnkilepes
            // 
            this.btnkilepes.Location = new System.Drawing.Point(659, 474);
            this.btnkilepes.Name = "btnkilepes";
            this.btnkilepes.Size = new System.Drawing.Size(113, 55);
            this.btnkilepes.TabIndex = 8;
            this.btnkilepes.Text = "Kilépés";
            this.btnkilepes.UseVisualStyleBackColor = true;
            this.btnkilepes.Click += new System.EventHandler(this.btnkilepes_Click);
            // 
            // lblbetutipus
            // 
            this.lblbetutipus.AutoSize = true;
            this.lblbetutipus.Location = new System.Drawing.Point(91, 285);
            this.lblbetutipus.Name = "lblbetutipus";
            this.lblbetutipus.Size = new System.Drawing.Size(97, 24);
            this.lblbetutipus.TabIndex = 9;
            this.lblbetutipus.Text = "Betű típus:";
            // 
            // lblbetustilus
            // 
            this.lblbetustilus.AutoSize = true;
            this.lblbetustilus.Location = new System.Drawing.Point(91, 324);
            this.lblbetustilus.Name = "lblbetustilus";
            this.lblbetustilus.Size = new System.Drawing.Size(99, 24);
            this.lblbetustilus.TabIndex = 10;
            this.lblbetustilus.Text = "Betű stílus:";
            // 
            // lblbetumeret
            // 
            this.lblbetumeret.AutoSize = true;
            this.lblbetumeret.Location = new System.Drawing.Point(91, 364);
            this.lblbetumeret.Name = "lblbetumeret";
            this.lblbetumeret.Size = new System.Drawing.Size(106, 24);
            this.lblbetumeret.TabIndex = 11;
            this.lblbetumeret.Text = "Betű Méret:";
            // 
            // btnfont
            // 
            this.btnfont.Location = new System.Drawing.Point(74, 474);
            this.btnfont.Name = "btnfont";
            this.btnfont.Size = new System.Drawing.Size(125, 51);
            this.btnfont.TabIndex = 12;
            this.btnfont.Text = "Font";
            this.btnfont.UseVisualStyleBackColor = true;
            this.btnfont.Click += new System.EventHandler(this.btnfont_Click);
            // 
            // btnszin
            // 
            this.btnszin.Location = new System.Drawing.Point(205, 474);
            this.btnszin.Name = "btnszin";
            this.btnszin.Size = new System.Drawing.Size(125, 51);
            this.btnszin.TabIndex = 13;
            this.btnszin.Text = "Szín";
            this.btnszin.UseVisualStyleBackColor = true;
            this.btnszin.Click += new System.EventHandler(this.btnszin_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnmentes
            // 
            this.btnmentes.Location = new System.Drawing.Point(336, 474);
            this.btnmentes.Name = "btnmentes";
            this.btnmentes.Size = new System.Drawing.Size(125, 51);
            this.btnmentes.TabIndex = 14;
            this.btnmentes.Text = "Mentés";
            this.btnmentes.UseVisualStyleBackColor = true;
            this.btnmentes.Click += new System.EventHandler(this.btnmentes_Click);
            // 
            // btnbeolvas
            // 
            this.btnbeolvas.Location = new System.Drawing.Point(467, 474);
            this.btnbeolvas.Name = "btnbeolvas";
            this.btnbeolvas.Size = new System.Drawing.Size(125, 51);
            this.btnbeolvas.TabIndex = 15;
            this.btnbeolvas.Text = "Beolvasás";
            this.btnbeolvas.UseVisualStyleBackColor = true;
            this.btnbeolvas.Click += new System.EventHandler(this.btnbeolvas_Click);
            // 
            // lbxforras
            // 
            this.lbxforras.FormattingEnabled = true;
            this.lbxforras.ItemHeight = 24;
            this.lbxforras.Location = new System.Drawing.Point(482, 131);
            this.lbxforras.Name = "lbxforras";
            this.lbxforras.Size = new System.Drawing.Size(266, 244);
            this.lbxforras.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lbxforras);
            this.Controls.Add(this.btnbeolvas);
            this.Controls.Add(this.btnmentes);
            this.Controls.Add(this.btnszin);
            this.Controls.Add(this.btnfont);
            this.Controls.Add(this.lblbetumeret);
            this.Controls.Add(this.lblbetustilus);
            this.Controls.Add(this.lblbetutipus);
            this.Controls.Add(this.btnkilepes);
            this.Controls.Add(this.lblnagybetuk2);
            this.Controls.Add(this.lblmaganhangzok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblnagybetuk);
            this.Controls.Add(this.lblkarakter);
            this.Controls.Add(this.lblszavak);
            this.Controls.Add(this.txtszoveg);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Szöveg Kezelés";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtszoveg;
        private System.Windows.Forms.Label lblszavak;
        private System.Windows.Forms.Label lblkarakter;
        private System.Windows.Forms.Label lblnagybetuk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblmaganhangzok;
        private System.Windows.Forms.Label lblnagybetuk2;
        private System.Windows.Forms.Button btnkilepes;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label lblbetutipus;
        private System.Windows.Forms.Label lblbetustilus;
        private System.Windows.Forms.Label lblbetumeret;
        private System.Windows.Forms.Button btnfont;
        private System.Windows.Forms.Button btnszin;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnmentes;
        private System.Windows.Forms.Button btnbeolvas;
        private System.Windows.Forms.ListBox lbxforras;
    }
}

