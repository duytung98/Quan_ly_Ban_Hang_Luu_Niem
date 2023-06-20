namespace Quan_ly_Ban_Hang_Luu_Niem
{
    partial class F_HoaDonBan
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_HoaDonBan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_mahoadon = new System.Windows.Forms.TextBox();
            this.txt_tennhanvien = new System.Windows.Forms.TextBox();
            this.cb_manhanvien = new System.Windows.Forms.ComboBox();
            this.tNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanHangDataSet6 = new Quan_ly_Ban_Hang_Luu_Niem.QuanLyBanHangDataSet6();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_tenkhach = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.id_ngayban = new System.Windows.Forms.DateTimePicker();
            this.cb_makhach = new System.Windows.Forms.ComboBox();
            this.tKhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanHangDataSet7 = new Quan_ly_Ban_Hang_Luu_Niem.QuanLyBanHangDataSet7();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dgv_HoaDonBan = new System.Windows.Forms.DataGridView();
            this.t_NhanVienTableAdapter = new Quan_ly_Ban_Hang_Luu_Niem.QuanLyBanHangDataSet6TableAdapters.T_NhanVienTableAdapter();
            this.t_KhachHangTableAdapter = new Quan_ly_Ban_Hang_Luu_Niem.QuanLyBanHangDataSet7TableAdapters.T_KhachHangTableAdapter();
            this.quan_Ly_Ban_HangDataSet3 = new Quan_ly_Ban_Hang_Luu_Niem.Quan_Ly_Ban_HangDataSet3();
            this.tNhanVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.t_NhanVienTableAdapter1 = new Quan_ly_Ban_Hang_Luu_Niem.Quan_Ly_Ban_HangDataSet3TableAdapters.T_NhanVienTableAdapter();
            this.quan_Ly_Ban_HangDataSet6 = new Quan_ly_Ban_Hang_Luu_Niem.Quan_Ly_Ban_HangDataSet6();
            this.tKhachHangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.t_KhachHangTableAdapter1 = new Quan_ly_Ban_Hang_Luu_Niem.Quan_Ly_Ban_HangDataSet6TableAdapters.T_KhachHangTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet6)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tKhachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet7)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDonBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quan_Ly_Ban_HangDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNhanVienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quan_Ly_Ban_HangDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKhachHangBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 64);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(418, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(39, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(39, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(39, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên nhân viên";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(365, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã khách";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(365, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tên khách";
            // 
            // txt_mahoadon
            // 
            this.txt_mahoadon.Location = new System.Drawing.Point(182, 41);
            this.txt_mahoadon.Name = "txt_mahoadon";
            this.txt_mahoadon.Size = new System.Drawing.Size(138, 30);
            this.txt_mahoadon.TabIndex = 7;
            // 
            // txt_tennhanvien
            // 
            this.txt_tennhanvien.Location = new System.Drawing.Point(182, 123);
            this.txt_tennhanvien.Name = "txt_tennhanvien";
            this.txt_tennhanvien.ReadOnly = true;
            this.txt_tennhanvien.Size = new System.Drawing.Size(138, 30);
            this.txt_tennhanvien.TabIndex = 0;
            // 
            // cb_manhanvien
            // 
            this.cb_manhanvien.DataSource = this.tNhanVienBindingSource1;
            this.cb_manhanvien.DisplayMember = "MaNhanVien";
            this.cb_manhanvien.FormattingEnabled = true;
            this.cb_manhanvien.Location = new System.Drawing.Point(182, 82);
            this.cb_manhanvien.Name = "cb_manhanvien";
            this.cb_manhanvien.Size = new System.Drawing.Size(138, 33);
            this.cb_manhanvien.TabIndex = 8;
            this.cb_manhanvien.SelectedIndexChanged += new System.EventHandler(this.cb_manhanvien_SelectedIndexChanged);
            // 
            // tNhanVienBindingSource
            // 
            this.tNhanVienBindingSource.DataMember = "T_NhanVien";
            this.tNhanVienBindingSource.DataSource = this.quanLyBanHangDataSet6;
            // 
            // quanLyBanHangDataSet6
            // 
            this.quanLyBanHangDataSet6.DataSetName = "QuanLyBanHangDataSet6";
            this.quanLyBanHangDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_timkiem.Location = new System.Drawing.Point(752, 123);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(151, 30);
            this.txt_timkiem.TabIndex = 0;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.BackColor = System.Drawing.Color.Silver;
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Image = global::Quan_ly_Ban_Hang_Luu_Niem.Properties.Resources.search16;
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Search.Location = new System.Drawing.Point(926, 122);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(104, 35);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Text = "Search";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(365, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Ngày bán";
            // 
            // txt_tenkhach
            // 
            this.txt_tenkhach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_tenkhach.Location = new System.Drawing.Point(509, 123);
            this.txt_tenkhach.Name = "txt_tenkhach";
            this.txt_tenkhach.ReadOnly = true;
            this.txt_tenkhach.Size = new System.Drawing.Size(138, 30);
            this.txt_tenkhach.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.id_ngayban);
            this.groupBox1.Controls.Add(this.cb_makhach);
            this.groupBox1.Controls.Add(this.txt_tenkhach);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.txt_timkiem);
            this.groupBox1.Controls.Add(this.cb_manhanvien);
            this.groupBox1.Controls.Add(this.txt_tennhanvien);
            this.groupBox1.Controls.Add(this.txt_mahoadon);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1066, 163);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hàng hóa";
            // 
            // id_ngayban
            // 
            this.id_ngayban.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.id_ngayban.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.id_ngayban.Location = new System.Drawing.Point(509, 39);
            this.id_ngayban.Name = "id_ngayban";
            this.id_ngayban.Size = new System.Drawing.Size(138, 30);
            this.id_ngayban.TabIndex = 9;
            // 
            // cb_makhach
            // 
            this.cb_makhach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_makhach.DataSource = this.tKhachHangBindingSource1;
            this.cb_makhach.DisplayMember = "MaKhach";
            this.cb_makhach.FormattingEnabled = true;
            this.cb_makhach.Location = new System.Drawing.Point(509, 82);
            this.cb_makhach.Name = "cb_makhach";
            this.cb_makhach.Size = new System.Drawing.Size(138, 33);
            this.cb_makhach.TabIndex = 10;
            this.cb_makhach.SelectedIndexChanged += new System.EventHandler(this.cb_makhach_SelectedIndexChanged);
            // 
            // tKhachHangBindingSource
            // 
            this.tKhachHangBindingSource.DataMember = "T_KhachHang";
            this.tKhachHangBindingSource.DataSource = this.quanLyBanHangDataSet7;
            // 
            // quanLyBanHangDataSet7
            // 
            this.quanLyBanHangDataSet7.DataSetName = "QuanLyBanHangDataSet7";
            this.quanLyBanHangDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Dong);
            this.panel2.Controls.Add(this.btn_xoa);
            this.panel2.Controls.Add(this.btn_Sua);
            this.panel2.Controls.Add(this.btn_Them);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 474);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1066, 80);
            this.panel2.TabIndex = 2;
            // 
            // btn_Dong
            // 
            this.btn_Dong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Dong.BackColor = System.Drawing.Color.Silver;
            this.btn_Dong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dong.Image = global::Quan_ly_Ban_Hang_Luu_Niem.Properties.Resources.close_hover;
            this.btn_Dong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dong.Location = new System.Drawing.Point(815, 20);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(110, 38);
            this.btn_Dong.TabIndex = 3;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Dong.UseVisualStyleBackColor = false;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_xoa.BackColor = System.Drawing.Color.Silver;
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Image = global::Quan_ly_Ban_Hang_Luu_Niem.Properties.Resources._346114245_773042190893931_3953372100401773050_n;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(597, 20);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(91, 38);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Sua.BackColor = System.Drawing.Color.Silver;
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Image = global::Quan_ly_Ban_Hang_Luu_Niem.Properties.Resources._346102494_1635312940270040_6122453276413198084_n;
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(379, 20);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(85, 38);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Them.BackColor = System.Drawing.Color.Silver;
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Image = global::Quan_ly_Ban_Hang_Luu_Niem.Properties.Resources.add16;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(155, 20);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(98, 38);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dgv_HoaDonBan
            // 
            this.dgv_HoaDonBan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_HoaDonBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HoaDonBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_HoaDonBan.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_HoaDonBan.Location = new System.Drawing.Point(0, 227);
            this.dgv_HoaDonBan.Name = "dgv_HoaDonBan";
            this.dgv_HoaDonBan.RowHeadersWidth = 51;
            this.dgv_HoaDonBan.RowTemplate.Height = 24;
            this.dgv_HoaDonBan.Size = new System.Drawing.Size(1066, 247);
            this.dgv_HoaDonBan.TabIndex = 3;
            this.dgv_HoaDonBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HoaDonBan_CellContentClick);
            // 
            // t_NhanVienTableAdapter
            // 
            this.t_NhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // t_KhachHangTableAdapter
            // 
            this.t_KhachHangTableAdapter.ClearBeforeFill = true;
            // 
            // quan_Ly_Ban_HangDataSet3
            // 
            this.quan_Ly_Ban_HangDataSet3.DataSetName = "Quan_Ly_Ban_HangDataSet3";
            this.quan_Ly_Ban_HangDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tNhanVienBindingSource1
            // 
            this.tNhanVienBindingSource1.DataMember = "T_NhanVien";
            this.tNhanVienBindingSource1.DataSource = this.quan_Ly_Ban_HangDataSet3;
            // 
            // t_NhanVienTableAdapter1
            // 
            this.t_NhanVienTableAdapter1.ClearBeforeFill = true;
            // 
            // quan_Ly_Ban_HangDataSet6
            // 
            this.quan_Ly_Ban_HangDataSet6.DataSetName = "Quan_Ly_Ban_HangDataSet6";
            this.quan_Ly_Ban_HangDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tKhachHangBindingSource1
            // 
            this.tKhachHangBindingSource1.DataMember = "T_KhachHang";
            this.tKhachHangBindingSource1.DataSource = this.quan_Ly_Ban_HangDataSet6;
            // 
            // t_KhachHangTableAdapter1
            // 
            this.t_KhachHangTableAdapter1.ClearBeforeFill = true;
            // 
            // F_HoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 554);
            this.Controls.Add(this.dgv_HoaDonBan);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "F_HoaDonBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn bán";
            this.Load += new System.EventHandler(this.F_HoaDonBan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet6)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tKhachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet7)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDonBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quan_Ly_Ban_HangDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNhanVienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quan_Ly_Ban_HangDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKhachHangBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_mahoadon;
        private System.Windows.Forms.TextBox txt_tennhanvien;
        private System.Windows.Forms.ComboBox cb_manhanvien;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_tenkhach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker id_ngayban;
        private System.Windows.Forms.ComboBox cb_makhach;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView dgv_HoaDonBan;
        private QuanLyBanHangDataSet6 quanLyBanHangDataSet6;
        private System.Windows.Forms.BindingSource tNhanVienBindingSource;
        private QuanLyBanHangDataSet6TableAdapters.T_NhanVienTableAdapter t_NhanVienTableAdapter;
        private QuanLyBanHangDataSet7 quanLyBanHangDataSet7;
        private System.Windows.Forms.BindingSource tKhachHangBindingSource;
        private QuanLyBanHangDataSet7TableAdapters.T_KhachHangTableAdapter t_KhachHangTableAdapter;
        private Quan_Ly_Ban_HangDataSet3 quan_Ly_Ban_HangDataSet3;
        private System.Windows.Forms.BindingSource tNhanVienBindingSource1;
        private Quan_Ly_Ban_HangDataSet3TableAdapters.T_NhanVienTableAdapter t_NhanVienTableAdapter1;
        private Quan_Ly_Ban_HangDataSet6 quan_Ly_Ban_HangDataSet6;
        private System.Windows.Forms.BindingSource tKhachHangBindingSource1;
        private Quan_Ly_Ban_HangDataSet6TableAdapters.T_KhachHangTableAdapter t_KhachHangTableAdapter1;
    }
}