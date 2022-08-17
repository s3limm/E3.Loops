namespace Againfocused
{
    partial class MetodsExample
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
            this.btnENArttır = new System.Windows.Forms.Button();
            this.btnEnEksilt = new System.Windows.Forms.Button();
            this.lblEN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnENArttır
            // 
            this.btnENArttır.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnENArttır.Location = new System.Drawing.Point(137, 236);
            this.btnENArttır.Name = "btnENArttır";
            this.btnENArttır.Size = new System.Drawing.Size(216, 50);
            this.btnENArttır.TabIndex = 0;
            this.btnENArttır.Text = "+";
            this.btnENArttır.UseVisualStyleBackColor = true;
            this.btnENArttır.Click += new System.EventHandler(this.btnENArttır_Click);
            // 
            // btnEnEksilt
            // 
            this.btnEnEksilt.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnEksilt.Location = new System.Drawing.Point(466, 236);
            this.btnEnEksilt.Name = "btnEnEksilt";
            this.btnEnEksilt.Size = new System.Drawing.Size(216, 50);
            this.btnEnEksilt.TabIndex = 0;
            this.btnEnEksilt.Text = "-";
            this.btnEnEksilt.UseVisualStyleBackColor = true;
            this.btnEnEksilt.Click += new System.EventHandler(this.btnEnEksilt_Click);
            // 
            // lblEN
            // 
            this.lblEN.AutoSize = true;
            this.lblEN.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEN.Location = new System.Drawing.Point(375, 81);
            this.lblEN.Name = "lblEN";
            this.lblEN.Size = new System.Drawing.Size(0, 37);
            this.lblEN.TabIndex = 1;
            // 
            // MetodsExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEN);
            this.Controls.Add(this.btnEnEksilt);
            this.Controls.Add(this.btnENArttır);
            this.Name = "MetodsExample";
            this.Text = "MetodsExample";
            this.Load += new System.EventHandler(this.MetodsExample_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnENArttır;
        private System.Windows.Forms.Button btnEnEksilt;
        private System.Windows.Forms.Label lblEN;
    }
}