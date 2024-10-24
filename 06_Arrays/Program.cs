using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region temel dizi örnekleri
            // değişken türü [] dizi adı=new değişen türü [eleman sayısı];
            //string[] colors =new string[4];
            //colors[0] = "mavi";
            //colors[1] = "pembe";
            //colors[2] = "sarı";
            //colors[3] = "mor";
            //Console.WriteLine(colors[0]);

            //string[] city = new string[4];
            //city[0] = "milano";
            //city[1] = "roma";
            //city[2] = "paris";
            //city[3] = "kahire";
            //Console.WriteLine(city[5]);

            //int[] numbers = new int[10];
            //numbers[0] = 456;
            //numbers[4] = 12;
            //numbers[7] = 56;
            //Console.WriteLine(numbers[5]);
            // dizinin boyutunda bu değer mevcut fakat değer ataması yapılmadığı için sıfır değeri ekrana basılır


            //string[] city = { "roma", "atina", "ankara", "bursa" };
            //Console.WriteLine(city[2]);

            //string[] colors = { "sarı", "kırmızı", "mavi", "mor", "turuncu", "yeşil", "pembe" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);


            //}

            //int[] numbers = { 1, 78, 75, 96, 456, 2675, 9634 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}


            //char[] symbols = { 'a', 'b', 'c', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //  Console.WriteLine(symbols[i]);

            //}

            //int[] myarray = { 47, 85, 956, 203, 456, 95, 100, 86 };

            //int maxnumber=myarray[0];
            //for (int i = 0; i < myarray.Length; i++)
            //{
            //    if (myarray[i] > maxnumber)
            //    {
            //        maxnumber = myarray[i];
            //    }

            //}
            //    Console.WriteLine(maxnumber);


            //string[] persons = { "ali", "ayşe", "buse", "can" };
            //Console.WriteLine(persons.Length);


            //int[] numbers = { 45, 85, 41, 86, 22, 35 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);



            //}




            //int[] numbers = { 45, 85, 41, 86, 22, 35 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);



            //}





            #endregion

            #region dizi metodları
            //string[] customer = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customer, "çınar";
            //Console.WriteLine(index);

            //int[] number = { 45, 89, 63, 52, 73 };
            //Console.WriteLine("dizinin en büyük elemanı:"+number.Max()+"en küçük eleman:"+number.Min();

            #endregion

            #region kullanıcıdan değer alma
            //string[] city = new string[5];
            //for(int i=0;i<city.Length; i++)
            //{
            //    Console.WriteLine($"lütfen{i+1}.şehri giriniz: ");
            //    city[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("----------------");
            //for (int i = 0; i < city.Length; i++)
            //{
            //    Console.WriteLine(city[i]);
            //}

            //int[] number = { 1, 2, 10, 85, 79 };
            //int sum = 0;
            //for (int i = 0; i < number.Length; i++)
            //{
            //    sum += number[i];
            //}
            //Console.WriteLine(sum);

            //int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            //Console.WriteLine("çift sayılar:");
            //for (int i = 0; i < number.Length; i++)
            //{

            //    if (number[i] % 2 == 0)
            //    {
            //        Console.WriteLine(number[i]);
            //    }

            //}
            //----------------------------------------
            //int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            //Console.WriteLine("tek sayılar:");
            //for (int i = 0; i < number.Length; i++)
            //{

            //    if (number[i] % 2 == 1)
            //    {
            //        Console.WriteLine(number[i]);
            //    }

            //}
            #endregion

            Console.Read();
            }
        }
    
}
