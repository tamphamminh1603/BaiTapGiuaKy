using QLKS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            string query = "select * from khachhang";
            DgvKhachHang.DataSource = DataProvider.Instance.ExecuteQuery(query);

        }
        public string RemoveAllWhitespace(string str)
        {
            try
            {
                Regex reg = new Regex(@"\s*");
                str = reg.Replace(str, "");
                return str;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CheckAllWhitespace()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                {
                    if (txbMaKH.Text == "" || txbHoTen.Text == "" || txbCMND.Text == "" || txbEmail.Text == "" || txbSDT.Text == "")
                    {
                        //RemoveAllWhitespace(txbMaKH.Text);
                        //RemoveAllWhitespace(txbEmail.Text);
                        //RemoveAllWhitespace(txbHoTen.Text);
                        MessageBox.Show("Không được để trống: ");
                        txbMaKH.Focus();
                        SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS1;Initial Catalog=dataQLKS;Integrated Security=True");
                        kn.Close();
                        //DgvKhachHang.Enabled();
                        return;

                    }
                }
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
                SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS1;Initial Catalog=dataQLKS;Integrated Security=True");
                kn.Open();
                CheckAllWhitespace();
                them = ("insert into khachhang values ('"+txbMaKH.Text+"',N'"+ txbHoTen.Text+"','"+ txbCMND.Text+"','"+txbSDT.Text+ "','"+txbEmail.Text+"',N'"+txbDiaChi.Text+"')");
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
                SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS1;Initial Catalog=dataQLKS;Integrated Security=True");
                kn.Close();
            }
        }

        string xoadatphong;
        string xoa;
        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS1;Initial Catalog=dataQLKS;Integrated Security=True");
                kn.Open();
                CheckAllWhitespace();
                xoa = "delete khachhang where makh = '" + txbMaKH.Text + "'";
                xoadatphong = "delete datphong where makh = '" + txbMaKH.Text + "'";
                SqlCommand comm = new SqlCommand(xoa, kn);
                //SqlCommand com = new SqlCommand(xoadatphong, kn);
                comm.ExecuteNonQuery();
                //com.ExecuteNonQuery();
                Ketnoi();
                MessageBox.Show("Xóa thành công(--)");
            }
            catch
            {
                MessageBox.Show("Lỗi! xóa không được:");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS1;Initial Catalog=dataQLKS;Integrated Security=True");
                kn.Close();
            }
        }

        string sua;
        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS1;Initial Catalog=dataQLKS;Integrated Security=True");
                kn.Open();
                CheckAllWhitespace();
                sua = "update khachhang set hoten = N'" + txbHoTen.Text + "', cmnd ='" + txbCMND.Text + "', sdt ='" + txbSDT.Text + "', email ='" + txbEmail.Text + "', diachi = N'" + txbDiaChi.Text + "' where makh ='" + txbMaKH.Text + "'";
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
                SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS1;Initial Catalog=dataQLKS;Integrated Security=True");
                kn.Close();
            }
        }

      
    }
}
