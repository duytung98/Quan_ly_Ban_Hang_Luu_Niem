using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quan_ly_Ban_Hang_Luu_Niem
{
    public partial class F_Thongketheonhanvien : Form
    {
        SqlCommand command;
        SqlConnection connection;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string str = @"Data Source=.;Initial Catalog=Quan_Ly_Ban_Hang;Integrated Security=True";
        void loaddata()
        {

            command = connection.CreateCommand();
            command.CommandText = "select T_HoaDonBan.MaHDBan as N'Mã hóa đơn bán',NgayBan as N'Ngày bán',T_ChiTietHDBan.MaHang as N'Mã hàng',TenHang as N'Tên hàng',T_ChiTietHDBan.SoLuong as N'Số lượng',DonGiaBan as N'Đơn giá bán',GiamGia as N'Giảm giá',(T_ChiTietHDBan.SoLuong*DonGiaBan - T_ChiTietHDBan.SoLuong*DonGiaBan*GiamGia/100) as N'Thành tiền' from T_ChiTietHDBan,T_HoaDonBan,T_HangHoa,T_NhanVien where T_ChiTietHDBan.MaHDBan = T_HoaDonBan.MaHDBan and T_HoaDonBan.MaNhanVien = T_NhanVien.MaNhanVien and T_ChiTietHDBan.MaHang = T_HangHoa.MaHang and T_HoaDonBan.MaNhanVien = '" + cb_mnv.Text+"'";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_nhanvien.DataSource = table;
        }

        public F_Thongketheonhanvien()
        {
            InitializeComponent();
        }

        private void F_Thongketheonhanvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quan_Ly_Ban_HangDataSet5.T_NhanVien' table. You can move, or remove it, as needed.
            this.t_NhanVienTableAdapter1.Fill(this.quan_Ly_Ban_HangDataSet5.T_NhanVien);
            
            dgv_nhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
            cb_mnv_SelectedIndexChanged(sender, e);
            
        }

        private void cb_mnv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mnv = "select TenNV from T_NhanVien where MaNhanVien = '"+cb_mnv.Text+"'";
            command = new SqlCommand(mnv,connection);
            var dup = Convert.ToString(command.ExecuteScalar());
            txt_tennv.Text = dup;
            string gt = "select GioiTinh from T_NhanVien where MaNhanVien = '" + cb_mnv.Text + "'";
            command = new SqlCommand(gt, connection);
            var dup1 = Convert.ToString(command.ExecuteScalar());
            txt_gt.Text = dup1;
            string ns = "select NgaySinh from T_NhanVien where MaNhanVien = '" + cb_mnv.Text + "'";
            command = new SqlCommand(ns, connection);
            var dup2 = Convert.ToString(command.ExecuteScalar());
            txt_nsinh.Text = dup2;
            string dc = "select DiaChi from T_NhanVien where MaNhanVien = '" + cb_mnv.Text + "'";
            command = new SqlCommand(dc, connection);
            var dup3 = Convert.ToString(command.ExecuteScalar());
            txt_diachi.Text = dup3;
            string dt = "select Dienthoai from T_NhanVien where MaNhanVien = '" + cb_mnv.Text + "'";
            command = new SqlCommand(dt, connection);
            var dup4 = Convert.ToString(command.ExecuteScalar());
            txt_dienthoai.Text = dup4;
            string tt = "select sum(T_ChiTietHDBan.SoLuong*DonGiaBan - T_ChiTietHDBan.SoLuong*DonGiaBan*GiamGia/100) from T_ChiTietHDBan,T_HoaDonBan,T_HangHoa,T_NhanVien where T_ChiTietHDBan.MaHDBan = T_HoaDonBan.MaHDBan and T_HoaDonBan.MaNhanVien = T_NhanVien.MaNhanVien and T_ChiTietHDBan.MaHang = T_HangHoa.MaHang and T_HoaDonBan.MaNhanVien = '"+cb_mnv.Text+"' group by (T_HoaDonBan.MaNhanVien)";
            command = new SqlCommand(tt, connection);
            var dup5 = Convert.ToString(command.ExecuteScalar());
            txt_tongtien.Text = dup5;
            loaddata();
        }
        void loaddata1()
        {

            command = connection.CreateCommand();
            command.CommandText = "select T_HoaDonBan.MaHDBan as N'Mã hóa đơn bán',NgayBan as N'Ngày bán',T_ChiTietHDBan.MaHang as N'Mã hàng',TenHang as N'Tên hàng',T_ChiTietHDBan.SoLuong as N'Số lượng',DonGiaBan as N'Đơn giá bán',GiamGia as N'Giảm giá',(T_ChiTietHDBan.SoLuong*DonGiaBan - T_ChiTietHDBan.SoLuong*DonGiaBan*GiamGia/100) as N'Thành tiền' from T_ChiTietHDBan,T_HoaDonBan,T_HangHoa,T_NhanVien where T_ChiTietHDBan.MaHDBan = T_HoaDonBan.MaHDBan and T_HoaDonBan.MaNhanVien = T_NhanVien.MaNhanVien and T_ChiTietHDBan.MaHang = T_HangHoa.MaHang and T_HoaDonBan.MaNhanVien = '" + cb_mnv.Text + "' and NgayBan = '"+id_ngayban.Text+"'";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_nhanvien.DataSource = table;
        }

        private void cb_tkngb_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_tkngb.Checked == true)
            {
                dgv_nhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                connection = new SqlConnection(str);
                connection.Open();
                loaddata1();
                string tt = "select sum(T_ChiTietHDBan.SoLuong*DonGiaBan - T_ChiTietHDBan.SoLuong*DonGiaBan*GiamGia/100) from T_ChiTietHDBan,T_HoaDonBan,T_HangHoa,T_NhanVien where T_ChiTietHDBan.MaHDBan = T_HoaDonBan.MaHDBan and T_HoaDonBan.MaNhanVien = T_NhanVien.MaNhanVien and T_ChiTietHDBan.MaHang = T_HangHoa.MaHang and T_HoaDonBan.MaNhanVien = '" + cb_mnv.Text + " ' and NgayBan = '"+id_ngayban.Text+"' group by (T_HoaDonBan.MaNhanVien)";
                command = new SqlCommand(tt, connection);
                var dup5 = Convert.ToString(command.ExecuteScalar());
                txt_tongtien.Text = dup5;  
            }
            else
            {
                loaddata();
                cb_mnv_SelectedIndexChanged(sender, e);
            }
        }
       
        private void dgv_nhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
