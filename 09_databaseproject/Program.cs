using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_databaseproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ado.net
            Console.WriteLine("*****c# veri tabanlı ürün kategori bilgi sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tablonumber; 


            Console.WriteLine("--------------------------------");
            Console.WriteLine("1--Kategoriler");
            Console.WriteLine("2--ürünler");
            Console.WriteLine("3--siparişler");
            Console.WriteLine("4--çıkış yap");
            Console.Write("lütfen getirmek istediğiniz tablo numarasını giriniz:");
            tablonumber = Console.ReadLine();
     
            Console.WriteLine("--------------------------------");
            //sql bağlantısına ihtiyacımız var bundan dolayı sqlconnection
            SqlConnection connection=new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=EğitimkampiDb;integrated security=true");
           connection.Open();
            // hangi tablo olduğunu öğrenmek için coonection lullanmamız gerekir
        SqlCommand command =new SqlCommand("Select *From TblCategory",connection);
        // sqldataadapter sql ile c# arası köprü göreyi üstlenir
            
          SqlDataAdapter adapter = new SqlDataAdapter(command);
            // datatable verileri geçici ram belleğe almamızı sağlar

            DataTable dt = new DataTable();
            adapter.Fill(dt);//sorguyu ram bellekte kullanıcıya göstermek
            connection.Close();
            // var bütün değişken türlerini üzerine alan değişkendir string int double hepsi olabilir
            foreach(DataRow row in dt.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine();
            }
            
            Console.Read();
        }
    }
}
