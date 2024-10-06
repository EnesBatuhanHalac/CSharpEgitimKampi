using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Yazdırma Komutları
            //Console.Write("Merhaba Dünya");
            //Console.WriteLine("Selam");


            //Console.WriteLine("******* Yemek Kategorileri *************");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Yiyecekler");
            //Console.WriteLine("6-Tatlılar");
            //Console.WriteLine("******** Yemek Kategorileri **********");


            //Değişkenler


            #endregion
            #region StringDeğişkenler


            //string name;
            //name = "Enes";
            //Console.WriteLine(name);
            //string customerName;

            //string customerSurname,customerPhone, customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerEmail = "Deneme@Email.com";
            //district = "Kadıköy";
            //customerPhone = "555 555 55 55";
            //city = "İstanbul";
            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName +" " +  customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email-Adress: " + customerEmail);
            //Console.WriteLine("Adress: " + district + "/" + city);
            //Console.WriteLine("-------------------------------------------------------");

            //Console.WriteLine();

            //customerName = "Ayşegül";
            //customerSurname = "Kaya"; 
            //customerPhone = "555 444 33 33";
            //district = "Sapanca";
            //customerEmail = "Ayşe3425@gmail.com";
            //city = "Sakarya";
            //Console.WriteLine("------------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email-Adress: " +customerEmail);
            //Console.WriteLine("Adress: " + district + "/" + city);
            //Console.WriteLine("-------------------------------------------------------");
            #endregion
            #region Int Değişkenler
            //int

            //int number = 24;
            //Console.WriteLine(number);

           

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 54;
            int pizzaPrice = 254;
            int lemonadePrice = 30;

            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("---- Hamburger Fiyatı:" + hamburgerPrice + " Tl");
            Console.WriteLine("---- Pizza Fiyatı:" + pizzaPrice + " TL");
            Console.WriteLine("---- Kızartma Fiyatı:" + friesPrice + " TL");
            Console.WriteLine("---- Kola Fiyatı:" + cokePrice + " TL");
            Console.WriteLine("---- Limonata Fiyatı:" + lemonadePrice + " TL");
            Console.WriteLine("---- Su Fiyatı:" + waterPrice + " TL");
            Console.WriteLine("***** Restoran Menü Fiyatı *****");

            Console.WriteLine();


            int hamburgerCount,cokeCount,waterCount,friesCount,pizzaCount,lemonadeCount;

            int totalHamburgerPrice; 
            int totalCokePrice; 
            int totalFriesPrice ; 
            int totalWaterPrice ;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount=3;
            waterCount=3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + "Tl");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + "Tl");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + "Tl");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + "Tl");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + "Tl");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + "Tl");

            int totalPrice;
            Console.WriteLine();
            totalPrice=totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalLemonadePrice + totalPizzaPrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + "TL");
            Console.WriteLine("-----------------------------------------------");
            #endregion

            




            Console.Read();
        }
    }
}


