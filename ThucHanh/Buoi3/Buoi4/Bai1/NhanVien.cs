using System;

namespace Bai1
{
    public class NhanVien
    {
        public string MSNV;
        public string Hoten;

        public NhanVien(string MSNV, string Hoten) {
            this.MSNV = MSNV;
            this.Hoten = Hoten;
        }

        public virtual int TinhLuong() {
            return 0;
        }
    }
}
