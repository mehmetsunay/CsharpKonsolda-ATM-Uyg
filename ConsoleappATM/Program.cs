using System;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleappATM
{
    class Program
    {
        static void Main(string[] args)
        {
            int hesap = 2500;
            Console.WriteLine("\n");
            Console.WriteLine("Bakiyeniz = " + hesap);
            Console.WriteLine("\n");
            Console.WriteLine("HİZMETLERİMİZ");
            Console.WriteLine("\n");
            Console.WriteLine(" 1. Para Çekme");
            Console.WriteLine(" 2. Para Yatırma");
            Console.WriteLine(" 3. Bakiye Durumu");
            Console.WriteLine(" 4. Kart İade");
            menu:
            Console.Write("\nİsleminizi Belirtiniz: ");
            int secim = Convert.ToInt32(Console.ReadLine());
            
            switch (secim)
            {
                case 1:
                    Console.WriteLine("Hesap Bakiyeniz = " + hesap);
                    Console.Write("Çekmek istediğiniz tutarı belirtiniz: ");
                    int miktar = Convert.ToInt32(Console.ReadLine());
                    if (miktar > hesap)
                    {
                        Console.Write("Bakiyeniz Yetersiz Başka Bir Tutar Giriniz: ");
                        miktar = Convert.ToInt32(Console.ReadLine());
                    }
                    hesap -= miktar;
                    Console.WriteLine("İşlem Sonrası Bakiyeniz = " + hesap);
                    break;
                case 2:
                    Console.WriteLine("Hesap Bakiyeniz = " + hesap);
                    Console.Write("Kaç Para Yatırmak İstiyorsunuz ?: ");
                    miktar = Convert.ToInt32(Console.ReadLine());
                    hesap += miktar;
                    Console.WriteLine("İşem Sonrası Bakiyeniz = " + hesap);
                    break;
                case 3:
                    Console.WriteLine("Hesap Bakiyeniz = " + hesap);
                    break;
                case 4:
                    Console.WriteLine("Teşekkür Ederiz Lütfen Kartınızı Almayı Unutmayınız");
                    Environment.Exit(0);
                    break;
                   

                default:
                    Console.WriteLine("Yanlış Seçim Yaptınız Lütfen Tekrar Deneyiniz.");
                   
                    break;
            }
            Console.ReadLine();
            Thread.Sleep(500);
            Console.WriteLine("Ana Menüye Geçiliyor Lütfen Bekleyiniz");
            Thread.Sleep(500);
            goto menu;






        }
    }
}
