using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public class NhanVienKinhDoanh : NhanVien
    {
        public static readonly int TIEN_CUA_MOI_HOP_DONG = 500000;
        private int _soLuongHopDong = 0;

        public int soLuongHopDong
        {
            get { return _soLuongHopDong; }
            set { _soLuongHopDong = value; }
        }

        private int _luongCoban = 0;

        public int luongCoBan
        {
            get { return _luongCoban; }
            set { _luongCoban = value; }
        }

        public NhanVienKinhDoanh(string MSNV, string Hoten, int luongCoBan, int soLuongHopDong) : base(MSNV, Hoten) {
            this.luongCoBan = luongCoBan;
            this.soLuongHopDong = soLuongHopDong;
        }

        public override int TinhLuong()
        {
            return this.luongCoBan + this.soLuongHopDong * NhanVienKinhDoanh.TIEN_CUA_MOI_HOP_DONG;
        }
    }
}
