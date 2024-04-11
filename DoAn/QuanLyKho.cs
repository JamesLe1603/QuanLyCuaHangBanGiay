using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class QuanLyKho : Form
    {
        public QuanLyKho()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        public SqlConnection createConn()
        {
            string conn;
            conn = "Data Source=.;Initial Catalog=BanGiay;Integrated Security=True";
            SqlConnection SqlConn = new SqlConnection(conn);
            return SqlConn;
        }
        private void btnOut_Click(object sender, EventArgs e)
        {
            
        }
        public string XoaKhoangTrang(string str)
        {
            string inputString = Regex.Replace(str.Trim(), @"\s+", " ");
            return inputString;
        }
        public void DisplayData(String sSql)
        {
            SqlConnection myConn = createConn();
            try
            {
                myConn.Open();

                SqlDataAdapter daNCC = new SqlDataAdapter(sSql, myConn);

                DataSet dsNCC = new DataSet();
                daNCC.Fill(dsNCC);

                myConn.Close();
                dataGridView1.DataSource = dsNCC.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void FindAll()
        {
            string sSql;
            sSql = "Select * from NhaCungCap";
            DisplayData(sSql);
        }

        [Obsolete]
        private void btnAdd_Click(object sender, EventArgs e)
        {//,XUATXU,GIANHAP,GIABAN,DONVITINH,SOLUONG,DONGIA,HINHANH,KHUYENMAI,TRANGTHAIBAN,MANCC
            SqlConnection myconnection = createConn();

            double gianhap = double.Parse(txtGiaNhap.Text.ToString());
            double giaban = double.Parse(txtGiaBan.Text.ToString());
            int sl = int.Parse(txtSL.Text);
            double dongia = double.Parse(txtDonGia.Text.ToString());
            int km = int.Parse(txtKM.Text);
            int size = int.Parse(txtSize1.Text);
            int MaNCC = int.Parse(txtNCC.Text);
            try
            {
                myconnection.Open();
                string sqlInsert = "insert into SanPham" +
               " (MASP,TENSP,XUATXU,GIANHAP,GIABAN,DONVITINH,SOLUONG,DONGIA,KHUYENMAI,TRANGTHAIBAN,MANCC,SIZE) " +
               "VALUES(@MASP,@TENSP,@XX,@GIANHAP,@GIABAN,@DVT,@SL,@GIA,@KM,@TTBAN,@MANCC,@SIZE)";
                SqlCommand cmd = new SqlCommand(sqlInsert, myconnection);
                cmd.Parameters.Add("@MASP", "0");
                cmd.Parameters.Add("@TENSP", XoaKhoangTrang(txtTenSP.Text));
                cmd.Parameters.Add("@XX", XoaKhoangTrang(txtXuattXu.Text));
                cmd.Parameters.Add("@GIANHAP", gianhap);
                cmd.Parameters.Add("@GIABAN", giaban);
                cmd.Parameters.Add("@DVT", txtDVT.Text);
                cmd.Parameters.Add("@SL", sl);
                cmd.Parameters.Add("@GIA", dongia);
                cmd.Parameters.Add("@KM", km);
                cmd.Parameters.Add("@TTBAN", chkTT.Checked);
                cmd.Parameters.Add("@MANCC", MaNCC);
                cmd.Parameters.Add("@SIZE", size);
                cmd.ExecuteNonQuery();


                myconnection.Close();
                MessageBox.Show("Thêm thành công");
                FindAll();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }
        public void DeleteProduct()
        {
            SqlConnection myConn = createConn();

            try
            {
                myConn.Open();
                string sql = "Delete from SANPHAM where MASP = " + int.Parse(txtMaSP.Text);
                SqlCommand sqlCommand = new SqlCommand(sql, myConn);
                sqlCommand.ExecuteNonQuery();
                myConn.Close();
                MessageBox.Show("Xóa thành công");
                txtMaSP.Clear();
                txtTenSP.Clear();
                txtXuattXu.Clear();
                txtNCC.Clear();
                chkTT.Checked = false;
                txtDonGia.Clear();
                txtFind.Clear();
                txtGiaBan.Clear();
                txtGiaNhap.Clear();
                txtKM.Clear();
                txtSize1.Clear();
                txtSL.Clear();
                

                FindAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void editProduct()
        {
            SqlConnection myConn = createConn();
            int tt = 0;
            double gianhap = double.Parse(txtGiaNhap.Text);
            double giaban = double.Parse(txtGiaBan.Text);
            int sl = int.Parse(txtSL.Text);
            double dongia = double.Parse(txtDonGia.Text);
            int km = int.Parse(txtKM.Text);
            int size = int.Parse(txtSize1.Text);
            int MaNCC = int.Parse(txtNCC.Text);
            try
            {
                myConn.Open();

                if (chkTT.Checked)
                {
                    tt = 1;
                }
                string sSQL = "UPDATE SANPHAM SET " +

                    "TENSP = N'" + XoaKhoangTrang(txtTenSP.Text) +
                    "',XUATXU = N'" + XoaKhoangTrang(txtXuattXu.Text) +
                    "',GIANHAP = " + gianhap +
                    ",GIABAN = " + giaban +
                    ",DONVITINH = '" + txtDVT.Text +
                    "',SOLUONG = " + sl+
                    ",DONGIA = " + dongia+
                    ",KHUYENMAI = " + km+
                    ",TRANGTHAI = " + tt+
                    ",MANCC = " + MaNCC+
                    ",SIZE = " + size
                    + "WHERE MASP = " + int.Parse(txtMaSP.Text);


                //"MANCC = @MANCC, TENNHACUNGCAP = @TENNCC" +
                //" DIACHI = @DIACHI, SDT = @SDT, TRANGTHAI = @TRANGTHAI";

                SqlCommand sqlCommand = new SqlCommand(sSQL, myConn);
                sqlCommand.ExecuteNonQuery();
                myConn.Close();
                MessageBox.Show("Sửa thành công!");
                FindAll();
                //sqlCommand.Parameters.AddWithValue();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int MaSP = (int)row.Cells["colMaSP"].Value;
                String TenSP = row.Cells["colTenSP"].Value.ToString();
                String XuatXu = row.Cells["colXuatXu"].Value.ToString();
                double GiaNhap = Double.Parse(row.Cells["colGiaNhap"].Value.ToString());
                double GiaBan = Double.Parse(row.Cells["colGiaBan"].Value.ToString());
                String dvt = row.Cells["colDVT"].Value.ToString();
                int sl = (int)row.Cells["colSL"].Value;
                double dongia = Double.Parse(row.Cells["colDonGia"].Value.ToString());
                int km = (int)row.Cells["colKM"].Value;
                bool tt = (bool)row.Cells["colTT"].Value;
                int mancc = (int)row.Cells["colMaNCC"].Value;
                int size = (int)row.Cells["colSize"].Value;


                txtMaSP.Text = MaSP.ToString();
                txtTenSP.Text = TenSP;
                txtXuattXu.Text = XuatXu;
                txtGiaNhap.Text = GiaNhap.ToString();
                txtGiaBan.Text = GiaBan.ToString();
                txtDVT.Text = dvt;
                txtSL.Text=sl.ToString();
                txtDonGia.Text = dongia.ToString();
                txtKM.Text = km.ToString();
                txtNCC.Text = mancc.ToString   ();
                txtSize.Text = size.ToString();
                if (tt)
                {
                    chkTT.Checked = true;
                }
                else chkTT.Checked = false;
            }
        }
       
        private void QuanLyKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banGiayDataSet1.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.banGiayDataSet1.SANPHAM);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editProduct();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DeleteProduct();
        }

        private void btnFindx_Click(object sender, EventArgs e)
        {
            FindAll();
        }
    }
}
