﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region for döngüsü
            //for(x;y;z)
            //x:başlangıç değeri
            //y:bitiş değeri
            //z: artış azalış miktarı
            //---------------------------------
            //int i;
            //for(i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine(" c# eğitim kampı");
            //}

            //int i;
            //for (i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}
            //----------------------------------

            //Console.WriteLine("lütfen ekrana yazmak ,stediğiniz adedi girniz:");
            //int finishvalue=int.Parse(Console.ReadLine());
            //for (int i = 0; i < finishvalue; i++)
            //{
            //    Console.WriteLine("yaşasın cumhuriyet");



            //}



            #endregion

            #region for döngüsü ile karar yapıları
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);

            //    }

            //}
            //------------------------------------------
            //int totalvalue = 0;
            //for(int i = 0; i <= 10; i++)
            //{
            //    totalvalue += i;
            //}
            //Console.WriteLine(totalvalue);
            //--------------------------------------------
            //int totalvalue = 0;
            //for (int i = 0; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalvalue = +i;
            //    }

            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(totalvalue);
            //-----------------------------------
            //int count = 0;
            //for (int i = 0; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //    Console.WriteLine(i);

            //}
            //Console.WriteLine("---------------");
            //Console.WriteLine(count);
            //----------------------------------------
            //int bacerium = 1;
            //for (int i = 0; i <= 24; i++)
            //{
            //    bacerium *= 2;
            //    Console.WriteLine(i + "saat sonunda:" + bacerium);
            //}
            //--------------------------------------------


            #endregion


            #region while döngüsü


            // while(şart)
            //{
            // işlemler
            //}

            //int i = 1;
            //while (i < 10)
            //{
            //    Console.WriteLine(" merhaba döngüler");
            //    i++;
            //}
            //-------------------------------
            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0) {
            //        Console.WriteLine(i);

            //    }
            //    i++;
            //}
            //------------------------------------
            //int i = 1;
            //int sum = 0;
            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //    Console.WriteLine(i);
            //}
            // Console.WriteLine(sum);
            //---------------------------------------



            #endregion


            #region örnek sınav sorusu 
            //456
            //Console.WriteLine(" bir sayı giriniz:");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundred;
            //int sum;
            //ones = number % 10;
            //hundred = number / 100;
            //tens = number % 100 / 10;

            //Console.WriteLine(ones + "" + tens + "" + "" + hundred);
            //sum = ones + tens + hundred;
            //Console.WriteLine("toplam:" + sum);

            #endregion

            Console.Read();


        }
    }
}
