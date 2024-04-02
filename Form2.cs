using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ASM1
{
    public partial class Form2_User : Form
    {
        SqlConnection conn;
        public Form2_User()
        {
            InitializeComponent();
            createConnection();
        }
        private void createConnection()
        {
            try
            {

                //tạo chuỗi kết nối
                String stringConnection = "Data Source=RAIN;Initial Catalog=Bookmanagets;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
                //tạo kết nối 
                conn = new SqlConnection(stringConnection);


            }
            catch (Exception ex)
            {
                MessageBox.Show("có ở gia đoạn lỗi kết nối sqlSever:" + ex.Message);
            }

        }
        private void display()
        {

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            string sql = "select * from Book";
            //gắn querry string vào command
            cmd.CommandText = sql;
            //chạy command 
            cmd.ExecuteNonQuery();
            // khai báo datatable để biến đổi data trả về data dạng bảng
            DataTable dt = new DataTable();
            //khai báo Adapter trung gian
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // đổ dữ liệu vào (dt)
            da.Fill(dt);
            // hiên thị dữ liệu lên datagrtidview
            dgv1.DataSource = dt;
            //đóng kết nối 

            conn.Close();
        }
        private void Search()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;

            // Lấy giá trị tìm kiếm từ TextBox và loại bỏ các khoảng trắng ở đầu và cuối chuỗi
            string searchKeyword = Appdata.username;

            // Sử dụng câu lệnh SQL với tham số @search để tìm kiếm các tên người dùng chứa chuỗi tìm kiếm
            string sql = @"
            SELECT Users.Username, BorrowedBooks.BorrowDate, BorrowedBooks.ReturnDate, Book.Title, Book.Genre
            FROM BorrowedBooks
            JOIN Users ON Users.UserID = BorrowedBooks.UserID 
            JOIN Book ON Book.BookID = BorrowedBooks.BookID 
            WHERE Users.Username  =  @search  ";
            // Thêm tham số với giá trị tìm kiếm vào câu lệnh SQL
            cmd.Parameters.AddWithValue("@search", searchKeyword);
            cmd.CommandText = sql;
            DataTable dt = new DataTable();
            // Khởi tạo SqlDataAdapter với câu lệnh SQL
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // Đổ dữ liệu vào DataTable
            da.Fill(dt);
            // Hiển thị dữ liệu trên DataGridView
            dgv1.DataSource = dt;

            // Đóng kết nối
            conn.Close();
        }
        private void sreachbook()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;

            string sql = "SELECT * FROM Book WHERE Book.Title LIKE '%' + @sreach + '%' ";
            cmd.Parameters.AddWithValue("@sreach", tbsreach.Text);
            cmd.CommandText = sql;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv1.DataSource = dt;

            conn.Close();
        }
        private void muonsach()
        {
            try
            {
                conn.Open();
                // Truy vấn để lấy UserID dựa trên tên người dùng
                string selectSql = "SELECT UserID FROM Users WHERE Username = @username";
                SqlCommand selectCmd = new SqlCommand(selectSql, conn);
                selectCmd.Parameters.AddWithValue("@username", Appdata.username);

                int userID = Convert.ToInt32(selectCmd.ExecuteScalar()); // Lấy UserID từ câu truy vấn

                // Truy vấn để lấy số lượng sách hiện có
                string selectQuantitySql = "SELECT Quantity FROM Book WHERE BookID = @BookID";
                SqlCommand selectQuantityCmd = new SqlCommand(selectQuantitySql, conn);
                selectQuantityCmd.Parameters.AddWithValue("@BookID", tb_idbook.Text);
                int quantity = Convert.ToInt32(selectQuantityCmd.ExecuteScalar());

                if (userID != 0) // Kiểm tra xem có UserID tương ứng với tên người dùng hay không
                {
                    if (quantity <= 0)
                    {
                        MessageBox.Show("hết sách nhé");
                    }
                    else
                    {
                        string insertSql = "INSERT INTO BorrowedBooks ( UserID, BookID, BorrowDate, ReturnDate) VALUES ( @UserID, @BookID, @BorrowDate, @ReturnDate)";

                        SqlCommand Cmd = conn.CreateCommand();
                        Cmd.CommandText = insertSql;

                        Cmd.Parameters.AddWithValue("@UserID", userID); // Giá trị UserID đã được lấy từ cơ sở dữ liệu
                        Cmd.Parameters.AddWithValue("@BookID", tb_idbook.Text); // Giá trị BookID lấy từ TextBox
                        Cmd.Parameters.AddWithValue("@BorrowDate", dtimengaymuon.Value); // Giá trị BorrowDate lấy từ DateTimePicker
                        Cmd.Parameters.AddWithValue("@ReturnDate", dtimengaytra.Value); // Giá trị ReturnDate lấy từ DateTimePicker
                        Cmd.ExecuteNonQuery(); // Thực thi lệnh INSERT vào cơ sở dữ liệu
                        trusoluongsach();
                        themsachvaodanhsachmuon();
                        MessageBox.Show("Mượn sách thành công"); // Thông báo thành công

                    }

                }
                else
                {
                    MessageBox.Show("Tên người dùng không hợp lệ"); // Thông báo nếu không tìm thấy UserID tương ứng với tên người dùng
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close(); //  kết nối  đóng nếu có ngoại lệ xảy ra
            }

        }
        public void trusoluongsach()
        {
            string updateSql = "UPDATE Book SET Quantity = Quantity - 1 WHERE BookID = @BookID";
            SqlCommand updateCmd = new SqlCommand(updateSql, conn);
            updateCmd.Parameters.AddWithValue("@BookID", tb_idbook.Text); // Giá trị BookID lấy từ TextBox
            updateCmd.ExecuteNonQuery(); // Thực thi lệnh UPDATE để giảm số lượng sách trong kho                     
        }
        public void themsachvaodanhsachmuon()
        {
            try
            {

                string logSql = "INSERT INTO BookLogs (BookID, Action, UserID, Timestamp)\r\nSELECT @bookid, 'Borrow', UserID,@time\r\nFROM Users\r\nWHERE Username = @username;";
                SqlCommand cmd1 = new SqlCommand(logSql, conn);
                cmd1.Parameters.AddWithValue("@bookid", tb_idbook.Text); // Giá trị BookID đã được lấy từ TextBox
                cmd1.Parameters.AddWithValue("@username", Appdata.username);
                cmd1.Parameters.AddWithValue("@time", dtimengaymuon.Value); // ID của người mượn sách             
                cmd1.ExecuteNonQuery(); // Thực thi lệnh INSERT vào bảng BookLogs

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            display();

        }

        private void bt_dangky_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            display();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            muonsach();
            display();
        }

        private void tbsreach_TextChanged(object sender, EventArgs e)
        {
            if(tbsreach.Text != "")
            {
                sreachbook();
               
            }
            else
            {
                display();
            }
        }
    }
}
