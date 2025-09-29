
namespace _20230904
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_kilep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_kilep
            // 
            this.btn_kilep.BackColor = System.Drawing.Color.Transparent;
            this.btn_kilep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_kilep.Location = new System.Drawing.Point(451, 412);
            this.btn_kilep.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_kilep.Name = "btn_kilep";
            this.btn_kilep.Size = new System.Drawing.Size(243, 87);
            this.btn_kilep.TabIndex = 0;
            this.btn_kilep.Text = "Kilépés";
            this.btn_kilep.UseVisualStyleBackColor = false;
            this.btn_kilep.Click += new System.EventHandler(this.btn_kilep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1149, 550);
            this.Controls.Add(this.btn_kilep);
            this.Font = new System.Drawing.Font("Wide Latin", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.Name = "Form1";
            this.Text = "Gyakorlás";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_kilep;
    }
}

