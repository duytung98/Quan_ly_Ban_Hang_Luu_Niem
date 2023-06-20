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
    public partial class F_Thongketheodonhang : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string str = @"Data Source=.;Initial Catalog=Quan_Ly_Ban_Hang;Integrated Security=True";
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select T_ChiTietHDBan.MaHDBan as N'Mã hóa đơn',T_HangHoa.MaHang as N'Mã hàng',TenHang as N'Tên hàng',NgayBan as N'Ngày bán',T_ChiTietHDBan.SoLuong as N'Số lượng',DonGiaBan as N'Đơn giá',GiamGia as N'Giảm giá',(T_ChiTietHDBan.SoLuong*DonGiaBan - T_ChiTietHDBan.SoLuong*DonGiaBan*GiamGia/100) as N'Thành tiền' from T_ChiTietHDBan,T_HangHoa,T_HoaDonBan where T_ChiTietHDBan.MaHDBan = T_HoaDonBan.MaHDBan and T_ChiTietHDBan.MaHang = T_HangHoa.MaHang";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_tkdh.DataSource = table;
            string strdup1 = "select sum(T_ChiTietHDBan.SoLuong*DonGiaBan - T_ChiTietHDBan.SoLuong*DonGiaBan*GiamGia/100) from T_ChiTietHDBan,T_HangHoa where T_ChiTietHDBan.MaHang = T_HangHoa.MaHang";
            command = new SqlCommand(strdup1, connection);
            var dup = Convert.ToString(command.ExecuteScalar());
            txt_tongtien.Text = dup;
        }
        public F_Thongketheodonhang()
        {
            InitializeComponent();
        }

        private void F_Thongketheodonhang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quan_Ly_Ban_HangDataSet4.T_HoaDonBan' table. You can move, or remove it, as needed.
            this.t_HoaDonBanTableAdapter1.Fill(this.quan_Ly_Ban_HangDataSet4.T_HoaDonBan);

            dgv_tkdh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
            cb_mahoadon.Text = "";

        }
        void loaddata1()
        {
            command = connection.CreateCommand();
            command.CommandText = "select T_ChiTietHDBan.MaHDBan as N'Mã hóa đơn',T_HangHoa.MaHang as N'Mã hàng',TenHang as N'Tên hàng',NgayBan as N'Ngày bán',T_ChiTietHDBan.SoLuong as N'Số lượng',DonGiaBan as N'Đơn giá',GiamGia as N'Giảm giá',(T_ChiTietHDBan.SoLuong*DonGiaBan - T_ChiTietHDBan.SoLuong*DonGiaBan*GiamGia/100) as N'Thành tiền' from T_ChiTietHDBan,T_HangHoa,T_HoaDonBan where T_ChiTietHDBan.MaHDBan = T_HoaDonBan.MaHDBan and T_ChiTietHDBan.MaHang = T_HangHoa.MaHang and T_ChiTietHDBan.MaHDBan = '" + cb_mahoadon.Text+"'";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_tkdh.DataSource = table;
        }

        private void cb_mahoadon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_mahoadon.Text != "")
            {
                dgv_tkdh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                connection = new SqlConnection(str);
                connection.Open();
                string strdup1 = "select sum(T_ChiTietHDBan.SoLuong*DonGiaBan - T_ChiTietHDBan.SoLuong*DonGiaBan*GiamGia/100) from T_ChiTietHDBan,T_HangHoa where T_ChiTietHDBan.MaHang = T_HangHoa.MaHang and T_ChiTietHDBan.MaHDBan = '"+cb_mahoadon.Text+"'";
                command = new SqlCommand(strdup1, connection);
                var dup = Convert.ToString(command.ExecuteScalar());
                txt_tongtien.Text = dup;
                loaddata1();

                
            }
            else
            {
                
                
                loaddata();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dgv_tkdh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            connection = new SqlConnection(str);
            connection.Open();
            if (txt_timkiem.Text != "" && cb_mahoadon.Text != "")
            {
                command = connection.CreateCommand();
                command.CommandText = "select T_ChiTietHDBan.MaHDBan as N'Mã hóa đơn',T_HangHoa.MaHang as N'Mã hàng',TenHang as N'Tên hàng',NgayBan as N'Ngày bán',T_ChiTietHDBan.SoLuong as N'Số lượng',DonGiaBan as N'Đơn giá',GiamGia as N'Giảm giá',(T_ChiTietHDBan.SoLuong*DonGiaBan - T_ChiTietHDBan.SoLuong*DonGiaBan*GiamGia/100) as N'Thành tiền' from T_ChiTietHDBan,T_HangHoa,T_HoaDonBan where T_ChiTietHDBan.MaHDBan = T_HoaDonBan.MaHDBan and T_ChiTietHDBan.MaHang = T_HangHoa.MaHang and T_ChiTietHDBan.MaHDBan = '"+cb_mahoadon.Text+"'  and T_ChiTietHDBan.MaHang like '%" + txt_timkiem.Text+"%'";
                command.ExecuteNonQuery();
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgv_tkdh.DataSource = table;
                string strdup1 = "select sum(T_ChiTietHDBan.SoLuong*DonGiaBan - T_ChiTietHDBan.SoLuong*DonGiaBan*GiamGia/100) from T_ChiTietHDBan,T_HangHoa where T_ChiTietHDBan.MaHang = T_HangHoa.MaHang and T_ChiTietHDBan.MaHDBan = '"+cb_mahoadon.Text+"' and T_ChiTietHDBan.MaHang like '%" + txt_timkiem.Text+"%'";
                command = new SqlCommand(strdup1, connection);
                var dup = Convert.ToString(command.ExecuteScalar());
                txt_tongtien.Text = dup;
                txt_timkiem.Clear();
            }
            else if(txt_timkiem.Text !="" && cb_mahoadon.Text == "")
            {
                command = connection.CreateCommand();
                command.CommandText = "select T_ChiTietHDBan.MaHDBan as N'Mã hóa đơn',T_HangHoa.MaHang as N'Mã hàng',TenHang as N'Tên hàng',NgayBan as N'Ngày bán',T_ChiTietHDBan.SoLuong as N'Số lượng',DonGiaBan as N'Đơn giá',GiamGia as N'Giảm giá',(T_ChiTietHDBan.SoLuong*DonGiaBan - T_ChiTietHDBan.SoLuong*DonGiaBan*GiamGia/100) as N'Thành tiền' from T_ChiTietHDBan,T_HangHoa,T_HoaDonBan where T_ChiTietHDBan.MaHDBan = T_HoaDonBan.MaHDBan and T_ChiTietHDBan.MaHang = T_HangHoa.MaHang and T_ChiTietHDBan.MaHang like '%" + txt_timkiem.Text + "%'";
                command.ExecuteNonQuery();
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgv_tkdh.DataSource = table;
                string strdup1 = "select sum(T_ChiTietHDBan.SoLuong*DonGiaBan - T_ChiTietHDBan.SoLuong*DonGiaBan*GiamGia/100) from T_ChiTietHDBan,T_HangHoa where T_ChiTietHDBan.MaHang = T_HangHoa.MaHang and T_ChiTietHDBan.MaHang like '%" + txt_timkiem.Text + "%'";
                command = new SqlCommand(strdup1, connection);
                var dup = Convert.ToString(command.ExecuteScalar());
                txt_tongtien.Text = dup;
                txt_timkiem.Clear();
            }

            else
            {
                loaddata();
                cb_mahoadon.Text = "";
            }
        }
    }
}
