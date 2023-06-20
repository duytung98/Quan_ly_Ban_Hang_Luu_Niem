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
    public partial class F_Quenmatkhau : Form
    {
        SqlConnection connection;
        string str = @"Data Source=.;Initial Catalog=Quan_Ly_Ban_Hang;Integrated Security=True";
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();

        public F_Quenmatkhau()
        {
            InitializeComponent();
            id_ketqua1.Text = "";
            id_ketqua2.Text = "";
        }

        private void btn_laymk_Click(object sender, EventArgs e)
        {
            if(id_email.Text == "")
            {
                MessageBox.Show("Nhập email để lấy lại mật khẩu","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connection = new SqlConnection(str);
                    connection.Open();
                    command = connection.CreateCommand();
                    adapter.SelectCommand = command;
                    string sql = "select count(Email) from T_TaiKhoan where Email = '" + id_email.Text + "'";
                    command = new SqlCommand(sql, connection);
                    var dup = Convert.ToInt32(command.ExecuteScalar());
                    if (dup > 0)
                    {
                        string mk = "select MatKhau from T_TaiKhoan where Email = '" + id_email.Text + "'";
                        command = new SqlCommand(mk, connection);
                        var dup1 = Convert.ToString(command.ExecuteScalar());
                        string tk = "select TaiKhoan from T_TaiKhoan where Email = '" + id_email.Text + "'";
                        command = new SqlCommand(tk, connection);
                        var dup2 = Convert.ToString(command.ExecuteScalar());
                        id_ketqua1.ForeColor = Color.Blue;
                        id_ketqua2.ForeColor = Color.Blue;
                        id_ketqua1.Text = "Tài khoản:   " + dup2;
                        id_ketqua2.Text = "Mật khẩu:    " + dup1;


                    }
                    else
                    {
                        id_ketqua1.ForeColor = Color.Red; id_ketqua2.Text = "";
                        MessageBox.Show("Email chưa được đăng ký, vui lòng nhập đúng email", "Thông báo");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            
        }

        private void F_Quenmatkhau_Load(object sender, EventArgs e)
        {

        }
    }
}
