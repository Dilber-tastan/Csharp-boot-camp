using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_foreachloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region foreach döngüsü 
            // değişken türü
            // değişken adı
            // in komutu
            //liste ,kolleksiyon ,dizi

            //string[] cties = { "milano ", "roma", "ankara", "istanbul", "varşova" };
            //foreach (string x in cties)
            //{
            //    Console.WriteLine(x);
            //}


            //int[] numbers = { 45, 85, 79, 120, 653, 485, 563, 2207 };
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 45, 85, 79, 120, 653, 485, 563, 2207 };

            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;

            //}
            // Console.WriteLine(total);

            //List<int>number = new List<int>()
            //{
            //    1,8,6,3,5
            //};
            //foreach (int i in number)
            //{
            //    Console.WriteLine(i);
            //}

            //string word = "dünya0";
            //foreach (char s in word)
            //{
            //    Console.Write(s);

            //}



            #endregion

            #region örnek sınav sistemi uygulaması 
            Console.WriteLine("**c# eğitim kampı sınav uygulaması**");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.Write("sınıfınızda kaç öğrenci var");
            int studentcount=int .Parse(Console.ReadLine());
            Console.WriteLine("--------------------------");

            string []studentname = new string[studentcount];
            double []studentexamavg = new double[studentcount];

            for (int i = 0; i < studentcount; i++)
            {
                Console.Write($"{i + 1}.öğrencinin ismini giriniz.");
                studentname[i] = Console.ReadLine();

                double totalexamresult = 0;


                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"{studentname[i]}isimli öğrencinin[j+1].sınav notunu giriniz:");

                    double value = double.Parse(Console.ReadLine());
                    totalexamresult += value;//notları topluyoruz
                }
                studentexamavg[i] = totalexamresult / 3;

       
            }
            for (int i = 0; i < studentcount; i++)
            {
                Console.WriteLine($"{studentname[i]} adlı öğrencinin ortalaması:{studentexamavg[i]}");
                if (studentexamavg[i]>=50) {
                    Console.WriteLine($"{studentname[i]} adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentname[i]}adlı öğrenci dersten kaldı ");

                }
            
            
            
            }




            #endregion
            Console.Read();
        }
    }
}
