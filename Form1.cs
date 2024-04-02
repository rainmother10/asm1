using Microsoft.Data.SqlClient;
using System.Data.SqlClient;

namespace ASM1
{
    public partial class From_Login : Form
    {
        public From_Login()
        {
            InitializeComponent();
            createConnection();
        }
        SqlConnection conn;
        private void createConnection()//kết nối cơ sở dữ liệu
        {
            try
            {
                // Chuỗi kết nối đến cơ sở dữ liệu SQL Server.
                String strConnection = "Data Source=RAIN;Initial Catalog=Bookmanagets;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
                // Tạo một kết nối mới với thông tin được cung cấp.
                conn = new SqlConnection(strConnection);
            }
            catch (Exception ex)
            {
                // Thông báo cho người dùng nếu có lỗi xảy ra.
                MessageBox.Show("Có lỗi xảy ra ở createConnection " + ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void bt_login_Click(object sender, EventArgs e)
        {
            try
            {
                string username = tb_user.Text;// Đọc thông tin từ textbox tên người dùng
                string password = tb_pass.Text;// Đọc mật khẩu từ textbox mật khẩu
                conn.Open();// Mở kết nối cơ sở dữ liệu
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                string sql = "SELECT RoleID FROM Users WHERE Username = @Username AND Password = @Password";
                cmd.CommandText = sql; // Thiết lập CommandText cho đối tượng SqlCommand
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) // Kiểm tra xem có dữ liệu trả về hay không
                {
                    int roleId = Convert.ToInt32(reader["RoleID"]);

                    if (roleId == Appdata.ROLE_User)
                    {
                        Appdata.role = roleId;
                        MessageBox.Show(" Hello " + username);
                        Appdata.islogin = true;
                        Appdata.username = username;
                       
                    }
                    else if (roleId == Appdata.ROLE_ADmin)
                    {
                        Appdata.role = roleId;
                        MessageBox.Show(" Hello admin ");
                        Appdata.islogin = true;
                    }
                    Close();// Đóng kết nối cơ sở dữ liệu
                }
                else
                {
                    MessageBox.Show("sai tài khoản hoặc mật khẩu ");
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi ở buttom: " + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Formquenpass formquenpass = new Formquenpass();
            formquenpass.ShowDialog();
        }
    }
}
