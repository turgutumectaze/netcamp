using System;

namespace HesapMakinasi
{
    class MainClass
    {
        public static int sonuc = 0;
        public static void Main(string[] args)
        {
            Console.WriteLine("Hesap Makinasına Hoşgeldiniz : ");
            IslemSec(true);



            Console.ReadLine();
        }

        public static void IslemSec(bool isFirst=false)
        {
            bool devamEdiyorMu = true;
            int sayi1=0;
            int sayi2=0;
            if (isFirst)
            {
                Console.WriteLine("1. Sayıyı giriniz : ");
                 sayi1 =Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2. Sayıyı giriniz : ");
                 sayi2 = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                sayi1 = sonuc;
                Console.WriteLine("Devam etmek için sayı giriniz veya çıkış için herhangi bir tuşa basınız");
                try
                {
                    sayi2 = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    devamEdiyorMu = false;
                }
                
            }
            if (devamEdiyorMu)
            {
                Console.WriteLine("İşlem seçiniz");
                Console.WriteLine("1 Toplama");
                Console.WriteLine("2 Çarpma");
                Console.WriteLine("3 Bölme");
                Console.WriteLine("4 Çıkarma");

                var islem = Convert.ToInt32(Console.ReadLine());

                IslemYap(sayi1, sayi2, islem);
            }
           
        }

        /// <summary>
        /// Toplama 1, Çarpma 2, Bölme 3, Çıkarma 4
        /// </summary>
        /// <param name="sayi1"></param>
        /// <param name="sayi2"></param>
        public static void IslemYap(int sayi1, int sayi2, int islem)
        { 
                switch (islem)
                {
                    case 1:
                        {
                            VeriYaz((sayi1 + sayi2));
                        }
                        break;
                    case 2:
                        {
                            VeriYaz((sayi1 * sayi2));
                        }
                        break;
                    case 3:
                        {
                            VeriYaz((sayi1 / sayi2));
                        }
                        break;
                    case 4:
                        {
                            VeriYaz((sayi1 - sayi2));
                        }
                        break;
                    default:
                        break;
                }

            IslemSec();
        }

        private static void VeriYaz(int veri)
        {
            sonuc = veri;
            Console.WriteLine("Sonuç : "+veri);
            Console.WriteLine("*****************************************");
        }
    }
}
