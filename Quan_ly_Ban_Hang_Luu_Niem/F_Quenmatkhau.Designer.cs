namespace Quan_ly_Ban_Hang_Luu_Niem
{
    partial class F_Quenmatkhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Quenmatkhau));
            this.id_ketqua2 = new System.Windows.Forms.Label();
            this.id_ketqua1 = new System.Windows.Forms.Label();
            this.btn_laymk = new System.Windows.Forms.Button();
            this.id_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_ketqua2
            // 
            this.id_ketqua2.AutoSize = true;
            this.id_ketqua2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_ketqua2.Location = new System.Drawing.Point(358, 424);
            this.id_ketqua2.Name = "id_ketqua2";
            this.id_ketqua2.Size = new System.Drawing.Size(99, 26);
            this.id_ketqua2.TabIndex = 13;
            this.id_ketqua2.Text = "Mật khẩu";
            // 
            // id_ketqua1
            // 
            this.id_ketqua1.AutoSize = true;
            this.id_ketqua1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_ketqua1.Location = new System.Drawing.Point(358, 380);
            this.id_ketqua1.Name = "id_ketqua1";
            this.id_ketqua1.Size = new System.Drawing.Size(106, 26);
            this.id_ketqua1.TabIndex = 12;
            this.id_ketqua1.Text = "Tài khoản";
            // 
            // btn_laymk
            // 
            this.btn_laymk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_laymk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_laymk.Location = new System.Drawing.Point(479, 469);
            this.btn_laymk.Name = "btn_laymk";
            this.btn_laymk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_laymk.Size = new System.Drawing.Size(187, 46);
            this.btn_laymk.TabIndex = 1;
            this.btn_laymk.Text = "Lấy lại mật khẩu";
            this.btn_laymk.UseVisualStyleBackColor = false;
            this.btn_laymk.Click += new System.EventHandler(this.btn_laymk_Click);
            // 
            // id_email
            // 
            this.id_email.Location = new System.Drawing.Point(465, 318);
            this.id_email.Name = "id_email";
            this.id_email.Size = new System.Drawing.Size(272, 30);
            this.id_email.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Email";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(419, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // F_Quenmatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.id_ketqua2);
            this.Controls.Add(this.id_ketqua1);
            this.Controls.Add(this.btn_laymk);
            this.Controls.Add(this.id_email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "F_Quenmatkhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.F_Quenmatkhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id_ketqua2;
        private System.Windows.Forms.Label id_ketqua1;
        private System.Windows.Forms.Button btn_laymk;
        private System.Windows.Forms.TextBox id_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}