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
    //tung tiền tỷ
    public partial class F_Chatlieu : Form
    {
        SqlConnection connection;
        string str = "Data Source=.;Initial Catalog=Quan_Ly_Ban_Hang;Integrated Security=True";
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select MaChatLieu as N'Mã chất liệu',TenChatLieu as N'Tên chất liệu' from T_ChatLieu";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dvg_chatlieu.DataSource = table;

        }
        public F_Chatlieu()
        {
            InitializeComponent();
        }
        public void clear_form()
        {
            txt_Machatlieu.Text = "";
            txt_Tenchatlieu.Text = "";
            txt_Machatlieu.Focus();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(txt_Machatlieu.Text == "")
            {
                MessageBox.Show("Chưa nhập mã chất liệu","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if(txt_Tenchatlieu.Text == "")
            {
                MessageBox.Show("Chưa nhập mã chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string strdup = "select count(MaChatLieu) from T_ChatLieu where MaChatLieu = '"+txt_Machatlieu+"'";
                command = new SqlCommand( strdup ,connection);
                var dup = Convert.ToInt32(command.ExecuteScalar() );
                if( dup != 0)
                {
                    MessageBox.Show("Mã"+txt_Machatlieu.Text+"đã tồn tại","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txt_Machatlieu.Text = "";
                }
                else
                {
                    command = connection.CreateCommand();
                    command.CommandText = "insert into T_Chatlieu values('"+txt_Machatlieu.Text+"',N'"+txt_Tenchatlieu.Text+"')";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công", "thông báo", MessageBoxButtons.OK);
                    loaddata();
                    clear_form();
                }
            }
        }

        private void F_Chatlieu_Load(object sender, EventArgs e)
        {
            dvg_chatlieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dvg_chatlieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int i = dvg_chatlieu.CurrentRow.Index;
            txt_Machatlieu.Text = dvg_chatlieu.Rows[i].Cells[0].Value.ToString();
            txt_Tenchatlieu.Text = dvg_chatlieu.Rows[i].Cells[1].Value.ToString();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if(txt_Machatlieu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã chất liệu để sửa","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if(txt_Tenchatlieu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên chất liệu để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                command = connection.CreateCommand();
                command.CommandText = "update T_ChatLieu set TenChatlieu = N'"+txt_Tenchatlieu.Text+"' where MaChatLieu = '" + txt_Machatlieu.Text + "'";
                command.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công", "thông báo", MessageBoxButtons.OK);
                loaddata();
                clear_form();

            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_Machatlieu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã chất liệu để xóa", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                command = connection.CreateCommand();
                command.CommandText = "Delete From T_ChatLieu where MaChatLieu = '" + txt_Machatlieu.Text + "'";
                DialogResult kq = MessageBox.Show("Bạn chắc chắn muốn xóa?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    loaddata();
                    clear_form();
                }
            }
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn đóng?","Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if(txt_Timkiem.Text != "")
            {

                
                string sqlsearch = "select MaChatLieu as N'Mã chất liệu',TenChatLieu as N'Tên chất liệu' from T_ChatLieu where MaChatLieu like N'%"+txt_Timkiem.Text+"%' or TenChatLieu like N'%"+txt_Timkiem.Text+"%'";
                SqlCommand cmd = new SqlCommand(sqlsearch, connection);
                cmd.Parameters.AddWithValue("MaChatLieu", txt_Machatlieu.Text);
                cmd.Parameters.AddWithValue("TenChatLieu", txt_Tenchatlieu.Text);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dvg_chatlieu.DataSource = dt;
                txt_Timkiem.Text = "";
            }
            else
            {
                F_Chatlieu_Load(sender, e);
            }
        }

        
    }
}
