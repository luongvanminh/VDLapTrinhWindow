using System;

namespace Buoi6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataProvider dataProvider = new DataProvider();

            int code = -1;
            while (code != 0)
            {
                Console.WriteLine("============================");
                Console.WriteLine(@"Vui long chon chuc nang:
                    (1) Xem danh sach cac thuc uong
                    (2) Xem chi tiet mot hoa don
                    (3) Dat mon
                    (0) Thoat
                ");

                code = int.Parse(Console.ReadLine());

                switch (code)
                {
                    case 0:
                    break;
                    case 1:
                        Console.WriteLine("Danh sach thuc uong:");
                        dataProvider.LietKeThucUong();
                        ThemXoaSuaThucUong(dataProvider);
                    break;
                    case 2:
                        Console.WriteLine("Danh sach don hang:");
                        dataProvider.LietKeHoaDon();
                        Console.WriteLine("Vui long nhap danh ma hoa don can xem:");
                        string msdh = Console.ReadLine();
                        dataProvider.LietKeHoaDonChiTietVoiMSDH(msdh);
                    break;
                    case 3:
                        DatMon(dataProvider);
                    break;
                    default:
                        Console.WriteLine("Vui long chon 0-3");
                    break;
                }

            }
        }

        private static void ThemXoaSuaThucUong(DataProvider dataProvider) {
            int code = -1;
            while (code != 0) {
                Console.WriteLine("============================");
                Console.WriteLine(@"Vui long chon chuc nang:
                    (1) Them thuc uong moi
                    (2) Sua thuc uong
                    (3) Xoa thuc uong
                    (0) Tro lai
                ");

                code = int.Parse(Console.ReadLine());

                switch (code)
                {
                    case 0:
                    break;
                    case 1:
                        Console.WriteLine("Vui long nhap ma so hang hoa: ");
                        string mshh = Console.ReadLine();
                        Console.WriteLine("Vui long nhap ten hang hoa: ");
                        string tenHangHoa = Console.ReadLine();
                        Console.WriteLine("Vui long nhap gia hang hoa: ");
                        int gia = int.Parse(Console.ReadLine());
                        Console.WriteLine("Vui long nhap tinh trang hang hoa: ");
                        int tinhTrang = int.Parse(Console.ReadLine());

                        dataProvider.ThemMoiThucUong(mshh, tenHangHoa, gia, tinhTrang);
                        dataProvider.LietKeThucUong();
                    break;
                    case 2:
                        Console.WriteLine("Vui long nhap ma so hang hoa can chinh sua: ");
                        mshh = Console.ReadLine();
                        Console.WriteLine("Vui long nhap ma so hang hoa moi: ");
                        string newMshh = Console.ReadLine();
                        Console.WriteLine("Vui long nhap ten hang hoa moi: ");
                        tenHangHoa = Console.ReadLine();
                        Console.WriteLine("Vui long nhap gia hang hoa moi: ");
                        gia = int.Parse(Console.ReadLine());
                        Console.WriteLine("Vui long nhap tinh trang hang hoa moi: ");
                        tinhTrang = int.Parse(Console.ReadLine());
                        dataProvider.ChinhSuaThucUong(mshh, newMshh, tenHangHoa, gia, tinhTrang);
                        dataProvider.LietKeThucUong();
                    break;
                    case 3:
                        Console.WriteLine("Vui long nhap ma so hang hoa can xoa: ");
                        mshh = Console.ReadLine();
                        dataProvider.XoaThucUong(mshh);
                        dataProvider.LietKeThucUong();
                    break;
                    default:
                        Console.WriteLine("Vui long chon 0-3");
                    break;
                }
            }
        }

        private static void DatMon(DataProvider dataProvider) {
            Console.WriteLine("============================");
            Console.WriteLine("Vui long nhap ma so don hang: ");
            string msdh = Console.ReadLine();
            dataProvider.TaoHoaDon(msdh, DateTime.Now);

            int code = -1;
            while (code != 0) {
                Console.WriteLine(@"Vui long chon chuc nang:
                    (1) Chon thuc uong
                    (0) Ket thuc dat hang
                ");

                code = int.Parse(Console.ReadLine());

                switch (code)
                {
                    case 0:
                    break;
                    case 1:
                        Console.WriteLine("============================");
                        Console.WriteLine("Danh sach thuc uong");
                        dataProvider.LietKeThucUong();
                        Console.WriteLine("Vui long nhap ma so thuc uong ma ban muon dat:");
                        string mshh = Console.ReadLine();
                        Console.WriteLine("Vui long nhap so luong ma ban muon dat:");
                        int soLuong = int.Parse(Console.ReadLine());
                        Console.WriteLine("Vui long nhap ti le giam:");
                        int tiLeGiam = int.Parse(Console.ReadLine());
                        dataProvider.TaoHoaDonChiTiet(msdh, mshh, soLuong, tiLeGiam);
                    break;
                    default:
                        Console.WriteLine("Vui long chon 0-1");
                    break;
                }
            }

            Console.WriteLine("============================");
            Console.WriteLine("Hoa don chi tiet cua don han ma so " + msdh + " la:");
            dataProvider.LietKeHoaDonChiTietVoiMSDH(msdh);

        }
    }
}
