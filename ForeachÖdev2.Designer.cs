namespace Againfocused
{
    partial class ForeachÖdev2
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
            this.txtCheck = new System.Windows.Forms.TextBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lstEN = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtCheck
            // 
            this.txtCheck.Enabled = false;
            this.txtCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCheck.Location = new System.Drawing.Point(337, 118);
            this.txtCheck.Name = "txtCheck";
            this.txtCheck.Size = new System.Drawing.Size(186, 29);
            this.txtCheck.TabIndex = 0;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(602, 371);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(186, 67);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "Yeni Oyun";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Enabled = false;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(337, 181);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(186, 67);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Kontrol Et";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lstEN
            // 
            this.lstEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstEN.FormattingEnabled = true;
            this.lstEN.ItemHeight = 18;
            this.lstEN.Location = new System.Drawing.Point(12, 12);
            this.lstEN.Name = "lstEN";
            this.lstEN.Size = new System.Drawing.Size(284, 418);
            this.lstEN.TabIndex = 2;
            // 
            // ForeachÖdev2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstEN);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.txtCheck);
            this.Name = "ForeachÖdev2";
            this.Text = "ForeachÖdev2";
            this.Load += new System.EventHandler(this.ForeachÖdev2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCheck;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.ListBox lstEN;
    }
}