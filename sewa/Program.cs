using System;
using System.Data;
using System.Data.SqlClient;

namespace insert_read
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            while (true)
            {
                try
                {
                    Console.Write("\nKetik K untuk Terhubung ke database: ");
                    char chr = Convert.ToChar(Console.ReadLine());
                    switch (chr)
                    {
                        case 'K':
                            {
                                Console.Clear();
                                Console.WriteLine("Masukkan Database yang Dituju Kemudian klik Enter: ");
                                string db = Console.ReadLine();
                                SqlConnection conn = null;
                                string strKoneksi = "Data Source = LAPTOP-DAGQJ192\\WINDYANURMARETHA; " +
                                "initial catalog = sewa; " +
                                "User ID = sa; password = Puput123@";
                                conn = new SqlConnection(string.Format(strKoneksi, db));
                                conn.Open();
                                Console.Clear();
                                while (true)
                                {
                                    try
                                    {
                                        Console.WriteLine("\nMenu");
                                        Console.WriteLine("0. Menambahkan Data Admin");
                                        Console.WriteLine("1. Melihat Seluruh Data Kios");
                                        Console.WriteLine("2. Tambah Data Kios");
                                        Console.WriteLine("3. Edit Data Kios");
                                        Console.WriteLine("4. Hapus Data Kios");
                                        Console.WriteLine("5. Melihat Seluruh Data Penyewa");
                                        Console.WriteLine("6. Tambah Data Penyewa");
                                        Console.WriteLine("7. Edit Data Penyewa");
                                        Console.WriteLine("8. Hapus Data Penyewa");
                                        Console.WriteLine("9. Melihat Seluruh Data Tanaman");
                                        Console.WriteLine("A. Tambah Data Tanaman");
                                        Console.WriteLine("B. Edit Data Tanaman");
                                        Console.WriteLine("C. Hapus Data Tanaman");
                                        Console.WriteLine("D. Kembali");
                                        Console.WriteLine("\nEnter your choice : ");
                                        char ch = Convert.ToChar(Console.ReadLine());
                                        switch (ch)
                                        {
                                            case '0':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Input Data Admin\n");
                                                    Console.WriteLine("Masukkan NIP :");
                                                    string NIP = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Nama Admin :");
                                                    string nma = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Password :");
                                                    string pass = Console.ReadLine();
                                                    try
                                                    {
                                                        pr.insertadmin(NIP, nma, pass, conn);

                                                    }
                                                    catch (Exception e)
                                                    {
                                                        Console.WriteLine("\n Anda tidak memiliki " +
                                                            "akses untuk menambah data");
                                                        Console.WriteLine(e.ToString());
                                                    }

                                                }
                                                break;
                                            case '1':
                                                {
                                                        Console.Clear();
                                                        Console.WriteLine("Data Kios\n");
                                                        Console.WriteLine();
                                                        pr.bacakios(conn);
                                                }
                                                break;
                                            case '2':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Input Data Kios\n");
                                                    Console.WriteLine("Masukkan Kode Kios :");
                                                    string kd_kios = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Biaya :");
                                                    string biaya = Console.ReadLine();
                                                    Console.WriteLine("Masukkan NIP :");
                                                    string NIP = Console.ReadLine();
                                                    try
                                                    {
                                                            pr.insertkios(kd_kios, biaya, NIP, conn);

                                                    }
                                                    catch (Exception e)
                                                    {
                                                    Console.WriteLine("\n Anda tidak memiliki " +
                                                        "akses untuk menambah data");
                                                    Console.WriteLine(e.ToString());
                                                    }

                                                }
                                                break;
                                            case '3':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Input Data Kios\n");
                                                    Console.WriteLine("Masukkan Kode Kios :");
                                                    string kd_kios = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Biaya :");
                                                    string biaya = Console.ReadLine();
                                                    Console.WriteLine("Masukkan NIP :");
                                                    string NIP = Console.ReadLine();
                                                    try
                                                    {
                                                        pr.insertkios(kd_kios, biaya, NIP, conn);

                                                    }
                                                    catch (Exception e)
                                                    {
                                                        Console.WriteLine("\n Anda tidak memiliki " +
                                                            "akses untuk mengubah data");
                                                        Console.WriteLine(e.ToString());
                                                    }

                                                }
                                                break;
                                            case '4':
                                                {
                                                     Console.Clear();
                                                     Console.WriteLine("Masukkan Data Kios yang Ingin Dihapus\n");
                                                     string kd_kios = Console.ReadLine();
                                                     try
                                                     {
                                                        pr.deletekios(kd_kios, conn);

                                                }
                                                     catch (Exception e)
                                                     {
                                                        Console.WriteLine("\nAnda tidak memiliki " +
                                                            "akses untuk menambah data atau Data yang anda masukkan salah");
                                                        Console.WriteLine(e.ToString());
                                                     }
                                                }
                                                break;
                                            case '5':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Data Penyewa\n");
                                                    Console.WriteLine();
                                                    pr.bacapenyewa(conn);
                                                }
                                                break;
                                            case '6':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Input Data Penyewa\n");
                                                    Console.WriteLine("Masukkan NIK :");
                                                    string NIK = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Nama Penyewa :");
                                                    string nmp = Console.ReadLine();
                                                    Console.WriteLine("Masukkan No. Telepon :");
                                                    string no_tlpn = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Kode Kios yang disewa :");
                                                    string kd_kios = Console.ReadLine();
                                                    try
                                                    {
                                                        pr.insertpenyewa(NIK, nmp, no_tlpn, kd_kios, conn);

                                                    }
                                                    catch (Exception e)
                                                    {
                                                        Console.WriteLine("\n Anda tidak memiliki " +
                                                            "akses untuk menambah data");
                                                        Console.WriteLine(e.ToString());
                                                    }

                                                }
                                                break;
                                            case '7':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Edit Data Penyewa\n");
                                                    Console.WriteLine("Masukkan NIK :");
                                                    string NIK = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Nama Penyewa :");
                                                    string nmp = Console.ReadLine();
                                                    Console.WriteLine("Masukkan No. Telepon :");
                                                    string no_tlpn = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Kode Kios yang disewa :");
                                                    string kd_kios = Console.ReadLine();
                                                    try
                                                    {
                                                        pr.insertpenyewa(NIK, nmp, no_tlpn, kd_kios, conn);

                                                    }
                                                    catch (Exception e)
                                                    {
                                                        Console.WriteLine("\n Anda tidak memiliki " +
                                                            "akses untuk mengubah data");
                                                        Console.WriteLine(e.ToString());
                                                    }

                                                }
                                                break;
                                            case '8':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Masukkan Data Kios yang Ingin Dihapus\n");
                                                    string NIK = Console.ReadLine();
                                                    try
                                                    {
                                                        pr.deletepenyewa(NIK, conn);

                                                    }
                                                    catch (Exception e)
                                                    {
                                                        Console.WriteLine("\nAnda tidak memiliki " +
                                                            "akses untuk menambah data atau Data yang anda masukkan salah");
                                                        Console.WriteLine(e.ToString());
                                                    }
                                                }
                                                break;
                                            case '9':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Data Tanaman\n");
                                                    Console.WriteLine();
                                                    pr.bacatanaman(conn);
                                                }
                                                break;
                                            case 'A':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Input Data Tanaman\n");
                                                    Console.WriteLine("Masukkan Kode Tanaman :");
                                                    string kd_tnm = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Nama Tanaman :");
                                                    string nm_tnm = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Kode Kios :");
                                                    string kd_kios = Console.ReadLine();
                                                    try
                                                    {
                                                        pr.inserttanaman(kd_tnm, nm_tnm, kd_kios, conn);

                                                    }
                                                    catch (Exception e)
                                                    {
                                                        Console.WriteLine("\n Anda tidak memiliki " +
                                                            "akses untuk menambah data");
                                                        Console.WriteLine(e.ToString());
                                                    }

                                                }
                                                break;
                                            case 'B':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Edit Data Tanaman\n");
                                                    Console.WriteLine("Masukkan Kode Tanaman :");
                                                    string kd_tnm = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Nama Tanaman :");
                                                    string nm_tnm = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Kode Kios :");
                                                    string kd_kios = Console.ReadLine();
                                                    try
                                                    {
                                                        pr.edittanaman(kd_tnm, nm_tnm, kd_kios, conn);

                                                    }
                                                    catch (Exception e)
                                                    {
                                                        Console.WriteLine("\n Anda tidak memiliki " +
                                                            "akses untuk mengubah data");
                                                        Console.WriteLine(e.ToString());
                                                    }

                                                }
                                                break;
                                            case 'C':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Masukkan Data Tanaman yang Ingin Dihapus\n");
                                                    string kd_tnm = Console.ReadLine();
                                                    try
                                                    {
                                                        pr.deletetanaman(kd_tnm, conn);

                                                    }
                                                    catch (Exception e)
                                                    {
                                                        Console.WriteLine("\nAnda tidak memiliki " +
                                                            "akses untuk menambah data atau Data yang anda masukkan salah");
                                                        Console.WriteLine(e.ToString());
                                                    }
                                                }
                                                break;
                                            case 'D':
                                                conn.Close();
                                                Console.Clear();
                                                Main(new String[0]);
                                                return;
                                            default:
                                                {
                                                Console.Clear();
                                                Console.WriteLine("\nInvalid option");
                                                }
                                                break;
                                        }
                                    }
                                    catch
                                    {
                                    Console.Clear();
                                    Console.WriteLine("\nCheck for the value entered.");
                                    }
                                }
                            }
                        case 'E':
                            return;
                        default:
                            {
                                Console.WriteLine("\nInvalid option");
                            }
                            break;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Tidak dapat mengakses database tersebut\n");
                    Console.ResetColor();
                }
            }
        }
        public void insertadmin(string NIP, string nma, string pass, SqlConnection con)
        {

            string str = "";
            str = "insert into admin (NIP, nama_admin, password) " +
                "values(@NIP, @nma, @pa)";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("NIP", NIP));
            cmd.Parameters.Add(new SqlParameter("nma", nma));
            cmd.Parameters.Add(new SqlParameter("pa", pass));
            cmd.ExecuteNonQuery();
            Console.WriteLine("Data Berhasil Ditambahkan");
        }
        public void bacakios(SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand("Select kode_kios, biaya, NIP From kios", conn);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                for (int i = 0; i < r.FieldCount; i++)
                {
                    Console.WriteLine(r.GetValue(i));
                }
                Console.WriteLine();
            }
            r.Close();
        }
        public void insertkios(string kd_kios, string biaya, string NIP, SqlConnection con)
        {

            string str = "";
            str = "insert into kios (kode_kios, biaya, NIP) " +
                "values(@kdk, @bi, @NIP)";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("kdk", kd_kios));
            cmd.Parameters.Add(new SqlParameter("bi", biaya));
            cmd.Parameters.Add(new SqlParameter("NIP", NIP));
            cmd.ExecuteNonQuery();
            Console.WriteLine("Data Berhasil Ditambahkan");
        }
        public void editkios(string kd_kios, string biaya, string NIP, SqlConnection con)
        {

            string str = "";
            str = "insert into kios (kode_kios, biaya, NIP) " +
                "values(@kdk, @bi, @NIP)";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("kdk", kd_kios));
            cmd.Parameters.Add(new SqlParameter("bi", biaya));
            cmd.Parameters.Add(new SqlParameter("NIP", NIP));
            cmd.ExecuteNonQuery();
            Console.WriteLine("Data Berhasil Diupdate");
        }
        public void deletekios(String kd_kios, SqlConnection con)
        {
            string str = "";
            str = "Delete kios where kode_kios= @kdk";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("kdk", kd_kios));
            cmd.ExecuteNonQuery();
            Console.WriteLine("Data Berhasil Dihapus");
        }
        public void bacatanaman(SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand("Select kode_tanaman, nama_tanaman, kode_kios From tanaman", conn);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                for (int i = 0; i < r.FieldCount; i++)
                {
                    Console.WriteLine(r.GetValue(i));
                }
                Console.WriteLine();
            }
            r.Close();
        }
        public void inserttanaman(string kd_tnm, string nm_tnm, string kd_kios, SqlConnection con)
        {

            string str = "";
            str = "insert into tanaman (kode_tanaman, nama_tanaman, kode_kios) " +
                "values(@kdt, @nmt, @kdk)";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("kdt", kd_tnm));
            cmd.Parameters.Add(new SqlParameter("nmt", nm_tnm));
            cmd.Parameters.Add(new SqlParameter("kdk", kd_kios));
            cmd.ExecuteNonQuery();
            Console.WriteLine("Data Berhasil Diupdate");
        }
        public void edittanaman(string kd_tnm, string nm_tnm, string kd_kios, SqlConnection con)
        {

            string str = "";
            str = "insert into tanaman (kode_tanaman, nama_tanaman, kode_kios) " +
                "values(@kdt, @nmt, @kdk)";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("kdt", kd_tnm));
            cmd.Parameters.Add(new SqlParameter("nmt", nm_tnm));
            cmd.Parameters.Add(new SqlParameter("kdk", kd_kios));
            cmd.ExecuteNonQuery();
            Console.WriteLine("Data Berhasil Diupdate");
        }
        public void deletetanaman(string kd_tnm, SqlConnection con)
        {
            string str = "";
            str = "Delete tanaman where kode_tanaman= @kdt";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("kdt", kd_tnm));
            cmd.ExecuteNonQuery();
            Console.WriteLine("Data Berhasil Dihapus");
        }
        public void bacapenyewa(SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand("Select NIK, nama_penyewa, no_telp, kode_kios From penyewa", conn);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                for (int i = 0; i < r.FieldCount; i++)
                {
                    Console.WriteLine(r.GetValue(i));
                }
                Console.WriteLine();
            }
            r.Close();
        }
        public void insertpenyewa(string NIK, string nmp, string no_tlpn, string kd_kios, SqlConnection con)
        {

            string str = "";
            str = "insert into penyewa (NIK, nama_penyewa, no_telp, kode_kios) " +
                "values(@NIK, @nmp, @no, @kdk)";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("NIK", NIK));
            cmd.Parameters.Add(new SqlParameter("nmp", nmp));
            cmd.Parameters.Add(new SqlParameter("no", no_tlpn));
            cmd.Parameters.Add(new SqlParameter("kdk", kd_kios));
            cmd.ExecuteNonQuery();
            Console.WriteLine("Data Berhasil Ditambahkan");
        }
        public void editpenyewa(string NIK, string nmp, string no_tlpn, string kd_kios, SqlConnection con)
        {

            string str = "";
            str = "insert into penyewa (NIK, nama_penyewa, no_telp, kode_kios) " +
                "values(@NIK, @nmp, @no, @kdk)";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("NIK", NIK));
            cmd.Parameters.Add(new SqlParameter("nmp", nmp));
            cmd.Parameters.Add(new SqlParameter("no", no_tlpn));
            cmd.Parameters.Add(new SqlParameter("kdk", kd_kios));
            cmd.ExecuteNonQuery();
            Console.WriteLine("Data Berhasil Diupdate");
        }
        public void deletepenyewa(String NIK, SqlConnection con)
        {
            string str = "";
            str = "Delete penyewa where NIK= @NIK";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("NIK", NIK));
            cmd.ExecuteNonQuery();
            Console.WriteLine("Data Berhasil Dihapus");
        }
    }
}
