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
using QLKS.DAO;

namespace QLKS
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            //LoadAccount();
        }

        //ket noi vs database
        //private void LoadAccount()
        //{           
        //    string query = "select * from quyennv where manv = '" + user + "', matkhau = '" + pass + "'";
        //    Dataprovider provider = new Dataprovider();

        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Focus();
            txtMatKhau.Focus();
        }

        //private void dangnhap()
        //{
        //    if (txtTaiKhoan.Text.Length == 0 && txtMatKhau.Text.Length == 0)
        //        MessageBox.Show("Moi nhap");
        //    else
        //        if (this.txtTaiKhoan.Text.Length == 0)
        //        MessageBox.Show("Ban chua nhap tai khoan");
        //    else
        //        if (this.txtMatKhau.Text.Length == 0)
        //        MessageBox.Show("Ban chua nhap mat khau");
        //    else
        //        if (this.txtTaiKhoan.Text == "admin" && txtMatKhau.Text == "123")
        //        MessageBox.Show("Đăng nhập thành công!");
        //    else
        //        MessageBox.Show("Nhập sai!");
        //}

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //if (this.txtTaiKhoan.Text == "admin" && this.txtMatKhau.Text == "123")
            //{
            //    fQLKS fm = new fQLKS();
            //    this.Hide();
            //    fm.ShowDialog();
            //    this.Show();
            //}
            //dangnhap();

            // Ket noi vs database
            string userName = txtTaiKhoan.Text;
            string passWord = txtMatKhau.Text;
            if (Login(userName, passWord))
            {
                fQLKS fm = new fQLKS();
                this.Hide();
                fm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu hoặc tài khoản");
            }
        }

        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
