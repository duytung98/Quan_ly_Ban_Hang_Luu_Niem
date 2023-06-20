namespace Quan_ly_Ban_Hang_Luu_Niem
{
    partial class F_Thongketheodonhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Thongketheodonhang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.cb_mahoadon = new System.Windows.Forms.ComboBox();
            this.tHoaDonBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanHangDataSet10 = new Quan_ly_Ban_Hang_Luu_Niem.QuanLyBanHangDataSet10();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_tkdh = new System.Windows.Forms.DataGridView();
            this.t_HoaDonBanTableAdapter = new Quan_ly_Ban_Hang_Luu_Niem.QuanLyBanHangDataSet10TableAdapters.T_HoaDonBanTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quan_Ly_Ban_HangDataSet4 = new Quan_ly_Ban_Hang_Luu_Niem.Quan_Ly_Ban_HangDataSet4();
            this.tHoaDonBanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.t_HoaDonBanTableAdapter1 = new Quan_ly_Ban_Hang_Luu_Niem.Quan_Ly_Ban_HangDataSet4TableAdapters.T_HoaDonBanTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tHoaDonBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tkdh)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quan_Ly_Ban_HangDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHoaDonBanBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 60);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(292, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(591, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ THEO ĐƠN HÀNG";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.txt_timkiem);
            this.panel2.Controls.Add(this.cb_mahoadon);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 73);
            this.panel2.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_search.Image = global::Quan_ly_Ban_Hang_Luu_Niem.Properties.Resources.search_interface_symbol1;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Location = new System.Drawing.Point(929, 22);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 36);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Search";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_timkiem.Location = new System.Drawing.Point(728, 26);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(195, 30);
            this.txt_timkiem.TabIndex = 2;
            // 
            // cb_mahoadon
            // 
            this.cb_mahoadon.DataSource = this.tHoaDonBanBindingSource1;
            this.cb_mahoadon.DisplayMember = "MaHDBan";
            this.cb_mahoadon.FormattingEnabled = true;
            this.cb_mahoadon.Location = new System.Drawing.Point(140, 30);
            this.cb_mahoadon.Name = "cb_mahoadon";
            this.cb_mahoadon.Size = new System.Drawing.Size(155, 30);
            this.cb_mahoadon.TabIndex = 1;
            this.cb_mahoadon.SelectedIndexChanged += new System.EventHandler(this.cb_mahoadon_SelectedIndexChanged);
            // 
            // tHoaDonBanBindingSource
            // 
            this.tHoaDonBanBindingSource.DataMember = "T_HoaDonBan";
            this.tHoaDonBanBindingSource.DataSource = this.quanLyBanHangDataSet10;
            // 
            // quanLyBanHangDataSet10
            // 
            this.quanLyBanHangDataSet10.DataSetName = "QuanLyBanHangDataSet10";
            this.quanLyBanHangDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn";
            // 
            // dgv_tkdh
            // 
            this.dgv_tkdh.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_tkdh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tkdh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_tkdh.Location = new System.Drawing.Point(0, 133);
            this.dgv_tkdh.Name = "dgv_tkdh";
            this.dgv_tkdh.RowHeadersWidth = 51;
            this.dgv_tkdh.RowTemplate.Height = 24;
            this.dgv_tkdh.Size = new System.Drawing.Size(1100, 486);
            this.dgv_tkdh.TabIndex = 2;
            // 
            // t_HoaDonBanTableAdapter
            // 
            this.t_HoaDonBanTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.txt_tongtien);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 547);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1100, 72);
            this.panel3.TabIndex = 3;
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tongtien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongtien.Location = new System.Drawing.Point(814, 19);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.ReadOnly = true;
            this.txt_tongtien.Size = new System.Drawing.Size(215, 34);
            this.txt_tongtien.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(724, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng tiền";
            // 
            // quan_Ly_Ban_HangDataSet4
            // 
            this.quan_Ly_Ban_HangDataSet4.DataSetName = "Quan_Ly_Ban_HangDataSet4";
            this.quan_Ly_Ban_HangDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tHoaDonBanBindingSource1
            // 
            this.tHoaDonBanBindingSource1.DataMember = "T_HoaDonBan";
            this.tHoaDonBanBindingSource1.DataSource = this.quan_Ly_Ban_HangDataSet4;
            // 
            // t_HoaDonBanTableAdapter1
            // 
            this.t_HoaDonBanTableAdapter1.ClearBeforeFill = true;
            // 
            // F_Thongketheodonhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgv_tkdh);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "F_Thongketheodonhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê thao đơn hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_Thongketheodonhang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tHoaDonBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tkdh)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quan_Ly_Ban_HangDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHoaDonBanBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.ComboBox cb_mahoadon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_tkdh;
        private QuanLyBanHangDataSet10 quanLyBanHangDataSet10;
        private System.Windows.Forms.BindingSource tHoaDonBanBindingSource;
        private QuanLyBanHangDataSet10TableAdapters.T_HoaDonBanTableAdapter t_HoaDonBanTableAdapter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Label label3;
        private Quan_Ly_Ban_HangDataSet4 quan_Ly_Ban_HangDataSet4;
        private System.Windows.Forms.BindingSource tHoaDonBanBindingSource1;
        private Quan_Ly_Ban_HangDataSet4TableAdapters.T_HoaDonBanTableAdapter t_HoaDonBanTableAdapter1;
    }
}