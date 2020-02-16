namespace GUI
{
    partial class fMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.bCrypt = new System.Windows.Forms.Button();
            this.tServer = new System.Windows.Forms.TextBox();
            this.tIcon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bSelectFile = new System.Windows.Forms.Button();
            this.bSelectIcon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bCrypt
            // 
            this.bCrypt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bCrypt.ForeColor = System.Drawing.Color.Lime;
            this.bCrypt.Location = new System.Drawing.Point(4, 67);
            this.bCrypt.Name = "bCrypt";
            this.bCrypt.Size = new System.Drawing.Size(415, 23);
            this.bCrypt.TabIndex = 0;
            this.bCrypt.Text = "Crypt";
            this.bCrypt.UseVisualStyleBackColor = false;
            this.bCrypt.Click += new System.EventHandler(this.bCrypt_Click);
            // 
            // tServer
            // 
            this.tServer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tServer.ForeColor = System.Drawing.Color.Lime;
            this.tServer.Location = new System.Drawing.Point(51, 13);
            this.tServer.Name = "tServer";
            this.tServer.Size = new System.Drawing.Size(326, 20);
            this.tServer.TabIndex = 1;
            // 
            // tIcon
            // 
            this.tIcon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tIcon.ForeColor = System.Drawing.Color.Lime;
            this.tIcon.Location = new System.Drawing.Point(51, 40);
            this.tIcon.Name = "tIcon";
            this.tIcon.Size = new System.Drawing.Size(326, 20);
            this.tIcon.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(1, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Server: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(1, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Icon: ";
            // 
            // bSelectFile
            // 
            this.bSelectFile.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bSelectFile.ForeColor = System.Drawing.Color.Lime;
            this.bSelectFile.Location = new System.Drawing.Point(383, 11);
            this.bSelectFile.Name = "bSelectFile";
            this.bSelectFile.Size = new System.Drawing.Size(36, 23);
            this.bSelectFile.TabIndex = 5;
            this.bSelectFile.Text = "...";
            this.bSelectFile.UseVisualStyleBackColor = false;
            this.bSelectFile.Click += new System.EventHandler(this.bSelectFile_Click);
            // 
            // bSelectIcon
            // 
            this.bSelectIcon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bSelectIcon.ForeColor = System.Drawing.Color.Lime;
            this.bSelectIcon.Location = new System.Drawing.Point(383, 38);
            this.bSelectIcon.Name = "bSelectIcon";
            this.bSelectIcon.Size = new System.Drawing.Size(36, 23);
            this.bSelectIcon.TabIndex = 6;
            this.bSelectIcon.Text = "...";
            this.bSelectIcon.UseVisualStyleBackColor = false;
            this.bSelectIcon.Click += new System.EventHandler(this.bSelectIcon_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(427, 99);
            this.Controls.Add(this.bSelectIcon);
            this.Controls.Add(this.bSelectFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tIcon);
            this.Controls.Add(this.tServer);
            this.Controls.Add(this.bCrypt);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(443, 138);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(443, 138);
            this.Name = "fMain";
            this.Text = "njCrypter by 0xPh0enix ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCrypt;
        private System.Windows.Forms.TextBox tServer;
        private System.Windows.Forms.TextBox tIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bSelectFile;
        private System.Windows.Forms.Button bSelectIcon;
    }
}

