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
            #region YazdırmaKomutları

            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam!");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion

            #region StringDegiskenler
            //string name;
            //name = "Rumeysa";
            //Console.Write(name);

            //string customerName;
            //string customerSurnmae;
            //string customerPhone;
            //string customerMail, district, city;


            //customerName = "Rumeysa";
            //customerSurnmae = "Coşkun";
            //customerPhone = "+90 546 786 34 20";
            //customerMail = "deneme@gmail.com";
            //district = "Sultanbeyli";
            //city = "Ankara";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("Müşteri : " + customerName +  " "+customerSurnmae);
            //Console.WriteLine("İletişim :" + customerPhone);
            //Console.WriteLine("Email :" + customerMail);
            //Console.WriteLine("Adres :" + district + "/" + city);
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------");

            //Console.WriteLine();

            //customerName = "Büşra";
            //customerSurnmae = "Türk";
            //customerPhone = "+90 567 980 34 12";
            //customerMail = "test@gmail.com";
            //district = "Gölbaşı";
            //city = "Ankara";

            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("Müşteri : " + customerName +" "+ customerSurnmae);
            //Console.WriteLine("İletişim :" + customerPhone);
            //Console.WriteLine("Email :" + customerMail);
            //Console.WriteLine("Adres :" + district + "/" + city);
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------");


            #endregion

            #region IntDegiskenler

            //int number = 26;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int juicePrice = 40;
            int waterPrice = 10;
            int pizaPrice = 150;
            int friesPrice = 200;
            int lemonadePrice = 50;

            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("----Hamburger :" + hamburgerPrice + " TL");
            Console.WriteLine("----Meyve Suyu :" + juicePrice+ " TL");
            Console.WriteLine("----Pizza  :" + pizaPrice+ " TL");
            Console.WriteLine("----Kızartma  :" + friesPrice + " TL");
            Console.WriteLine("----Limonata :" + lemonadePrice + " TL");
            Console.WriteLine();
            Console.WriteLine("***** Restoran Menü Fiyatı *****");

            Console.WriteLine();

            int hamburgerCount=3;
            int juiceCount=3;
            int pizaCount=0;
            int friesCount=1;
            int lemonadeCount=3;

            int totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            int totalJuicePrice = juicePrice * juiceCount;
            int totalPizaPrice = pizaPrice * pizaCount;
            int totalFriesPrice=friesPrice * friesCount;
            int totalLemonadePrice= lemonadePrice * lemonadeCount;

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Hamburger Tutarı :" + totalHamburgerPrice + " TL");
            Console.WriteLine("Meyve Suyu Tutarı :" + totalJuicePrice + " TL");
            Console.WriteLine("Piza Tutarı :" + totalPizaPrice + " TL");
            Console.WriteLine("Kızartma Tutarı :" + totalFriesPrice + " TL");
            Console.WriteLine("Limonata Tutarı :" + totalLemonadePrice + " TL ");

            int totalPrice=totalHamburgerPrice+totalJuicePrice+totalPizaPrice+totalFriesPrice+totalLemonadePrice;

            Console.WriteLine("Toplam Hesap Tutarı : " + totalPrice + " TL");
            #endregion

            Console.Read();
        }
    }
}
