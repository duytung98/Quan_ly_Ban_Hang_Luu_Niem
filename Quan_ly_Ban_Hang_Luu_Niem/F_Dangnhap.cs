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
    public partial class F_Dangnhap : Form
    {
        public F_Dangnhap()
        {
            InitializeComponent();
        }

        private void id_hienthimk_CheckedChanged(object sender, EventArgs e)
        {
            if(id_matkhau.PasswordChar ==  '*')
            {
                id_matkhau.PasswordChar = '\0';
            }
            else
            {
                id_matkhau.PasswordChar = '*';
            }
        }

        private void id_quenmk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            F_Quenmatkhau f_Quenmatkhau = new F_Quenmatkhau();
            f_Quenmatkhau.ShowDialog();
            f_Quenmatkhau = null;
            this.Show();
        }

        private void id_dangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=Quan_Ly_Ban_Hang;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = id_taikhoan.Text;
                string mk = id_matkhau.Text;
                string sql = "select * from T_TaiKhoan where TaiKhoan = '"+tk+"' and MatKhau = '"+mk+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader DataReader = cmd.ExecuteReader();
                if(id_matkhau.Text == ""||id_taikhoan.Text == "")
                {
                    MessageBox.Show("Bạn điền tài khoản và mật khẩu để đăng nhâp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else if(DataReader.Read() == true) 
                {
                    this.Hide();
                    F_main f_Main = new F_main();
                    f_Main.ShowDialog();
                    f_Main = null;
                    id_matkhau.Text = "";
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng? Vui lòng nhập lại tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    id_matkhau.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối"+ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void id_reset_Click(object sender, EventArgs e)
        {
            id_taikhoan.Text = "";
            id_matkhau.Text = "";
            id_taikhoan.Focus();
        }

        private void id_dangky_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_Dangky f_Dangky = new F_Dangky();
            f_Dangky.ShowDialog();
            this.Show();
        }

        private void id_thoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if(kq == DialogResult.Yes)
            {
                Close();
                Application.Exit();
            }
        }

        private void F_Dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void id_dangnhap_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
