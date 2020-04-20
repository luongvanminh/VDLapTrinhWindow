using System;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vui long nhap so luong nhan vien cua phong ban: ");
            int soLuongNhanVien = int.Parse(Console.ReadLine());
            PhongBan mPhongBan = new PhongBan(soLuongNhanVien);

            mPhongBan.KhoiTaoPhongBan();
            Console.WriteLine("Tong luong cua phong ban la: " + mPhongBan.TinhLuongPhongBan());
        }
    }
}
