using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace ASM1
{
    public partial class Form3 : Form
    {
        SqlConnection conn;
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
        private void displays()
        {
            try
            {
                //kết nối dữ liệu
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
            catch (Exception ex)
            {

                MessageBox.Show("có lỗi ở hàm display:" + ex.Message);

            }
        }



        private void createNewBrand()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;

                // Khai báo chuỗi SQL query
                string sql = "INSERT INTO dbo.Book (BookID,Title, Author, Genre, Quantity) VALUES (@value_bookid, @value_title, @value_author, @value_genre, @value_quantity)";
                cmd.CommandText = sql;

                // Gán giá trị cho biến với kiểu dữ liệu phù hợp

                cmd.Parameters.Add("@value_bookid", SqlDbType.Int);
                cmd.Parameters.Add("@value_title", SqlDbType.VarChar);
                cmd.Parameters.Add("@value_author", SqlDbType.VarChar);
                cmd.Parameters.Add("@value_genre", SqlDbType.VarChar);
                cmd.Parameters.Add("@value_quantity", SqlDbType.Int);
                //thêm biến vào câu query với kiểu biến là varchar
                cmd.Parameters["@value_bookid"].Value = int.Parse(tb_bookid.Text);
                cmd.Parameters["@value_title"].Value = tb_title.Text.ToString();
                cmd.Parameters["@value_author"].Value = tb_author.Text.ToString();
                cmd.Parameters["@value_genre"].Value = tb_genre.Text.ToString();
                cmd.Parameters["@value_quantity"].Value = int.Parse(tb_quantity.Text);

                // Thực thi câu lệnh SQL
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tạo book mới thành công!");
                conn.Close();
            }
            finally
            {
                // Đảm bảo rằng kết nối luôn được đóng
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        private void deletebrand()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                //khai báo chuỗi sql qeury với biến sql được bắt đầu = kí tự @             
                string sql = "Delete Book WHERE BookID = @value_bookid";
                cmd.CommandText = sql;
                //gán giá trị cho biến
                cmd.Parameters.Add("@value_bookid", SqlDbType.Int);
                //thêm biến vào câu query với kiểu biến là varchar
                cmd.Parameters["@value_bookid"].Value = tb_bookid.Text.ToString();
                cmd.ExecuteNonQuery();
                MessageBox.Show("xóa brand thành công");

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("có lỗi ở hàm deletebrand :" + ex.Message);
            }
            conn.Close();
        }
        private void update()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;

                // Corrected SQL command without single quotes around parameter placeholders
                string sql = "UPDATE Book SET Title = @value_title, Author = @value_author, Genre = @value_genre, Quantity = @value_quantity WHERE BookID = @value_bookid";
                cmd.CommandText = sql;

                // Assuming tb_bookid.Text and tb_quantity.Text are valid integer strings.
                cmd.Parameters.AddWithValue("@value_bookid", int.Parse(tb_bookid.Text));
                cmd.Parameters.AddWithValue("@value_title", tb_title.Text);
                cmd.Parameters.AddWithValue("@value_author", tb_author.Text);
                cmd.Parameters.AddWithValue("@value_genre", tb_genre.Text);
                cmd.Parameters.AddWithValue("@value_quantity", int.Parse(tb_quantity.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thông tin sách thành công");
                conn.Close();
            }
            catch (Exception ex)
            {

            }
        }
        public void xemusermuonsach()
        {
            try
            {
                //kết nối dữ liệu
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                string sql = "SELECT BookLogs.BookID, BookLogs.Action, Users.UserID, Users.Username, BookLogs.Timestamp\r\nFROM BookLogs\r\njoin Users ON Users.UserID = BookLogs.UserID;";
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
                dgv3.DataSource = dt;
                //đóng kết nối 
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("có lỗi " + ex.Message);

            }
        }


        public Form3()
        {
            InitializeComponent();
            createConnection();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            displays();
            xemusermuonsach();

        }
        private void homecontroler(UserControl userControl)
        {

        }

        private void bt_addbook_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bt_delete_Click(object sender, EventArgs e)
        {

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv1.CurrentRow.Index;
            tb_bookid.Text = dgv1.Rows[i].Cells[0].Value.ToString();
            tb_title.Text = dgv1.Rows[i].Cells[1].Value.ToString();
            tb_author.Text = dgv1.Rows[i].Cells[2].Value.ToString();
            tb_genre.Text = dgv1.Rows[i].Cells[3].Value.ToString();
            tb_quantity.Text = dgv1.Rows[i].Cells[4].Value.ToString();
        }

        private void dgv1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void bt_edit_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            displays();
            tb_bookid.Text = "";
            tb_author.Text = "";
            tb_genre.Text = "";
            tb_quantity.Text = "";
            tb_title.Text = "";
        }

        private void tabpage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void bt_addbook_Click_1(object sender, EventArgs e)
        {
            try
            {
                createNewBrand();
                displays();
            }
            catch (Exception ex)
            {

            }
        }

        private void bt_delete_Click_1(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("bạn có muốn xóa không ", "xác nhận ", MessageBoxButtons.YesNo);
            if (re == DialogResult.Yes)
            {
                deletebrand();
                displays();

            }
        }

        private void bt_edit_Click_1(object sender, EventArgs e)
        {
            update();
            displays();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
