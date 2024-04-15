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

namespace WindowsFormsApp1
{
    public partial class GiaoDienQuanLyKhachHangChoNhanVien : Form
    {
        [Obsolete]
        public GiaoDienQuanLyKhachHangChoNhanVien()
        {
            InitializeComponent();
        }

        public SqlConnection createConnSQL()
        {
            string conn;
            conn = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=banGiay;" +
                "Integrated Security=True";

            SqlConnection myConnection = new SqlConnection(conn);

            return myConnection;
        }

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

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


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

        private void btn_tim_Click(object sender, EventArgs e)
        {
            findCustomerWithInput();
        }

        [Obsolete]
        private void btn_addCustomer_Click(object sender, EventArgs e)
        {
            string caption = "Thông báo";
            
            if(string.IsNullOrEmpty(txt_tenKH.Text) ||
               string.IsNullOrEmpty(txt_diaChi.Text) ||
                string.IsNullOrEmpty(txt_SDT.Text) ||
                string.IsNullOrEmpty(txt_maKH.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", caption);
            }
            else
            {
                addCustomer();
            }

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            txt_tenKH.Clear();
            txt_diaChi.Clear();
            txt_SDT.Clear();
            txt_maKH.Clear();
            txt_timKH.Clear();
            dateNgayTao.Value = DateTime.Now;
        }


        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) 
            { 
                e.Handled = true;
            }
        }


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

        private void GiaoDienQuanLyKhachHangChoNhanVien_Load(object sender, EventArgs e)
        {
            cbo_danhMuc.SelectedIndex = 0;
            grid_dsKhachHang.AllowUserToAddRows = false;
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

        private void grid_dsKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txt_tenKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_maKH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
