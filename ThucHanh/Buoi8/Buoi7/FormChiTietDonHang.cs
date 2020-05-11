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
    public partial class FormChiTietDonHang : Form
    {
        private string msdh;

        public FormChiTietDonHang(string MSDH)
        {
            InitializeComponent();

            this.msdh = MSDH;

            //DataProvider dataProvider = new DataProvider();
            //ThucUong[] arrThucUong = dataProvider.LietKeThucUong();
            //this.initListView(arrThucUong);
        }

        private void refreshListView(HoaDonChiTietDatHang[] arrHoaDonChiTietDatHang)
        {
            this.lstViewDSThucUong.Clear();

            ListViewItem[] lstViewItem = new ListViewItem[arrHoaDonChiTietDatHang.Length];
            for (int i = 0; i < arrHoaDonChiTietDatHang.Length; i++)
            {
                HoaDonChiTietDatHang mHoaDonChiTietDatHang = arrHoaDonChiTietDatHang[i];
                ListViewItem item = new ListViewItem(mHoaDonChiTietDatHang.MSDH);
                item.SubItems.Add(mHoaDonChiTietDatHang.MSHH);
                item.SubItems.Add(mHoaDonChiTietDatHang.TenSanPham);
                item.SubItems.Add(mHoaDonChiTietDatHang.SoLuong.ToString());
                item.SubItems.Add(mHoaDonChiTietDatHang.TiLeGiam.ToString());
                lstViewItem[i] = item;
            }

            // Create columns for the items and subitems.
            // Width of -2 indicates auto-size.
            this.lstViewDSThucUong.Columns.Add("MSDH", -2, HorizontalAlignment.Left);
            this.lstViewDSThucUong.Columns.Add("MSHH Hang", -2, HorizontalAlignment.Left);
            this.lstViewDSThucUong.Columns.Add("Ten san pham", -2, HorizontalAlignment.Left);
            this.lstViewDSThucUong.Columns.Add("So luong", -2, HorizontalAlignment.Left);
            this.lstViewDSThucUong.Columns.Add("Ti le giam", -2, HorizontalAlignment.Center);

            //Add the items to the listview.
            this.lstViewDSThucUong.Items.AddRange(lstViewItem);

            this.lstViewDSThucUong.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            this.lstViewDSThucUong.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
            this.lstViewDSThucUong.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
            this.lstViewDSThucUong.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.HeaderSize);
            this.lstViewDSThucUong.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.HeaderSize);

           
        }



        private void btnThemMoiThucUong_Click(object sender, EventArgs e)
        {
            string mshh = this.txtBoxMSHH.Text;
            int soLuong = int.Parse(this.txtBoxSoLuong.Text);
            int tiLeGiam = int.Parse(this.txtBoxTiLeGiam.Text);

            DataProvider dataProvider = new DataProvider();
            dataProvider.TaoHoaDonChiTiet(this.msdh, mshh, soLuong, tiLeGiam);

            HoaDonChiTietDatHang[] arrHoaDonChiTietDatHang = dataProvider.LietKeHoaDonChiTietVoiMSDH(this.msdh);

            this.refreshListView(arrHoaDonChiTietDatHang);

            this.clearForm();
        }

        private void clearForm()
        {
            this.txtBoxMSHH.Text = "";
            this.txtBoxSoLuong.Text = "";
            this.txtBoxTiLeGiam.Text = "";
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            DataProvider dataProvider = new DataProvider();
            dataProvider.XoaDonHang(this.msdh);
            dataProvider.XoaDonHangChiTiet(this.msdh);
            this.Close();
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            this.Close();
        }
   
    }
}
