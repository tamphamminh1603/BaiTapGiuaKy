using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using QLKS;
namespace QLKS
{
    public partial class AccoutProfile : Form
    {
        public AccoutProfile()
        {
            InitializeComponent();
        }
    
        private void BtThoat_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn thoát không?", "thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                this.Close();
            };

        }
    }
}
