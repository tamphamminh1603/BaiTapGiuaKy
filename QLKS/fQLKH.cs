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
    public partial class fQLKH : Form
    {
        public fQLKH()
        {
            InitializeComponent();
        }
        private void Ketnoi()
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=LAPTOP-3CRPGS0S;Initial Catalog=dataQLKS1;Integrated Security=True");
                kn.Open();
                string sql = "select * from khachhang";
                SqlCommand commandsql = new SqlCommand(sql, kn); //thực thi các câu lệnh trong sql
                SqlDataAdapter com = new SqlDataAdapter(commandsql); // Vận chuyển dữ liệu
                DataTable table = new DataTable(); // tạo bảng ảo trong hệ thống
                com.Fill(table); // đỗ dữ liệu vào bảng ảo
                DgvKhachHang.DataSource = table; // bảng ảo được đưa vào dataGridview
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối vui lòng kiểm tra lại!");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=LAPTOP-3CRPGS0S;Initial Catalog=dataQLKS1;Integrated Security=True");
                kn.Close();
            }

        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn thoát không?", "thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                fQLKS f = new fQLKS();
                this.Hide();
                f.ShowDialog();
            }
        }

        private void fQLKH_Load(object sender, EventArgs e)
        {
            Ketnoi();
        }

        int index;
        private void DgvKhachHang_Click(object sender, EventArgs e)
        {
            index = DgvKhachHang.CurrentRow.Index;
            txbMaKH.Text = DgvKhachHang.Rows[index].Cells[0].Value.ToString();
            txbHoTen.Text = DgvKhachHang.Rows[index].Cells[1].Value.ToString();
            txbCMND.Text = DgvKhachHang.Rows[index].Cells[2].Value.ToString();
            txbSDT.Text = DgvKhachHang.Rows[index].Cells[3].Value.ToString();
            txbEmail.Text = DgvKhachHang.Rows[index].Cells[4].Value.ToString();
            txbDiaChi.Text = DgvKhachHang.Rows[index].Cells[5].Value.ToString();

        }

        string them;
        string themPhieu;
        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=LAPTOP-3CRPGS0S;Initial Catalog=dataQLKS1;Integrated Security=True");
                kn.Open();
               
                them = "insert into khachhang values ('"+txbMaKH.Text+"','"+ txbHoTen.Text+"','"+ txbCMND.Text+"','"+txbSDT.Text+ "','"+txbEmail.Text+"','"+txbDiaChi.Text+"')";
                themPhieu = "insert into datphong values ('" +txbMaKH.Text+ "')";
                SqlCommand commandthem = new SqlCommand(them, kn);
                commandthem.ExecuteNonQuery();
                Ketnoi();
            }
            catch
            {
                MessageBox.Show("Lỗi , Không thêm được!");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=LAPTOP-3CRPGS0S;Initial Catalog=dataQLKS1;Integrated Security=True");
                kn.Close();
            }
        }

        string xoa;
        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=LAPTOP-3CRPGS0S;Initial Catalog=dataQLKS1;Integrated Security=True");
                kn.Open();
                xoa = "delete khachhang where makh = '" + txbMaKH.Text + "'";
                SqlCommand comm = new SqlCommand(xoa, kn);
                comm.ExecuteNonQuery();
                Ketnoi();
                MessageBox.Show("Xóa thành công(--)");
            }
            catch
            {
                MessageBox.Show("Lỗi! xóa không được:");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=LAPTOP-3CRPGS0S;Initial Catalog=dataQLKS1;Integrated Security=True");
                kn.Close();
            }
        }

        string sua;
        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=LAPTOP-3CRPGS0S;Initial Catalog=dataQLKS1;Integrated Security=True");
                kn.Open();
                sua = "update khachhang set hoten ='" + txbHoTen.Text + "', cmnd ='" + txbCMND.Text + "', sdt ='" + txbSDT.Text + "', email ='" + txbEmail.Text + "', diachi ='" + txbDiaChi.Text + "' where makh ='" + txbMaKH.Text + "'";
                SqlCommand commandsua = new SqlCommand(sua, kn);
                commandsua.ExecuteNonQuery();
                Ketnoi();
                MessageBox.Show("Sửa thành công(--)");
            }
            catch
            {
                MessageBox.Show("Lỗi !");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=LAPTOP-3CRPGS0S;Initial Catalog=dataQLKS1;Integrated Security=True");
                kn.Close();
            }
        } 
    }
}
