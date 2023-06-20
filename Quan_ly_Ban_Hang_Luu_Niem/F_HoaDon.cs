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
using Excel = Microsoft.Office.Interop.Excel;





namespace Quan_ly_Ban_Hang_Luu_Niem
{
    public partial class F_HoaDon : Form
    {
        SqlCommand command;
        SqlConnection connection;
        string str = @"Data Source=.;Initial Catalog=Quan_Ly_Ban_Hang;Integrated Security=True";
        DataTable table = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter();
        void loaddata()
        {
         
            command =connection.CreateCommand();
            command.CommandText = "select T_ChiTietHDBan.MaHDBan as N'Mã hóa đơn', T_HangHoa.MaHang as N'Mã hàng',TenHang as N'Tên hàng',T_ChiTietHDBan.SoLuong as N'Số lượng',DonGiaBan as N'Đơn giá',GiamGia as N'Giảm giá(%)',(T_ChiTietHDBan.SoLuong*DonGiaBan - T_ChiTietHDBan.SoLuong*DonGiaBan*GiamGia/100) as N'Thành tiền' from T_ChiTietHDBan,T_HoaDonBan,T_HangHoa where T_ChiTietHDBan.MaHang = T_HangHoa.MaHang and T_ChiTietHDBan.MaHDBan = T_HoaDonBan.MaHDBan and T_HoaDonBan.MaHDBan = '"+cb_MaHD.Text+"'";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_HoaDon.DataSource = table;
        }
        public F_HoaDon()
        {
            InitializeComponent();
        }

        private void F_HoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quan_Ly_Ban_HangDataSet2.T_HangHoa' table. You can move, or remove it, as needed.
            this.t_HangHoaTableAdapter1.Fill(this.quan_Ly_Ban_HangDataSet2.T_HangHoa);
            // TODO: This line of code loads data into the 'quan_Ly_Ban_HangDataSet1.T_HoaDonBan' table. You can move, or remove it, as needed.
            this.t_HoaDonBanTableAdapter1.Fill(this.quan_Ly_Ban_HangDataSet1.T_HoaDonBan);

            dgv_HoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
            cb_MaHang.Text = "";
            comboBox1_SelectedIndexChanged(sender, e);
            cb_MaHang_SelectedIndexChanged(sender, e);

        }
        public void clear_form()
        {
            
            cb_MaHang.Text = "";
            txt_giamgia.Text = "";
            txt_soluong.Text = "";
            id_ngayban.Text = "";
            txt_nhanvien.Text = "";
            txt_TenNV.Text = "";
            txt_Tongtien.Text= "";
            txt_makhach.Text = "";
            txt_tenhang.Text = "";
            txt_diachi.Text = "";
            txt_dienthoai.Text = "";           
            txt_tenkhach.Text = "";
            txt_dongia.Text= "";
            txt_thanhtien.Text= "";
            
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            double a,b;
            if(cb_MaHD.Text == "" || cb_MaHang.Text == "" || txt_soluong.Text == "" || txt_giamgia.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
            }
            else if(!double.TryParse(this.txt_soluong.Text,out a))
            {
                MessageBox.Show("Số lượng phải là số,vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK);
            }
            else if(!double.TryParse(this.txt_giamgia.Text,out b))
            {
                MessageBox.Show("Giảm giá phải là số,vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                string strdup = "select count(T_ChiTietHDBan.MaHang) from T_ChiTietHDBan,T_HoaDonBan,T_HangHoa where T_ChiTietHDBan.MaHang = T_HangHoa.MaHang and T_ChiTietHDBan.MaHDBan = T_HoaDonBan.MaHDBan and T_ChiTietHDBan.MaHDBan = '" + cb_MaHD.Text + "'and T_ChiTietHDBan.MaHang = '"+cb_MaHang.Text+"'";
                command = new SqlCommand(strdup, connection);
                var dup = Convert.ToInt32(command.ExecuteScalar());
                if (dup != 0)
                {
                    MessageBox.Show("Mã " +cb_MaHang.Text+ " đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cb_MaHang.Text = "";
                    txt_soluong.Text = "";
                    txt_giamgia.Text = "";
                }
                else
                {
                    command = connection.CreateCommand();
                    command.CommandText = "insert into T_ChiTietHDBan values ('" + cb_MaHD.Text + "','" + cb_MaHang.Text + "','" + txt_soluong.Text + "','" + txt_giamgia.Text + "')";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công");
                    loaddata();
                    comboBox1_SelectedIndexChanged(sender, e);
                }
            }           
        }

        

        private void dgv_HoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_HoaDon.CurrentRow.Index;
            cb_MaHD.Text = dgv_HoaDon.Rows[i].Cells[0].Value.ToString();
            cb_MaHang.Text = dgv_HoaDon.Rows[i].Cells[1].Value.ToString();
            txt_tenhang.Text = dgv_HoaDon.Rows[i].Cells[2].Value.ToString();
            txt_soluong.Text = dgv_HoaDon.Rows[i].Cells[3].Value.ToString();           
            txt_giamgia.Text = dgv_HoaDon.Rows[i].Cells[5].Value.ToString();
            txt_thanhtien.Text = dgv_HoaDon.Rows[i].Cells[6].Value.ToString();   
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ngayban = "select NgayBan,T_HoaDonBan.MaNhanVien from T_HoaDonBan where MaHDBan = '"+cb_MaHD.Text+"'";
            command = new SqlCommand(ngayban, connection);
            var dup1 = Convert.ToString(command.ExecuteScalar());
            id_ngayban.Text = dup1;
            string MNV = "select T_HoaDonBan.MaNhanVien From T_HoaDonBan,T_NhanVien where T_NhanVien.MaNhanVien = T_HoaDonBan.MaNhanVien and MaHDBan = '" + cb_MaHD.Text+"'";
            command = new SqlCommand(MNV, connection);
            var dup2 = Convert.ToString(command.ExecuteScalar());
            txt_nhanvien.Text = dup2;
            string TNV = "select TenNv From T_HoaDonBan,T_NhanVien where T_NhanVien.MaNhanVien = T_HoaDonBan.MaNhanVien and MaHDBan = '" + cb_MaHD.Text + "'";
            command = new SqlCommand(TNV, connection);
            var dup3 = Convert.ToString(command.ExecuteScalar());
            txt_TenNV.Text = dup3;
            string MKH = "select T_HoaDonBan.MaKhach From T_HoaDonBan,T_NhanVien where T_NhanVien.MaNhanVien = T_HoaDonBan.MaNhanVien and MaHDBan = '" + cb_MaHD.Text + "'";
            command = new SqlCommand(MKH, connection);
            var dup4 = Convert.ToString(command.ExecuteScalar());
            txt_makhach.Text = dup4;
            string TKH = "select TenKhach From T_HoaDonBan,T_KhachHang where T_KhachHang.MaKhach = T_HoaDonBan.MaKhach and MaHDBan = '" + cb_MaHD.Text + "'";
            command = new SqlCommand(TKH, connection);
            var dup5 = Convert.ToString(command.ExecuteScalar());
            txt_tenkhach.Text = dup5;
            string DC = "select DiaChi From T_HoaDonBan,T_KhachHang where T_KhachHang.MaKhach = T_HoaDonBan.MaKhach and MaHDBan = '" + cb_MaHD.Text + "'";
            command = new SqlCommand(DC, connection);
            var dup6 = Convert.ToString(command.ExecuteScalar());
            txt_diachi.Text = dup6;
            string DT = "select DienThoai From T_HoaDonBan,T_KhachHang where T_KhachHang.MaKhach = T_HoaDonBan.MaKhach and MaHDBan = '" + cb_MaHD.Text + "'";
            command = new SqlCommand(DT, connection);
            var dup7 = Convert.ToString(command.ExecuteScalar());
            txt_dienthoai.Text = dup7;
            string TongTien = "select sum(T_ChiTietHDBan.SoLuong*DonGiaBan - T_ChiTietHDBan.SoLuong*DonGiaBan*GiamGia/100) from T_ChiTietHDBan,T_HoaDonBan,T_HangHoa where T_ChiTietHDBan.MaHang = T_HangHoa.MaHang and T_ChiTietHDBan.MaHDBan = T_HoaDonBan.MaHDBan and T_HoaDonBan.MaHDBan = '"+cb_MaHD.Text+"' group by(T_HoaDonBan.MaHDBan)";
            command = new SqlCommand (TongTien, connection);
            var tongtien = Convert.ToString(command.ExecuteScalar());
            txt_Tongtien.Text = tongtien;
            loaddata();
        }

        private void cb_MaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string TH = "Select TenHang From T_HangHoa where MaHang = '" + cb_MaHang.Text + "'";
            command = new SqlCommand(TH, connection);
            var dup8 = Convert.ToString(command.ExecuteScalar());
            txt_tenhang.Text = dup8;
            string DG = "Select DonGiaBan From T_HangHoa where MaHang = '" + cb_MaHang.Text + "'";
            command = new SqlCommand(DG, connection);
            var dup9 = Convert.ToString(command.ExecuteScalar());
            txt_dongia.Text = dup9;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            double a, b;
            if (cb_MaHD.Text == "" || cb_MaHang.Text == "" || txt_soluong.Text == "" || txt_giamgia.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
            }
            else if (!double.TryParse(this.txt_soluong.Text, out a))
            {
                MessageBox.Show("Số lượng phải là số,vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK);
            }
            else if (!double.TryParse(this.txt_giamgia.Text, out b))
            {
                MessageBox.Show("Giảm giá phải là số,vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {

                command = connection.CreateCommand();
                command.CommandText = "update T_ChiTietHDBan set T_ChiTietHDBan.SoLuong = '" + txt_soluong.Text+"',GiamGia = '"+txt_giamgia.Text+"' where MaHDBan = '"+cb_MaHD.Text+"' and MaHang = '"+cb_MaHang.Text+"'";
                command.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công");
                loaddata();
                comboBox1_SelectedIndexChanged(sender, e);

            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if(cb_MaHD.Text == "")
            {
                MessageBox.Show("Nhập mã hóa đơn để xóa","Thông báo",MessageBoxButtons.OK);
            }
            else if(cb_MaHang.Text == "")
            {
                MessageBox.Show("Nhập mã hàng để xóa", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                command = connection.CreateCommand();
                command.CommandText = "delete from T_ChiTietHDBan where MaHDBan = '" + cb_MaHD.Text + "' and MaHang = '" + cb_MaHang.Text + "'";
                DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn xóa?","Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(kq == DialogResult.Yes)
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("xóa thành công");
                    loaddata();
                    comboBox1_SelectedIndexChanged(sender, e);
                }
            }
            
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn đóng?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if(kq == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if(txt_timkiem.Text != "")
            {
                string search = "select T_ChiTietHDBan.MaHDBan as N'Mã hóa đơn', T_HangHoa.MaHang as N'Mã hàng',TenHang as N'Tên hàng',T_ChiTietHDBan.SoLuong as N'Số lượng',DonGiaBan as N'Đơn giá',GiamGia as N'Giảm giá(%)',(T_ChiTietHDBan.SoLuong*DonGiaBan - T_ChiTietHDBan.SoLuong*DonGiaBan*GiamGia/100) as N'Thành tiền' from T_ChiTietHDBan,T_HoaDonBan,T_HangHoa where T_ChiTietHDBan.MaHang = T_HangHoa.MaHang and T_ChiTietHDBan.MaHDBan = T_HoaDonBan.MaHDBan and T_ChiTietHDBan.MaHang = T_HangHoa.MaHang and T_HoaDonBan.MaHDBan = '" + cb_MaHD.Text+ "' and T_ChiTietHDBan.MaHang like '%" + txt_timkiem.Text+ "%'";
                SqlCommand cmd = new SqlCommand(search,connection);
                cmd.Parameters.AddWithValue("MaHDBan", txt_timkiem.Text);
                cmd.Parameters.AddWithValue("MaHang", txt_timkiem.Text);
                cmd.Parameters.AddWithValue("SoLuong", txt_timkiem.Text);
                cmd.Parameters.AddWithValue("GiamGia", txt_timkiem.Text);
                cmd.Parameters.AddWithValue("TenHang", txt_timkiem.Text);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgv_HoaDon.DataSource = dt;
                txt_timkiem.Text = "";
            }
            else
            {
                F_HoaDon_Load(sender, e);
            }
        }

        private void btn_Inhoadon_Click(object sender, EventArgs e)
        {
            
            Excel.Application exapp = new Excel.Application();
            Excel.Workbook exbook = exapp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exbook.Worksheets[1];
            Excel.Range exRange = (Excel.Range)exSheet.Cells[1, 1];
            exRange.Font.Size = 18;
            exRange.Font.Bold = true;
            exRange.Font.Color = Color.Blue;
            exRange.Value = "CỬA HÀNG BÁN HÀNG LƯU NIỆM THAO THAO";
            Excel.Range diachi = (Excel.Range)exSheet.Cells[2, 1];
            diachi.Value = "Ngõ 12 Tả Thanh Oai - Thanh Trì - Hà Nội";
            //in chữ hóa đơn bán

            exRange.Range["D4"].Font.Size = 25;
            exRange.Range["D4"].Font.Bold = true;
            exRange.Range["D4"].Font.Color = Color.Red;
            exRange.Range["D4"].Value = "HÓA ĐƠN BÁN";
            // in thông tin chung
            exSheet.Range["A5:A8"].Font.Size = 14;
            exSheet.Range["A5"].Value = "Mã hóa đơn : " + cb_MaHD.Text;
            exSheet.Range["A6"].Value = "Khách Hang: " + txt_tenkhach.Text;
            exSheet.Range["A7"].Value = "Địa chỉ: "+txt_diachi.Text;
            exSheet.Range["A8"].Value = "Điện thoại: "+txt_dienthoai.Text;
            //in tiêu đề
            exSheet.Range["A10:G10"].Font.Size=14;
            exSheet.Range["A10"].ColumnWidth = 20;
            exSheet.Range["B10"].ColumnWidth = 20;
            exSheet.Range["C10"].ColumnWidth = 20;
            exSheet.Range["D10"].ColumnWidth = 20;
            exSheet.Range["E10"].ColumnWidth = 20;
            exSheet.Range["F10"].ColumnWidth = 20;
            exSheet.Range["G10"].ColumnWidth = 20;
            exSheet.Range["A10"].Value = "STT";
            exSheet.Range["B10"].Value = "Mã hàng";
            exSheet.Range["C10"].Value = "Tên Hàng";
            exSheet.Range["D10"].Value = "Số lượng";
            exSheet.Range["E10"].Value = "Đơn giá";
            exSheet.Range["F10"].Value = "Giảm giá";
            exSheet.Range["G10"].Value = "Thành tiền";
            int dong = 11;
            for (int i = 0; i < dgv_HoaDon.Rows.Count; i++)
            {
                exSheet.Range["A" + (dong + 1).ToString()].Value = (i + 1).ToString();
                exSheet.Range["B" + (dong + i).ToString()].Value = dgv_HoaDon.Rows[i].Cells[0].Value.ToString();
                exSheet.Range["C" + (dong + i).ToString()].Value = dgv_HoaDon.Rows[i].Cells[0].Value.ToString();
                exSheet.Range["D" + (dong + i).ToString()].Value = dgv_HoaDon.Rows[i].Cells[0].Value.ToString();
                exSheet.Range["E" + (dong + i).ToString()].Value = dgv_HoaDon.Rows[i].Cells[0].Value.ToString();
                exSheet.Range["F" + (dong + i).ToString()].Value = dgv_HoaDon.Rows[i].Cells[0].Value.ToString() + "%"; 
                exSheet.Range["G" + (dong + i).ToString()].Value = dgv_HoaDon.Rows[i].Cells[0].Value.ToString();
            }
            dong  = dong +dgv_HoaDon.Rows.Count;
            exSheet.Range["E" + dong.ToString()].Value = txt_Tongtien.Text + "đồng";
            exSheet.Name = cb_MaHD.Text;
            exbook.Activate();
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                exbook.SaveAs(save.FileName.ToLower());
            }
            exapp.Quit();
        }
    }
}
