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
            this.dataQLKSDataSet = new QLKS.dataQLKSDataSet();
            this.dataQLKSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.btthoat = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DgvDanhSachPhieuDK = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbMaPhieuDP = new System.Windows.Forms.Label();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.lbSoLuongPhong = new System.Windows.Forms.Label();
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.cbTenLoaiPhong = new System.Windows.Forms.ComboBox();
            this.lbTienCoc = new System.Windows.Forms.Label();
            this.lbMaPhieuDV = new System.Windows.Forms.Label();
            this.txtNgayTraPhong = new System.Windows.Forms.DateTimePicker();
            this.lbMaPhong = new System.Windows.Forms.Label();
            this.txtMaPhieuDP = new System.Windows.Forms.TextBox();
            this.txtNgayDen = new System.Windows.Forms.DateTimePicker();
            this.lbNgayTraPhong = new System.Windows.Forms.Label();
            this.txtNgayDK = new System.Windows.Forms.DateTimePicker();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lbNgayDK = new System.Windows.Forms.Label();
            this.txtSoLuongPhong = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataQLKSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataQLKSDataSetBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDanhSachPhieuDK)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.btthoat);
            this.panel3.Controls.Add(this.btThem);
            this.panel3.Controls.Add(this.btSua);
            this.panel3.Controls.Add(this.btXoa);
            this.panel3.Location = new System.Drawing.Point(0, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(966, 92);
            this.panel3.TabIndex = 16;
            // 
            // btthoat
            // 
            this.btthoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthoat.Location = new System.Drawing.Point(671, 20);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(93, 59);
            this.btthoat.TabIndex = 14;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btThem
            // 
            this.btThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(253, 20);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(93, 59);
            this.btThem.TabIndex = 11;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(393, 18);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(93, 59);
            this.btSua.TabIndex = 13;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(533, 20);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(93, 59);
            this.btXoa.TabIndex = 12;
            this.btXoa.Text = "Xóa ";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(966, 107);
            this.panel2.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(0, 106);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(382, 422);
            this.panel6.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(384, 106);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(582, 217);
            this.panel4.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi tiết phiếu đặt phòng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.DgvDanhSachPhieuDK);
            this.panel5.Location = new System.Drawing.Point(385, 204);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(581, 373);
            this.panel5.TabIndex = 17;
            // 
            // DgvDanhSachPhieuDK
            // 
            this.DgvDanhSachPhieuDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDanhSachPhieuDK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvDanhSachPhieuDK.Location = new System.Drawing.Point(0, 0);
            this.DgvDanhSachPhieuDK.Name = "DgvDanhSachPhieuDK";
            this.DgvDanhSachPhieuDK.Size = new System.Drawing.Size(581, 373);
            this.DgvDanhSachPhieuDK.TabIndex = 15;
            this.DgvDanhSachPhieuDK.Click += new System.EventHandler(this.DgvDanhSachPhieuDK_Click);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel7.Controls.Add(this.lbMaPhieuDP);
            this.panel7.Controls.Add(this.cbTrangThai);
            this.panel7.Controls.Add(this.lbSoLuongPhong);
            this.panel7.Controls.Add(this.lbTrangThai);
            this.panel7.Controls.Add(this.cbTenLoaiPhong);
            this.panel7.Controls.Add(this.lbTienCoc);
            this.panel7.Controls.Add(this.lbMaPhieuDV);
            this.panel7.Controls.Add(this.txtNgayTraPhong);
            this.panel7.Controls.Add(this.lbMaPhong);
            this.panel7.Controls.Add(this.txtMaPhieuDP);
            this.panel7.Controls.Add(this.txtNgayDen);
            this.panel7.Controls.Add(this.lbNgayTraPhong);
            this.panel7.Controls.Add(this.txtNgayDK);
            this.panel7.Controls.Add(this.txtMaNV);
            this.panel7.Controls.Add(this.lbNgayDK);
            this.panel7.Controls.Add(this.txtSoLuongPhong);
            this.panel7.Controls.Add(this.txtMaKH);
            this.panel7.Controls.Add(this.lbMaNV);
            this.panel7.Controls.Add(this.lbMaKH);
            this.panel7.Controls.Add(this.txtTienCoc);
            this.panel7.Location = new System.Drawing.Point(3, 204);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(376, 376);
            this.panel7.TabIndex = 18;
            // 
            // lbMaPhieuDP
            // 
            this.lbMaPhieuDP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbMaPhieuDP.AutoSize = true;
            this.lbMaPhieuDP.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPhieuDP.Location = new System.Drawing.Point(9, 17);
            this.lbMaPhieuDP.Name = "lbMaPhieuDP";
            this.lbMaPhieuDP.Size = new System.Drawing.Size(116, 15);
            this.lbMaPhieuDP.TabIndex = 0;
            this.lbMaPhieuDP.Text = "Mã phiếu đặt phòng:";
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbTrangThai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTrangThai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cbTrangThai.Location = new System.Drawing.Point(136, 309);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(197, 21);
            this.cbTrangThai.TabIndex = 10;
            // 
            // lbSoLuongPhong
            // 
            this.lbSoLuongPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbSoLuongPhong.AutoSize = true;
            this.lbSoLuongPhong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuongPhong.Location = new System.Drawing.Point(11, 284);
            this.lbSoLuongPhong.Name = "lbSoLuongPhong";
            this.lbSoLuongPhong.Size = new System.Drawing.Size(97, 15);
            this.lbSoLuongPhong.TabIndex = 0;
            this.lbSoLuongPhong.Tag = "";
            this.lbSoLuongPhong.Text = "Số lượng phòng:";
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbTrangThai.AutoSize = true;
            this.lbTrangThai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrangThai.Location = new System.Drawing.Point(11, 316);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(68, 15);
            this.lbTrangThai.TabIndex = 0;
            this.lbTrangThai.Tag = "";
            this.lbTrangThai.Text = "Trạng thái:";
            // 
            // cbTenLoaiPhong
            // 
            this.cbTenLoaiPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbTenLoaiPhong.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTenLoaiPhong.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTenLoaiPhong.FormattingEnabled = true;
            this.cbTenLoaiPhong.Items.AddRange(new object[] {
            "Deluxe",
            "Standard",
            "Suite",
            "Superio"});
            this.cbTenLoaiPhong.Location = new System.Drawing.Point(136, 107);
            this.cbTenLoaiPhong.Name = "cbTenLoaiPhong";
            this.cbTenLoaiPhong.Size = new System.Drawing.Size(197, 21);
            this.cbTenLoaiPhong.TabIndex = 4;
            // 
            // lbTienCoc
            // 
            this.lbTienCoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbTienCoc.AutoSize = true;
            this.lbTienCoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienCoc.Location = new System.Drawing.Point(10, 247);
            this.lbTienCoc.Name = "lbTienCoc";
            this.lbTienCoc.Size = new System.Drawing.Size(57, 15);
            this.lbTienCoc.TabIndex = 0;
            this.lbTienCoc.Text = "Tiền cọc:";
            // 
            // lbMaPhieuDV
            // 
            this.lbMaPhieuDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbMaPhieuDV.AutoSize = true;
            this.lbMaPhieuDV.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPhieuDV.Location = new System.Drawing.Point(10, 116);
            this.lbMaPhieuDV.Name = "lbMaPhieuDV";
            this.lbMaPhieuDV.Size = new System.Drawing.Size(94, 15);
            this.lbMaPhieuDV.TabIndex = 0;
            this.lbMaPhieuDV.Text = "Tên loại phòng :";
            // 
            // txtNgayTraPhong
            // 
            this.txtNgayTraPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNgayTraPhong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgayTraPhong.Location = new System.Drawing.Point(137, 204);
            this.txtNgayTraPhong.Name = "txtNgayTraPhong";
            this.txtNgayTraPhong.Size = new System.Drawing.Size(196, 20);
            this.txtNgayTraPhong.TabIndex = 7;
            // 
            // lbMaPhong
            // 
            this.lbMaPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbMaPhong.AutoSize = true;
            this.lbMaPhong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPhong.Location = new System.Drawing.Point(10, 211);
            this.lbMaPhong.Name = "lbMaPhong";
            this.lbMaPhong.Size = new System.Drawing.Size(94, 15);
            this.lbMaPhong.TabIndex = 0;
            this.lbMaPhong.Text = "Ngày trả phòng:";
            // 
            // txtMaPhieuDP
            // 
            this.txtMaPhieuDP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtMaPhieuDP.Location = new System.Drawing.Point(137, 17);
            this.txtMaPhieuDP.Name = "txtMaPhieuDP";
            this.txtMaPhieuDP.Size = new System.Drawing.Size(196, 20);
            this.txtMaPhieuDP.TabIndex = 1;
            // 
            // txtNgayDen
            // 
            this.txtNgayDen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgayDen.Location = new System.Drawing.Point(137, 170);
            this.txtNgayDen.Name = "txtNgayDen";
            this.txtNgayDen.Size = new System.Drawing.Size(196, 20);
            this.txtNgayDen.TabIndex = 6;
            // 
            // lbNgayTraPhong
            // 
            this.lbNgayTraPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbNgayTraPhong.AutoSize = true;
            this.lbNgayTraPhong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayTraPhong.Location = new System.Drawing.Point(10, 177);
            this.lbNgayTraPhong.Name = "lbNgayTraPhong";
            this.lbNgayTraPhong.Size = new System.Drawing.Size(61, 15);
            this.lbNgayTraPhong.TabIndex = 0;
            this.lbNgayTraPhong.Text = "Ngày đến:";
            // 
            // txtNgayDK
            // 
            this.txtNgayDK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNgayDK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgayDK.Location = new System.Drawing.Point(136, 136);
            this.txtNgayDK.Name = "txtNgayDK";
            this.txtNgayDK.Size = new System.Drawing.Size(197, 20);
            this.txtNgayDK.TabIndex = 5;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtMaNV.Location = new System.Drawing.Point(136, 49);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(197, 20);
            this.txtMaNV.TabIndex = 2;
            // 
            // lbNgayDK
            // 
            this.lbNgayDK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbNgayDK.AutoSize = true;
            this.lbNgayDK.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayDK.Location = new System.Drawing.Point(11, 143);
            this.lbNgayDK.Name = "lbNgayDK";
            this.lbNgayDK.Size = new System.Drawing.Size(85, 15);
            this.lbNgayDK.TabIndex = 0;
            this.lbNgayDK.Text = "Ngày đăng ký:";
            // 
            // txtSoLuongPhong
            // 
            this.txtSoLuongPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtSoLuongPhong.Location = new System.Drawing.Point(136, 280);
            this.txtSoLuongPhong.Name = "txtSoLuongPhong";
            this.txtSoLuongPhong.Size = new System.Drawing.Size(197, 20);
            this.txtSoLuongPhong.TabIndex = 9;
            this.txtSoLuongPhong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongPhong_KeyPress);
            // 
            // txtMaKH
            // 
            this.txtMaKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtMaKH.Location = new System.Drawing.Point(136, 78);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(197, 20);
            this.txtMaKH.TabIndex = 3;
            // 
            // lbMaNV
            // 
            this.lbMaNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNV.Location = new System.Drawing.Point(11, 49);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(83, 15);
            this.lbMaNV.TabIndex = 0;
            this.lbMaNV.Text = "Mã nhân viên:";
            // 
            // lbMaKH
            // 
            this.lbMaKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKH.Location = new System.Drawing.Point(11, 85);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(95, 15);
            this.lbMaKH.TabIndex = 0;
            this.lbMaKH.Text = "Mã khách hàng:";
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtTienCoc.Location = new System.Drawing.Point(136, 239);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.Size = new System.Drawing.Size(197, 20);
            this.txtTienCoc.TabIndex = 8;
            this.txtTienCoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTienCoc_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 580);
            this.panel1.TabIndex = 0;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 580);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.Booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataQLKSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataQLKSDataSetBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDanhSachPhieuDK)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dataQLKSDataSetBindingSource;
        private dataQLKSDataSet dataQLKSDataSet;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView DgvDanhSachPhieuDK;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbMaPhieuDP;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.Label lbSoLuongPhong;
        private System.Windows.Forms.Label lbTrangThai;
        private System.Windows.Forms.ComboBox cbTenLoaiPhong;
        private System.Windows.Forms.Label lbTienCoc;
        private System.Windows.Forms.Label lbMaPhieuDV;
        private System.Windows.Forms.DateTimePicker txtNgayTraPhong;
        private System.Windows.Forms.Label lbMaPhong;
        private System.Windows.Forms.TextBox txtMaPhieuDP;
        private System.Windows.Forms.DateTimePicker txtNgayDen;
        private System.Windows.Forms.Label lbNgayTraPhong;
        private System.Windows.Forms.DateTimePicker txtNgayDK;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lbNgayDK;
        private System.Windows.Forms.TextBox txtSoLuongPhong;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.Panel panel1;
    }
}