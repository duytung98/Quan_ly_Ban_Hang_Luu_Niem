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
    public partial class F_KhachHang : Form
    {
        SqlCommand command;
        string str = @"Data Source=.;Initial Catalog=Quan_Ly_Ban_Hang;Integrated Security=True";
        SqlConnection connection;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select MaKhach as N'Mã khách',TenKhach as N'Tên khách',GioiTinh as N'Giới tính',NgaySinh as N'Ngày Sinh',DiaChi as N'Địa chỉ',DienThoai as N'Điện thoại' from T_KhachHang";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dvg_khachhang.DataSource = table;
        }
        public F_KhachHang()
        {
            InitializeComponent();
        }
        public void clear_form()
        {
            txt_makhach.Text = "";
            txt_tenkhach.Text = "";
            cb_gioitinh.Text = "";
            id_ngaysinh.Text = "";
            txt_diachi.Text = "";
            txt_dienthoai.Text = "";
            txt_makhach.Focus();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            double a;
            
            if(txt_makhach.Text == ""||txt_tenkhach.Text == ""||cb_gioitinh.Text == "" || txt_diachi.Text == "" || txt_dienthoai.Text == "")
            {
                MessageBox.Show("vui lòng nhập đủ thông tin","Thông báo",MessageBoxButtons.OK);
            }
            else if (!double.TryParse(this.txt_dienthoai.Text, out a))
            {
                MessageBox.Show("Điện thoại phải là số!!", "Thông báo", MessageBoxButtons.OK);

            }
            else
            {
                command = connection.CreateCommand();
                command.CommandText = "insert into T_KhachHang values ('"+txt_makhach.Text+"',N'"+txt_tenkhach.Text+"',N'"+cb_gioitinh.Text+"','"+id_ngaysinh.Text+"',N'"+txt_diachi.Text+"','"+txt_dienthoai.Text+"')";
                command.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                loaddata();
                clear_form();
            }
        }

        private void F_KhachHang_Load(object sender, EventArgs e)
        {
            dvg_khachhang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dvg_khachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dvg_khachhang.CurrentRow.Index;
            txt_makhach.Text = dvg_khachhang.Rows[i].Cells[0].Value.ToString();
            txt_tenkhach.Text = dvg_khachhang.Rows[i].Cells[1].Value.ToString();
            cb_gioitinh.Text = dvg_khachhang.Rows[i].Cells[2].Value.ToString();
            id_ngaysinh.Text = dvg_khachhang.Rows[i].Cells[3].Value.ToString();
            txt_diachi.Text = dvg_khachhang.Rows[i].Cells[4].Value.ToString();
            txt_dienthoai.Text = dvg_khachhang.Rows[i].Cells[5].Value.ToString();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            double a;
            if (!double.TryParse(this.txt_dienthoai.Text, out a))
            {
                MessageBox.Show("Điện thoại phải là số!!", "Thông báo", MessageBoxButtons.OK);

            }
            else if (txt_makhach.Text == "" || txt_tenkhach.Text == "" || cb_gioitinh.Text == "" 
                || txt_diachi.Text == "" || txt_dienthoai.Text == "")
            {
                MessageBox.Show("vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                command = connection.CreateCommand();
                command.CommandText = "update T_KhachHang set TenKhach = N'"+txt_tenkhach.Text+"',GioiTinh = N'"+cb_gioitinh.Text+"',NgaySinh = '"+id_ngaysinh.Text+"',DiaChi = N'"+txt_diachi.Text+"',DienThoai = '"+txt_dienthoai.Text+"' where MaKhach = '"+txt_makhach.Text+"'";
                command.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                loaddata();
                clear_form();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "Delete from T_KhachHang where MaKhach = '" + txt_makhach.Text + "'";
            DialogResult kq = MessageBox.Show("Bạn chắc chắn muốn xóa??","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                command.ExecuteNonQuery() ;
                MessageBox.Show("Xóa thành công!!", "Thông báo", MessageBoxButtons.OK);
                loaddata() ;
                clear_form();
            }

        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if(txt_timkiem.Text != "")
            {
                string sqlsearch = "select MaKhach as N'Mã khách',TenKhach as N'Tên khách',GioiTinh as N'Giới tính',NgaySinh as N'Ngày Sinh',DiaChi as N'Địa chỉ',DienThoai as N'Điện thoại' from T_KhachHang where MaKhach like '%"+txt_timkiem.Text+"%'or TenKhach like N'%"+txt_timkiem.Text+"%'";
                SqlCommand cmd = new SqlCommand(sqlsearch,connection);
                cmd.Parameters.AddWithValue("MaKhach", txt_timkiem.Text);
                cmd.Parameters.AddWithValue("TenKhach", txt_timkiem.Text);
                cmd.Parameters.AddWithValue("GioiTinh", txt_timkiem.Text);
                cmd.Parameters.AddWithValue("NgaySinh", txt_timkiem.Text);
                cmd.Parameters.AddWithValue("DiaChi",txt_timkiem.Text);
                cmd.Parameters.AddWithValue("DienThoai",txt_timkiem.Text);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dvg_khachhang.DataSource = dt;
                txt_timkiem.Text = "";
            }
            else
            {
                F_KhachHang_Load(sender, e);
            }
        }
    }
}
