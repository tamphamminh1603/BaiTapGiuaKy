namespace QLKS
{
    partial class Booking
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DgvDanhSachPhieuDK = new System.Windows.Forms.DataGridView();
            this.lbMaPhieuDK = new System.Windows.Forms.Label();
            this.txtMaPhieuDK = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.TtxtTienCoc = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgayTra = new System.Windows.Forms.DateTimePicker();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.lbNgayDK = new System.Windows.Forms.Label();
            this.lbNgayTraPhong = new System.Windows.Forms.Label();
            this.lbMaPhong = new System.Windows.Forms.Label();
            this.lbTienCoc = new System.Windows.Forms.Label();
            this.lbDonVi = new System.Windows.Forms.Label();
            this.lbMaPhieuDV = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.cbbDonVi = new System.Windows.Forms.ComboBox();
            this.cbbMaPhieuDV = new System.Windows.Forms.ComboBox();
            this.cbbMaPhong = new System.Windows.Forms.ComboBox();
            this.dateTimePickerNgayDk = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDanhSachPhieuDK)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 532);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi tiết phiếu đăng ký";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbMaPhieuDV);
            this.groupBox1.Controls.Add(this.cbbMaPhong);
            this.groupBox1.Controls.Add(this.cbbDonVi);
            this.groupBox1.Controls.Add(this.btThem);
            this.groupBox1.Controls.Add(this.dateTimePickerNgayTra);
            this.groupBox1.Controls.Add(this.dateTimePickerNgayDk);
            this.groupBox1.Controls.Add(this.TtxtTienCoc);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.txtMaPhieuDK);
            this.groupBox1.Controls.Add(this.lbMaPhieuDV);
            this.groupBox1.Controls.Add(this.lbDonVi);
            this.groupBox1.Controls.Add(this.lbTienCoc);
            this.groupBox1.Controls.Add(this.lbMaPhong);
            this.groupBox1.Controls.Add(this.lbNgayTraPhong);
            this.groupBox1.Controls.Add(this.lbNgayDK);
            this.groupBox1.Controls.Add(this.lbMaKH);
            this.groupBox1.Controls.Add(this.lbMaNV);
            this.groupBox1.Controls.Add(this.lbMaPhieuDK);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 389);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btthoat);
            this.groupBox2.Controls.Add(this.btSua);
            this.groupBox2.Controls.Add(this.btXoa);
            this.groupBox2.Controls.Add(this.DgvDanhSachPhieuDK);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(312, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(587, 332);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phiếu đăng ký";
            // 
            // DgvDanhSachPhieuDK
            // 
            this.DgvDanhSachPhieuDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDanhSachPhieuDK.Dock = System.Windows.Forms.DockStyle.Top;
            this.DgvDanhSachPhieuDK.Location = new System.Drawing.Point(3, 18);
            this.DgvDanhSachPhieuDK.Name = "DgvDanhSachPhieuDK";
            this.DgvDanhSachPhieuDK.Size = new System.Drawing.Size(581, 245);
            this.DgvDanhSachPhieuDK.TabIndex = 0;
            // 
            // lbMaPhieuDK
            // 
            this.lbMaPhieuDK.AutoSize = true;
            this.lbMaPhieuDK.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPhieuDK.Location = new System.Drawing.Point(6, 32);
            this.lbMaPhieuDK.Name = "lbMaPhieuDK";
            this.lbMaPhieuDK.Size = new System.Drawing.Size(107, 15);
            this.lbMaPhieuDK.TabIndex = 0;
            this.lbMaPhieuDK.Text = "Mã phiếu đăng ký:";
            // 
            // txtMaPhieuDK
            // 
            this.txtMaPhieuDK.Location = new System.Drawing.Point(134, 29);
            this.txtMaPhieuDK.Name = "txtMaPhieuDK";
            this.txtMaPhieuDK.Size = new System.Drawing.Size(141, 22);
            this.txtMaPhieuDK.TabIndex = 1;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(134, 61);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(141, 22);
            this.txtMaNV.TabIndex = 1;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(134, 90);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(141, 22);
            this.txtMaKH.TabIndex = 1;
            // 
            // TtxtTienCoc
            // 
            this.TtxtTienCoc.Location = new System.Drawing.Point(134, 229);
            this.TtxtTienCoc.Name = "TtxtTienCoc";
            this.TtxtTienCoc.Size = new System.Drawing.Size(141, 22);
            this.TtxtTienCoc.TabIndex = 1;
            // 
            // dateTimePickerNgayTra
            // 
            this.dateTimePickerNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayTra.Location = new System.Drawing.Point(134, 161);
            this.dateTimePickerNgayTra.Name = "dateTimePickerNgayTra";
            this.dateTimePickerNgayTra.Size = new System.Drawing.Size(141, 22);
            this.dateTimePickerNgayTra.TabIndex = 2;
            this.dateTimePickerNgayTra.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNV.Location = new System.Drawing.Point(6, 66);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(83, 15);
            this.lbMaNV.TabIndex = 0;
            this.lbMaNV.Text = "Mã nhân viên:";
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKH.Location = new System.Drawing.Point(6, 92);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(95, 15);
            this.lbMaKH.TabIndex = 0;
            this.lbMaKH.Text = "Mã khách hàng:";
            // 
            // lbNgayDK
            // 
            this.lbNgayDK.AutoSize = true;
            this.lbNgayDK.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayDK.Location = new System.Drawing.Point(6, 127);
            this.lbNgayDK.Name = "lbNgayDK";
            this.lbNgayDK.Size = new System.Drawing.Size(89, 15);
            this.lbNgayDK.TabIndex = 0;
            this.lbNgayDK.Text = "Ngày Đăng Ký:";
            // 
            // lbNgayTraPhong
            // 
            this.lbNgayTraPhong.AutoSize = true;
            this.lbNgayTraPhong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayTraPhong.Location = new System.Drawing.Point(6, 161);
            this.lbNgayTraPhong.Name = "lbNgayTraPhong";
            this.lbNgayTraPhong.Size = new System.Drawing.Size(94, 15);
            this.lbNgayTraPhong.TabIndex = 0;
            this.lbNgayTraPhong.Text = "Ngày trả phòng:";
            // 
            // lbMaPhong
            // 
            this.lbMaPhong.AutoSize = true;
            this.lbMaPhong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPhong.Location = new System.Drawing.Point(6, 195);
            this.lbMaPhong.Name = "lbMaPhong";
            this.lbMaPhong.Size = new System.Drawing.Size(64, 15);
            this.lbMaPhong.TabIndex = 0;
            this.lbMaPhong.Text = "Mã phòng:";
            // 
            // lbTienCoc
            // 
            this.lbTienCoc.AutoSize = true;
            this.lbTienCoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienCoc.Location = new System.Drawing.Point(6, 231);
            this.lbTienCoc.Name = "lbTienCoc";
            this.lbTienCoc.Size = new System.Drawing.Size(53, 15);
            this.lbTienCoc.TabIndex = 0;
            this.lbTienCoc.Text = "Tiền cọc";
            // 
            // lbDonVi
            // 
            this.lbDonVi.AutoSize = true;
            this.lbDonVi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonVi.Location = new System.Drawing.Point(6, 268);
            this.lbDonVi.Name = "lbDonVi";
            this.lbDonVi.Size = new System.Drawing.Size(46, 15);
            this.lbDonVi.TabIndex = 0;
            this.lbDonVi.Tag = "";
            this.lbDonVi.Text = "Đơn vị:";
            // 
            // lbMaPhieuDV
            // 
            this.lbMaPhieuDV.AutoSize = true;
            this.lbMaPhieuDV.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPhieuDV.Location = new System.Drawing.Point(6, 305);
            this.lbMaPhieuDV.Name = "lbMaPhieuDV";
            this.lbMaPhieuDV.Size = new System.Drawing.Size(103, 15);
            this.lbMaPhieuDV.TabIndex = 0;
            this.lbMaPhieuDV.Text = "Mã Phiếu Dịch vụ";
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(182, 344);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(93, 29);
            this.btThem.TabIndex = 3;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(232, 286);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(93, 29);
            this.btXoa.TabIndex = 3;
            this.btXoa.Text = "Xóa ";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(349, 286);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(93, 29);
            this.btSua.TabIndex = 3;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // btthoat
            // 
            this.btthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthoat.Location = new System.Drawing.Point(465, 286);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(93, 29);
            this.btthoat.TabIndex = 3;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            // 
            // cbbDonVi
            // 
            this.cbbDonVi.FormattingEnabled = true;
            this.cbbDonVi.Location = new System.Drawing.Point(134, 264);
            this.cbbDonVi.Name = "cbbDonVi";
            this.cbbDonVi.Size = new System.Drawing.Size(141, 24);
            this.cbbDonVi.TabIndex = 4;
            this.cbbDonVi.Text = "VND";
            this.cbbDonVi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbbMaPhieuDV
            // 
            this.cbbMaPhieuDV.FormattingEnabled = true;
            this.cbbMaPhieuDV.Location = new System.Drawing.Point(134, 305);
            this.cbbMaPhieuDV.Name = "cbbMaPhieuDV";
            this.cbbMaPhieuDV.Size = new System.Drawing.Size(141, 24);
            this.cbbMaPhieuDV.TabIndex = 4;
            // 
            // cbbMaPhong
            // 
            this.cbbMaPhong.FormattingEnabled = true;
            this.cbbMaPhong.Location = new System.Drawing.Point(134, 195);
            this.cbbMaPhong.Name = "cbbMaPhong";
            this.cbbMaPhong.Size = new System.Drawing.Size(141, 24);
            this.cbbMaPhong.TabIndex = 4;
            this.cbbMaPhong.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePickerNgayDk
            // 
            this.dateTimePickerNgayDk.Checked = false;
            this.dateTimePickerNgayDk.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayDk.Location = new System.Drawing.Point(134, 127);
            this.dateTimePickerNgayDk.Name = "dateTimePickerNgayDk";
            this.dateTimePickerNgayDk.Size = new System.Drawing.Size(141, 22);
            this.dateTimePickerNgayDk.TabIndex = 2;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 532);
            this.Controls.Add(this.panel1);
            this.Name = "Booking";
            this.Text = "Booking";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDanhSachPhieuDK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DgvDanhSachPhieuDK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaPhieuDK;
        private System.Windows.Forms.Label lbMaPhieuDK;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayTra;
        private System.Windows.Forms.TextBox TtxtTienCoc;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label lbMaPhieuDV;
        private System.Windows.Forms.Label lbDonVi;
        private System.Windows.Forms.Label lbTienCoc;
        private System.Windows.Forms.Label lbMaPhong;
        private System.Windows.Forms.Label lbNgayTraPhong;
        private System.Windows.Forms.Label lbNgayDK;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.ComboBox cbbMaPhieuDV;
        private System.Windows.Forms.ComboBox cbbDonVi;
        private System.Windows.Forms.ComboBox cbbMaPhong;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayDk;
    }
}