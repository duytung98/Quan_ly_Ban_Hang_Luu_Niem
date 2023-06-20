namespace Quan_ly_Ban_Hang_Luu_Niem
{
    partial class F_Dangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Dangnhap));
            this.id_quenmk = new System.Windows.Forms.LinkLabel();
            this.id_hienthimk = new System.Windows.Forms.CheckBox();
            this.id_matkhau = new System.Windows.Forms.TextBox();
            this.id_taikhoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id_thoat = new System.Windows.Forms.Button();
            this.id_dangky = new System.Windows.Forms.Button();
            this.id_reset = new System.Windows.Forms.Button();
            this.id_dangnhap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // id_quenmk
            // 
            this.id_quenmk.AutoSize = true;
            this.id_quenmk.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_quenmk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.id_quenmk.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.id_quenmk.Location = new System.Drawing.Point(654, 307);
            this.id_quenmk.Name = "id_quenmk";
            this.id_quenmk.Size = new System.Drawing.Size(120, 20);
            this.id_quenmk.TabIndex = 7;
            this.id_quenmk.TabStop = true;
            this.id_quenmk.Text = "Quên mật khẩu";
            this.id_quenmk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.id_quenmk_LinkClicked);
            // 
            // id_hienthimk
            // 
            this.id_hienthimk.AutoSize = true;
            this.id_hienthimk.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_hienthimk.Location = new System.Drawing.Point(396, 307);
            this.id_hienthimk.Name = "id_hienthimk";
            this.id_hienthimk.Size = new System.Drawing.Size(160, 24);
            this.id_hienthimk.TabIndex = 6;
            this.id_hienthimk.Text = "Hiển thị mật khẩu";
            this.id_hienthimk.UseVisualStyleBackColor = true;
            this.id_hienthimk.CheckedChanged += new System.EventHandler(this.id_hienthimk_CheckedChanged);
            // 
            // id_matkhau
            // 
            this.id_matkhau.Location = new System.Drawing.Point(467, 226);
            this.id_matkhau.Name = "id_matkhau";
            this.id_matkhau.PasswordChar = '*';
            this.id_matkhau.Size = new System.Drawing.Size(285, 30);
            this.id_matkhau.TabIndex = 15;
            // 
            // id_taikhoan
            // 
            this.id_taikhoan.Location = new System.Drawing.Point(467, 165);
            this.id_taikhoan.Name = "id_taikhoan";
            this.id_taikhoan.Size = new System.Drawing.Size(285, 30);
            this.id_taikhoan.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(305, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 45);
            this.label1.TabIndex = 11;
            this.label1.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // id_thoat
            // 
            this.id_thoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.id_thoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_thoat.Image = global::Quan_ly_Ban_Hang_Luu_Niem.Properties.Resources.close;
            this.id_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.id_thoat.Location = new System.Drawing.Point(737, 380);
            this.id_thoat.Name = "id_thoat";
            this.id_thoat.Size = new System.Drawing.Size(82, 36);
            this.id_thoat.TabIndex = 4;
            this.id_thoat.Text = "Thoát";
            this.id_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.id_thoat.UseVisualStyleBackColor = false;
            this.id_thoat.Click += new System.EventHandler(this.id_thoat_Click);
            // 
            // id_dangky
            // 
            this.id_dangky.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.id_dangky.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_dangky.Image = global::Quan_ly_Ban_Hang_Luu_Niem.Properties.Resources.đăng_ký;
            this.id_dangky.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.id_dangky.Location = new System.Drawing.Point(467, 380);
            this.id_dangky.Name = "id_dangky";
            this.id_dangky.Size = new System.Drawing.Size(106, 36);
            this.id_dangky.TabIndex = 2;
            this.id_dangky.Text = "Đăng ký";
            this.id_dangky.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.id_dangky.UseVisualStyleBackColor = false;
            this.id_dangky.Click += new System.EventHandler(this.id_dangky_Click);
            // 
            // id_reset
            // 
            this.id_reset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.id_reset.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_reset.Image = global::Quan_ly_Ban_Hang_Luu_Niem.Properties.Resources.reset;
            this.id_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.id_reset.Location = new System.Drawing.Point(609, 380);
            this.id_reset.Name = "id_reset";
            this.id_reset.Size = new System.Drawing.Size(90, 36);
            this.id_reset.TabIndex = 3;
            this.id_reset.Text = "Restart";
            this.id_reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.id_reset.UseVisualStyleBackColor = false;
            this.id_reset.Click += new System.EventHandler(this.id_reset_Click);
            // 
            // id_dangnhap
            // 
            this.id_dangnhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.id_dangnhap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_dangnhap.Image = global::Quan_ly_Ban_Hang_Luu_Niem.Properties.Resources.open;
            this.id_dangnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.id_dangnhap.Location = new System.Drawing.Point(304, 380);
            this.id_dangnhap.Name = "id_dangnhap";
            this.id_dangnhap.Size = new System.Drawing.Size(112, 36);
            this.id_dangnhap.TabIndex = 1;
            this.id_dangnhap.Text = "Đăng nhập";
            this.id_dangnhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.id_dangnhap.UseVisualStyleBackColor = false;
            this.id_dangnhap.Click += new System.EventHandler(this.id_dangnhap_Click);
            this.id_dangnhap.KeyUp += new System.Windows.Forms.KeyEventHandler(this.id_dangnhap_KeyUp);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Image = global::Quan_ly_Ban_Hang_Luu_Niem.Properties.Resources.padlock1;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(346, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mật khẩu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Image = global::Quan_ly_Ban_Hang_Luu_Niem.Properties.Resources.user1;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(346, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tài khoản";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // F_Dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 496);
            this.Controls.Add(this.id_thoat);
            this.Controls.Add(this.id_dangky);
            this.Controls.Add(this.id_reset);
            this.Controls.Add(this.id_dangnhap);
            this.Controls.Add(this.id_quenmk);
            this.Controls.Add(this.id_hienthimk);
            this.Controls.Add(this.id_matkhau);
            this.Controls.Add(this.id_taikhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Dangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập hệ thống";
            this.Load += new System.EventHandler(this.F_Dangnhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button id_thoat;
        private System.Windows.Forms.Button id_dangky;
        private System.Windows.Forms.Button id_reset;
        private System.Windows.Forms.Button id_dangnhap;
        private System.Windows.Forms.LinkLabel id_quenmk;
        private System.Windows.Forms.CheckBox id_hienthimk;
        private System.Windows.Forms.TextBox id_matkhau;
        private System.Windows.Forms.TextBox id_taikhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}