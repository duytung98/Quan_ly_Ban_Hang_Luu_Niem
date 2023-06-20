using Microsoft.SqlServer.Server;
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
    public partial class F_HangHoa : Form
    {

        SqlConnection Connection;
        string str = @"Data Source=.;Initial Catalog=Quan_Ly_Ban_Hang;Integrated Security=True";
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = Connection.CreateCommand();
            command.CommandText = "select MaHang as N'Mã Hàng', TenHang as N'Tên Hàng',T_ChatLieu.MaChatLieu as N'Mã chất liệu'," +
                "TenChatLieu as N'Tên chất liệu',SoLuong as N'Số lượng',DonGiaNhap N'Đơn giá nhập',DonGiaBan N'Đơn giá bán',GhiChu N'Ghi chú' " +
                "from T_HangHoa,T_ChatLieu where T_HangHoa.MaChatLieu = T_ChatLieu.MaChatLieu";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dvg_hanghoa.DataSource = table;
        }
        public F_HangHoa()
        {
            InitializeComponent();
        }

        private void F_HangHoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quan_Ly_Ban_HangDataSet.T_ChatLieu' table. You can move, or remove it, as needed.
            this.t_ChatLieuTableAdapter3.Fill(this.quan_Ly_Ban_HangDataSet.T_ChatLieu);


            dvg_hanghoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Connection = new SqlConnection(str);
            Connection.Open();
            loaddata();
        }
        public void clear_form()
        {
            txt_mahang.Text = "";
            txt_tenhang.Text = "";
            cb_machatlieu.Text = "";
            txt_gianhap.Text = "";
            txt_giaban.Text = "";
            txt_gichu.Text = "";
            txt_soluong.Text = "";
            txt_tenchatlieu.Text = "";
            txt_mahang.Focus();
            
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            double a,b,c;
            if (txt_mahang.Text == "" || txt_tenhang.Text == "" || cb_machatlieu.Text == "" || txt_gianhap.Text == "" || txt_giaban.Text == "" || txt_soluong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!!", "Thông báo",MessageBoxButtons.OK);
            }
            else if(!double.TryParse(this.txt_soluong.Text,out a))
            {
                MessageBox.Show("Số lượng phải là số ", "Thông báo", MessageBoxButtons.OK);
            }
            else if(!double.TryParse(this.txt_giaban.Text,out b))
            {
                MessageBox.Show("Đơn giá bán phải là số ", "Thông báo", MessageBoxButtons.OK);
            }
            else if(!double.TryParse(this.txt_gianhap.Text,out c))
            {
                MessageBox.Show("Đơn giá nhập phải là số ", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                string strup = "select count(MaHang) from T_HangHoa where MaHang = '" + txt_mahang + "'";
                command = new SqlCommand(strup,Connection);
                var dup = Convert.ToInt32(command.ExecuteScalar());
                if (dup > 0)
                {
                    MessageBox.Show("Mã"+txt_mahang+"đã tồn tại","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txt_mahang.Text = "";
                }
                else
                {
                    command = Connection.CreateCommand();
                    command.CommandText = "insert into T_HangHoa values ('"+txt_mahang.Text+"',N'"+txt_tenhang.Text+"',N'"+cb_machatlieu.Text+"','"+txt_soluong.Text+"','"+txt_gianhap.Text+"','"+txt_giaban.Text+"',N'"+txt_gichu.Text+"')";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!!", "Thông báo", MessageBoxButtons.OK);
                    loaddata();
                    clear_form();
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            double a, b, c;
            if (txt_mahang.Text == "" || txt_tenhang.Text == "" || cb_machatlieu.Text == "" || txt_gianhap.Text == "" || txt_giaban.Text == "" || txt_soluong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!!", "Thông báo", MessageBoxButtons.OK);
            }
            else if (!double.TryParse(this.txt_soluong.Text, out a))
            {
                MessageBox.Show("Số lượng phải là số ", "Thông báo", MessageBoxButtons.OK);
            }
            else if (!double.TryParse(this.txt_giaban.Text, out b))
            {
                MessageBox.Show("Đơn giá bán phải là số ", "Thông báo", MessageBoxButtons.OK);
            }
            else if (!double.TryParse(this.txt_gianhap.Text, out c))
            {
                MessageBox.Show("Đơn giá nhập phải là số ", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                command = Connection.CreateCommand();
                command.CommandText="update T_HangHoa set TenHang = N'"+txt_tenhang.Text+"',MaChatLieu = N'"+cb_machatlieu.Text+"',SoLuong = '"+txt_soluong.Text+"'," +
                    "DonGiaNhap = '"+txt_gianhap.Text+"',DonGiaBan = '"+txt_giaban.Text+"',GhiChu = '"+txt_gichu.Text+"' where MaHang = '"+txt_mahang.Text+"'";
                command.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                loaddata();
                clear_form();
            }
        }

        private void dvg_hanghoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int i = dvg_hanghoa.CurrentRow.Index;
            txt_mahang.Text = dvg_hanghoa.Rows[i].Cells[0].Value.ToString();
            txt_tenhang.Text = dvg_hanghoa.Rows[i].Cells[1].Value.ToString();
            cb_machatlieu.Text = dvg_hanghoa.Rows[i].Cells[2].Value.ToString();
            txt_tenchatlieu.Text = dvg_hanghoa.Rows[i].Cells[3].Value.ToString();
            txt_soluong.Text = dvg_hanghoa.Rows[i].Cells[4].Value.ToString();
            txt_gianhap.Text = dvg_hanghoa.Rows[i].Cells[5].Value.ToString();
            txt_giaban.Text = dvg_hanghoa.Rows[i].Cells[6].Value.ToString();
            txt_gichu.Text = dvg_hanghoa.Rows[i].Cells[7].Value.ToString();

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if(txt_mahang.Text == "")
            {
                MessageBox.Show("Nhập mã hàng để xóa","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                command = Connection.CreateCommand();
                command.CommandText = "Delete from T_HangHoa where MaHang ='" + txt_mahang.Text + "'";
                DialogResult kq = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(kq == DialogResult.Yes)
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công!!", "Thông báo", MessageBoxButtons.OK);
                    loaddata();
                    clear_form();
                }
            }
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn đóng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(kq == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if(txt_timkiem.Text != "")
            {
                string sqlsearch = "select MaHang as N'Mã Hàng', TenHang as N'Tên Hàng',T_ChatLieu.MaChatLieu as N'Mã chất liệu',TenChatLieu as N'Tên chất liệu',SoLuong as N'Số lượng',DonGiaNhap N'Đơn giá nhập',DonGiaBan N'Đơn giá bán',GhiChu N'Ghi chú' from T_HangHoa,T_ChatLieu where T_ChatLieu.MaChatLieu = T_HangHoa.MaChatLieu and MaHang like '%"+txt_timkiem.Text+"%' or TenHang like N'%"+txt_timkiem.Text +"%'";
                SqlCommand Cmd = new SqlCommand(sqlsearch,Connection);
                Cmd.Parameters.AddWithValue("MaHang", txt_timkiem.Text);
                Cmd.Parameters.AddWithValue("TenHang", txt_timkiem.Text);
                Cmd.Parameters.AddWithValue("MaChatLieu", txt_timkiem.Text);
                Cmd.Parameters.AddWithValue("TenChatLieu", txt_timkiem.Text);
                Cmd.Parameters.AddWithValue("SoLuong", txt_timkiem.Text);
                Cmd.Parameters.AddWithValue("DonGiaNhap", txt_timkiem.Text);
                Cmd.Parameters.AddWithValue("DonGiaBan", txt_timkiem.Text);
                Cmd.Parameters.AddWithValue("GhiChu", txt_timkiem.Text);
                Cmd.ExecuteNonQuery();
                SqlDataReader reader = Cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dvg_hanghoa.DataSource = dt;
                txt_timkiem.Text = "";

            }
            else
            {
                F_HangHoa_Load(sender, e);
            }
        }

        private void txt_tenchatlieu_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cb_machatlieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenchat = "select TenChatLieu from T_ChatLieu where MaChatLieu = '" + cb_machatlieu.Text + "'";
            command = new SqlCommand(tenchat, Connection);
            var dup = Convert.ToString(command.ExecuteScalar());
            txt_tenchatlieu.Text = dup;
        }

        private void txt_mahang_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
