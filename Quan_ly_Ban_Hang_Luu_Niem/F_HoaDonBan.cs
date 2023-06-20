using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_Ban_Hang_Luu_Niem
{
    public partial class F_HoaDonBan : Form
    {
        SqlCommand command;
        SqlConnection connection;
        string str = @"Data Source=.;Initial Catalog=Quan_Ly_Ban_Hang;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select T_HoaDonBan.MaHDban as N'Mã hóa đơn',T_NhanVien.MaNhanVien as N'Mã nhân viên',TenNv as N'Tên nhân viên',NgayBan as N'Ngày Bán',T_KhachHang.MaKhach as N'Mã khách',TenKhach as N'Tên Khách' from T_HoaDonBan,T_NhanVien,T_KhachHang where T_NhanVien.MaNhanVien =T_HoaDonBan.MaNhanVien and T_HoaDonBan.MaKhach = T_KhachHang.MaKhach";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_HoaDonBan.DataSource = table;
     
            
        }
        public F_HoaDonBan()
        {
            InitializeComponent();
            
            cb_makhach.Text = "";
            txt_mahoadon.Focus();

        }

        private void F_HoaDonBan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quan_Ly_Ban_HangDataSet6.T_KhachHang' table. You can move, or remove it, as needed.
            this.t_KhachHangTableAdapter1.Fill(this.quan_Ly_Ban_HangDataSet6.T_KhachHang);
            // TODO: This line of code loads data into the 'quan_Ly_Ban_HangDataSet3.T_NhanVien' table. You can move, or remove it, as needed.
            this.t_NhanVienTableAdapter1.Fill(this.quan_Ly_Ban_HangDataSet3.T_NhanVien);

            dgv_HoaDonBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
            clear_form();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_mahoadon.Text == ""||cb_makhach.Text == ""||cb_manhanvien.Text==""||id_ngayban.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin,vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            else
            {
                string strdup = "select count(MaHDBan) from T_HoaDonBan where MaHDBan = '" + txt_mahoadon.Text + "'";
                command = new SqlCommand(strdup, connection);
                var dup = Convert.ToInt32(command.ExecuteScalar());
                if (dup != 0)
                {
                    MessageBox.Show("Mã" + txt_mahoadon.Text + "đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_mahoadon.Text = "";
                }
                else
                {
                    command = connection.CreateCommand();
                    command.CommandText = "insert into T_HoaDonBan values('" + txt_mahoadon.Text + "','" + cb_manhanvien.Text + "','"+id_ngayban.Text+"','"+cb_makhach.Text+"')";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công", "thông báo", MessageBoxButtons.OK);
                    loaddata();
                    clear_form();
                }
                
            }
        }
        public void clear_form()
        {
            
            cb_manhanvien.Text = "";
            cb_makhach.Text = "";
            txt_tenkhach.Text = "";
            txt_tennhanvien.Text = "";
            txt_mahoadon.Focus();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_mahoadon.Text == "" )
            {
                MessageBox.Show("Chưa nhập mã hóa đơn để sửa,vui lòng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                command = connection.CreateCommand();
                command.CommandText = "update T_HoaDonBan set MaNhanVien = '"+cb_manhanvien.Text+"',NgayBan = '"+id_ngayban.Text+"',MaKhach = '"+cb_makhach.Text+"' where MaHDBan = '"+txt_mahoadon.Text+"'";
                command.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công", "thông báo", MessageBoxButtons.OK);
                loaddata();
                clear_form();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_mahoadon.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã chất liệu để xóa", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                command = connection.CreateCommand();
                command.CommandText = "Delete From T_HoaDonBan where MaHDBan = '" + txt_mahoadon.Text + "'";
                DialogResult kq = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    loaddata();
                    clear_form();
                }
            }
        }

        private void dgv_HoaDonBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_HoaDonBan.CurrentRow.Index;
            txt_mahoadon.Text = dgv_HoaDonBan.Rows[i].Cells[0].Value.ToString();
            cb_manhanvien.Text = dgv_HoaDonBan.Rows[i].Cells[1].Value.ToString();
            txt_tennhanvien.Text = dgv_HoaDonBan.Rows[i].Cells[2].Value.ToString();
            id_ngayban.Text = dgv_HoaDonBan.Rows[i].Cells[3].Value.ToString();
            cb_makhach.Text = dgv_HoaDonBan.Rows[i].Cells[4].Value.ToString();
            txt_tenkhach.Text = dgv_HoaDonBan.Rows[i].Cells[5].Value.ToString();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn đóng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (txt_timkiem.Text != "")
            {


                string sqlsearch = "select MaHDban as N'Mã hóa đơn',T_NhanVien.MaNhanVien as N'Mã nhân viên',TenNv as N'Tên nhân viên',NgayBan as N'Ngày Bán',T_KhachHang.MaKhach as N'Mã khách',TenKhach as N'Tên Khách' from T_HoaDonBan,T_NhanVien,T_KhachHang where T_NhanVien.MaNhanVien =T_HoaDonBan.MaNhanVien and T_HoaDonBan.MaKhach = T_KhachHang.MaKhach and MaHDBan like '%"+txt_timkiem.Text+"%'";
                SqlCommand cmd = new SqlCommand(sqlsearch, connection);
                cmd.Parameters.AddWithValue("MaHDban", txt_timkiem.Text);
                cmd.Parameters.AddWithValue("MaNhanVien", txt_timkiem.Text);
                cmd.Parameters.AddWithValue("TenNv", txt_timkiem.Text);
                cmd.Parameters.AddWithValue("NgayBan", txt_timkiem.Text);
                cmd.Parameters.AddWithValue("MaKhach", txt_timkiem.Text);
                cmd.Parameters.AddWithValue("TenKhach", txt_timkiem.Text);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgv_HoaDonBan.DataSource = dt;
                txt_timkiem.Text = "";
            }
            else
            {
                F_HoaDonBan_Load(sender, e);
            }
        }

        private void cb_manhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string inten = "select TenNv from T_NhanVien where MaNhanVien = N'" + cb_manhanvien.Text + "'";
            command = new SqlCommand(inten, connection);
            var dup = Convert.ToString(command.ExecuteScalar());
            txt_tennhanvien.Text = dup;
        }

        private void cb_makhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string inkh = "select TenKhach from T_KhachHang where MaKhach = N'" + cb_makhach.Text + "'";
            command = new SqlCommand(inkh, connection);
            var dup1 = Convert.ToString(command.ExecuteScalar());
            txt_tenkhach.Text = dup1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
