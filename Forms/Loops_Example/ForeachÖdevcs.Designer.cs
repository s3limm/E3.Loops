namespace Againfocused
{
    partial class ForeachÖdevcs
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
            this.btnNewGame = new System.Windows.Forms.Button();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstEN
            // 
            this.lstEN.FormattingEnabled = true;
            this.lstEN.Location = new System.Drawing.Point(12, 12);
            this.lstEN.Name = "lstEN";
            this.lstEN.Size = new System.Drawing.Size(258, 420);
            this.lstEN.TabIndex = 0;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewGame.Location = new System.Drawing.Point(599, 370);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(189, 62);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "NewGame";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // txtGuess
            // 
            this.txtGuess.Enabled = false;
            this.txtGuess.Location = new System.Drawing.Point(353, 139);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(230, 20);
            this.txtGuess.TabIndex = 2;
            // 
            // btnGuess
            // 
            this.btnGuess.Enabled = false;
            this.btnGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuess.Location = new System.Drawing.Point(371, 192);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(189, 62);
            this.btnGuess.TabIndex = 1;
            this.btnGuess.Text = "Tahmin Et";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // ForeachÖdevcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lstEN);
            this.Name = "ForeachÖdevcs";
            this.Text = "ForeachÖdevcs";
            this.Load += new System.EventHandler(this.ForeachÖdevcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEN;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnGuess;
    }
}