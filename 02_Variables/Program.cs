using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doubleDegiskenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);


            //Console.WriteLine("**** Fiyat Listesi ****");
            //Console.WriteLine();
            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("----- Elma Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("----- Portakal Fiyatı: "+ orangePrice + " TL");
            //Console.WriteLine("----- Çilek Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("----- Patates Fiyatı" + potatoPrice + " TL");
            //Console.WriteLine("----- Domates Fiyatı" + tomatoPrice + " TL");

            //double appleGram,orangeGram, strawberryGram,potatoGram,tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Elmanın Birim Fiyatı"+applePrice+" " +"Elmanın Toplam Fiyatı: " + appleTotalPrice);
            //Console.WriteLine("Portakalın Birim Fiyatı"+orangePrice+" "+ "Portakal'ın Toplam Fiyatı: " + orangeTotalPrice);
            //Console.WriteLine("Çilek'in Birim Fiyatı" +strawberryPrice+" " +"Çilek'in Toplam Fiyatı: " + strawberryTotalPrice);
            //Console.WriteLine("Patates'in Birim Fiyatı:" +potatoPrice + " " + "Patates'in Toplam Fiyatı: " + potatoTotalPrice);
            //Console.WriteLine("Domates'in Birim Fiyatı"+tomatoPrice+" " +"Domates'in Toplam Fiyatı: " + tomatoTotalPrice);
            #endregion

            #region charDegişkenler
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);
            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();
            //string passangerName, passangerSurname, passangerAge, passangerDistrict, passangerCity,passangerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passangerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı: ");
            //passangerSurname = Console.ReadLine();
            //Console.Write("Yolcunun Yaşı: ");
            //passangerAge = Console.ReadLine();
            //Console.Write("Yolcunun İkamet İlçesi: ");
            //passangerDistrict = Console.ReadLine();
            //Console.Write("Yolcunun İkamet İli: ");
            //passangerCity = Console.ReadLine();
            //Console.Write("Yolcunun T.C. Kimlik No'su: ");
            //passangerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------------");
            //Console.WriteLine("Yolcu TcNo: " + passangerIdentityNumber +" "+ "Yolcu Adı: " + passangerName
            //    + " "+ passangerSurname +" "+ "Yolcunun Yaşı: " + passangerAge+" "
            // +"Yolcu İlçesi: " + passangerDistrict + "/" + passangerCity    
            //    );







            #endregion


            #region Klavyeden Tam Sayı Girişleri Ve Dönüşümler

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoeCount, computerCount, chairCount, tvCount;
            //Console.WriteLine("Lütfen Aldığınız Ayakkabı Sayısını Giriniz: ");
            //shoeCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen Aldığınız Bilgisayar Sayısını Giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen Aldığınız Sandalye Sayısını Giriniz");
            //chairCount= int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen Aldığınız Tv Sayısını Giriniz");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice=shoeCount*shoePrice+computerCount*computerPrice+chairCount*chairPrice+tvCount*tvPrice;
            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + "" + totalPrice + "Tl");
            #endregion


            #region Klavyeden Ondalıklı Sayı İşlemleri
            //double exam1, exam2, exam3, result;

            //Console.WriteLine("Lütfen 1. Sınav Notunu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen 2. Sınav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen 3. Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //double ortalama;
            //ortalama=(exam1+exam2+exam3)/3;
            //Console.WriteLine();
            //Console.WriteLine("Ortalama Notunuz: " + ortalama);


            #endregion

            #region Klavyeden Karakter Girişleri
            //char gender;
            //Console.WriteLine("Lütfen Cinsiyet Seçiniz: ");
            //gender =char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiginiz Cinsiyet: " + gender);
            #endregion
            Console.Read();
        }
    }
}
