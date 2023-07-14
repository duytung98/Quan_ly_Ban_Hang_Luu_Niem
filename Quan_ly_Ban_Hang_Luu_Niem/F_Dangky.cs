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
using System.Text.RegularExpressions;

namespace Quan_ly_Ban_Hang_Luu_Niem
{
    public partial class F_Dangky : Form
    {
        SqlConnection connection;
        string sql = @"Data Source=.;Initial Catalog=Quan_Ly_Ban_Hang;Integrated Security=True";
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        public F_Dangky()
        {
            InitializeComponent();
        }
        public bool checkcout(string ac)//check tk và mk
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool checkout(string em)//check email
        {
            return Regex.IsMatch(em, "^[a-zA-Z0-9]{6,50}@gmail.com(.vn|)");
        }

        private void id_dangky_Click(object sender, EventArgs e)
        {
            if (!checkcout(id_tentk.Text))
            {
                MessageBox.Show("Tên tài khoản phải từ 6 - 24 ký tự và các chữ và số");
                return;
            } 
            else if(!checkcout(id_mk.Text)) {
                MessageBox.Show("Mật khẩu phải từ 6 - 24 ký tự, gồm chữ và số");
                return;
            }
            else if (!checkout(id_email.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ email đúng định dạng!!");
                return;
            }
            else if(id_mk.Text != id_xnmk.Text)
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác!!");
                return;
            }
           
            else
            {
                connection = new SqlConnection(sql);
                connection.Open();
                cmd = connection.CreateCommand();
                adapter.SelectCommand = cmd;
                string strdup = "select count(Email) from T_TaiKhoan where Email = '" + id_email.Text + "'";
                cmd = new SqlCommand(strdup,connection);
                var dup = Convert.ToInt32(cmd.ExecuteScalar());
                string strdup1 = "select count(TaiKhoan) from T_TaiKhoan where Email = '" + id_email.Text + "'";
                cmd = new SqlCommand(strdup1, connection);
                var dup1 = Convert.ToInt32(cmd.ExecuteScalar());
                if(dup1 > 0)
                {
                    MessageBox.Show("Tài khoản đã tồn tại, vui lòng nhập tài khoản khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dup > 0)
                {
                    MessageBox.Show("Email đã tồn tại, vui lòng nhập email khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    try
                    {
                        cmd = connection.CreateCommand();
                        cmd.CommandText = "insert into T_TaiKhoan values ('" + id_tentk.Text + "','" + id_mk.Text + "','" + id_email.Text + "')";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK);
                        DialogResult kq = MessageBox.Show("Bạn có muốn đăng nhập không?", "Thông báo", MessageBoxButtons.YesNo);
                        if (kq == DialogResult.Yes)
                        {
                            this.Hide();
                            F_Dangnhap f_Dangnhap = new F_Dangnhap();
                            f_Dangnhap.ShowDialog();
                            f_Dangnhap = null;
                            this.Show();
                        }
                        else
                        {
                            id_tentk.Text = "";
                            id_mk.Text = "";
                            id_xnmk.Text = "";
                            id_email.Text = "";
                            id_tentk.Focus();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi kết nối" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }

        }

        private void id_dangnhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_Dangnhap f_Dangnhap = new F_Dangnhap();
            f_Dangnhap.ShowDialog();
            f_Dangnhap = null;
            this.Show();
        }

        private void btb_htmk1_Click(object sender, EventArgs e)// hiển thị mật khẩu
        {
            if(id_mk.PasswordChar == '*')
            {
                id_mk.PasswordChar = '\0';
            }
            else
            {
                id_mk.PasswordChar = '*';
            }
        }

        private void btb_htmk2_Click(object sender, EventArgs e) // hiển thị xác nhận mật khẩu
        {
            if (id_xnmk.PasswordChar == '*')
            {
                id_xnmk.PasswordChar = '\0';
            }
            else
            {
                id_xnmk.PasswordChar = '*';
            }
        }
    }
}
