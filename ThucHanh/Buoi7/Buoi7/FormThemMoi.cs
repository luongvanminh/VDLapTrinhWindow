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
    public partial class FormThemMoi : Form
    {

        public FormThemMoi()
        {
            InitializeComponent();

        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            string mshh = this.txtBoxMSHH.Text;
            string tenHang = this.txtBoxTenHangHoa.Text;
            int gia = int.Parse(this.txtBoxGia.Text);
            int tinhTrang = this.rdBtnConHang.Checked ? 1 : 0;

            DataProvider dataProvider = new DataProvider();
            dataProvider.ThemMoiThucUong(mshh, tenHang, gia, tinhTrang);

            this.Close();
        }

   
    }
}
