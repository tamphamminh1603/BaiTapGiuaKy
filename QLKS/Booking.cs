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
namespace QLKS
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }
        private void ketnoi()
        {
            try           {
                SqlConnection kn = new SqlConnection(@"Data Source=LAPTOP-3CRPGS0S;Initial Catalog=dataQLKS1;Integrated Security=True");
                kn.Open();
                string sql = "select * from datphong";
                SqlCommand commandsql = new SqlCommand(sql, kn); //thực thi các câu lệnh trong sql
                SqlDataAdapter com = new SqlDataAdapter(commandsql); // Vận chuyển dữ liệu
                DataTable table = new DataTable(); // tạo bảng ảo trong hệ thống
                com.Fill(table); // đỗ dữ liệu vào bảng ảo
                DgvDanhSachPhieuDK.DataSource = table; // bảng ảo được đưa vào dataGridview
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

        private void Booking_Load(object sender, EventArgs e)
        {
            ketnoi();
        }

      
        int index;
        private void DgvDanhSachPhieuDK_Click(object sender, EventArgs e)
        {
            index = DgvDanhSachPhieuDK.CurrentRow.Index;
            txtMaPhieuDP.Text = DgvDanhSachPhieuDK.Rows[index].Cells[0].Value.ToString();
            txtMaNV.Text = DgvDanhSachPhieuDK.Rows[index].Cells[1].Value.ToString();
            txtMaKH.Text = DgvDanhSachPhieuDK.Rows[index].Cells[2].Value.ToString();
            cbTenLoaiPhong.Text = DgvDanhSachPhieuDK.Rows[index].Cells[3].Value.ToString();
            txtNgayDK.Text = DgvDanhSachPhieuDK.Rows[index].Cells[4].Value.ToString();
            txtNgayDen.Text = DgvDanhSachPhieuDK.Rows[index].Cells[5].Value.ToString();
            txtNgayTraPhong.Text = DgvDanhSachPhieuDK.Rows[index].Cells[6].Value.ToString();
            txtTienCoc.Text = DgvDanhSachPhieuDK.Rows[index].Cells[7].Value.ToString();
            txtSoLuongPhong.Text = DgvDanhSachPhieuDK.Rows[index].Cells[8].Value.ToString();
            cbTrangThai.Text = DgvDanhSachPhieuDK.Rows[index].Cells[9].Value.ToString();
           

        }

        //string themKH;
        //string themHD;
        string them;      
        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=LAPTOP-3CRPGS0S;Initial Catalog=dataQLKS1;Integrated Security=True");
                kn.Open();

                them = "insert into datphong values('" + txtMaPhieuDP.Text + "','" + txtMaNV.Text + "','" + txtMaKH.Text + "','" + cbTenLoaiPhong.Text + "','" + txtNgayDK.Text + "','" + txtNgayDen.Text + "','" + txtNgayTraPhong.Text + "','" + txtTienCoc.Text + "','" + txtSoLuongPhong.Text + "','" + cbTrangThai.Text + "' )";
                //themKH = "insert in khachhang values('" + txtMaKH.Text + "')";
                //themHD = "insert in hoadon values('" + txtHoaDon.Text + "')";
                SqlCommand commandthem = new SqlCommand(them, kn);
                //SqlCommand command = new SqlCommand(themHD, kn);
                commandthem.ExecuteNonQuery();
                //command.ExecuteNonQuery();
                ketnoi();

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

        string xoaphieudatphong;
       // string xoahoadon;
        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=LAPTOP-3CRPGS0S;Initial Catalog=dataQLKS1;Integrated Security=True");
                kn.Open();
                xoaphieudatphong = "delete datphong where madp = '" + txtMaPhieuDP.Text + "'";
               // xoahoadon = "delete hoadon where madp = '" + txtMaPhieuDP.Text + "'";
                SqlCommand comm = new SqlCommand(xoaphieudatphong, kn);
               // SqlCommand conn = new SqlCommand(xoahoadon, kn);
                comm.ExecuteNonQuery();
                //conn.ExecuteNonQuery();
                ketnoi();

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
                sua = "update datphong set manv ='" + txtMaNV.Text + "', makh ='" + txtMaKH.Text + "', tenlp ='" + cbTenLoaiPhong.Text + "', ngaydat ='" + txtNgayDK.Text + "', ngayden ='" + txtNgayDen.Text + "', ngaydi ='" + txtNgayTraPhong.Text + "', tiendatcoc ='" + txtTienCoc.Text + "', soluong ='" + txtSoLuongPhong.Text + "',trangthai ='" + cbTrangThai.Text + "' where madp = '" +txtMaPhieuDP.Text+ "'";
                SqlCommand commandsua = new SqlCommand(sua, kn);
                commandsua.ExecuteNonQuery();
                ketnoi();
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
