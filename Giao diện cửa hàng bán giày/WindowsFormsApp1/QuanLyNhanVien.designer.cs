namespace DoAn
{
    partial class QuanLyNhanVien
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
            this.label6 = new System.Windows.Forms.Label();
            this.dt_ngaySinh = new System.Windows.Forms.DateTimePicker();
            this.btn_tim = new System.Windows.Forms.Button();
            this.txt_nhapDuLieuRoiTim = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_diaChi = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_tenNV = new System.Windows.Forms.TextBox();
            this.txt_maNV = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_dsNhanVien = new System.Windows.Forms.DataGridView();
            this.txt_luong = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.rad_nam = new System.Windows.Forms.RadioButton();
            this.rad_nu = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.chk_trangThai = new System.Windows.Forms.CheckBox();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banGiayDataSet2 = new WindowsFormsApp1.banGiayDataSet2();
            this.nHANVIENTableAdapter = new WindowsFormsApp1.banGiayDataSet2TableAdapters.NHANVIENTableAdapter();
            this.banGiayDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grid_dsNhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banGiayDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banGiayDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(573, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(472, 51);
            this.label6.TabIndex = 36;
            this.label6.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // dt_ngaySinh
            // 
            this.dt_ngaySinh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngaySinh.Location = new System.Drawing.Point(1767, 216);
            this.dt_ngaySinh.Name = "dt_ngaySinh";
            this.dt_ngaySinh.Size = new System.Drawing.Size(588, 50);
            this.dt_ngaySinh.TabIndex = 35;
            // 
            // btn_tim
            // 
            this.btn_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim.ImageIndex = 7;
            this.btn_tim.Location = new System.Drawing.Point(1437, 748);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(152, 61);
            this.btn_tim.TabIndex = 34;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // txt_nhapDuLieuRoiTim
            // 
            this.txt_nhapDuLieuRoiTim.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nhapDuLieuRoiTim.Location = new System.Drawing.Point(1274, 748);
            this.txt_nhapDuLieuRoiTim.Name = "txt_nhapDuLieuRoiTim";
            this.txt_nhapDuLieuRoiTim.Size = new System.Drawing.Size(156, 50);
            this.txt_nhapDuLieuRoiTim.TabIndex = 33;
            this.txt_nhapDuLieuRoiTim.TextChanged += new System.EventHandler(this.txt_nhapDuLieuRoiTim_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 756);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(351, 42);
            this.label7.TabIndex = 31;
            this.label7.Text = "Danh sách khách hàng";
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diaChi.Location = new System.Drawing.Point(412, 530);
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Size = new System.Drawing.Size(618, 50);
            this.txt_diaChi.TabIndex = 30;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(978, 334);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(360, 50);
            this.txt_SDT.TabIndex = 29;
            this.txt_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_luong_KeyPress);
            // 
            // txt_tenNV
            // 
            this.txt_tenNV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenNV.Location = new System.Drawing.Point(412, 325);
            this.txt_tenNV.Name = "txt_tenNV";
            this.txt_tenNV.Size = new System.Drawing.Size(242, 50);
            this.txt_tenNV.TabIndex = 28;
            this.txt_tenNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tenNV_KeyPress);
            // 
            // txt_maNV
            // 
            this.txt_maNV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maNV.Location = new System.Drawing.Point(412, 216);
            this.txt_maNV.Name = "txt_maNV";
            this.txt_maNV.Size = new System.Drawing.Size(238, 50);
            this.txt_maNV.TabIndex = 27;
            // 
            // btn_back
            // 
            this.btn_back.ImageIndex = 1;
            this.btn_back.Location = new System.Drawing.Point(594, 92);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 39);
            this.btn_back.TabIndex = 25;
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.ImageIndex = 3;
            this.btn_exit.Location = new System.Drawing.Point(483, 92);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 39);
            this.btn_exit.TabIndex = 24;
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // btn_refresh
            // 
            this.btn_refresh.ImageIndex = 2;
            this.btn_refresh.Location = new System.Drawing.Point(375, 92);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 39);
            this.btn_refresh.TabIndex = 26;
            this.btn_refresh.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.ImageIndex = 5;
            this.btn_delete.Location = new System.Drawing.Point(273, 92);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 39);
            this.btn_delete.TabIndex = 23;
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.ImageIndex = 6;
            this.btn_edit.Location = new System.Drawing.Point(170, 92);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 39);
            this.btn_edit.TabIndex = 22;
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.ImageIndex = 4;
            this.btn_add.Location = new System.Drawing.Point(66, 92);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(86, 39);
            this.btn_add.TabIndex = 21;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1558, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 42);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ngày sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 530);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 42);
            this.label4.TabIndex = 18;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(728, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 42);
            this.label3.TabIndex = 17;
            this.label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 42);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên Nhân Viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã Nhân Viên:";
            // 
            // grid_dsNhanVien
            // 
            this.grid_dsNhanVien.AllowUserToAddRows = false;
            this.grid_dsNhanVien.AutoGenerateColumns = false;
            this.grid_dsNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_dsNhanVien.DataSource = this.banGiayDataSet2BindingSource;
            this.grid_dsNhanVien.Location = new System.Drawing.Point(18, 820);
            this.grid_dsNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grid_dsNhanVien.Name = "grid_dsNhanVien";
            this.grid_dsNhanVien.ReadOnly = true;
            this.grid_dsNhanVien.RowHeadersWidth = 51;
            this.grid_dsNhanVien.RowTemplate.Height = 24;
            this.grid_dsNhanVien.Size = new System.Drawing.Size(2432, 272);
            this.grid_dsNhanVien.TabIndex = 37;
            this.grid_dsNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_dsNhanVien_CellClick);
            this.grid_dsNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_dsNhanVien_CellContentClick);
            // 
            // txt_luong
            // 
            this.txt_luong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_luong.Location = new System.Drawing.Point(978, 212);
            this.txt_luong.Name = "txt_luong";
            this.txt_luong.Size = new System.Drawing.Size(360, 50);
            this.txt_luong.TabIndex = 39;
            this.txt_luong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_luong_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(728, 334);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 42);
            this.label14.TabIndex = 38;
            this.label14.Text = "Lương";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(978, 420);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(360, 50);
            this.txt_password.TabIndex = 41;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(728, 425);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(158, 42);
            this.label15.TabIndex = 40;
            this.label15.Text = "Password";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(412, 425);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(242, 50);
            this.txt_username.TabIndex = 43;
            this.txt_username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_username_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(57, 425);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(167, 42);
            this.label16.TabIndex = 42;
            this.label16.Text = "Username";
            // 
            // rad_nam
            // 
            this.rad_nam.AutoSize = true;
            this.rad_nam.Location = new System.Drawing.Point(9, 62);
            this.rad_nam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_nam.Name = "rad_nam";
            this.rad_nam.Size = new System.Drawing.Size(121, 46);
            this.rad_nam.TabIndex = 44;
            this.rad_nam.TabStop = true;
            this.rad_nam.Text = "Nam";
            this.rad_nam.UseVisualStyleBackColor = true;
            // 
            // rad_nu
            // 
            this.rad_nu.AutoSize = true;
            this.rad_nu.Location = new System.Drawing.Point(309, 62);
            this.rad_nu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_nu.Name = "rad_nu";
            this.rad_nu.Size = new System.Drawing.Size(96, 46);
            this.rad_nu.TabIndex = 45;
            this.rad_nu.TabStop = true;
            this.rad_nu.Text = "Nữ";
            this.rad_nu.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_nam);
            this.groupBox1.Controls.Add(this.rad_nu);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1568, 334);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(704, 156);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới tính";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1568, 539);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(168, 42);
            this.label17.TabIndex = 47;
            this.label17.Text = "Trạng thái";
            // 
            // chk_trangThai
            // 
            this.chk_trangThai.AutoSize = true;
            this.chk_trangThai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_trangThai.Location = new System.Drawing.Point(1810, 552);
            this.chk_trangThai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_trangThai.Name = "chk_trangThai";
            this.chk_trangThai.Size = new System.Drawing.Size(28, 27);
            this.chk_trangThai.TabIndex = 48;
            this.chk_trangThai.UseVisualStyleBackColor = true;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.banGiayDataSet2;
            // 
            // banGiayDataSet2
            // 
            this.banGiayDataSet2.DataSetName = "banGiayDataSet2";
            this.banGiayDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // banGiayDataSet2BindingSource
            // 
            this.banGiayDataSet2BindingSource.DataSource = this.banGiayDataSet2;
            this.banGiayDataSet2BindingSource.Position = 0;
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2487, 1139);
            this.Controls.Add(this.chk_trangThai);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_luong);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.grid_dsNhanVien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dt_ngaySinh);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.txt_nhapDuLieuRoiTim);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_diaChi);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_tenNV);
            this.Controls.Add(this.txt_maNV);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyNhanVien";
            this.Text = "QuanLyNhanVien";
            this.Load += new System.EventHandler(this.QuanLyNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_dsNhanVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banGiayDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banGiayDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dt_ngaySinh;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.TextBox txt_nhapDuLieuRoiTim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_diaChi;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_tenNV;
        private System.Windows.Forms.TextBox txt_maNV;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_dsNhanVien;
        private WindowsFormsApp1.banGiayDataSet2 banGiayDataSet2;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private WindowsFormsApp1.banGiayDataSet2TableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.TextBox txt_luong;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton rad_nam;
        private System.Windows.Forms.RadioButton rad_nu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox chk_trangThai;
        private System.Windows.Forms.BindingSource banGiayDataSet2BindingSource;
    }
}