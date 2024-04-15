namespace DoAn
{
    partial class GiaoDienAD
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
        [System.Obsolete]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaoDienAD));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_out = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.dateNgayTao = new System.Windows.Forms.DateTimePicker();
            this.chk_trangThai = new System.Windows.Forms.CheckBox();
            this.cbo_danhMuc = new System.Windows.Forms.ComboBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.txt_timKH = new System.Windows.Forms.TextBox();
            this.grid_dsKhachHang = new System.Windows.Forms.DataGridView();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTENKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYTAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANGTHAI = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banGiayDataSet1 = new WindowsFormsApp1.banGiayDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_maKH = new System.Windows.Forms.TextBox();
            this.txt_diaChi = new System.Windows.Forms.TextBox();
            this.txt_tenKH = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.kHACHHANGTableAdapter = new WindowsFormsApp1.banGiayDataSet1TableAdapters.KHACHHANGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grid_dsKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banGiayDataSet1)).BeginInit();
            this.SuspendLayout();
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 200);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Thêm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(152, 200);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Sửa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(252, 200);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Xóa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(342, 200);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Làm mới";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(460, 200);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Thoát";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(568, 200);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Trở lại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(716, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(525, 51);
            this.label6.TabIndex = 9;
            this.label6.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // btn_back
            // 
            this.btn_back.ImageIndex = 1;
            this.btn_back.ImageList = this.imageList1;
            this.btn_back.Location = new System.Drawing.Point(564, 130);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(122, 67);
            this.btn_back.TabIndex = 1;
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // btn_out
            // 
            this.btn_out.ImageIndex = 3;
            this.btn_out.ImageList = this.imageList1;
            this.btn_out.Location = new System.Drawing.Point(456, 130);
            this.btn_out.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(76, 67);
            this.btn_out.TabIndex = 1;
            this.btn_out.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.ImageIndex = 2;
            this.button4.ImageList = this.imageList1;
            this.button4.Location = new System.Drawing.Point(346, 130);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 67);
            this.button4.TabIndex = 1;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.ImageIndex = 5;
            this.btn_delete.ImageList = this.imageList1;
            this.btn_delete.Location = new System.Drawing.Point(243, 130);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(78, 67);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.ImageIndex = 6;
            this.btn_edit.ImageList = this.imageList1;
            this.btn_edit.Location = new System.Drawing.Point(142, 130);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(70, 67);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.ImageIndex = 4;
            this.btn_add.ImageList = this.imageList1;
            this.btn_add.Location = new System.Drawing.Point(50, 130);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(84, 67);
            this.btn_add.TabIndex = 1;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(52, 434);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(270, 43);
            this.label15.TabIndex = 28;
            this.label15.Text = "Tên khách hàng:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(753, 312);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(141, 42);
            this.label16.TabIndex = 27;
            this.label16.Text = "Địa chỉ: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1540, 312);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(163, 43);
            this.label17.TabIndex = 26;
            this.label17.Text = "Ngày tạo:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1534, 439);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(176, 43);
            this.label18.TabIndex = 25;
            this.label18.Text = "Trạng thái";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(753, 439);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(239, 43);
            this.label19.TabIndex = 24;
            this.label19.Text = "Số điện thoại: ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(52, 312);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(262, 43);
            this.label20.TabIndex = 23;
            this.label20.Text = "Mã khách hàng:";
            // 
            // dateNgayTao
            // 
            this.dateNgayTao.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayTao.Location = new System.Drawing.Point(1707, 312);
            this.dateNgayTao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateNgayTao.Name = "dateNgayTao";
            this.dateNgayTao.Size = new System.Drawing.Size(360, 51);
            this.dateNgayTao.TabIndex = 33;
            // 
            // chk_trangThai
            // 
            this.chk_trangThai.AutoSize = true;
            this.chk_trangThai.Checked = true;
            this.chk_trangThai.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_trangThai.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_trangThai.Location = new System.Drawing.Point(1732, 453);
            this.chk_trangThai.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_trangThai.Name = "chk_trangThai";
            this.chk_trangThai.Size = new System.Drawing.Size(28, 27);
            this.chk_trangThai.TabIndex = 32;
            this.chk_trangThai.UseVisualStyleBackColor = true;
            // 
            // cbo_danhMuc
            // 
            this.cbo_danhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_danhMuc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_danhMuc.FormattingEnabled = true;
            this.cbo_danhMuc.Items.AddRange(new object[] {
            "Tất cả KH",
            "Mã KH",
            "Tên KH"});
            this.cbo_danhMuc.Location = new System.Drawing.Point(1358, 562);
            this.cbo_danhMuc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbo_danhMuc.Name = "cbo_danhMuc";
            this.cbo_danhMuc.Size = new System.Drawing.Size(252, 51);
            this.cbo_danhMuc.TabIndex = 36;
            // 
            // btn_tim
            // 
            this.btn_tim.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim.Location = new System.Drawing.Point(2000, 562);
            this.btn_tim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(116, 56);
            this.btn_tim.TabIndex = 35;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click_1);
            // 
            // txt_timKH
            // 
            this.txt_timKH.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timKH.Location = new System.Drawing.Point(1620, 562);
            this.txt_timKH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_timKH.Name = "txt_timKH";
            this.txt_timKH.Size = new System.Drawing.Size(368, 51);
            this.txt_timKH.TabIndex = 34;
            // 
            // grid_dsKhachHang
            // 
            this.grid_dsKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_dsKhachHang.AutoGenerateColumns = false;
            this.grid_dsKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_dsKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_dsKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAKH,
            this.HOTENKH,
            this.SDT,
            this.NGAYTAO,
            this.TRANGTHAI,
            this.DIACHI});
            this.grid_dsKhachHang.Cursor = System.Windows.Forms.Cursors.Default;
            this.grid_dsKhachHang.DataSource = this.kHACHHANGBindingSource;
            this.grid_dsKhachHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grid_dsKhachHang.Location = new System.Drawing.Point(18, 642);
            this.grid_dsKhachHang.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grid_dsKhachHang.Name = "grid_dsKhachHang";
            this.grid_dsKhachHang.ReadOnly = true;
            this.grid_dsKhachHang.RowHeadersVisible = false;
            this.grid_dsKhachHang.RowHeadersWidth = 51;
            this.grid_dsKhachHang.RowTemplate.Height = 24;
            this.grid_dsKhachHang.Size = new System.Drawing.Size(2240, 567);
            this.grid_dsKhachHang.TabIndex = 37;
            this.grid_dsKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_dsKhachHang_CellClick);
            this.grid_dsKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_dsKhachHang_CellContentClick);
            // 
            // MAKH
            // 
            this.MAKH.DataPropertyName = "MAKH";
            this.MAKH.HeaderText = "MAKH";
            this.MAKH.MinimumWidth = 6;
            this.MAKH.Name = "MAKH";
            this.MAKH.ReadOnly = true;
            // 
            // HOTENKH
            // 
            this.HOTENKH.DataPropertyName = "HOTENKH";
            this.HOTENKH.HeaderText = "HOTENKH";
            this.HOTENKH.MinimumWidth = 6;
            this.HOTENKH.Name = "HOTENKH";
            this.HOTENKH.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // NGAYTAO
            // 
            this.NGAYTAO.DataPropertyName = "NGAYTAO";
            this.NGAYTAO.HeaderText = "NGAYTAO";
            this.NGAYTAO.MinimumWidth = 6;
            this.NGAYTAO.Name = "NGAYTAO";
            this.NGAYTAO.ReadOnly = true;
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.DataPropertyName = "TRANGTHAI";
            this.TRANGTHAI.HeaderText = "TRANGTHAI";
            this.TRANGTHAI.MinimumWidth = 6;
            this.TRANGTHAI.Name = "TRANGTHAI";
            this.TRANGTHAI.ReadOnly = true;
            this.TRANGTHAI.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TRANGTHAI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "DIACHI";
            this.DIACHI.MinimumWidth = 6;
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.ReadOnly = true;
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource.DataSource = this.banGiayDataSet1;
            // 
            // banGiayDataSet1
            // 
            this.banGiayDataSet1.DataSetName = "banGiayDataSet1";
            this.banGiayDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 577);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 43);
            this.label1.TabIndex = 38;
            this.label1.Text = "Danh sách khách hàng:";
            // 
            // txt_maKH
            // 
            this.txt_maKH.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maKH.Location = new System.Drawing.Point(310, 312);
            this.txt_maKH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_maKH.MaxLength = 5;
            this.txt_maKH.Name = "txt_maKH";
            this.txt_maKH.Size = new System.Drawing.Size(414, 51);
            this.txt_maKH.TabIndex = 39;
            this.txt_maKH.TextChanged += new System.EventHandler(this.txt_maKH_TextChanged);
            this.txt_maKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_maKH_KeyPress);
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diaChi.Location = new System.Drawing.Point(1004, 300);
            this.txt_diaChi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Size = new System.Drawing.Size(454, 51);
            this.txt_diaChi.TabIndex = 42;
            // 
            // txt_tenKH
            // 
            this.txt_tenKH.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenKH.Location = new System.Drawing.Point(310, 430);
            this.txt_tenKH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_tenKH.MaxLength = 30;
            this.txt_tenKH.Name = "txt_tenKH";
            this.txt_tenKH.Size = new System.Drawing.Size(414, 51);
            this.txt_tenKH.TabIndex = 41;
            this.txt_tenKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tenKH_KeyPress);
            // 
            // txt_SDT
            // 
            this.txt_SDT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(1004, 422);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_SDT.MaxLength = 10;
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(454, 51);
            this.txt_SDT.TabIndex = 40;
            this.txt_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SDT_KeyPress);
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // GiaoDienAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2276, 1648);
            this.Controls.Add(this.txt_diaChi);
            this.Controls.Add(this.txt_tenKH);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_maKH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_dsKhachHang);
            this.Controls.Add(this.cbo_danhMuc);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.txt_timKH);
            this.Controls.Add(this.dateNgayTao);
            this.Controls.Add(this.chk_trangThai);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_out);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "GiaoDienAD";
            this.Text = "GiaoDienAD";
            this.Load += new System.EventHandler(this.GiaoDienAD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_dsKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banGiayDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_out;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker dateNgayTao;
        private System.Windows.Forms.CheckBox chk_trangThai;
        private System.Windows.Forms.ComboBox cbo_danhMuc;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.TextBox txt_timKH;
        private System.Windows.Forms.DataGridView grid_dsKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_maKH;
        private System.Windows.Forms.TextBox txt_diaChi;
        private System.Windows.Forms.TextBox txt_tenKH;
        private System.Windows.Forms.TextBox txt_SDT;
        private WindowsFormsApp1.banGiayDataSet1 banGiayDataSet1;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private WindowsFormsApp1.banGiayDataSet1TableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTENKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYTAO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TRANGTHAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
    }
}