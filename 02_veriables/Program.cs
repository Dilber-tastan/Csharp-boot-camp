using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_veriables
{
    internal class ProgramS
    {
         static void Main(string[] args) {


            #region double değişkenler
           // Console.WriteLine("***** fiyat listesi ******");

           // double appleprice, orangeprice, tomatoprice, potatoprice, strawberryprice;
           // appleprice = 14.56;
           // orangeprice = 13.12;// virgül kullanamayız nokta kullanıyoruz ve consolede virgül olarak çıkyıyor 
           // tomatoprice = 11;
           // potatoprice = 10.6;
           // strawberryprice = 16.3;

           // Console.WriteLine("----elma birim fiyatı:" + appleprice);
           // Console.WriteLine("----portakal birim fiyatı:" + orangeprice);
           // Console.WriteLine("----çilek  birim fiyatı:" + strawberryprice);
           // Console.WriteLine("----domates birim fiyatı:" + tomatoprice);
           // Console.WriteLine("----patates birim fiyatı:" + potatoprice);
           // Console.WriteLine();



           // double applegram = 1.245;
           //  double   orangegram=0.5;
           // double strawberrygram=4.1;
           //double tomatogram=3.2;
           //double potatogram=2.7;

           // double appletotalprice = appleprice * applegram;
           // double orangetotalprice= orangeprice * orangegram;
           // double strawberrytotalprice= strawberryprice * applegram;
           // double tomatototalprice= tomatoprice * applegram;
           // double potatototalprice= potatoprice * applegram;
           // Console.WriteLine("------------------------");


           // Console.WriteLine("---elmanın toplam fiyatı :" + appletotalprice+"tl");
           // Console.WriteLine("---portakalın toplam fiyatı :" + orangetotalprice + "tl");
           // Console.WriteLine("---çileğin toplam fiyatı :" + strawberrytotalprice + "tl");
           // Console.WriteLine("---domatesin toplam fiyatı :" + tomatototalprice + "tl");
           // Console.WriteLine("---patatesin toplam fiyatı :" + potatototalprice + "tl");


           



            #endregion


            #region char değişkenler
            // karakter tipindeki verileri  tutar
            // charlar ' tırnak ile gösterilir
            // char sembol;
            // sembol = 'a';
            // Console.WriteLine(sembol);


            #endregion

            #region klavyeden veri girişleri string değişkenler 
            //Console.WriteLine("csharp yolcu bilgileri");
            //Console.WriteLine();
            //string passengername, passengersurname, passengercity, passengerage;
            ////ctrl f ile  toplu değiştirmek istediklerini seç
            //Console.Write("müşteri adı :");
            //passengername = Console.ReadLine();//entere basınca girilen değer passengere atanır

            //Console.Write(" müşteri soyadı:");
            //passengersurname= Console.ReadLine();
            //Console.Write(" müşterinin yaşı");
            
          


            //Console.Write(" müşterinin  şehri:");
            //passengercity=Console.ReadLine();
            //Console.WriteLine("--------");

            //Console.WriteLine("yolcu:" + passengername + passengersurname);




            #endregion


            #region tam sayı dönüşümleri
            //ab12d

           // int shoesprice, computerprice, chairprice, tvprice;
           // shoesprice = 2000;
           // computerprice = 25000;
           // chairprice = 5000;
           // tvprice = 45000;
           // int shoescount, computercount, chaircount, tvcount;

           // Console.Write(" lütfen kaç adet ayakkabı aldığınızı  girniz:");
           // shoescount =int.Parse( Console.ReadLine());

           // Console.Write(" lütfen kaç adet bilgisayar aldığınızı  girniz:");
           // computercount = int.Parse(Console.ReadLine());

           // Console.Write(" lütfen kaç adet sandalye aldığınızı  girniz:");
           //chaircount = int.Parse(Console.ReadLine());

           // Console.Write(" lütfen kaç adet televizyon aldığınızı  girniz:");
           //tvcount = int.Parse(Console.ReadLine());

           // int totalprice=shoescount*shoesprice+computercount*computerprice+chaircount*chairprice+tvprice*tvprice;
           // Console.WriteLine();
           // Console.WriteLine("toplam ödemeniz gereken tutar:"+totalprice);





            #endregion

            #region klavyeden ondalıklı sayı girişleri



            //double exam1, exam2, exam3, result;
            //Console.Write(" lütfen 1. sınav notunuzu girniz:");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write(" lütfen 2. sınav notunuzu girniz:");
            //exam2 =double.Parse(Console.ReadLine());

            //Console.Write("lütfen 3.sınav notunuzu girniz:");
            //exam3 =double.Parse(Console.ReadLine());
            //result = (exam1 + exam2 + exam3)/3;
            //Console.WriteLine();
            //Console.WriteLine(" sınav ortalamanız:"+result);





            #endregion


            #region klavyeden karakter girişleri 
            //char gender;
            //Console.WriteLine(" lütfen cinsiyet seçiniz");
            //gender =char.Parse(Console.ReadLine());
            //Console.WriteLine(("seçtiğiniz cinsiyet :" + gender));




            #endregion
            Console.Read();
        }
    }
    }

