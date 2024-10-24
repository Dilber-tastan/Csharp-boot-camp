using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region void metotlar
            //()
            // geriye değer döndürmeyen metotlar
            // listele ,ekle,sil,güncelle
            //void


            //void customerlist()
            //{
            //    Console.WriteLine(" dilber taştan");
            //    Console.WriteLine("mewrve yıldız");
            //    Console.WriteLine("ayşe çınar");
            //    Console.WriteLine(" hakan öztürk");
            //}
            //Console.WriteLine();

            //void sum()
            //{
            //    int x = 1;
            //    int y=2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //sum();
            #endregion
            #region geriye değer döndürmeyen string parametreli metotlar
            //void writemethod(string name)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.WriteLine("mehmet yıldırım");

            //void sutomercard(string name,string surname)
            //{
            //    Console.WriteLine(name);
            //    Console.WriteLine(surname);
            //}

            #endregion
            #region geriye değer döndürmeyen int parametreli metotlar
            //void sum (int number1,int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //sum(4, 8, 79);
            #endregion

            #region geriye değer döndüren metotlar

            // string customername()
            // {
            //     return "buse yıldız";
            // }
            //Console.WriteLine(customername());   

            //string studentcard()
            //{
            //    string name = "ali";
            //    string surname = "kaya";

            //    return name+" " + surname;

            //}
            //Console.WriteLine(studentcard());
            #endregion

            #region geriye değer döndüren parametreli metotlar


            //string countrycard(string countryname ,string capital,string flagcolor){


            //  string cardinfo = "ülke:" + countryname + " başkent:" + capital + "bayrak rengi:" + flagcolor;

            //  return cardinfo;
            //  { 

            //  }
            //  string x, y, z;
            //  Console.Write("ülke adını giriniz:");
            //  x=Console.ReadLine();
            //  Console.Write("başkent adını giriniz:");
            //  y=Console.ReadLine();
            //  Console.Write("bayrak rengini giriniz:");

            //  z=Console.ReadLine();
            //  Console.WriteLine(countrycard(x,y,z));






            #endregion

            #region geriye değer döndüren int parametreli metotlar

            //int sum(int number1,int number2)
            //{
            //    int result =number1 + number2;
            //   return result;
            //}
            //Console.WriteLine(sum(45, 90));
            //Console.WriteLine(sum(85,63));


            #endregion

            string examresult(string student ,int exam1,int exam2,int exam3)
            {

                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return " student passed the exam:" + "result:"+result;

                }
                else
                {
                    return "student failed:" + "result:"+result;
                }
            }
            Console.WriteLine(examresult("ali", 25, 41, 85));
            Console.WriteLine(examresult("beyza",56,23,96));
            
            Console.Read();






        }
    }
}
