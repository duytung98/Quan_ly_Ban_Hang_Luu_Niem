namespace Quan_ly_Ban_Hang_Luu_Niem
{
    partial class F_Thongketheonhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Thongketheonhanvien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_nsinh = new System.Windows.Forms.DateTimePicker();
            this.txt_dienthoai = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_gt = new System.Windows.Forms.TextBox();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.cb_mnv = new System.Windows.Forms.ComboBox();
            this.tNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanHangDataSet9 = new Quan_ly_Ban_Hang_Luu_Niem.QuanLyBanHangDataSet9();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.id_ngayban = new System.Windows.Forms.DateTimePicker();
            this.cb_tkngb = new System.Windows.Forms.CheckBox();
            this.dgv_nhanvien = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.t_NhanVienTableAdapter = new Quan_ly_Ban_Hang_Luu_Niem.QuanLyBanHangDataSet9TableAdapters.T_NhanVienTableAdapter();
            this.quan_Ly_Ban_HangDataSet5 = new Quan_ly_Ban_Hang_Luu_Niem.Quan_Ly_Ban_HangDataSet5();
            this.tNhanVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.t_NhanVienTableAdapter1 = new Quan_ly_Ban_Hang_Luu_Niem.Quan_Ly_Ban_HangDataSet5TableAdapters.T_NhanVienTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet9)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quan_Ly_Ban_HangDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNhanVienBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 65);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(366, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ THEO NHÂN VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txt_nsinh);
            this.groupBox1.Controls.Add(this.txt_dienthoai);
            this.groupBox1.Controls.Add(this.txt_diachi);
            this.groupBox1.Controls.Add(this.txt_gt);
            this.groupBox1.Controls.Add(this.txt_tennv);
            this.groupBox1.Controls.Add(this.cb_mnv);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1100, 147);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // txt_nsinh
            // 
            this.txt_nsinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nsinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_nsinh.Location = new System.Drawing.Point(496, 93);
            this.txt_nsinh.Name = "txt_nsinh";
            this.txt_nsinh.Size = new System.Drawing.Size(149, 30);
            this.txt_nsinh.TabIndex = 12;
            // 
            // txt_dienthoai
            // 
            this.txt_dienthoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_dienthoai.Location = new System.Drawing.Point(860, 96);
            this.txt_dienthoai.Name = "txt_dienthoai";
            this.txt_dienthoai.ReadOnly = true;
            this.txt_dienthoai.Size = new System.Drawing.Size(194, 30);
            this.txt_dienthoai.TabIndex = 11;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_diachi.Location = new System.Drawing.Point(860, 46);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.ReadOnly = true;
            this.txt_diachi.Size = new System.Drawing.Size(194, 30);
            this.txt_diachi.TabIndex = 10;
            // 
            // txt_gt
            // 
            this.txt_gt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_gt.Location = new System.Drawing.Point(496, 46);
            this.txt_gt.Name = "txt_gt";
            this.txt_gt.ReadOnly = true;
            this.txt_gt.Size = new System.Drawing.Size(149, 30);
            this.txt_gt.TabIndex = 8;
            // 
            // txt_tennv
            // 
            this.txt_tennv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_tennv.Location = new System.Drawing.Point(188, 96);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.ReadOnly = true;
            this.txt_tennv.Size = new System.Drawing.Size(149, 30);
            this.txt_tennv.TabIndex = 7;
            // 
            // cb_mnv
            // 
            this.cb_mnv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_mnv.DataSource = this.tNhanVienBindingSource1;
            this.cb_mnv.DisplayMember = "MaNhanVien";
            this.cb_mnv.FormattingEnabled = true;
            this.cb_mnv.Location = new System.Drawing.Point(188, 46);
            this.cb_mnv.Name = "cb_mnv";
            this.cb_mnv.Size = new System.Drawing.Size(149, 30);
            this.cb_mnv.TabIndex = 6;
            this.cb_mnv.SelectedIndexChanged += new System.EventHandler(this.cb_mnv_SelectedIndexChanged);
            // 
            // tNhanVienBindingSource
            // 
            this.tNhanVienBindingSource.DataMember = "T_NhanVien";
            this.tNhanVienBindingSource.DataSource = this.quanLyBanHangDataSet9;
            // 
            // quanLyBanHangDataSet9
            // 
            this.quanLyBanHangDataSet9.DataSetName = "QuanLyBanHangDataSet9";
            this.quanLyBanHangDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(751, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 22);
            this.label8.TabIndex = 5;
            this.label8.Text = "Điện thoại";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(751, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 22);
            this.label7.TabIndex = 4;
            this.label7.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(402, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã nhân viên";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.Controls.Add(this.id_ngayban);
            this.panel2.Controls.Add(this.cb_tkngb);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 212);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 54);
            this.panel2.TabIndex = 2;
            // 
            // id_ngayban
            // 
            this.id_ngayban.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.id_ngayban.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.id_ngayban.Location = new System.Drawing.Point(825, 12);
            this.id_ngayban.Name = "id_ngayban";
            this.id_ngayban.Size = new System.Drawing.Size(149, 30);
            this.id_ngayban.TabIndex = 13;
            // 
            // cb_tkngb
            // 
            this.cb_tkngb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_tkngb.AutoSize = true;
            this.cb_tkngb.Location = new System.Drawing.Point(603, 13);
            this.cb_tkngb.Name = "cb_tkngb";
            this.cb_tkngb.Size = new System.Drawing.Size(216, 26);
            this.cb_tkngb.TabIndex = 0;
            this.cb_tkngb.Text = "Thống kê theo ngày bán";
            this.cb_tkngb.UseVisualStyleBackColor = true;
            this.cb_tkngb.CheckedChanged += new System.EventHandler(this.cb_tkngb_CheckedChanged);
            // 
            // dgv_nhanvien
            // 
            this.dgv_nhanvien.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_nhanvien.Location = new System.Drawing.Point(0, 266);
            this.dgv_nhanvien.Name = "dgv_nhanvien";
            this.dgv_nhanvien.RowHeadersWidth = 51;
            this.dgv_nhanvien.RowTemplate.Height = 24;
            this.dgv_nhanvien.Size = new System.Drawing.Size(1100, 353);
            this.dgv_nhanvien.TabIndex = 3;
            this.dgv_nhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nhanvien_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.txt_tongtien);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 568);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1100, 51);
            this.panel3.TabIndex = 4;
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tongtien.Location = new System.Drawing.Point(810, 11);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.ReadOnly = true;
            this.txt_tongtien.Size = new System.Drawing.Size(225, 30);
            this.txt_tongtien.TabIndex = 1;
            this.txt_tongtien.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(641, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng tiền bán được";
            // 
            // t_NhanVienTableAdapter
            // 
            this.t_NhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // quan_Ly_Ban_HangDataSet5
            // 
            this.quan_Ly_Ban_HangDataSet5.DataSetName = "Quan_Ly_Ban_HangDataSet5";
            this.quan_Ly_Ban_HangDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tNhanVienBindingSource1
            // 
            this.tNhanVienBindingSource1.DataMember = "T_NhanVien";
            this.tNhanVienBindingSource1.DataSource = this.quan_Ly_Ban_HangDataSet5;
            // 
            // t_NhanVienTableAdapter1
            // 
            this.t_NhanVienTableAdapter1.ClearBeforeFill = true;
            // 
            // F_Thongketheonhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgv_nhanvien);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "F_Thongketheonhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê theo nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_Thongketheonhanvien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet9)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quan_Ly_Ban_HangDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNhanVienBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_nhanvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.ComboBox cb_mnv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_dienthoai;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_gt;
        private System.Windows.Forms.TextBox txt_tennv;
        private System.Windows.Forms.DateTimePicker txt_nsinh;
        private System.Windows.Forms.DateTimePicker id_ngayban;
        private System.Windows.Forms.CheckBox cb_tkngb;
        private QuanLyBanHangDataSet9 quanLyBanHangDataSet9;
        private System.Windows.Forms.BindingSource tNhanVienBindingSource;
        private QuanLyBanHangDataSet9TableAdapters.T_NhanVienTableAdapter t_NhanVienTableAdapter;
        private Quan_Ly_Ban_HangDataSet5 quan_Ly_Ban_HangDataSet5;
        private System.Windows.Forms.BindingSource tNhanVienBindingSource1;
        private Quan_Ly_Ban_HangDataSet5TableAdapters.T_NhanVienTableAdapter t_NhanVienTableAdapter1;
    }
}