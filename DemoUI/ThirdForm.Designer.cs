namespace DemoUI
{
    partial class ThirdForm
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
            this.readTextBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // readTextBtn
            // 
            this.readTextBtn.Location = new System.Drawing.Point(23, 35);
            this.readTextBtn.Name = "readTextBtn";
            this.readTextBtn.Size = new System.Drawing.Size(895, 96);
            this.readTextBtn.TabIndex = 0;
            this.readTextBtn.Text = "Yazıyı Oku";
            this.readTextBtn.UseVisualStyleBackColor = true;
            this.readTextBtn.Click += new System.EventHandler(this.readTextBtn_Click);
            // 
            // ThirdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 168);
            this.Controls.Add(this.readTextBtn);
            this.Name = "ThirdForm";
            this.Text = "ThirdForm";
            this.Load += new System.EventHandler(this.ThirdForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button readTextBtn;
    }
}