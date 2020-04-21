using System;

namespace Bai1
{
    public class NhanVienSanXuat:NhanVien 
    {
        public static readonly int TIEN_CONG_MOI_SAN_PHAM = 1000;
        private int _soLuongSanPham = 0;

        public int soLuongSanPham {
            get { return _soLuongSanPham; }
            set { _soLuongSanPham = value; }
        }

        public NhanVienSanXuat(string MSNV, string Hoten):base(MSNV, Hoten) {}

        public override int TinhLuong() {
            // if (this.soLuongSanPham < 3000) {
            //     return this.soLuongSanPham * NhanVienSanXuat.TIEN_CONG_MOI_SAN_PHAM;
            // } else {
            //     return (int) ((this.soLuongSanPham * NhanVienSanXuat.TIEN_CONG_MOI_SAN_PHAM) * 1.05);
            // } 
            int kq = this.soLuongSanPham * NhanVienSanXuat.TIEN_CONG_MOI_SAN_PHAM;
            if (this.soLuongSanPham >= 3000)
                kq = (int) (kq*1.05);
            return kq;
        }
    }
}
