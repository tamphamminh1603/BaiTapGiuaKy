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

namespace QLKS
{
    public partial class fQuanLyPhong : Form
    {
        public fQuanLyPhong()
        {
            InitializeComponent();
        }

        private void ketnoi1()
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=LAPTOP-3CRPGS0S;Initial Catalog=dataQLKS;Integrated Security=True");
                kn.Open();
                string sql = "select * from phong";
                SqlCommand commandsql = new SqlCommand(sql, kn); //thực thi các câu lệnh trong sql
                SqlDataAdapter com = new SqlDataAdapter(commandsql); // Vận chuyển dữ liệu
                DataTable table = new DataTable(); // tạo bảng ảo trong hệ thống
                com.Fill(table); // đỗ dữ liệu vào bảng ảo
                DgvQLKS.DataSource = table; // bảng ảo được đưa vào dataGridview
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối vui lòng kiểm tra lại!");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=LAPTOP-3CRPGS0S;Initial Catalog=dataQLKS;Integrated Security=True");
                kn.Close();
            }

        }
  
        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccoutProfile f = new AccoutProfile();
            f.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Booking b = new Booking();
            this.Hide();
            b.ShowDialog();
        }
        int index;

        private void DgvQLKS_Click(object sender, EventArgs e)
        {
            index = DgvQLKS.CurrentRow.Index;
            txbMaPhong.Text = DgvQLKS.Rows[index].Cells[0].Value.ToString();
            txbTenLoaiPhong.Text = DgvQLKS.Rows[index].Cells[1].Value.ToString();
            txbTinhTrang.Text = DgvQLKS.Rows[index].Cells[2].Value.ToString();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ketnoi1();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn thoát không?", "thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                this.Close();
            }
        }
        string them;
        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=LAPTOP-3CRPGS0S;Initial Catalog=dataQLKS;Integrated Security=True");
                kn.Open();
                them = "insert into phong values('"+txbMaPhong.Text+"','"+txbTenLoaiPhong.Text+"','"+txbTinhTrang.Text +"')";
                SqlCommand commandthem = new SqlCommand(them, kn);
                commandthem.ExecuteNonQuery();
                ketnoi1();
                MessageBox.Show("Thêm thành công!");
            }
            catch
            {
                MessageBox.Show("Lỗi , Không thêm được!");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=LAPTOP-3CRPGS0S;Initial Catalog=dataQLKS;Integrated Security=True");
                kn.Close();
            }
        }

        string xoaphong;
        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=LAPTOP-3CRPGS0S;Initial Catalog=dataQLKS;Integrated Security=True");
                kn.Open();
                xoaphong = "delete phong where maphong = '" + txbMaPhong.Text + "'";              
                SqlCommand comm = new SqlCommand(xoaphong, kn);
                comm.ExecuteNonQuery();
                ketnoi1();

            }
            catch
            {
                MessageBox.Show("Lỗi! xóa không được:");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=LAPTOP-3CRPGS0S;Initial Catalog=dataQLKS;Integrated Security=True");
                kn.Close();
            }
        }

        string sua;
        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=LAPTOP-3CRPGS0S;Initial Catalog=dataQLKS;Integrated Security=True");
                kn.Open();
                sua = "update phong set tenlp ='"+txbTenLoaiPhong.Text+"', tinhtrang = '"+ txbTinhTrang.Text+"' where maphong = '" + txbMaPhong.Text+"'";
                SqlCommand commandsua = new SqlCommand(sua, kn);
                commandsua.ExecuteNonQuery();
                ketnoi1();
            }
            catch
            {
                MessageBox.Show("Lỗi !");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=LAPTOP-3CRPGS0S;Initial Catalog=dataQLKS;Integrated Security=True");
                kn.Close();
            }
        }
    }
}
