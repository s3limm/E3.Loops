namespace Againfocused
{
    partial class ForExample
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
            this.lstEn = new System.Windows.Forms.ListBox();
            this.lstYs = new System.Windows.Forms.ListBox();
            this.btnAktar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstEn
            // 
            this.lstEn.FormattingEnabled = true;
            this.lstEn.Location = new System.Drawing.Point(12, 12);
            this.lstEn.Name = "lstEn";
            this.lstEn.Size = new System.Drawing.Size(295, 407);
            this.lstEn.TabIndex = 0;
            // 
            // lstYs
            // 
            this.lstYs.FormattingEnabled = true;
            this.lstYs.Location = new System.Drawing.Point(466, 12);
            this.lstYs.Name = "lstYs";
            this.lstYs.Size = new System.Drawing.Size(295, 407);
            this.lstYs.TabIndex = 0;
            // 
            // btnAktar
            // 
            this.btnAktar.Location = new System.Drawing.Point(325, 188);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(117, 78);
            this.btnAktar.TabIndex = 1;
            this.btnAktar.Text = "button1";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // ForExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.lstYs);
            this.Controls.Add(this.lstEn);
            this.Name = "ForExample";
            this.Text = "ForExample";
            this.Load += new System.EventHandler(this.ForExample_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstEn;
        private System.Windows.Forms.ListBox lstYs;
        private System.Windows.Forms.Button btnAktar;
    }
}