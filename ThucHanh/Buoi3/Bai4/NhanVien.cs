using System;

namespace Bai4
{
    public class NhanVien
    {
        string ten;
        int luong;
        int soNgayNghi;

        public NhanVien(string ten, int luong, int soNgayNghi){
            this.ten = ten;
            this.luong = luong;
            this.soNgayNghi = soNgayNghi;
        }

        public int TinhLuong(){
            return luong - soNgayNghi*100000;
        }
    }
}
