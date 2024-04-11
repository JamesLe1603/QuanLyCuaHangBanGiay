namespace WindowsFormsApp1
{
    partial class GiaoDienQuanLyKhachHangChoNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaoDienQuanLyKhachHangChoNhanVien));
            this.Icon = new System.Windows.Forms.ImageList(this.components);
            this.txt_maKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_timKH = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_tenKH = new System.Windows.Forms.TextBox();
            this.txt_diaChi = new System.Windows.Forms.TextBox();
            this.chk_trangThai = new System.Windows.Forms.CheckBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.grid_dsKhachHang = new System.Windows.Forms.DataGridView();
            this.mAKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOTENKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYTAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRANGTHAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dIACHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banGiayDataSet = new WindowsFormsApp1.banGiayDataSet();
            this.btn_addCustomer = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateNgayTao = new System.Windows.Forms.DateTimePicker();
            this.cbo_danhMuc = new System.Windows.Forms.ComboBox();
            this.kHACHHANGTableAdapter = new WindowsFormsApp1.banGiayDataSetTableAdapters.KHACHHANGTableAdapter();
            this.banGiayDataSet1 = new WindowsFormsApp1.banGiayDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.grid_dsKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banGiayDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banGiayDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Icon
            // 
            this.Icon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Icon.ImageStream")));
            this.Icon.TransparentColor = System.Drawing.Color.Transparent;
            this.Icon.Images.SetKeyName(0, "arrow-left-solid.png");
            this.Icon.Images.SetKeyName(1, "arrows-rotate-solid.png");
            this.Icon.Images.SetKeyName(2, "square-plus-solid.png");
            this.Icon.Images.SetKeyName(3, "door-open-solid.png");
            // 
            // txt_maKH
            // 
            this.txt_maKH.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maKH.Location = new System.Drawing.Point(310, 166);
            this.txt_maKH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_maKH.MaxLength = 10;
            this.txt_maKH.Name = "txt_maKH";
            this.txt_maKH.Size = new System.Drawing.Size(414, 51);
            this.txt_maKH.TabIndex = 1;
            this.txt_maKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_maKH_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(748, 298);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 43);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số điện thoại: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1530, 298);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 43);
            this.label3.TabIndex = 8;
            this.label3.Text = "Trạng thái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1536, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 43);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ngày tạo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(748, 172);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 43);
            this.label7.TabIndex = 12;
            this.label7.Text = "Địa chỉ: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 294);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(270, 43);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tên khách hàng:";
            // 
            // txt_timKH
            // 
            this.txt_timKH.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timKH.Location = new System.Drawing.Point(1594, 383);
            this.txt_timKH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_timKH.Name = "txt_timKH";
            this.txt_timKH.Size = new System.Drawing.Size(368, 51);
            this.txt_timKH.TabIndex = 14;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(998, 298);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_SDT.MaxLength = 10;
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(454, 51);
            this.txt_SDT.TabIndex = 15;
            this.txt_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SDT_KeyPress);
            // 
            // txt_tenKH
            // 
            this.txt_tenKH.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenKH.Location = new System.Drawing.Point(310, 289);
            this.txt_tenKH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_tenKH.MaxLength = 30;
            this.txt_tenKH.Name = "txt_tenKH";
            this.txt_tenKH.Size = new System.Drawing.Size(414, 51);
            this.txt_tenKH.TabIndex = 16;
            this.txt_tenKH.TextChanged += new System.EventHandler(this.txt_tenKH_TextChanged);
            this.txt_tenKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tenKH_KeyPress);
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diaChi.Location = new System.Drawing.Point(998, 166);
            this.txt_diaChi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Size = new System.Drawing.Size(454, 51);
            this.txt_diaChi.TabIndex = 17;
            // 
            // chk_trangThai
            // 
            this.chk_trangThai.AutoSize = true;
            this.chk_trangThai.Checked = true;
            this.chk_trangThai.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_trangThai.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_trangThai.Location = new System.Drawing.Point(1754, 306);
            this.chk_trangThai.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_trangThai.Name = "chk_trangThai";
            this.chk_trangThai.Size = new System.Drawing.Size(28, 27);
            this.chk_trangThai.TabIndex = 19;
            this.chk_trangThai.UseVisualStyleBackColor = true;
            // 
            // btn_tim
            // 
            this.btn_tim.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim.Location = new System.Drawing.Point(1974, 383);
            this.btn_tim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(116, 56);
            this.btn_tim.TabIndex = 21;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 411);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(361, 43);
            this.label5.TabIndex = 22;
            this.label5.Text = "Danh sách khách hàng";
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
            this.mAKHDataGridViewTextBoxColumn,
            this.hOTENKHDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.nGAYTAODataGridViewTextBoxColumn,
            this.tRANGTHAIDataGridViewTextBoxColumn,
            this.dIACHIDataGridViewTextBoxColumn});
            this.grid_dsKhachHang.Cursor = System.Windows.Forms.Cursors.Default;
            this.grid_dsKhachHang.DataSource = this.kHACHHANGBindingSource;
            this.grid_dsKhachHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grid_dsKhachHang.Location = new System.Drawing.Point(0, 483);
            this.grid_dsKhachHang.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grid_dsKhachHang.Name = "grid_dsKhachHang";
            this.grid_dsKhachHang.ReadOnly = true;
            this.grid_dsKhachHang.RowHeadersVisible = false;
            this.grid_dsKhachHang.RowHeadersWidth = 51;
            this.grid_dsKhachHang.RowTemplate.Height = 24;
            this.grid_dsKhachHang.Size = new System.Drawing.Size(2062, 389);
            this.grid_dsKhachHang.TabIndex = 23;
            this.grid_dsKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_dsKhachHang_CellContentClick);
            // 
            // mAKHDataGridViewTextBoxColumn
            // 
            this.mAKHDataGridViewTextBoxColumn.DataPropertyName = "MAKH";
            this.mAKHDataGridViewTextBoxColumn.HeaderText = "MAKH";
            this.mAKHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mAKHDataGridViewTextBoxColumn.Name = "mAKHDataGridViewTextBoxColumn";
            this.mAKHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hOTENKHDataGridViewTextBoxColumn
            // 
            this.hOTENKHDataGridViewTextBoxColumn.DataPropertyName = "HOTENKH";
            this.hOTENKHDataGridViewTextBoxColumn.HeaderText = "HOTENKH";
            this.hOTENKHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hOTENKHDataGridViewTextBoxColumn.Name = "hOTENKHDataGridViewTextBoxColumn";
            this.hOTENKHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            this.sDTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nGAYTAODataGridViewTextBoxColumn
            // 
            this.nGAYTAODataGridViewTextBoxColumn.DataPropertyName = "NGAYTAO";
            this.nGAYTAODataGridViewTextBoxColumn.HeaderText = "NGAYTAO";
            this.nGAYTAODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nGAYTAODataGridViewTextBoxColumn.Name = "nGAYTAODataGridViewTextBoxColumn";
            this.nGAYTAODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tRANGTHAIDataGridViewTextBoxColumn
            // 
            this.tRANGTHAIDataGridViewTextBoxColumn.DataPropertyName = "TRANGTHAI";
            this.tRANGTHAIDataGridViewTextBoxColumn.HeaderText = "TRANGTHAI";
            this.tRANGTHAIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tRANGTHAIDataGridViewTextBoxColumn.Name = "tRANGTHAIDataGridViewTextBoxColumn";
            this.tRANGTHAIDataGridViewTextBoxColumn.ReadOnly = true;
            this.tRANGTHAIDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tRANGTHAIDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dIACHIDataGridViewTextBoxColumn
            // 
            this.dIACHIDataGridViewTextBoxColumn.DataPropertyName = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.HeaderText = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dIACHIDataGridViewTextBoxColumn.Name = "dIACHIDataGridViewTextBoxColumn";
            this.dIACHIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource.DataSource = this.banGiayDataSet;
            // 
            // banGiayDataSet
            // 
            this.banGiayDataSet.DataSetName = "banGiayDataSet";
            this.banGiayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_addCustomer
            // 
            this.btn_addCustomer.ImageKey = "square-plus-solid.png";
            this.btn_addCustomer.ImageList = this.Icon;
            this.btn_addCustomer.Location = new System.Drawing.Point(42, 19);
            this.btn_addCustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_addCustomer.Name = "btn_addCustomer";
            this.btn_addCustomer.Size = new System.Drawing.Size(96, 98);
            this.btn_addCustomer.TabIndex = 6;
            this.btn_addCustomer.UseVisualStyleBackColor = true;
            this.btn_addCustomer.Click += new System.EventHandler(this.btn_addCustomer_Click);
            // 
            // button3
            // 
            this.button3.ImageIndex = 3;
            this.button3.ImageList = this.Icon;
            this.button3.Location = new System.Drawing.Point(294, 19);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 98);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_refresh
            // 
            this.btn_refresh.ImageKey = "arrows-rotate-solid.png";
            this.btn_refresh.ImageList = this.Icon;
            this.btn_refresh.Location = new System.Drawing.Point(172, 19);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(96, 98);
            this.btn_refresh.TabIndex = 4;
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // button1
            // 
            this.button1.ImageKey = "arrow-left-solid.png";
            this.button1.ImageList = this.Icon;
            this.button1.Location = new System.Drawing.Point(440, 19);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 98);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dateNgayTao
            // 
            this.dateNgayTao.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayTao.Location = new System.Drawing.Point(1728, 166);
            this.dateNgayTao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateNgayTao.Name = "dateNgayTao";
            this.dateNgayTao.Size = new System.Drawing.Size(360, 51);
            this.dateNgayTao.TabIndex = 24;
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
            this.cbo_danhMuc.Location = new System.Drawing.Point(1332, 383);
            this.cbo_danhMuc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbo_danhMuc.Name = "cbo_danhMuc";
            this.cbo_danhMuc.Size = new System.Drawing.Size(252, 51);
            this.cbo_danhMuc.TabIndex = 25;
            this.cbo_danhMuc.SelectedIndexChanged += new System.EventHandler(this.cbo_danhMuc_SelectedIndexChanged);
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // banGiayDataSet1
            // 
            this.banGiayDataSet1.DataSetName = "banGiayDataSet";
            this.banGiayDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GiaoDienQuanLyKhachHangChoNhanVien
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2433, 1592);
            this.Controls.Add(this.cbo_danhMuc);
            this.Controls.Add(this.dateNgayTao);
            this.Controls.Add(this.grid_dsKhachHang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.chk_trangThai);
            this.Controls.Add(this.txt_diaChi);
            this.Controls.Add(this.txt_tenKH);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_timKH);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_addCustomer);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_maKH);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "GiaoDienQuanLyKhachHangChoNhanVien";
            this.Text = "GiaoDienQuanLyKhachHangChoNhanVien";
            this.Load += new System.EventHandler(this.GiaoDienQuanLyKhachHangChoNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_dsKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banGiayDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banGiayDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_maKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_addCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_timKH;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_tenKH;
        private System.Windows.Forms.TextBox txt_diaChi;
        private System.Windows.Forms.CheckBox chk_trangThai;
        private System.Windows.Forms.ImageList Icon;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grid_dsKhachHang;
        private System.Windows.Forms.DateTimePicker dateNgayTao;
        private System.Windows.Forms.ComboBox cbo_danhMuc;
        private banGiayDataSet banGiayDataSet;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private banGiayDataSetTableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hOTENKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYTAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tRANGTHAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIACHIDataGridViewTextBoxColumn;
        private banGiayDataSet banGiayDataSet1;
    }
}