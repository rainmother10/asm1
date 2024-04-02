using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM1
{
    public partial class Formquenpass : Form
    {
        SqlConnection conn;
        public Formquenpass()
        {
            InitializeComponent();
        }
        private void createConnection()
        {
            try
            {
                String strConnection = "Data Source=RAIN;Initial Catalog=Bookmanagets;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
                conn = new SqlConnection(strConnection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra ở createConnection " + ex.Message);
            }
        }

        private void Formquenpass_Load(object sender, EventArgs e)
        {
            createConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                string sql = "UPDATE Users SET Password = @password WHERE Username = @username;";

                if (tbuser.Text == "" || tbpass.Text == "")
                {
                    MessageBox.Show("Không được để trống tên người dùng hoặc mật khẩu.");
                }
                else
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@username", tbuser.Text);
                    cmd.Parameters.AddWithValue("@password", tbpass.Text);
                    int nguoidung = cmd.ExecuteNonQuery();
                    if (nguoidung > 0)
                    {
                        MessageBox.Show("Đổi mật khẩu thành công cho người dùng: " + tbuser.Text);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy người dùng có tên là: " + tbuser.Text);
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra: " + ex.Message);
            }



        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                string sql = "INSERT INTO Users (Username,Password,RoleID) values (@username,@password,'2')";
                          
                cmd.CommandText = sql;            
                cmd.Parameters.AddWithValue("@username", tbuser.Text);
                cmd.Parameters.AddWithValue("@password", tbpass.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" đăng kí thành công ");
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra: " + ex.Message);
            }
            
        }
    }
}
