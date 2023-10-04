namespace DemoUI
{
    partial class MainForm
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
            this.playSoundBtn = new System.Windows.Forms.Button();
            this.openSecFormBtn = new System.Windows.Forms.Button();
            this.readTextBtn = new System.Windows.Forms.Button();
            this.openThrdFormBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playSoundBtn
            // 
            this.playSoundBtn.Location = new System.Drawing.Point(48, 66);
            this.playSoundBtn.Name = "playSoundBtn";
            this.playSoundBtn.Size = new System.Drawing.Size(563, 70);
            this.playSoundBtn.TabIndex = 0;
            this.playSoundBtn.Text = "Hayvan Sesi Çıkar";
            this.playSoundBtn.UseVisualStyleBackColor = true;
            this.playSoundBtn.Click += new System.EventHandler(this.playSoundBtn_Click);
            // 
            // openSecFormBtn
            // 
            this.openSecFormBtn.Location = new System.Drawing.Point(48, 149);
            this.openSecFormBtn.Name = "openSecFormBtn";
            this.openSecFormBtn.Size = new System.Drawing.Size(563, 83);
            this.openSecFormBtn.TabIndex = 1;
            this.openSecFormBtn.Text = "İkincil Formu Aç";
            this.openSecFormBtn.UseVisualStyleBackColor = true;
            this.openSecFormBtn.Click += new System.EventHandler(this.openSecFormBtn_Click);
            // 
            // readTextBtn
            // 
            this.readTextBtn.Location = new System.Drawing.Point(48, 244);
            this.readTextBtn.Name = "readTextBtn";
            this.readTextBtn.Size = new System.Drawing.Size(563, 81);
            this.readTextBtn.TabIndex = 2;
            this.readTextBtn.Text = "Yazıyı Oku";
            this.readTextBtn.UseVisualStyleBackColor = true;
            this.readTextBtn.Click += new System.EventHandler(this.readTextBtn_Click);
            // 
            // openThrdFormBtn
            // 
            this.openThrdFormBtn.Location = new System.Drawing.Point(48, 340);
            this.openThrdFormBtn.Name = "openThrdFormBtn";
            this.openThrdFormBtn.Size = new System.Drawing.Size(563, 87);
            this.openThrdFormBtn.TabIndex = 3;
            this.openThrdFormBtn.Text = "Üçüncül Formu Aç";
            this.openThrdFormBtn.UseVisualStyleBackColor = true;
            this.openThrdFormBtn.Click += new System.EventHandler(this.openThrdFormBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 461);
            this.Controls.Add(this.openThrdFormBtn);
            this.Controls.Add(this.readTextBtn);
            this.Controls.Add(this.openSecFormBtn);
            this.Controls.Add(this.playSoundBtn);
            this.Name = "MainForm";
            this.Text = "Ana Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playSoundBtn;
        private System.Windows.Forms.Button openSecFormBtn;
        private System.Windows.Forms.Button readTextBtn;
        private System.Windows.Forms.Button openThrdFormBtn;
    }
}

