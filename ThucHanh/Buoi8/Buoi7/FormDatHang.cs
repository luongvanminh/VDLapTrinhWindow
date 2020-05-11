using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi7
{
    public partial class FormDatHang : Form
    {

        public FormDatHang()
        {
            InitializeComponent();

        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            string msdh = this.txtBoxMSDH.Text;

            DataProvider dataProvider = new DataProvider();
            dataProvider.TaoHoaDon(msdh, DateTime.Now);

            FormChiTietDonHang formChiTietDonHang = new FormChiTietDonHang(msdh);
            formChiTietDonHang.Show();

            formChiTietDonHang.FormClosed += new FormClosedEventHandler(OnCloseFormChiTietDonHang);

            this.Hide();
        }

        private void OnCloseFormChiTietDonHang(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

   
    }
}
