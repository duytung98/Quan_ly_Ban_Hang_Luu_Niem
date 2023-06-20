using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_Ban_Hang_Luu_Niem
{
    public partial class F_main : Form
    {
        public F_main()
        {
            InitializeComponent();
        }

       

        private void menu_dangxuat_Click(object sender, EventArgs e)
        {
            F_Dangnhap f_DangNhap = new F_Dangnhap();

            DialogResult kq = MessageBox.Show("Bạn có muốn đăng xuất", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                this.Hide();
                
                f_DangNhap.ShowDialog();
                f_DangNhap = null;
                this.Show();

            }
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_KhachHang f_KhachHang = new F_KhachHang();
            f_KhachHang.ShowDialog();

        }

        private void chấtLiệuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            F_Chatlieu f_Chatlieu = new F_Chatlieu();
            f_Chatlieu.ShowDialog();
            
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_HangHoa f_HangHoa = new F_HangHoa();
            f_HangHoa.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
        }

        private void menu_tikhoan_Click(object sender, EventArgs e)
        {
            
            F_Dangky f_Dangky = new F_Dangky();
            f_Dangky.ShowDialog();
            
        }

        private void MenuNhanVien_Click(object sender, EventArgs e)
        {
            F_NhanVien f_NhanVien = new F_NhanVien();
            f_NhanVien.ShowDialog();
            
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn chắc chắn muốn thoát??","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if(kq == DialogResult.Yes)
            {
                Close();
            }
        }

        private void menu_HDBan_Click(object sender, EventArgs e)
        {
            
            F_HoaDonBan f_HoaDonBan = new F_HoaDonBan();
            f_HoaDonBan.ShowDialog();
            
            
        }

        private void hóaĐơnBánChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_HoaDon f_HoaDon = new F_HoaDon();
            f_HoaDon.ShowDialog();
            f_HoaDon = null;
            this.Show();
        }

        private void menu_TkNV_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_Thongketheonhanvien f_Thongketheonhanvien = new F_Thongketheonhanvien();
            f_Thongketheonhanvien.ShowDialog();
            f_Thongketheonhanvien = null;
            this.Show();
        }

        private void menu_TKDH_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_Thongketheodonhang f_Thongketheodonhang = new F_Thongketheodonhang();
            f_Thongketheodonhang.ShowDialog();
            f_Thongketheodonhang=null;
            this.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
