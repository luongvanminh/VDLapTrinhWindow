using System;

namespace Bai1
{
    public class NhanVienKinhDoanh:NhanVien 
    {
        public static readonly int TIEN_CUA_MOI_HOP_DONG = 500000;
        private int _soLuongHopDong = 0;

        public int soLuongHopDong {
            get { return _soLuongHopDong; }
            set { _soLuongHopDong = value; }
        }

        private int _luongCoban = 0;

        public int luongCoBan {
            get { return _luongCoban; }
            set { _luongCoban = value; }
        }

        public NhanVienKinhDoanh(string MSNV, string Hoten):base(MSNV, Hoten) {}

        public override int TinhLuong() {
            return this.luongCoBan + this.soLuongHopDong * NhanVienKinhDoanh.TIEN_CUA_MOI_HOP_DONG;
        }
    }
}
