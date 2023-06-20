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
    public partial class F_NhanVien : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string sql = @"Data Source=.;Initial Catalog=Quan_Ly_Ban_Hang;Integrated Security=True";
        DataTable table = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select MaNhanVien as N'Mã nhân viên',TenNv as N'Tên nhân viên',GioiTinh as N'Giới tính',NgaySinh as N'Ngày sinh',DiaChi as N'Địa chỉ',DienThoai as N'Điện thoại' from T_NhanVien";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dvg_nhanvien.DataSource = table;
        }
        public F_NhanVien()
        {
            InitializeComponent();
        }

        private void F_NhanVien_Load(object sender, EventArgs e)
        {
            dvg_nhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            connection = new SqlConnection(sql);
            connection.Open();
            loaddata();
        }
        public void clear_form()
        {
            txt_manhanvien.Text = "";
            txt_tennv.Text = "";
            txt_gioitinh.Text = "";
            txt_dienthoai.Text = "";
            txt_diachi.Text = "";
            id_ngaysinh.Text = "";
            txt_manhanvien.Focus();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            double a;
            if (txt_manhanvien.Text == "" || txt_tennv.Text == "" || txt_gioitinh.Text == "" || txt_dienthoai.Text == "" || txt_diachi.Text == "" || id_ngaysinh.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else if(!double.TryParse(this.txt_dienthoai.Text,out a))
            {
                MessageBox.Show("Điện thoại phải là số!!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                string strdup = "Select count(MaNhanVien) from T_NhanVien where MaNhanVien = '" + txt_manhanvien.Text + "'";
                command = new SqlCommand(strdup,connection);
                var dup = Convert.ToInt32(command.ExecuteScalar());
                if (dup > 0)
                {
                    MessageBox.Show("Mã " + txt_manhanvien.Text + " đã tồn tại. Vui lòng nhập mã khác", "Thông báo", MessageBoxButtons.OK);

                }else
                {

                    command = connection.CreateCommand();
                    command.CommandText = "insert into T_NhanVien values ('" + txt_manhanvien.Text + "',N'" + txt_tennv.Text + "',N'" + txt_gioitinh.Text + "','" + id_ngaysinh.Text + "',N'" + txt_diachi.Text + "',N'" + txt_dienthoai.Text + "')";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!!", "Thông báo", MessageBoxButtons.OK);
                    loaddata();
                    clear_form();
                }
            }
        }

        private void dvg_nhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dvg_nhanvien.CurrentRow.Index;
            txt_manhanvien.Text = dvg_nhanvien.Rows[i].Cells[0].Value.ToString();
            txt_tennv.Text = dvg_nhanvien.Rows[i].Cells[1].Value.ToString();
            txt_gioitinh.Text = dvg_nhanvien.Rows[i].Cells[2].Value.ToString();
            id_ngaysinh.Text = dvg_nhanvien.Rows[i].Cells[3].Value.ToString();
            txt_diachi.Text = dvg_nhanvien.Rows[i].Cells[4].Value.ToString();
            txt_dienthoai.Text = dvg_nhanvien.Rows[i].Cells[5].Value.ToString();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            double a;
            if (txt_manhanvien.Text == "" || txt_tennv.Text == "" || txt_gioitinh.Text == "" || txt_dienthoai.Text == "" || txt_diachi.Text == "" || id_ngaysinh.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else if (!double.TryParse(this.txt_dienthoai.Text, out a))
            {
                MessageBox.Show("Điện thoại phải là số!!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                command = connection.CreateCommand();
                command.CommandText = "update T_NhanVien set TenNV = N'" + txt_tennv.Text + "',GioiTinh = N'"+txt_gioitinh.Text+"',NgaySinh = '"+id_ngaysinh.Text+"',DiaChi = N'"+txt_diachi.Text+"',DienThoai = '"+txt_dienthoai.Text+"' where MaNhanVien = '"+txt_manhanvien.Text+"'";
                command.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!!", "Thông báo", MessageBoxButtons.OK);
                loaddata();
                clear_form();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from T_NhanVien where MaNhanVien = '"+txt_manhanvien.Text+"'";
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn xóa? ","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                command.ExecuteNonQuery() ;
                MessageBox.Show("Xóa thành công!!","Thông báo",MessageBoxButtons.OK);
                loaddata();
                clear_form() ;
            }
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn muốn thoát?","Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if(txt_timkiem.Text .Length > 0)
            {
                string search = "select MaNhanVien as N'Mã nhân viên',TenNv as N'Tên nhân viên',GioiTinh as N'Giới tính',NgaySinh as N'Ngày sinh',DiaChi as N'Địa chỉ',DienThoai as N'Điện thoại' from T_NhanVien where MaNhanVien like '%"+txt_timkiem.Text+"%' or TenNV like '%"+txt_timkiem.Text+"%'";
                SqlCommand cmd = new SqlCommand(search,connection);
                cmd.Parameters.AddWithValue("MaNhanVien", txt_timkiem.Text);
                cmd.Parameters.AddWithValue("TenNV", txt_timkiem.Text);
                cmd.Parameters.AddWithValue("GioiTinh", txt_timkiem.Text);
                cmd.Parameters.AddWithValue("NgaySinh", txt_timkiem.Text);
                cmd.Parameters.AddWithValue("DiaChi", txt_timkiem.Text);
                cmd.Parameters.AddWithValue("DienThoai", txt_timkiem.Text);
                cmd.ExecuteNonQuery();
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                dvg_nhanvien.DataSource = dt;
                txt_timkiem.Text = "";
            }
            else
            {
                F_NhanVien_Load(sender, e);
            }
        }
    }
}
