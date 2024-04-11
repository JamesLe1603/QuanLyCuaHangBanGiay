using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class DienThongTin : Form
    {
        public DienThongTin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DialogResult r = MessageBox.Show("Xác nhận hóa đơn?", "LeTrung", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                MessageBox.Show("Lập hóa đơn thành công!", "LeTrung", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
