namespace DoAn
{
    partial class QuanLyKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyKho));
            this.label6 = new System.Windows.Forms.Label();
            this.btnFindx = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnRes = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNCC = new System.Windows.Forms.TextBox();
            this.chkTT = new System.Windows.Forms.CheckBox();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sANPHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banGiayDataSet1 = new DoAn.BanGiayDataSet1();
            this.LabelXX = new System.Windows.Forms.Label();
            this.txtXuatXu = new System.Windows.Forms.TextBox();
            this.LabelSize = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtKM = new System.Windows.Forms.TextBox();
            this.sANPHAMTableAdapter = new DoAn.BanGiayDataSet1TableAdapters.SANPHAMTableAdapter();
            this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXuatXu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTT = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colMaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banGiayDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(564, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(325, 51);
            this.label6.TabIndex = 36;
            this.label6.Text = "QUẢN LÝ KHO";
            // 
            // btnFindx
            // 
            this.btnFindx.ImageIndex = 7;
            this.btnFindx.ImageList = this.imageList1;
            this.btnFindx.Location = new System.Drawing.Point(1151, 456);
            this.btnFindx.Name = "btnFindx";
            this.btnFindx.Size = new System.Drawing.Size(75, 35);
            this.btnFindx.TabIndex = 34;
            this.btnFindx.UseVisualStyleBackColor = true;
            this.btnFindx.Click += new System.EventHandler(this.btnFindx_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "house-user-solid.png");
            this.imageList1.Images.SetKeyName(1, "arrow-left-solid.png");
            this.imageList1.Images.SetKeyName(2, "arrows-rotate-solid.png");
            this.imageList1.Images.SetKeyName(3, "door-open-solid.png");
            this.imageList1.Images.SetKeyName(4, "square-plus-solid.png");
            this.imageList1.Images.SetKeyName(5, "Delete.png");
            this.imageList1.Images.SetKeyName(6, "edit.png");
            this.imageList1.Images.SetKeyName(7, "Find.png");
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(989, 458);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(156, 31);
            this.txtFind.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 467);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 25);
            this.label7.TabIndex = 31;
            this.label7.Text = "Danh sách sản phẩm";
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(593, 239);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(145, 31);
            this.txtGiaNhap.TabIndex = 30;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(593, 288);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(145, 31);
            this.txtGiaBan.TabIndex = 29;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(257, 288);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(145, 31);
            this.txtTenSP.TabIndex = 28;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Enabled = false;
            this.txtMaSP.Location = new System.Drawing.Point(257, 238);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.ReadOnly = true;
            this.txtMaSP.Size = new System.Drawing.Size(145, 31);
            this.txtMaSP.TabIndex = 27;
            // 
            // btnBack
            // 
            this.btnBack.ImageIndex = 1;
            this.btnBack.ImageList = this.imageList1;
            this.btnBack.Location = new System.Drawing.Point(595, 135);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 39);
            this.btnBack.TabIndex = 25;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnOut
            // 
            this.btnOut.ImageIndex = 3;
            this.btnOut.ImageList = this.imageList1;
            this.btnOut.Location = new System.Drawing.Point(485, 135);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 39);
            this.btnOut.TabIndex = 24;
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnRes
            // 
            this.btnRes.ImageIndex = 2;
            this.btnRes.ImageList = this.imageList1;
            this.btnRes.Location = new System.Drawing.Point(376, 135);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(75, 39);
            this.btnRes.TabIndex = 26;
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDel
            // 
            this.btnDel.ImageIndex = 5;
            this.btnDel.ImageList = this.imageList1;
            this.btnDel.Location = new System.Drawing.Point(275, 135);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 39);
            this.btnDel.TabIndex = 23;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ImageIndex = 6;
            this.btnEdit.ImageList = this.imageList1;
            this.btnEdit.Location = new System.Drawing.Point(171, 135);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 39);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ImageIndex = 4;
            this.btnAdd.ImageList = this.imageList1;
            this.btnAdd.Location = new System.Drawing.Point(79, 135);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 39);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(771, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Nhà Cung Cấp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Giá Nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Giá Bán:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên Sản Phẩm:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(598, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 25);
            this.label13.TabIndex = 15;
            this.label13.Text = "Trở lại";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(490, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 25);
            this.label12.TabIndex = 14;
            this.label12.Text = "Thoát";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(371, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 25);
            this.label11.TabIndex = 13;
            this.label11.Text = "Làm mới";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(281, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "Xóa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(181, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "Sửa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Thêm";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã Sản Phẩm:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(131, 341);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 25);
            this.label14.TabIndex = 16;
            this.label14.Text = "Đơn vị tính:";
            // 
            // txtDVT
            // 
            this.txtDVT.Enabled = false;
            this.txtDVT.Location = new System.Drawing.Point(257, 338);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.ReadOnly = true;
            this.txtDVT.Size = new System.Drawing.Size(145, 31);
            this.txtDVT.TabIndex = 28;
            this.txtDVT.Text = "VNĐ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(485, 338);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 25);
            this.label15.TabIndex = 16;
            this.label15.Text = "Số lượng:";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(593, 338);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(145, 31);
            this.txtSL.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(815, 388);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 25);
            this.label16.TabIndex = 16;
            this.label16.Text = "Trạng thái:";
            // 
            // txtNCC
            // 
            this.txtNCC.Location = new System.Drawing.Point(936, 239);
            this.txtNCC.Name = "txtNCC";
            this.txtNCC.Size = new System.Drawing.Size(145, 31);
            this.txtNCC.TabIndex = 29;
            // 
            // chkTT
            // 
            this.chkTT.AutoSize = true;
            this.chkTT.Checked = true;
            this.chkTT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTT.Location = new System.Drawing.Point(938, 385);
            this.chkTT.Name = "chkTT";
            this.chkTT.Size = new System.Drawing.Size(137, 29);
            this.chkTT.TabIndex = 37;
            this.chkTT.Text = "Đang bán";
            this.chkTT.UseVisualStyleBackColor = true;
            // 
            // cboLoai
            // 
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Items.AddRange(new object[] {
            "Mã SP",
            "Tên SP",
            "Nhà cung cấp"});
            this.cboLoai.Location = new System.Drawing.Point(851, 458);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(121, 33);
            this.cboLoai.TabIndex = 38;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenSP,
            this.colXuatXu,
            this.colGiaNhap,
            this.colGiaBan,
            this.colDVT,
            this.colSL,
            this.colDonGia,
            this.colKhuyenMai,
            this.colTT,
            this.colMaNCC,
            this.colSize,
            this.colMaSP});
            this.dataGridView1.DataSource = this.sANPHAMBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(70, 497);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1089, 180);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sANPHAMBindingSource
            // 
            this.sANPHAMBindingSource.DataMember = "SANPHAM";
            this.sANPHAMBindingSource.DataSource = this.banGiayDataSet1;
            // 
            // banGiayDataSet1
            // 
            this.banGiayDataSet1.DataSetName = "BanGiayDataSet1";
            this.banGiayDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LabelXX
            // 
            this.LabelXX.AutoSize = true;
            this.LabelXX.Location = new System.Drawing.Point(839, 288);
            this.LabelXX.Name = "LabelXX";
            this.LabelXX.Size = new System.Drawing.Size(91, 25);
            this.LabelXX.TabIndex = 19;
            this.LabelXX.Text = "Xuất xứ:";
            // 
            // txtXuatXu
            // 
            this.txtXuatXu.Location = new System.Drawing.Point(936, 289);
            this.txtXuatXu.Name = "txtXuatXu";
            this.txtXuatXu.Size = new System.Drawing.Size(145, 31);
            this.txtXuatXu.TabIndex = 29;
            // 
            // LabelSize
            // 
            this.LabelSize.AutoSize = true;
            this.LabelSize.Location = new System.Drawing.Point(191, 388);
            this.LabelSize.Name = "LabelSize";
            this.LabelSize.Size = new System.Drawing.Size(60, 25);
            this.LabelSize.TabIndex = 16;
            this.LabelSize.Text = "Size:";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(257, 385);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(145, 31);
            this.txtSize.TabIndex = 28;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(485, 388);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 25);
            this.label17.TabIndex = 16;
            this.label17.Text = "Đơn giá:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(593, 388);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(145, 31);
            this.txtDonGia.TabIndex = 28;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(799, 338);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(131, 25);
            this.label18.TabIndex = 16;
            this.label18.Text = "Khuyến mãi:";
            // 
            // txtKM
            // 
            this.txtKM.Location = new System.Drawing.Point(936, 338);
            this.txtKM.Name = "txtKM";
            this.txtKM.Size = new System.Drawing.Size(145, 31);
            this.txtKM.TabIndex = 28;
            // 
            // sANPHAMTableAdapter
            // 
            this.sANPHAMTableAdapter.ClearBeforeFill = true;
            // 
            // colTenSP
            // 
            this.colTenSP.DataPropertyName = "TENSP";
            this.colTenSP.HeaderText = "TENSP";
            this.colTenSP.MinimumWidth = 10;
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.Width = 200;
            // 
            // colXuatXu
            // 
            this.colXuatXu.DataPropertyName = "XUATXU";
            this.colXuatXu.HeaderText = "XUATXU";
            this.colXuatXu.MinimumWidth = 10;
            this.colXuatXu.Name = "colXuatXu";
            this.colXuatXu.Width = 200;
            // 
            // colGiaNhap
            // 
            this.colGiaNhap.DataPropertyName = "GIANHAP";
            this.colGiaNhap.HeaderText = "GIANHAP";
            this.colGiaNhap.MinimumWidth = 10;
            this.colGiaNhap.Name = "colGiaNhap";
            this.colGiaNhap.Width = 200;
            // 
            // colGiaBan
            // 
            this.colGiaBan.DataPropertyName = "GIABAN";
            this.colGiaBan.HeaderText = "GIABAN";
            this.colGiaBan.MinimumWidth = 10;
            this.colGiaBan.Name = "colGiaBan";
            this.colGiaBan.Width = 200;
            // 
            // colDVT
            // 
            this.colDVT.DataPropertyName = "DONVITINH";
            this.colDVT.HeaderText = "DONVITINH";
            this.colDVT.MinimumWidth = 10;
            this.colDVT.Name = "colDVT";
            this.colDVT.Width = 200;
            // 
            // colSL
            // 
            this.colSL.DataPropertyName = "SOLUONG";
            this.colSL.HeaderText = "SOLUONG";
            this.colSL.MinimumWidth = 10;
            this.colSL.Name = "colSL";
            this.colSL.Width = 200;
            // 
            // colDonGia
            // 
            this.colDonGia.DataPropertyName = "DONGIA";
            this.colDonGia.HeaderText = "DONGIA";
            this.colDonGia.MinimumWidth = 10;
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.Width = 200;
            // 
            // colKhuyenMai
            // 
            this.colKhuyenMai.DataPropertyName = "KHUYENMAI";
            this.colKhuyenMai.HeaderText = "KHUYENMAI";
            this.colKhuyenMai.MinimumWidth = 10;
            this.colKhuyenMai.Name = "colKhuyenMai";
            this.colKhuyenMai.Width = 200;
            // 
            // colTT
            // 
            this.colTT.DataPropertyName = "TRANGTHAIBAN";
            this.colTT.HeaderText = "TRANGTHAIBAN";
            this.colTT.MinimumWidth = 10;
            this.colTT.Name = "colTT";
            this.colTT.Width = 200;
            // 
            // colMaNCC
            // 
            this.colMaNCC.DataPropertyName = "MANCC";
            this.colMaNCC.HeaderText = "MANCC";
            this.colMaNCC.MinimumWidth = 10;
            this.colMaNCC.Name = "colMaNCC";
            this.colMaNCC.Width = 200;
            // 
            // colSize
            // 
            this.colSize.DataPropertyName = "SIZE";
            this.colSize.HeaderText = "SIZE";
            this.colSize.MinimumWidth = 10;
            this.colSize.Name = "colSize";
            this.colSize.Width = 200;
            // 
            // colMaSP
            // 
            this.colMaSP.DataPropertyName = "MASP";
            this.colMaSP.HeaderText = "MASP";
            this.colMaSP.MinimumWidth = 10;
            this.colMaSP.Name = "colMaSP";
            this.colMaSP.Width = 200;
            // 
            // QuanLyKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 715);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboLoai);
            this.Controls.Add(this.chkTT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnFindx);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGiaNhap);
            this.Controls.Add(this.txtXuatXu);
            this.Controls.Add(this.txtNCC);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.txtKM);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtDVT);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.LabelXX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.LabelSize);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyKho";
            this.Text = "QuanLyKho";
            this.Load += new System.EventHandler(this.QuanLyKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banGiayDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFindx;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNCC;
        private System.Windows.Forms.CheckBox chkTT;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LabelXX;
        private System.Windows.Forms.TextBox txtXuatXu;
        private System.Windows.Forms.Label LabelSize;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtKM;
        private BanGiayDataSet1 banGiayDataSet1;
        private System.Windows.Forms.BindingSource sANPHAMBindingSource;
        private BanGiayDataSet1TableAdapters.SANPHAMTableAdapter sANPHAMTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXuatXu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhuyenMai;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSP;
    }
}