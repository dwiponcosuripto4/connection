using System;
using System.Data.SqlClient;

namespace connection
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().koneksi();
        }
        public void koneksi()
        {
            using (
                //membuat koneksi
                SqlConnection conn = new SqlConnection("data source=LAPTOP-9OD41I73\\DWIPONCOS;"
                + "database=PerizinanKuliah;user ID=sa;password=xm11tpro"))
            {
                conn.Open();
                Console.Write("Koneksi Sukses dengan Database");
                Console.Read();
            }

        }
        public void table()
        {
            using (SqlConnection connection = new SqlConnection($"Data Source=LAPTOP-9OD41I73\\DWIPONCOS;Initial Catalog=PerizinanKuliah;Integrated Security=True"))
            {
            }
        }
    }
}
