using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class FormBai1 : Form
    {
        public FormBai1()
        {
            InitializeComponent();

            
        }

        private void btnXuLy_Click(object sender, EventArgs e)
        {
            int x = int.Parse(this.txtBoxX.Text);
            int y = int.Parse(this.txtBoxY.Text);

            //MessageBox.Show("x mu y la: " + Math.Pow(x, y));
            this.lblKetQua.Text = "x mu y la: " + Math.Pow(x, y);
        }

    }
}
