using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class QuanLyNCC : Form
    {
        [Obsolete]
        public QuanLyNCC()
        {
            InitializeComponent();
        }
        public SqlConnection createConn()
        {
            string conn;
            conn = "Data Source=.;Initial Catalog=BanGiay;Integrated Security=True";
            SqlConnection SqlConn= new SqlConnection(conn);
            return SqlConn;
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
            catch(Exception ex)
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
        {
            SqlConnection myConn = createConn();
            if ( string.IsNullOrWhiteSpace(txtTenNCC.Text) || string.IsNullOrWhiteSpace(txtDT.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text) )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    myConn.Open();
                    String sSql = "INSERT INTO NHACUNGCAP(MANCC,TENNCC,DIACHI,SDT,TRANGTHAI) VALUES(" +
                        "@MANCC,@TENNCC,@DIACHI,@SDT,@TRANGTHAI)";
                    SqlCommand sqlCommand = new SqlCommand(sSql, myConn);

                    sqlCommand.Parameters.Add("@MANCC", "0");
                    sqlCommand.Parameters.Add("@TENNCC", XoaKhoangTrang(txtTenNCC.Text));
                    sqlCommand.Parameters.Add("@DIACHI", XoaKhoangTrang(txtDiaChi.Text));
                    sqlCommand.Parameters.Add("@SDT", txtDT.Text);
                    sqlCommand.Parameters.Add("@TRANGTHAI", chkTT.Checked);

                    sqlCommand.ExecuteNonQuery();
                    myConn.Close();

                    MessageBox.Show("Thêm thành công");
                    FindAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            
        }
        
        public string XoaKhoangTrang(string str)
        {
            string inputString = Regex.Replace(str.Trim(), @"\s+", " ");
            return inputString;
        }

        private void chkTT_CheckedChanged(object sender, EventArgs e)
        {
            if(chkTT.Checked)
            {
                chkTT.Text = "Hoạt động";
            }
            else
            {
                chkTT.Text = "Không hoạt động";
            }
        }

        public void editNCC()
        {
            SqlConnection myConn = createConn();
            int tt = 0;
            try
            {
                myConn.Open();

                if (chkTT.Checked)
                {
                    tt = 1;
                }
                string sSQL = "UPDATE NHACUNGCAP SET " +

                    "TENNCC = N'" + XoaKhoangTrang(txtTenNCC.Text) +
                    "',DIACHI = N'" + XoaKhoangTrang(txtDiaChi.Text) +
                    "',SDT = '" + txtDT.Text +
                    "',TRANGTHAI = " + tt
                    + "WHERE MANCC = " + int.Parse(txtMaNCC.Text);
                    

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
        public void XoaNCC()
        {
            SqlConnection myConn = createConn();

            try
            {
                myConn.Open();
                string sql = "Delete from NHACUNGCAP where MANCC = "+ int.Parse(txtMaNCC.Text);
                SqlCommand sqlCommand = new SqlCommand(sql, myConn);
                sqlCommand.ExecuteNonQuery();
                myConn.Close();
                MessageBox.Show("Xóa thành công");
                txtMaNCC.Clear();
                txtDT.Clear();
                txtTenNCC.Clear();
                txtDiaChi.Clear();
                chkTT.Checked = false;
                FindAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&& e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FindAll();
        }

        private void QuanLyNCC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banGiayDataSet.NHACUNGCAP' table. You can move, or remove it, as needed.
            this.nHACUNGCAPTableAdapter.Fill(this.banGiayDataSet.NHACUNGCAP);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int MaNCC = (int)row.Cells["colMaNCC"].Value;
                String TenNCC = row.Cells["colTenNCC"].Value.ToString();
                String dc = row.Cells["colDiaChi"].Value.ToString();
                String dt = row.Cells["colDT"].Value.ToString();
                int tt = (int)row.Cells["colTT"].Value;

                txtMaNCC.Text = MaNCC.ToString();
                txtTenNCC.Text = TenNCC;
                txtDiaChi.Text = dc;
                txtDT.Text = dt;
                if (tt == 1)
                {
                    chkTT.Checked = true;
                }
                else chkTT.Checked = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editNCC();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            XoaNCC();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void txtDT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
