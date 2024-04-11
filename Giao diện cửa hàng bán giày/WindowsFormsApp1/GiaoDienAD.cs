using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace DoAn
{
    public partial class GiaoDienAD : Form
    {
        [Obsolete]
        public GiaoDienAD()
        {
            InitializeComponent();
        }

        // Tạo kết nối với database
        public SqlConnection createConnSQL()
        {
            string conn;
            conn = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=banGiay;" +
                "Integrated Security=True";

            SqlConnection myConnection = new SqlConnection(conn);

            return myConnection;
        }

        // Đổ dữ liệu từ database vào gridview
        public void displayData(string sSQL)
        {
            SqlConnection myConn = createConnSQL();

            try
            {
                myConn.Open();

                SqlDataAdapter daKhachHang = new SqlDataAdapter(sSQL, myConn);

                DataSet dsKhachHang = new DataSet();
                daKhachHang.Fill(dsKhachHang);

                myConn.Close();

                grid_dsKhachHang.DataSource = dsKhachHang.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Tìm khách hàng
        public void findCustomer()
        {
            string sSQL = "SELECT * FROM KHACHHANG";

            displayData(sSQL);
        }

        public void findCustomerWithInput()
        {
            string input = txt_timKH.Text;
            string sSQL = "";

            if (cbo_danhMuc.SelectedIndex == 0)
            {
                findCustomer();
            }
            else if (cbo_danhMuc.SelectedIndex == 1)
            {
                sSQL += "Select * from KHACHHANG " +
                "where MAKH LIKE '%" + input + "%'";

                txt_timKH.Clear();
            }
            else if (cbo_danhMuc.SelectedIndex == 2)
            {
                sSQL += "Select * from KHACHHANG " +
               "where HOTENKH LIKE N'%" + input + "%'" +
               "or HOTENKH = N'" + input + "'";

                txt_timKH.Clear();
            }

            displayData(sSQL);
        }

        private void btn_tim_Click_1(object sender, EventArgs e)
        {
            findCustomerWithInput();
        }

        private void GiaoDienAD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banGiayDataSet1.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.banGiayDataSet1.KHACHHANG);
            cbo_danhMuc.SelectedIndex = 0;
            grid_dsKhachHang.AllowUserToAddRows = false;
        }

        // Thêm thông tin khách hàng
        [Obsolete]
        public void addCustomer()
        {
            string caption = "Thông báo";

            try
            {
                SqlConnection myConnection = createConnSQL();
                myConnection.Open();

                SqlCommand sqlCommand =
                    new SqlCommand("INSERT INTO KHACHHANG (MAKH, HOTENKH, DIACHI, SDT, NGAYTAO, TRANGTHAI)" +
                    "VALUES (@MAKH, @HOTENKH, @DIACHI, @SDT, @NGAYTAO , @TRANGTHAI)", myConnection);
                sqlCommand.Parameters.Add("@MAKH", xoaKhoangTrang(txt_maKH.Text));
                sqlCommand.Parameters.Add("@HOTENKH", xoaKhoangTrang(txt_tenKH.Text));
                sqlCommand.Parameters.Add("@DIACHI", xoaKhoangTrang(txt_diaChi.Text));
                sqlCommand.Parameters.Add("@SDT", txt_SDT.Text);
                sqlCommand.Parameters.Add("@NGAYTAO", dateNgayTao.Value.ToString());
                sqlCommand.Parameters.Add("@TRANGTHAI", chk_trangThai.Checked);
                sqlCommand.ExecuteNonQuery();

                myConnection.Close();
                MessageBox.Show("Thêm thành công", caption);

                findCustomer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        [Obsolete]
        private void btn_add_Click(object sender, EventArgs e)
        {
            string caption = "Thông báo";

            if (!kiemTraDuLieuNhapVao())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", caption);
            }
            else
            {
                addCustomer();

            }
        }

        // Sửa thông tin khách hàng
        public void editCustomer()
        {
            string caption = "Thông báo";

            // Kiểm tra dữ liệu trước khi sửa thông tin
            if (!kiemTraDuLieuNhapVao())
            {
                MessageBox.Show("Nhập thông tin", caption);
            }
            else 
            {

                SqlConnection myConnection = createConnSQL();
                myConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("UPDATE KHACHHANG SET HOTENKH = @HOTENKH," +
                    "DIACHI = @DIACHI, SDT = @SDT, NGAYTAO = @NGAYTAO, TRANGTHAI = @TRANGTHAI " +
                    "WHERE MAKH = @MAKH", myConnection);

                sqlCommand.Parameters.AddWithValue("@MAKH", xoaKhoangTrang(txt_maKH.Text));
                sqlCommand.Parameters.AddWithValue("@HOTENKH", xoaKhoangTrang(txt_tenKH.Text));
                sqlCommand.Parameters.AddWithValue("@DIACHI", xoaKhoangTrang(txt_diaChi.Text));
                sqlCommand.Parameters.AddWithValue("@SDT", txt_SDT.Text);
                sqlCommand.Parameters.AddWithValue("@NGAYTAO", dateNgayTao.Value.ToString());
                sqlCommand.Parameters.AddWithValue("@TRANGTHAI", chk_trangThai.Checked);
                sqlCommand.ExecuteNonQuery();

                myConnection.Close();
                MessageBox.Show("Sửa thành công", caption);

                // Kiểm tra thông tin sau khi thêm
                string input = txt_maKH.Text;
                string sSQL = "SELECT * FROM KHACHHANG WHERE MAKH = '" + input + "'";
                displayData(sSQL);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            editCustomer();
        }

        // Xóa khách hàng
        public void deleteCustommer()
        {
            string caption = "Thông báo";

            if (string.IsNullOrEmpty(txt_maKH.Text))
            {
                MessageBox.Show("Nhập mã khách hàng", caption);
            }
            else
            {
                string maKH = txt_maKH.Text;
                SqlConnection myConn = createConnSQL();

                myConn.Open();
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM KHACHHANG WHERE MAKH = '"+ maKH +"'", myConn);
                sqlCommand.ExecuteNonQuery();
                myConn.Close();
                MessageBox.Show("Xóa thành công", caption);

                findCustomer();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            deleteCustommer();
        }

        // Xóa khoảng trắng giữa các ký tự 
        public string xoaKhoangTrang(string str)
        {
            string inputString = Regex.Replace(str.Trim(), @"\s+", " ");

            return inputString;
        }

        private void txt_tenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back
                && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void txt_maKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar)
                && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void GiaoDienQuanLyKhachHangChoNhanVien_Load(object sender, EventArgs e)
        {
            cbo_danhMuc.SelectedIndex = 0;
        }

        private void cbo_danhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_timKH.Clear();

            // Clear combobox khi thay đổi lựa chọn
            grid_dsKhachHang.DataSource = null;
            grid_dsKhachHang.Rows.Clear();


            if (cbo_danhMuc.SelectedIndex == 0)
            {
                txt_timKH.Enabled = false;
            }
            else
            {
                txt_timKH.Enabled = true;
            }
        }

        // Hiện thông tin lên textbox khi nhấn vào gridDataView
        private void grid_dsKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow newDataGridView = grid_dsKhachHang.Rows[e.RowIndex];

                txt_maKH.Text = newDataGridView.Cells["MAKH"].Value.ToString();
                txt_tenKH.Text = newDataGridView.Cells["HOTENKH"].Value.ToString();
                txt_SDT.Text = newDataGridView.Cells["SDT"].Value.ToString();
                txt_diaChi.Text = newDataGridView.Cells["DIACHI"].Value.ToString();
                if (DateTime.TryParse(newDataGridView.Cells["NGAYTAO"].Value?.ToString(), out DateTime ngayTao))
                {
                    dateNgayTao.Value = ngayTao;
                }

                // Kiểm tra trạng thái
                if (Convert.ToBoolean(newDataGridView.Cells["TRANGTHAI"].Value) == true)
                {
                    chk_trangThai.Checked = true;
                }
                else
                {
                    chk_trangThai .Checked = false;
                }
            }
        }

        

        public bool kiemTraDuLieuNhapVao()
        {
            if (string.IsNullOrEmpty(txt_tenKH.Text) ||
               string.IsNullOrEmpty(txt_diaChi.Text) ||
                string.IsNullOrEmpty(txt_SDT.Text) ||
                string.IsNullOrEmpty(txt_maKH.Text))
            {
                return false;
            } 
            else
            {
                return true;
            }
        }

        private void grid_dsKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
