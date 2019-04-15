namespace QLKS
{
    partial class fQLKH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQLKH));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.lbMaPhieuDV = new System.Windows.Forms.Label();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.txbMaKH = new System.Windows.Forms.TextBox();
            this.lbMaPhong = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.lbNgayTraPhong = new System.Windows.Forms.Label();
            this.txbSDT = new System.Windows.Forms.TextBox();
            this.txbCMND = new System.Windows.Forms.TextBox();
            this.lbNgayDK = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DgvKhachHang = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvKhachHang)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 569);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.btXoa);
            this.panel5.Controls.Add(this.btThem);
            this.panel5.Controls.Add(this.btthoat);
            this.panel5.Controls.Add(this.btSua);
            this.panel5.Location = new System.Drawing.Point(3, 419);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1018, 150);
            this.panel5.TabIndex = 18;
            // 
            // btXoa
            // 
            this.btXoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(751, 48);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(93, 63);
            this.btXoa.TabIndex = 8;
            this.btXoa.Text = "Xóa ";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(108, 48);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(93, 63);
            this.btThem.TabIndex = 7;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btthoat
            // 
            this.btthoat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthoat.Location = new System.Drawing.Point(504, 48);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(93, 63);
            this.btthoat.TabIndex = 10;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btSua
            // 
            this.btSua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(308, 48);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(93, 63);
            this.btSua.TabIndex = 9;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.Controls.Add(this.lbMaKH);
            this.panel4.Controls.Add(this.lbMaPhieuDV);
            this.panel4.Controls.Add(this.txbDiaChi);
            this.panel4.Controls.Add(this.txbMaKH);
            this.panel4.Controls.Add(this.lbMaPhong);
            this.panel4.Controls.Add(this.txbEmail);
            this.panel4.Controls.Add(this.txbHoTen);
            this.panel4.Controls.Add(this.lbMaNV);
            this.panel4.Controls.Add(this.lbNgayTraPhong);
            this.panel4.Controls.Add(this.txbSDT);
            this.panel4.Controls.Add(this.txbCMND);
            this.panel4.Controls.Add(this.lbNgayDK);
            this.panel4.Location = new System.Drawing.Point(3, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(364, 327);
            this.panel4.TabIndex = 17;
            // 
            // lbMaKH
            // 
            this.lbMaKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKH.Location = new System.Drawing.Point(49, 16);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(95, 15);
            this.lbMaKH.TabIndex = 0;
            this.lbMaKH.Text = "Mã khách hàng:";
            // 
            // lbMaPhieuDV
            // 
            this.lbMaPhieuDV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbMaPhieuDV.AutoSize = true;
            this.lbMaPhieuDV.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPhieuDV.Location = new System.Drawing.Point(49, 84);
            this.lbMaPhieuDV.Name = "lbMaPhieuDV";
            this.lbMaPhieuDV.Size = new System.Drawing.Size(49, 15);
            this.lbMaPhieuDV.TabIndex = 0;
            this.lbMaPhieuDV.Text = "CMND:";
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txbDiaChi.Location = new System.Drawing.Point(172, 187);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(145, 20);
            this.txbDiaChi.TabIndex = 6;
            // 
            // txbMaKH
            // 
            this.txbMaKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txbMaKH.Location = new System.Drawing.Point(172, 9);
            this.txbMaKH.Name = "txbMaKH";
            this.txbMaKH.Size = new System.Drawing.Size(145, 20);
            this.txbMaKH.TabIndex = 1;        
            // 
            // lbMaPhong
            // 
            this.lbMaPhong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbMaPhong.AutoSize = true;
            this.lbMaPhong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPhong.Location = new System.Drawing.Point(49, 194);
            this.lbMaPhong.Name = "lbMaPhong";
            this.lbMaPhong.Size = new System.Drawing.Size(50, 15);
            this.lbMaPhong.TabIndex = 0;
            this.lbMaPhong.Text = "Địa chỉ:";
            // 
            // txbEmail
            // 
            this.txbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txbEmail.Location = new System.Drawing.Point(172, 150);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(145, 20);
            this.txbEmail.TabIndex = 5;
            // 
            // txbHoTen
            // 
            this.txbHoTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txbHoTen.Location = new System.Drawing.Point(172, 37);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.Size = new System.Drawing.Size(145, 20);
            this.txbHoTen.TabIndex = 2;
            // 
            // lbMaNV
            // 
            this.lbMaNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNV.Location = new System.Drawing.Point(49, 49);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(60, 15);
            this.lbMaNV.TabIndex = 0;
            this.lbMaNV.Text = "Họ và tên:";
            // 
            // lbNgayTraPhong
            // 
            this.lbNgayTraPhong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbNgayTraPhong.AutoSize = true;
            this.lbNgayTraPhong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayTraPhong.Location = new System.Drawing.Point(49, 157);
            this.lbNgayTraPhong.Name = "lbNgayTraPhong";
            this.lbNgayTraPhong.Size = new System.Drawing.Size(42, 15);
            this.lbNgayTraPhong.TabIndex = 0;
            this.lbNgayTraPhong.Text = "Email:";
            // 
            // txbSDT
            // 
            this.txbSDT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txbSDT.Location = new System.Drawing.Point(172, 116);
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.Size = new System.Drawing.Size(145, 20);
            this.txbSDT.TabIndex = 4;
            // 
            // txbCMND
            // 
            this.txbCMND.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txbCMND.Location = new System.Drawing.Point(172, 77);
            this.txbCMND.Name = "txbCMND";
            this.txbCMND.Size = new System.Drawing.Size(145, 20);
            this.txbCMND.TabIndex = 3;
            // 
            // lbNgayDK
            // 
            this.lbNgayDK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbNgayDK.AutoSize = true;
            this.lbNgayDK.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayDK.Location = new System.Drawing.Point(49, 123);
            this.lbNgayDK.Name = "lbNgayDK";
            this.lbNgayDK.Size = new System.Drawing.Size(81, 15);
            this.lbNgayDK.TabIndex = 0;
            this.lbNgayDK.Text = "Số điện thoại:";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.DgvKhachHang);
            this.panel3.Location = new System.Drawing.Point(373, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(648, 327);
            this.panel3.TabIndex = 16;
            // 
            // DgvKhachHang
            // 
            this.DgvKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvKhachHang.Location = new System.Drawing.Point(0, 0);
            this.DgvKhachHang.Name = "DgvKhachHang";
            this.DgvKhachHang.Size = new System.Drawing.Size(647, 324);
            this.DgvKhachHang.TabIndex = 15;
            this.DgvKhachHang.Click += new System.EventHandler(this.DgvKhachHang_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 80);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách hàng đăng ký";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fQLKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 569);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fQLKH";
            this.Text = " ";
            this.Load += new System.EventHandler(this.fQLKH_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvKhachHang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.DataGridView DgvKhachHang;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.TextBox txbMaKH;
        private System.Windows.Forms.Label lbMaPhieuDV;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMaPhong;
        private System.Windows.Forms.Label lbNgayTraPhong;
        private System.Windows.Forms.Label lbNgayDK;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbSDT;
        private System.Windows.Forms.TextBox txbCMND;
        private System.Windows.Forms.TextBox txbHoTen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}