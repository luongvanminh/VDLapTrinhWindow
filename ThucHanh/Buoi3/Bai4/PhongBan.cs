using System;

namespace Bai4
{
    public class PhongBan
    {
        NhanVien[] arrNhanVien;
        
        int soLuongNhanVien;

        public PhongBan() {
            arrNhanVien = new NhanVien[0];
            soLuongNhanVien = 0;
        }

        public PhongBan(int soLuongNhanVien){
            this.soLuongNhanVien = soLuongNhanVien;
            arrNhanVien = new NhanVien[soLuongNhanVien];
        }

        // operator []
        public NhanVien this[int i] {
            get { return arrNhanVien[i]; }
            set { arrNhanVien[i] = value; }
        }

        public void KhoiTaoPhongBan(){
            Console.WriteLine("Vui long nhap thong tin nhan vien o phong ban");
            for (int i = 0; i < this.soLuongNhanVien; i++) {
                Console.Write("Vui long nhap ten nhan vien thu " + i + ":");
                string ten = Console.ReadLine();
                Console.Write("Vui long nhap luong nhan vien thu " + i + ":");
                int luong = int.Parse(Console.ReadLine());
                Console.Write("Vui long nhap so ngay nghi nhan vien thu " + i + ":");
                int soNgayNghi = int.Parse(Console.ReadLine());
                this[i] = new NhanVien(ten, luong, soNgayNghi);
            }
        }

        public int TinhLuongPhongBan() {
            int kq = 0;
            for (int i=0; i < this.soLuongNhanVien; i++) {
                kq = kq + this[i].TinhLuong();
            }
            return kq;
        }
    }
}
