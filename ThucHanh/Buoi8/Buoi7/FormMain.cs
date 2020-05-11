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
    public partial class Buoi7 : Form
    {
        public Buoi7()
        {
            InitializeComponent();

            DataProvider dataProvider = new DataProvider();
            ThucUong[] arrThucUong = dataProvider.LietKeThucUong();
            this.initListView(arrThucUong);
        }

        private void btnConnectDB_Click(object sender, EventArgs e)
        {
            DataProvider dataProvider = new DataProvider();
            ThucUong[] arrThucUong = dataProvider.LietKeThucUong();
            this.initListView(arrThucUong);
        }

        private void initListView(ThucUong[] arrThucUong)
        {
            this.lstViewDSThucUong.Clear();

            ListViewItem[] lstViewItem = new ListViewItem[arrThucUong.Length];
            for (int i = 0; i < arrThucUong.Length; i++ )
            {
                ThucUong mThucUong = arrThucUong[i];
                ListViewItem item = new ListViewItem(mThucUong.MSHH);
                item.SubItems.Add(mThucUong.TenHang);
                item.SubItems.Add(mThucUong.Gia.ToString());
                item.SubItems.Add(mThucUong.TinhTrang.ToString());
                lstViewItem[i] = item;
            }

            // Create columns for the items and subitems.
            // Width of -2 indicates auto-size.
            this.lstViewDSThucUong.Columns.Add("MSHH", -2, HorizontalAlignment.Left);
            this.lstViewDSThucUong.Columns.Add("Ten Hang", -2, HorizontalAlignment.Left);
            this.lstViewDSThucUong.Columns.Add("Gia", -2, HorizontalAlignment.Left);
            this.lstViewDSThucUong.Columns.Add("Tinh trang", -2, HorizontalAlignment.Center);

            //Add the items to the ListView.
            this.lstViewDSThucUong.Items.AddRange(lstViewItem);

            this.lstViewDSThucUong.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            this.lstViewDSThucUong.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            this.lstViewDSThucUong.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
            this.lstViewDSThucUong.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.HeaderSize);

           
        }

        private void OnCloseForm(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
            DataProvider dataProvider = new DataProvider();
            ThucUong[] arrThucUong = dataProvider.LietKeThucUong();
            this.initListView(arrThucUong);
            //MessageBox.Show("OnCloseForm");
        }

        private void btnThemMoiThucUong_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            FormThemMoi formThemMoi = new FormThemMoi();
            formThemMoi.Show();

            formThemMoi.FormClosed += new FormClosedEventHandler(OnCloseForm);
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            FormChinhSua formChinhSua = new FormChinhSua();
            formChinhSua.Show();

            formChinhSua.FormClosed += new FormClosedEventHandler(OnCloseForm);
        }

        private void btnXoaThucUong_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            FormXoaThucUong formXoaThucUong = new FormXoaThucUong();
            formXoaThucUong.Show();

            formXoaThucUong.FormClosed += new FormClosedEventHandler(OnCloseForm);
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            FormDatHang formDatHang = new FormDatHang();
            formDatHang.Show();

            formDatHang.FormClosed += new FormClosedEventHandler(OnCloseForm);
        }
   
    }
}
