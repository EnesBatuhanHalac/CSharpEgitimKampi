using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDesicion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If

            //Console.WriteLine("Lütfen Şifreyi Giriniz");
            //string password;
            //password = Console.ReadLine();
            //if(password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.WriteLine("Başkenti Giriniz");
            //capital = Console.ReadLine();
            //Console.WriteLine("Ülkeyi Giriniz");
            //country = Console.ReadLine();
            //if(capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Veriler Doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı Bilgi");
            //}


            //int number;
            //Console.WriteLine("Sayıyı Giriniz");
            //number = int.Parse(Console.ReadLine());
            //if(number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Yanlış");
            //}

            //double exam1, exam2, exam3, avarage;
            //string result="Hata";  
            //Console.WriteLine("1. SINAV");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("2. SINAV");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("3. SINAV");
            //exam3 = double.Parse(Console.ReadLine());
            //avarage = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sonuc Ortalama: " + avarage);

            //if (avarage >= 0 & avarage <= 50)
            //{
            //    result = "Sonuc Vasat";
            //    Console.WriteLine(result);
            //}
            //if (avarage > 50 & avarage <= 70)
            //{
            //    result = "Sonuç Orta";
            //    Console.WriteLine(result);
            //}
            //if (avarage > 70 & avarage <= 100)
            //{
            //    result = "Sonuç Çok İyi";
            //    Console.WriteLine(result);
            //}
            //Console.WriteLine(result);

            //Console.WriteLine("Lütfen Şehir Girişi Yapınız");
            //string city = Console.ReadLine();
            //if(city == "adana" | city=="ankara" | city =="bursa"|city == "trabzon")
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değil");
            //}

            //string username;
            //Console.Write("Lütfen Kullanıcı Adınızı Giriniz:");
            //username = Console.ReadLine();
            //if(username != "admin")
            //{
            //    Console.WriteLine("Bu kulalnıcı Kabul Edilemez");

            //}
            //else
            //{
            //    Console.WriteLine("Hoş Geldiniz");
            //}


            #endregion
            #region Mod İşlemleri
            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen Mod alınacak Sayıyı Giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Mod Değerini Giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());
            //int result = number1 % number2;
            //Console.WriteLine("Sonuc: " + result);

            //int number1;

            //Console.WriteLine("Lütfen bir sayı giriniz");
            //number1=int.Parse(Console.ReadLine());

            //if(number1 % 2 == 0)
            //{
            //    Console.WriteLine("Sayı Çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Tektir");
            //}
            #endregion
            #region Char degişkenler ile karar yapilari

            //char team;
            //Console.WriteLine("Lütfen Takım Baş Harfini Giriniz");
            //team = char.Parse(Console.ReadLine());
            //if(team == 'b' | team =='B')
            //{
            //    Console.WriteLine("Takım Beşiktaş");
            //}
            //if(team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Takım Galatasaray");
            //}
            //if(team == 't' | team =='T')
            //{
            //    Console.WriteLine("Takım Trabzonspor");
            //}
            //if(team == 'f' | team =='F')
            //{
            //    Console.WriteLine("Takım Fenerbahçe");
            //}
            #endregion
            #region Örnek Uygulama Restoran
            //Console.WriteLine("**** C# EĞİTİM KAMPI *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatılar");
            //Console.WriteLine();
            //Console.WriteLine("Lütfen Bir Menü Seçiniz: ");
            //int menu = int.Parse(Console.ReadLine());
            //if(menu == 1)
            //{
            //    Console.WriteLine("AnaYemekler Menüsü");
            //    Console.WriteLine("1-Çorba");
            //    Console.WriteLine("2-Et");
            //    Console.WriteLine("3-Pilav");
            //    Console.WriteLine("4-Patates");
            //    Console.WriteLine("5-Soğan");
            //}
            //if (menu == 2)
            //{
            //    Console.WriteLine("Çorbalar Menüsü");
            //    Console.WriteLine("1-Mercimek");
            //    Console.WriteLine("2-Ezogelin");
            //    Console.WriteLine("3-Tavuk Suyu");
            //    Console.WriteLine("4-Patates Çorbası");
            //    Console.WriteLine("5-Sehire Çorbası");
            //}
            //if (menu == 3)
            //{
            //    Console.WriteLine("Pizzalar Menüsü");
            //    Console.WriteLine("1-Etli Pizza");
            //    Console.WriteLine("2-Karısık Pizza");
            //    Console.WriteLine("3-Ton Balıklı Pizza");
            //    Console.WriteLine("4-Sucuklu Pizzza");
            //    Console.WriteLine("5-Pastırmali Pizza");
            //}
            //if (menu == 4)
            //{
            //    Console.WriteLine("İçecek Menüsü");
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Et");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("4-Limonata");
            //    Console.WriteLine("5-Kahve");
            //}
            //if (menu == 5)
            //{
            //    Console.WriteLine("Tatlılar Menüsü");
            //    Console.WriteLine("1-Sütlaç");
            //    Console.WriteLine("2-Profiterol");
            //    Console.WriteLine("3-Pasta");
            //    Console.WriteLine("4-Ekler");
            //    Console.WriteLine("5-Yuvarlak Tatlı");
            //}
            #endregion
            #region Switch-Case

            //Console.WriteLine("Lütfen Ay Girişi Yapınız");
            //int monthNumber = int.Parse(Console.ReadLine());
            //switch (monthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Ay Ocak");
            //        break;
            //    case 2:
            //        Console.WriteLine("Ay Şubat");
            //        break;
            //    case 3:
            //        Console.WriteLine("Ay Mart");
            //        break;
            //    case 4:
            //        Console.WriteLine("Ay Nisan");
            //        break;
            //        case 5:
            //        Console.WriteLine("Ay Mayıs");
            //        break;
            //    case 6:
            //        Console.WriteLine("Ay Haziran");
            //        break;
            //        case 7:
            //        Console.WriteLine("Ay Temmuz");
            //        break;
            //    case 8:
            //        Console.WriteLine("Ay Agustos");
            //        break;
            //    case 9:
            //        Console.WriteLine("Ay Eylül");
            //        break;
            //    case 10:
            //        Console.WriteLine("Ay Ekim");
            //        break;
            //    case 11:
            //        Console.WriteLine("Ay Kasım");
            //        break;
            //    case 12:
            //        Console.WriteLine("Ay Aralık");
            //        break;
            //    default:
            //            Console.WriteLine("Hatalı Veri Giriş");
            //            break;
            //}


            #endregion
            #region Switch Case Hesap Makinesi

            int number1, number2, result;
            char symbol;

            Console.Write("İlk sayıyı giriniz: ");
            number1=int.Parse(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz: ");
            number2=int.Parse(Console.ReadLine());
            Console.Write("Yapmak istediğiniz işlemi giriniz: ");
            symbol = char.Parse(Console.ReadLine());
            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Sonuç: " + result);
                    break;
                    case '-':
                    result = number1 - number2;
                    Console.WriteLine("Sonuç: " + result);
                    break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Sonuc: " + result);
                    break;
                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Sonuç: " + result);
                    break;
                default:
                    Console.WriteLine("Yanlış İşlem");
                    break;
            }
            #endregion
            Console.Read();
        }
    }
}
