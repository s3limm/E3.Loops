namespace Againfocused
{
    partial class doWhıle
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
            this.txtbEN = new System.Windows.Forms.TextBox();
            this.btnEN = new System.Windows.Forms.Button();
            this.lblEN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbEN
            // 
            this.txtbEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbEN.Location = new System.Drawing.Point(77, 94);
            this.txtbEN.Name = "txtbEN";
            this.txtbEN.Size = new System.Drawing.Size(172, 38);
            this.txtbEN.TabIndex = 0;
            // 
            // btnEN
            // 
            this.btnEN.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEN.Location = new System.Drawing.Point(77, 193);
            this.btnEN.Name = "btnEN";
            this.btnEN.Size = new System.Drawing.Size(172, 74);
            this.btnEN.TabIndex = 1;
            this.btnEN.Text = "Kontrol Et";
            this.btnEN.UseVisualStyleBackColor = true;
            this.btnEN.Click += new System.EventHandler(this.btnEN_Click);
            // 
            // lblEN
            // 
            this.lblEN.AutoSize = true;
            this.lblEN.Location = new System.Drawing.Point(386, 94);
            this.lblEN.Name = "lblEN";
            this.lblEN.Size = new System.Drawing.Size(0, 13);
            this.lblEN.TabIndex = 2;
           
            // 
            // doWhıle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEN);
            this.Controls.Add(this.btnEN);
            this.Controls.Add(this.txtbEN);
            this.Name = "doWhıle";
            this.Text = "doWhıle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbEN;
        private System.Windows.Forms.Button btnEN;
        private System.Windows.Forms.Label lblEN;
    }
}