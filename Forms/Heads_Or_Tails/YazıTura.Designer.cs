namespace Againfocused
{
    partial class YazıTura
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
            this.btnENGuess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnENGuess
            // 
            this.btnENGuess.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnENGuess.Location = new System.Drawing.Point(251, 279);
            this.btnENGuess.Name = "btnENGuess";
            this.btnENGuess.Size = new System.Drawing.Size(288, 111);
            this.btnENGuess.TabIndex = 0;
            this.btnENGuess.Text = "Tahmin Et";
            this.btnENGuess.UseVisualStyleBackColor = true;
            this.btnENGuess.Click += new System.EventHandler(this.btnENGuess_Click);
            // 
            // YazıTura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnENGuess);
            this.Name = "YazıTura";
            this.Text = "YazıTura";
            this.Load += new System.EventHandler(this.YazıTura_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnENGuess;
    }
}