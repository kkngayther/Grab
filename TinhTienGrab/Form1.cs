using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhTienGrab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private String tinhTien()
        {
            String thanhTienString;
            float soKM = float.Parse(txtBoxSoKM.Text);
            float thanhTien = 0;
            if (soKM <= 5)
            {
                thanhTien = soKM * 20000;
            }
            else if (soKM <= 20)
            {
                thanhTien = 5 * 20000 + (soKM - 5) * 15000;
            }
            else
            {
                thanhTien = 100000 + 15 * 15000 + (soKM - 20) * 10000;
            }
            thanhTienString = Convert.ToString(thanhTien);
            return thanhTienString;
        }
        private String khuyenMai()
        {
            String khuyenMai = "0";
            if (int.Parse(txtBoxSoKM.Text) > 100)
                khuyenMai = "10";
            return khuyenMai;
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            txtBoxThanhTien.Text = tinhTien();
            txtBoxKM.Text = khuyenMai();
        }
    }
}
