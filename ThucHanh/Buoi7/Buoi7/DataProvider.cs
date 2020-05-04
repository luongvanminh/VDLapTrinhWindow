using System;
using System.Data.SqlClient;

namespace Buoi7
{
    public class DataProvider
    {
        private static readonly string connectionString =
                "Server=192.168.1.110,1433;Database=QLQuan;User Id=sa;Password=reallyStrongPwd123;";

        public DataProvider() {}

        public ThucUong[] LietKeThucUong() {

            ThucUong[] arrThuocUong = new ThucUong[0];

            // Provide the query string with a parameter placeholder.
            string queryString =
                "SELECT * From ThucUong";

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);

                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    int soLuongDong = this.LietKeSoLuongThucUong();
                    // Console.WriteLine("soLuongDong: " + soLuongDong);
                    arrThuocUong = new ThucUong[soLuongDong];
                    // int soLuongDong = reader.VisibleFieldCount;
                    // Console.WriteLine("soLuongDong: " + soLuongDong);
                    int i = 0;
                    while (reader.Read())
                    {
                        // Parse data to model
                        ThucUong mThucUong = new ThucUong();
                        mThucUong.MSHH = reader[0].ToString();
                        mThucUong.TenHang = reader[1].ToString();
                        mThucUong.Gia = int.Parse(reader[2].ToString());
                        mThucUong.TinhTrang = bool.Parse(reader[3].ToString());
                        arrThuocUong[i] = mThucUong;
                        i++;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex.Message);
                }
                // Console.ReadLine();

                return arrThuocUong;
            }
        }
    
        public int LietKeSoLuongThucUong() {
            int ketQua = 0;

            // Provide the query string with a parameter placeholder.
            string queryString =
                "SELECT COUNT(*) AS numofrows From ThucUong";


            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);

                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    
                    
                    // 
                    while (reader.Read())
                    {
                        // Console.WriteLine("reader[0]: " + reader[0].ToString());
                        ketQua = int.Parse(reader[0].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Console.WriteLine(ex.Message);
                }
                // Console.ReadLine();

                return ketQua;
            }
        }
    
        public int ThemMoiThucUong(string MSHH, string TenHangHoa, int Gia, int TinhTrang) {

            // Provide the query string with a parameter placeholder.
            string queryString =
                "INSERT INTO ThucUong (MSHH, TenHang, Gia, TinhTrang)"
                + "VALUES (@MSHH, @TenHangHoa, @Gia, @TinhTrang);";

            // Specify the parameter value.
            string mshh = MSHH;
            string tenHH = TenHangHoa;
            int gia = Gia;
            int tinhtrang = TinhTrang;

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MSHH", mshh);
                command.Parameters.AddWithValue("@TenHangHoa", tenHH);
                command.Parameters.AddWithValue("@Gia", gia);
                command.Parameters.AddWithValue("@TinhTrang", tinhtrang);


                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                    return 1;
                }
                catch (Exception ex)
                {
                    // Console.WriteLine(ex.Message);
                }
            }

            return 0;
        }

        public int XoaThucUong(string MSHH) {

            // Provide the query string with a parameter placeholder.
            string queryString =
                "DELETE FROM ThucUong WHERE MSHH=@MSHH";

            // Specify the parameter value.
            string mshh = MSHH;

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MSHH", mshh);

                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();

                    return 1;
                }
                catch (Exception ex)
                {
                    // Console.WriteLine(ex.Message);
                }
            }

            return 0;
        }
    
        public int ChinhSuaThucUong(string MSHH, string newMSHH, string TenHangHoa, int Gia, int TinhTrang) {

            // Provide the query string with a parameter placeholder.
            string queryString =
                "UPDATE ThucUong SET MSHH = @newMSHH, TenHang = @TenHangHoa, Gia=@Gia, TinhTrang = @TinhTrang " +
                    "WHERE MSHH = @MSHH;";

            // Specify the parameter value.
            string mshh = MSHH;
            string newMSHHParam = newMSHH;
            string tenHH = TenHangHoa;
            int gia = Gia;
            int tinhtrang = TinhTrang;

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MSHH", mshh);
                command.Parameters.AddWithValue("@newMSHH", newMSHHParam);
                command.Parameters.AddWithValue("@TenHangHoa", tenHH);
                command.Parameters.AddWithValue("@Gia", gia);
                command.Parameters.AddWithValue("@TinhTrang", tinhtrang);

                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();

                    return 1;
                }
                catch (Exception ex)
                {
                    // Console.WriteLine(ex.Message);
                }
            }

            return 0;
        }    
    
        public HoaDon[] LietKeHoaDon() {
            HoaDon[] arrHoaDon = new HoaDon[0];

            // Provide the query string with a parameter placeholder.
            string queryString =
                "SELECT * From HoaDon";


            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);

                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    int soLuongHoaDon = this.LietKeSoLuongHoaDon();
                    arrHoaDon = new HoaDon[soLuongHoaDon];
                    int i = 0;
                    while (reader.Read())
                    {
                        // Console.WriteLine("\t{0}\t\t\t{1}",
                        //     reader[0], reader[1]);
                        // Parse data to model HoaDon
                        HoaDon mHoaDon = new HoaDon();
                        mHoaDon.MSDH = reader[0].ToString();
                        mHoaDon.NgayDat =  DateTime.Parse(reader[1].ToString()); 
                        arrHoaDon[i] = mHoaDon;
                        i++;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Console.WriteLine(ex.Message);
                }
                // Console.ReadLine();
            }

            return arrHoaDon;
        }

        public int LietKeSoLuongHoaDon() {
            int ketQua = 0;

            // Provide the query string with a parameter placeholder.
            string queryString =
                "SELECT COUNT(*) AS numofrows From HoaDon";


            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);

                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ketQua = int.Parse(reader[0].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Console.WriteLine(ex.Message);
                }
                // Console.ReadLine();

                return ketQua;
            }
        }
    
        public int TaoHoaDon(string MSDH, DateTime dateTime) {
            
            // Provide the query string with a parameter placeholder.
            string queryString =
                "INSERT INTO HoaDon (MSDH, NgayDat)"
                    + "VALUES (@MSDH, @NgayDat);";

            // Specify the parameter value.
            string msdh = MSDH;
            string ngayDat = dateTime.ToString();        

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MSDH", msdh);
                command.Parameters.AddWithValue("@NgayDat", ngayDat);

                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                    return 1;
                }
                catch (Exception ex)
                {
                    // Console.WriteLine(ex.Message);
                }
            }

            return 0;
        }

        public HoaDonChiTietDatHang[] LietKeHoaDonChiTiet() {
            HoaDonChiTietDatHang[] arrHoaDonChiTietDatHang = new HoaDonChiTietDatHang[0];

            // Provide the query string with a parameter placeholder.
            string queryString =
                "SELECT * From HDChiTietDatHang";

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);

                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    int soLuongHoaDonChiTietDatHang = this.LietKeSoLuongHoaDonChiTietDatHang();
                    arrHoaDonChiTietDatHang = new HoaDonChiTietDatHang[soLuongHoaDonChiTietDatHang];
                    int i = 0;
                    while (reader.Read())
                    {
                        // Console.WriteLine("\t{0}\t\t\t{1}\t\t{2}\t\t{3}",
                        //     reader[0], reader[1], reader[2], reader[3]);
                        // Parse data to model HoaDonChiTietDatHang
                        HoaDonChiTietDatHang mHoaDonChiTietDatHang = new HoaDonChiTietDatHang();
                        mHoaDonChiTietDatHang.MSDH = reader[0].ToString();
                        mHoaDonChiTietDatHang.MSHH = reader[1].ToString();
                        mHoaDonChiTietDatHang.SoLuong = int.Parse(reader[2].ToString());
                        mHoaDonChiTietDatHang.TiLeGiam = int.Parse(reader[3].ToString());
                        arrHoaDonChiTietDatHang[i] = mHoaDonChiTietDatHang;
                        i++;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Console.WriteLine(ex.Message);
                }
                // Console.ReadLine();
            }

            return arrHoaDonChiTietDatHang;
        }
    
        public int LietKeSoLuongHoaDonChiTietDatHang() {
            int ketQua = 0;

            // Provide the query string with a parameter placeholder.
            string queryString =
                "SELECT COUNT(*) AS numofrows From HDChiTietDatHang";

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);

                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ketQua = int.Parse(reader[0].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Console.WriteLine(ex.Message);
                }
                // Console.ReadLine();

                return ketQua;
            }
        }

        public HoaDonChiTietDatHang[] LietKeHoaDonChiTietVoiMSDH(string MSDH) {
            HoaDonChiTietDatHang[] arrHoaDonChiTietDatHang = new HoaDonChiTietDatHang[0];

            // Provide the query string with a parameter placeholder.
            string queryString =
                @"SELECT * 
                    From HDChiTietDatHang hdct
                    INNER JOIN ThucUong thucUong 
                                ON hdct.MSHH = thucUong.MSHH
                    Where MSDH=@MSDH";

            // Specify the parameter value.
            string msdh = MSDH;    

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MSDH", msdh);

                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    int soLuongHoaDonChiTietDatHang = this.LietKeSoLuongHoaDonChiTietDatHangVoiMSDH(msdh);
                    arrHoaDonChiTietDatHang = new HoaDonChiTietDatHang[soLuongHoaDonChiTietDatHang];
                    int i = 0;
                    while (reader.Read())
                    {
                        // Parse data to model HoaDonChiTietDatHang
                        HoaDonChiTietDatHang mHoaDonChiTietDatHang = new HoaDonChiTietDatHang();
                        mHoaDonChiTietDatHang.MSDH = reader[0].ToString();
                        mHoaDonChiTietDatHang.MSHH = reader[1].ToString();
                        mHoaDonChiTietDatHang.SoLuong = int.Parse(reader[2].ToString());
                        mHoaDonChiTietDatHang.TiLeGiam = int.Parse(reader[3].ToString());
                        arrHoaDonChiTietDatHang[i] = mHoaDonChiTietDatHang;
                        i++;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Console.WriteLine(ex.Message);
                }
                // Console.ReadLine();
            }

            return arrHoaDonChiTietDatHang;
        }
 
         public int LietKeSoLuongHoaDonChiTietDatHangVoiMSDH(string MSDH) {
            int ketQua = 0;

            // Provide the query string with a parameter placeholder.
            string queryString =
                "SELECT COUNT(*) AS numofrows From HDChiTietDatHang Where MSDH=@MSDH ";

            // Specify the parameter value.
            string msdh = MSDH;   

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MSDH", msdh);

                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ketQua = int.Parse(reader[0].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Console.WriteLine(ex.Message);
                }
                // Console.ReadLine();

                return ketQua;
            }
        }


        public void TaoHoaDonChiTiet(string MSDH, string MSHH, int SoLuong, int TiLeGiam) {
            
            // Provide the query string with a parameter placeholder.
            string queryString =
                "INSERT INTO HDChiTietDatHang (MSDH, MSHH, SoLuong, TiLeGiam)"
                + "VALUES (@MSDH, @MSHH, @SoLuong, @TiLeGiam);";

            // Specify the parameter value.
            string msdh = MSDH;
            string mshh = MSHH;
            int soLuong = SoLuong;
            int tiLeGiam = TiLeGiam;
    

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MSDH", msdh);
                command.Parameters.AddWithValue("@MSHH", mshh);
                command.Parameters.AddWithValue("@SoLuong", soLuong);
                command.Parameters.AddWithValue("@TiLeGiam", tiLeGiam);

                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
