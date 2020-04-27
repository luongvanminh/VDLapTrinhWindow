using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class FormBai3 : Form
    {
        public FormBai3()
        {
            InitializeComponent();

            InitView();
        }

        private void InitView()
        {
            this.rdBtnNVKD.Checked = true;
            this.txtBoxSLSP.Enabled = false;
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien;
            string msnv = this.txtBoxMSNV.Text;
            string hoTen = this.txtBoxHoTenNV.Text;
            bool isNhanVienKinhDoanh = this.rdBtnNVKD.Checked;

            if (isNhanVienKinhDoanh) {
                int luongCoBan = int.Parse(this.txtBoxLCB.Text);
                int soLuongHopDong = int.Parse(this.txtBoxSLHD.Text);
                nhanVien = new NhanVienKinhDoanh(msnv, hoTen, luongCoBan, soLuongHopDong);
            }
            else
            {
                int soLuongSanPham = int.Parse(this.txtBoxSLSP.Text);
                nhanVien = new NhanVienSanXuat(msnv, hoTen, soLuongSanPham);
            }

            this.lblLuongNhanVien.Text = nhanVien.TinhLuong().ToString();
        }

        private void clearTextBoxNVSX_And_NVKD()
        {
            this.txtBoxSLSP.Text = "";
            this.txtBoxLCB.Text = "";
            this.txtBoxSLHD.Text = "";
        }

        private void rdBtnNVSX_CheckedChanged(object sender, EventArgs e)
        {
            this.clearTextBoxNVSX_And_NVKD();
            this.txtBoxSLSP.Enabled = true;
            this.txtBoxLCB.Enabled = false;
            this.txtBoxSLHD.Enabled = false;
        }

        private void rdBtnNVKD_CheckedChanged(object sender, EventArgs e)
        {
            this.clearTextBoxNVSX_And_NVKD();
            this.txtBoxSLSP.Enabled = false;
            this.txtBoxLCB.Enabled = true;
            this.txtBoxSLHD.Enabled = true;
        }
    }
}
