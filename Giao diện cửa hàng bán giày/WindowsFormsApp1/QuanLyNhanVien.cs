using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class QuanLyNhanVien : Form
    {
        [Obsolete]
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banGiayDataSet2.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.banGiayDataSet2.NHANVIEN);
        }

        public SqlConnection createConn()
        {
            string conn;
            conn = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=banGiay;Integrated Security=True";
            SqlConnection sqlConn = new SqlConnection(conn);

            return sqlConn;
        }

        public void displayData(string sSQL)
        {
            SqlConnection myConn = createConn();

            try
            {
                myConn.Open();

                SqlDataAdapter daNhanVien = new SqlDataAdapter(sSQL, myConn);

                DataSet dsNhanVien = new DataSet();
                daNhanVien.Fill(dsNhanVien);

                myConn.Close();

                grid_dsNhanVien.DataSource = dsNhanVien.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void findAllEmployees()
        {
            string sSQL;
            sSQL = "select * from NHANVIEN";

            displayData(sSQL);
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            findAllEmployees();
        }

        // Thêm nhân viên
        [Obsolete]
        public void addEmployee()
        {
            SqlConnection myConn = createConn();

            try
            {
                myConn.Open();

                string sSQL = "INSERT INTO NHANVIEN (MANV, HOTENNV, NGAYSINH, GIOITINH," +
                    " DIACHI, LUONG, SDT, USERNAME, PASSWORD, TRANGTHAI)" +
                    "VALUES (@MANV, @HOTENNV, @NGAYSINH, @GIOITINH, @DIACHI, @LUONG, @SDT" +
                    ", @USERNAME, @PASSWORD, @TRANGTHAI)";

                SqlCommand sqlCommand = new SqlCommand(sSQL, myConn);


                sqlCommand.Parameters.Add("@MANV", xoaKhoangTrang(txt_maNV.Text));
                sqlCommand.Parameters.Add("@HOTENNV", xoaKhoangTrang(txt_tenNV.Text));
                sqlCommand.Parameters.Add("@NGAYSINH", dt_ngaySinh.Value.ToString());
                sqlCommand.Parameters.Add("@GIOITINH", rad_nam.Checked ? rad_nam.Text : rad_nu.Text);
                sqlCommand.Parameters.Add("@LUONG", txt_luong.Text);
                sqlCommand.Parameters.Add("@DIACHI", xoaKhoangTrang(txt_diaChi.Text));
                sqlCommand.Parameters.Add("@SDT", txt_SDT.Text);
                sqlCommand.Parameters.Add("@USERNAME", txt_username.Text);
                sqlCommand.Parameters.Add("@PASSWORD", txt_password.Text);
                sqlCommand.Parameters.Add("@TRANGTHAI", chk_trangThai.Checked);

                sqlCommand.ExecuteNonQuery();
                myConn.Close();

                MessageBox.Show("Thêm nhân viên thành công");
                findAllEmployees();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        [Obsolete]
        private void btn_add_Click(object sender, EventArgs e)
        {
            addEmployee();
        }

        // Chỉnh sửa thông tin nhân viên
        public void editEmployee()
        {
            SqlConnection myConn = createConn();

            try
            {
                myConn.Open();

                string sSQL = "UPDATE NHANVIEN SET " +
                    "HOTENNV = @HOTENNV, NGAYSINH = @NGAYSINH, GIOITINH = @GIOITINH," +
                    " DIACHI = @DIACHI, LUONG = @LUONG, SDT = @SDT, USERNAME = @USERNAME, PASSWORD= @PASSWORD, TRANGTHAI = @TRANGTHAI" +
                    " WHERE MANV = @MANV";

                SqlCommand sqlCommand = new SqlCommand(sSQL, myConn);
                //sqlCommand.Parameters.AddWithValue();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btn_edit_Click(object sender, EventArgs e)
        {
            editEmployee();
        }

        public string xoaKhoangTrang(string str)
        {
            string inputString = Regex.Replace(str.Trim(), @"\s+", " ");

            return inputString;
        }

        private void grid_dsNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_luong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            } 
            else
            {
                e.Handled = false;
            }
        }

        private void txt_tenNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled= true;
            }
            else { e.Handled = false; }
        }

        private void txt_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else { e.Handled = false; }
        }

        private void grid_dsNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow newDataGridView = grid_dsNhanVien.Rows[e.RowIndex];

            txt_maNV.Text = newDataGridView.Cells["MANV"].Value.ToString();
            txt_tenNV.Text = newDataGridView.Cells["HOTENNV"].Value.ToString();
            txt_SDT.Text = newDataGridView.Cells["SDT"].Value.ToString();
            txt_username.Text = newDataGridView.Cells["USERNAME"].Value.ToString();
            txt_password.Text = newDataGridView.Cells["PASSWORD"].Value.ToString();
            txt_luong.Text = newDataGridView.Cells["LUONG"].Value.ToString();
            txt_diaChi.Text = newDataGridView.Cells["DIACHI"].Value.ToString();
            dt_ngaySinh.Value = (DateTime)newDataGridView.Cells["NGAYSINH"].Value;
            if (Convert.ToBoolean(newDataGridView.Cells["TRANGTHAI"].Value) == true)
            {
                chk_trangThai.Checked = true;
            }
            else
            {
                chk_trangThai.Checked = false;
            }
        }

        private void txt_nhapDuLieuRoiTim_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
