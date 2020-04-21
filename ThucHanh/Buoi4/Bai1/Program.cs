using System;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            NhanVien nhanVien;
            Console.WriteLine("Vui long nhap ma nhan vien:");
            string msnv = Console.ReadLine();
            Console.WriteLine("Vui long nhap hoten nhan vien:");
            string hoTen = Console.ReadLine();
            Console.WriteLine("Vui long cho biet loai nhan vien");
            Console.WriteLine("(1) Nhan Vien Kinh Doanh");
            Console.WriteLine("(2) Nhan Vien San Xuat");
            int loai = int.Parse(Console.ReadLine());

            switch (loai)
            {
                case 1: // Truong hop nhan vien kinh doanh
                    nhanVien = new NhanVienKinhDoanh(msnv, hoTen);
                    Console.WriteLine("Vui long nhap luong co ban cua nhan vien kinh doanh:");
                    int luongCoBan = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vui long nhap so luong hop dong cua nhan vien kinh doanh:");
                    int soLuongHopDong = int.Parse(Console.ReadLine());
                    (nhanVien as NhanVienKinhDoanh).luongCoBan = luongCoBan;
                    (nhanVien as NhanVienKinhDoanh).soLuongHopDong = soLuongHopDong;
                    break;
                case 2: // Truong hop nhan vien san xuat    
                    nhanVien = new NhanVienSanXuat(msnv, hoTen);
                    Console.WriteLine("Vui long nhap so luong san pham cua nhan vien san xuat:");
                    int soLuongSanPham = int.Parse(Console.ReadLine());
                    (nhanVien as NhanVienSanXuat).soLuongSanPham = soLuongSanPham;
                    break;
                default:
                    Console.WriteLine("Vui long nhap so 1 hoac 2");
                    nhanVien = new NhanVien(msnv, hoTen);
                    break;
            }

            int luongNhanVien = nhanVien.TinhLuong();
            Console.WriteLine("Luong cua nhan vien la:" + luongNhanVien);
        }
    }
}
