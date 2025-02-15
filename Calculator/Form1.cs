using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            /*int ketqua;
            ketqua = Int32.Parse(txtSoA.Text) + Int32.Parse(txtSoB.Text);
            txtKetQua.Text = ketqua.ToString();
            MessageBox.Show("Cong");*/
            int a, b, kq;
            a = int.Parse(txtSoA.Text);
            b = int.Parse(txtSoB.Text);
            kq = a + b;
            txtKetQua.Text = kq.ToString();

        }
    }
}
