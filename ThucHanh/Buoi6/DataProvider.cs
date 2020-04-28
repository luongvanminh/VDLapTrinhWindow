using System;
using System.Data.SqlClient;

namespace Buoi6
{
    public class DataProvider
    {
        private static readonly string connectionString =
                "Server=localhost,1433;Database=QLQuan;User Id=sa;Password=reallyStrongPwd123;";

        public DataProvider() {}

        public void LietKeThucUong() {

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
                    while (reader.Read())
                    {
                        Console.WriteLine("\t{0}\t\t\t{1}\t\t{2}\t\t{3}",
                            reader[0], reader[1], reader[2], reader[3]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                // Console.ReadLine();
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
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
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
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
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
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return 0;
        }    
    
        public void LietKeHoaDon() {

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
                    while (reader.Read())
                    {
                        Console.WriteLine("\t{0}\t\t\t{1}",
                            reader[0], reader[1]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                // Console.ReadLine();
            }
        }

        public void TaoHoaDon(string MSDH, DateTime dateTime) {
            
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
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void LietKeHoaDonChiTiet() {

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
                    while (reader.Read())
                    {
                        Console.WriteLine("\t{0}\t\t\t{1}\t\t{2}\t\t{3}",
                            reader[0], reader[1], reader[2], reader[3]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                // Console.ReadLine();
            }
        }
    
        public void LietKeHoaDonChiTietVoiMSDH(string MSDH) {

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
                    while (reader.Read())
                    {
                        Console.WriteLine("\t{0}\t\t\t{1}\t\t{2}\t\t{3}\t\t{4}\t\t{5}\t\t{6}",
                            reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                // Console.ReadLine();
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
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
