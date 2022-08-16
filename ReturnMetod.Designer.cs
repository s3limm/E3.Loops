namespace Againfocused
{
    partial class ReturnMetod
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
            this.btnGetName = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetName
            // 
            this.btnGetName.Location = new System.Drawing.Point(151, 194);
            this.btnGetName.Name = "btnGetName";
            this.btnGetName.Size = new System.Drawing.Size(134, 48);
            this.btnGetName.TabIndex = 0;
            this.btnGetName.Text = "Get Name";
            this.btnGetName.UseVisualStyleBackColor = true;
            this.btnGetName.Click += new System.EventHandler(this.btnGetName_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(476, 194);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(134, 48);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // ReturnMetod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnGetName);
            this.Name = "ReturnMetod";
            this.Text = "ReturnMetod";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetName;
        private System.Windows.Forms.Button btnCalculate;
    }
}