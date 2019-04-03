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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btthoat = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.DgvDanhSachPhieuDK = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNgayTraPhong = new System.Windows.Forms.DateTimePicker();
            this.txtNgayDen = new System.Windows.Forms.DateTimePicker();
            this.txtNgayDK = new System.Windows.Forms.DateTimePicker();
            this.btThem = new System.Windows.Forms.Button();
            this.txtHoaDon = new System.Windows.Forms.TextBox();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.txtSoLuongPhong = new System.Windows.Forms.TextBox();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.txtTenLoaiPhong = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaPhieuDP = new System.Windows.Forms.TextBox();
            this.lbMaPhieuDV = new System.Windows.Forms.Label();
            this.lbMaHoaDon = new System.Windows.Forms.Label();
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.lbSoLuongPhong = new System.Windows.Forms.Label();
            this.lbTienCoc = new System.Windows.Forms.Label();
            this.lbMaPhong = new System.Windows.Forms.Label();
            this.lbNgayTraPhong = new System.Windows.Forms.Label();
            this.lbNgayDK = new System.Windows.Forms.Label();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.lbMaPhieuDP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataQLKSDataSet = new QLKS.dataQLKSDataSet();
            this.dataQLKSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDanhSachPhieuDK)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataQLKSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataQLKSDataSetBindingSource)).BeginInit();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 655);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btthoat);
            this.groupBox2.Controls.Add(this.btSua);
            this.groupBox2.Controls.Add(this.btXoa);
            this.groupBox2.Controls.Add(this.DgvDanhSachPhieuDK);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(364, 98);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(685, 409);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phiếu đăng ký";
            // 
            // btthoat
            // 
            this.btthoat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthoat.Location = new System.Drawing.Point(542, 352);
            this.btthoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(108, 36);
            this.btthoat.TabIndex = 3;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(407, 352);
            this.btSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(108, 36);
            this.btSua.TabIndex = 3;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(271, 352);
            this.btXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(108, 36);
            this.btXoa.TabIndex = 3;
            this.btXoa.Text = "Xóa ";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // DgvDanhSachPhieuDK
            // 
            this.DgvDanhSachPhieuDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDanhSachPhieuDK.Location = new System.Drawing.Point(3, 22);
            this.DgvDanhSachPhieuDK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DgvDanhSachPhieuDK.Name = "DgvDanhSachPhieuDK";
            this.DgvDanhSachPhieuDK.Size = new System.Drawing.Size(678, 302);
            this.DgvDanhSachPhieuDK.TabIndex = 0;
            this.DgvDanhSachPhieuDK.Click += new System.EventHandler(this.DgvDanhSachPhieuDK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNgayTraPhong);
            this.groupBox1.Controls.Add(this.txtNgayDen);
            this.groupBox1.Controls.Add(this.txtNgayDK);
            this.groupBox1.Controls.Add(this.btThem);
            this.groupBox1.Controls.Add(this.txtHoaDon);
            this.groupBox1.Controls.Add(this.txtTrangThai);
            this.groupBox1.Controls.Add(this.txtSoLuongPhong);
            this.groupBox1.Controls.Add(this.txtTienCoc);
            this.groupBox1.Controls.Add(this.txtTenLoaiPhong);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.txtMaPhieuDP);
            this.groupBox1.Controls.Add(this.lbMaPhieuDV);
            this.groupBox1.Controls.Add(this.lbMaHoaDon);
            this.groupBox1.Controls.Add(this.lbTrangThai);
            this.groupBox1.Controls.Add(this.lbSoLuongPhong);
            this.groupBox1.Controls.Add(this.lbTienCoc);
            this.groupBox1.Controls.Add(this.lbMaPhong);
            this.groupBox1.Controls.Add(this.lbNgayTraPhong);
            this.groupBox1.Controls.Add(this.lbNgayDK);
            this.groupBox1.Controls.Add(this.lbMaKH);
            this.groupBox1.Controls.Add(this.lbMaNV);
            this.groupBox1.Controls.Add(this.lbMaPhieuDP);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 98);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(343, 508);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết";
            // 
            // txtNgayTraPhong
            // 
            this.txtNgayTraPhong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgayTraPhong.Location = new System.Drawing.Point(154, 266);
            this.txtNgayTraPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNgayTraPhong.Name = "txtNgayTraPhong";
            this.txtNgayTraPhong.Size = new System.Drawing.Size(165, 26);
            this.txtNgayTraPhong.TabIndex = 4;
            // 
            // txtNgayDen
            // 
            this.txtNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgayDen.Location = new System.Drawing.Point(154, 224);
            this.txtNgayDen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNgayDen.Name = "txtNgayDen";
            this.txtNgayDen.Size = new System.Drawing.Size(165, 26);
            this.txtNgayDen.TabIndex = 4;
            // 
            // txtNgayDK
            // 
            this.txtNgayDK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgayDK.Location = new System.Drawing.Point(155, 182);
            this.txtNgayDK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNgayDK.Name = "txtNgayDK";
            this.txtNgayDK.Size = new System.Drawing.Size(165, 26);
            this.txtNgayDK.TabIndex = 4;
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(211, 465);
            this.btThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(108, 36);
            this.btThem.TabIndex = 3;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // txtHoaDon
            // 
            this.txtHoaDon.Location = new System.Drawing.Point(154, 432);
            this.txtHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoaDon.Name = "txtHoaDon";
            this.txtHoaDon.Size = new System.Drawing.Size(164, 26);
            this.txtHoaDon.TabIndex = 1;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Location = new System.Drawing.Point(155, 399);
            this.txtTrangThai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(164, 26);
            this.txtTrangThai.TabIndex = 1;
            // 
            // txtSoLuongPhong
            // 
            this.txtSoLuongPhong.Location = new System.Drawing.Point(155, 359);
            this.txtSoLuongPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuongPhong.Name = "txtSoLuongPhong";
            this.txtSoLuongPhong.Size = new System.Drawing.Size(164, 26);
            this.txtSoLuongPhong.TabIndex = 1;
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.Location = new System.Drawing.Point(155, 316);
            this.txtTienCoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.Size = new System.Drawing.Size(164, 26);
            this.txtTienCoc.TabIndex = 1;
            // 
            // txtTenLoaiPhong
            // 
            this.txtTenLoaiPhong.Location = new System.Drawing.Point(156, 149);
            this.txtTenLoaiPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenLoaiPhong.Name = "txtTenLoaiPhong";
            this.txtTenLoaiPhong.Size = new System.Drawing.Size(164, 26);
            this.txtTenLoaiPhong.TabIndex = 1;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(156, 111);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(164, 26);
            this.txtMaKH.TabIndex = 1;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(156, 75);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(164, 26);
            this.txtMaNV.TabIndex = 1;
            // 
            // txtMaPhieuDP
            // 
            this.txtMaPhieuDP.Location = new System.Drawing.Point(156, 36);
            this.txtMaPhieuDP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaPhieuDP.Name = "txtMaPhieuDP";
            this.txtMaPhieuDP.Size = new System.Drawing.Size(164, 26);
            this.txtMaPhieuDP.TabIndex = 1;
            // 
            // lbMaPhieuDV
            // 
            this.lbMaPhieuDV.AutoSize = true;
            this.lbMaPhieuDV.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPhieuDV.Location = new System.Drawing.Point(6, 158);
            this.lbMaPhieuDV.Name = "lbMaPhieuDV";
            this.lbMaPhieuDV.Size = new System.Drawing.Size(128, 19);
            this.lbMaPhieuDV.TabIndex = 0;
            this.lbMaPhieuDV.Text = "Tên loại phòng :";
            // 
            // lbMaHoaDon
            // 
            this.lbMaHoaDon.AutoSize = true;
            this.lbMaHoaDon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHoaDon.Location = new System.Drawing.Point(5, 437);
            this.lbMaHoaDon.Name = "lbMaHoaDon";
            this.lbMaHoaDon.Size = new System.Drawing.Size(79, 19);
            this.lbMaHoaDon.TabIndex = 0;
            this.lbMaHoaDon.Tag = "";
            this.lbMaHoaDon.Text = "Hóa Đơn:";
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.AutoSize = true;
            this.lbTrangThai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrangThai.Location = new System.Drawing.Point(7, 404);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(91, 19);
            this.lbTrangThai.TabIndex = 0;
            this.lbTrangThai.Tag = "";
            this.lbTrangThai.Text = "Trạng thái:";
            // 
            // lbSoLuongPhong
            // 
            this.lbSoLuongPhong.AutoSize = true;
            this.lbSoLuongPhong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuongPhong.Location = new System.Drawing.Point(7, 364);
            this.lbSoLuongPhong.Name = "lbSoLuongPhong";
            this.lbSoLuongPhong.Size = new System.Drawing.Size(129, 19);
            this.lbSoLuongPhong.TabIndex = 0;
            this.lbSoLuongPhong.Tag = "";
            this.lbSoLuongPhong.Text = "Số lượng phòng:";
            // 
            // lbTienCoc
            // 
            this.lbTienCoc.AutoSize = true;
            this.lbTienCoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienCoc.Location = new System.Drawing.Point(6, 319);
            this.lbTienCoc.Name = "lbTienCoc";
            this.lbTienCoc.Size = new System.Drawing.Size(77, 19);
            this.lbTienCoc.TabIndex = 0;
            this.lbTienCoc.Text = "Tiền cọc:";
            // 
            // lbMaPhong
            // 
            this.lbMaPhong.AutoSize = true;
            this.lbMaPhong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPhong.Location = new System.Drawing.Point(6, 274);
            this.lbMaPhong.Name = "lbMaPhong";
            this.lbMaPhong.Size = new System.Drawing.Size(127, 19);
            this.lbMaPhong.TabIndex = 0;
            this.lbMaPhong.Text = "Ngày trả phòng:";
            // 
            // lbNgayTraPhong
            // 
            this.lbNgayTraPhong.AutoSize = true;
            this.lbNgayTraPhong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayTraPhong.Location = new System.Drawing.Point(6, 233);
            this.lbNgayTraPhong.Name = "lbNgayTraPhong";
            this.lbNgayTraPhong.Size = new System.Drawing.Size(82, 19);
            this.lbNgayTraPhong.TabIndex = 0;
            this.lbNgayTraPhong.Text = "Ngày đến:";
            // 
            // lbNgayDK
            // 
            this.lbNgayDK.AutoSize = true;
            this.lbNgayDK.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayDK.Location = new System.Drawing.Point(7, 191);
            this.lbNgayDK.Name = "lbNgayDK";
            this.lbNgayDK.Size = new System.Drawing.Size(112, 19);
            this.lbNgayDK.TabIndex = 0;
            this.lbNgayDK.Text = "Ngày đăng ký:";
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKH.Location = new System.Drawing.Point(7, 119);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(125, 19);
            this.lbMaKH.TabIndex = 0;
            this.lbMaKH.Text = "Mã khách hàng:";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNV.Location = new System.Drawing.Point(7, 75);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(113, 19);
            this.lbMaNV.TabIndex = 0;
            this.lbMaNV.Text = "Mã nhân viên:";
            // 
            // lbMaPhieuDP
            // 
            this.lbMaPhieuDP.AutoSize = true;
            this.lbMaPhieuDP.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPhieuDP.Location = new System.Drawing.Point(14, 36);
            this.lbMaPhieuDP.Name = "lbMaPhieuDP";
            this.lbMaPhieuDP.Size = new System.Drawing.Size(160, 19);
            this.lbMaPhieuDP.TabIndex = 0;
            this.lbMaPhieuDP.Text = "Mã phiếu đặt phòng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi tiết phiếu đặt phòng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataQLKSDataSet
            // 
            this.dataQLKSDataSet.DataSetName = "dataQLKSDataSet";
            this.dataQLKSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataQLKSDataSetBindingSource
            // 
            this.dataQLKSDataSetBindingSource.DataSource = this.dataQLKSDataSet;
            this.dataQLKSDataSetBindingSource.Position = 0;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 655);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.Booking_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDanhSachPhieuDK)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataQLKSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataQLKSDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DgvDanhSachPhieuDK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaPhieuDP;
        private System.Windows.Forms.Label lbMaPhieuDP;
        private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label lbMaPhieuDV;
        private System.Windows.Forms.Label lbSoLuongPhong;
        private System.Windows.Forms.Label lbTienCoc;
        private System.Windows.Forms.Label lbMaPhong;
        private System.Windows.Forms.Label lbNgayTraPhong;
        private System.Windows.Forms.Label lbNgayDK;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.TextBox txtSoLuongPhong;
        private System.Windows.Forms.TextBox txtTenLoaiPhong;
        private System.Windows.Forms.Label lbTrangThai;
        private System.Windows.Forms.DateTimePicker txtNgayTraPhong;
        private System.Windows.Forms.DateTimePicker txtNgayDen;
        private System.Windows.Forms.DateTimePicker txtNgayDK;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.BindingSource dataQLKSDataSetBindingSource;
        private dataQLKSDataSet dataQLKSDataSet;
        private System.Windows.Forms.TextBox txtHoaDon;
        private System.Windows.Forms.Label lbMaHoaDon;
    }
}