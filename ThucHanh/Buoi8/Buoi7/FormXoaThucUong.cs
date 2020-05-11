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
    public partial class FormXoaThucUong : Form
    {

        public FormXoaThucUong()
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

            DataProvider dataProvider = new DataProvider();
            dataProvider.XoaThucUong(mshh);

            this.Close();
        }

   
    }
}
