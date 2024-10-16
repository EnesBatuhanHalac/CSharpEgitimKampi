using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //int i;
            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for(int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for(int i =3;i<=50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Lütfen istediğiniz adedi Giriniz.");

            //int fnishValue=int.Parse(Console.ReadLine());
            //for(int i =1;i<=fnishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}
            #endregion

            #region For Döngüsü ile karar yapıları  
            //for(int i = 1; i <= 100; i++)
            //{
            //    if(i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int total = 0;
            //for(int i = 0; i <= 10; i++)
            //{
            //    total +=i;
            //    Console.WriteLine(total);
            //}

            //int total = 0;
            //for(int i = 2; i <20; i++)
            //{

            //    if (i % 2 == 0)
            //    {
            //        total += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("------------------------total-------------------");
            //Console.WriteLine(total);

            //int count = 0;
            //for(int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine(count);
            //int bakterium = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bakterium *= 2;
            //    Console.WriteLine(bakterium);
            //}
            #endregion
            #region While
            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}


            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i%3==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    Console.WriteLine(+sum);
            //    i++;
            //}
            //Console.WriteLine("toplam: " + sum);

            #endregion

            #region Örnek Sınav Sorusu
            //klavyeden girilen 3 basamaklı sayının basamakları toplamını Hesaplayınız...
            Console.WriteLine("Sayıyı Giriniz");
            int number=int.Parse(Console.ReadLine());
            int ones, tens, hundred;
            ones = number % 10;
            tens = (number % 100) / 10;
            hundred = number / 100;
            int total = ones + tens + hundred;
            Console.WriteLine("Sayların Toplamı : " + total);

            #endregion
            Console.Read();
        }
    }
}
