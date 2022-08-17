namespace Againfocused
{
    partial class PrintName
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
            this.lstEN = new System.Windows.Forms.ListBox();
            this.btnEN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstEN
            // 
            this.lstEN.FormattingEnabled = true;
            this.lstEN.Location = new System.Drawing.Point(12, 12);
            this.lstEN.Name = "lstEN";
            this.lstEN.Size = new System.Drawing.Size(316, 420);
            this.lstEN.TabIndex = 0;
            // 
            // btnEN
            // 
            this.btnEN.Font = new System.Drawing.Font("Microsoft Tai Le", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEN.Location = new System.Drawing.Point(455, 156);
            this.btnEN.Name = "btnEN";
            this.btnEN.Size = new System.Drawing.Size(180, 154);
            this.btnEN.TabIndex = 1;
            this.btnEN.Text = "Yazdır";
            this.btnEN.UseVisualStyleBackColor = true;
            this.btnEN.Click += new System.EventHandler(this.btnEN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEN);
            this.Controls.Add(this.lstEN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstEN;
        private System.Windows.Forms.Button btnEN;
    }
}

