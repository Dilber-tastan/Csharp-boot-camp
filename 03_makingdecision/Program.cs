using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_makingdecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if else
            //Console.WriteLine(" lütfen şifre giriniz");
            //string password;
            //password= Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("şifre yanlış");
            //}
            //Console.Read();
            //---------------------------------------------

            //string capital, country;
            //Console.WriteLine("başkenti giriniz");
            //capital= Console.ReadLine();
            //Console.WriteLine("ülkeyi giriniz");
            //country= Console.ReadLine();
            //if (capital ==  "ankara"& country == "türkiye")
            //{
            //    Console.WriteLine("veeriler doğrulandı");

            //}
            //else
            //{
            //    Console.WriteLine("veriler yanlış");
            //}

            //int number;
            //Console.Write("sayıyı giriniz");
            //number=int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("sayı doğru");
            //} else {
            //    Console.WriteLine("sayı hatalı");
            //-------------------------------------------------

            //int exam1, exam2, exam3, average;
            //string result="hata";
            //Console.WriteLine("sınav1:");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("sınav2:");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("sınav3:");
            //exam3 = int.Parse(Console.ReadLine());
            //average = exam1 + exam2 + exam3;
            //Console.WriteLine("sınavların ortalaması:" + average);
            //if (average > 0 & average <= 50)
            //{

            //    result = "sonuç fasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "sonuç orta";

            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "sonuç harika";

            //}
            //if (average > 84)
            //{
            //    result = "mükemmel";
            //}
            //Console.WriteLine(result);


            // sıfırdan küçük olma durumu var bundan dolayı resulta ilk değer ataması yap
            //sıfırdan küçük bir değer verirsen iflerin içine girmez ve direkt result değerini ekrana basar

            //string city;
            //Console.WriteLine("lütfen şehir girşi yapınız");
            //city =Console.ReadLine();
            //if (city == "adana" | city == "bursa" | city == "istanbul" | city == "trabzon")
            //{
            //    Console.WriteLine("şehir mevcuttur.");

            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değildir.");
            //}
            //------------------------------------------------------

            //Console.WriteLine("lütfen kullanıcı adı giriniz");
            // string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("bu kullanıcı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("kullanıcı kabul edilir");
            //}
            #endregion

            #region mod işlemleri

            // % kalan verir
            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.WriteLine(" lütfen 1.sayıyı giriniz.");
            //int number1=int.Parse(Console.ReadLine());
            //Console.WriteLine(" lütfen 2.sayıyı giriniz.");
            //int number2 = int.Parse(Console.ReadLine());

            //int result=number1%number2;
            //Console.WriteLine(" 1.sayının 2.sayoya bölümünden kalan :"+result);
            //--------------------------------------------------

            //Console.WriteLine("lütfen sayıyı giriniz");
            //int number1 = int.Parse(Console.ReadLine());
            //if (number1 % 2 == 0)
            //{
            //    Console.WriteLine(" bu sayı çifttir.");
            //}
            //else
            //{
            //    Console.WriteLine("bu sayı tektir"); 
            //}
            //************************************************************
            //char team;
            //Console.WriteLine("lütfen takım sembolünü girniz");
            //team=char.Parse(Console.ReadLine());
            //if (team == 'g' | team == 'G') {
            //    Console.WriteLine("Galatasaray");

            //}
            //if(team =='f'|team=='F')
            //{
            //    Console.WriteLine("fenerbahçe");
            //}if(team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("beşiktaş");

            //}
            //-------------------------------------------------


            #endregion

            #region switch case
            //Console.WriteLine("lütfen ay girişi yapınız:");
            //int monthnumber=int .Parse(Console.ReadLine());

            //switch (monthnumber)
            //{
            //    case 1:Console.WriteLine("January");break;
            //    case 2: Console.WriteLine("february"); break;
            //    case 3: Console.WriteLine("march"); break;
            //    case 4: Console.WriteLine("april"); break;
            //    case 5: Console.WriteLine("may"); break;
            //    case 6: Console.WriteLine("june"); break;
            //    case 7: Console.WriteLine("july"); break;
            //    case 8: Console.WriteLine("augst"); break;
            //    case 9: Console.WriteLine("september"); break;
            //    case 10: Console.WriteLine("okctober"); break;
            //    case 11: Console.WriteLine("november"); break;
            //    case 12: Console.WriteLine("december"); break;

            //}







            #endregion

            #region switch case hesap makinesi
            int number1, number2, result;
            char symbol;
            Console.WriteLine("1.sayıyı giriniz:");
            number1=int.Parse(Console.ReadLine());
            Console.WriteLine("2.sayıyı girimiz:");
            number2=int.Parse(Console.ReadLine());
            Console.WriteLine("lütfen yapmak istediğiniz işlemi seçiniz:");
            symbol=char.Parse(Console.ReadLine());
            switch (symbol)
            {
                case '+':
                    
                    result=number1 + number2; break;
                    Console.WriteLine("toplam:"+result);
                case '-':
                    result=number1 - number2; break;
                    Console.WriteLine("çıkarma:"+result);
                case '*':
                    result=number1 * number2; break;
                    Console.WriteLine("çarpma:" + result);
                case '/':
                    result=number1 / number2; break;
                    Console.WriteLine("bölme:"+result);

            }







            #endregion


            Console.Read();

            


        }
    }
}
