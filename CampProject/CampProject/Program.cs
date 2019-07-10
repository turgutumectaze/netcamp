using System;
using System.Collections;

namespace CampProject
{
    static class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            #region Temeller

            //string[] diller2 = new string[7] { "C#", "C", "C++", "Lua", "Java", "Delphi", "Visual Basic" };



            //var diller = new string[7];
            //diller[0] = "C#";
            //diller[1] = "C";
            //diller[3] = "Lua";
            //diller[4] = "Java";
            //diller[6] = "Visual Basic";

            //string[] diller = { "C#", "C", "C++", "Lua", "Java", "Delphi", "Visual Basic" };


            //foreach (var d in diller)
            //{
            //    Console.WriteLine(d);
            //}


            //Console.WriteLine("Dizideki toplam dil sayısı : "+ diller.Length);

            //Console.WriteLine("Dizi ters çevriliyor");

            //Array.Reverse(diller);

            //foreach (var d in diller)
            //{
            //    Console.WriteLine(d);
            //}

            //Console.WriteLine("Dizi sıralanıyor");

            //Array.Sort(diller);

            //foreach (var d in diller)
            //{
            //    Console.WriteLine(d);
            //}

            //Console.WriteLine(" C#'ın dizideki indeksi :"+Array.IndexOf(diller,"C#"));


            //ArrayList dizi = new ArrayList();
            ////ekleme işlemi
            //dizi.Add("Sanal Dosya");
            //dizi.Add(10);
            //dizi.Add(true);
            //dizi.Add(10.11d);
            //dizi.Add(10.121f);
            //dizi.Add('H');

            ////istenen indexe ekleme işlemi
            //dizi.Insert(2, "Sonradan Eklendi");


            //foreach (var item in dizi)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Silme işlemleri başladı");
            ////Silme işlemi
            //dizi.Remove(true);

            ////istenilen indexi silmek için
            //dizi.RemoveAt(4);

            //dizi.RemoveAt(dizi.IndexOf('H'));

            //foreach (var item in dizi)
            //{
            //    Console.WriteLine(item);
            //}



            //foreach (var item in dizi)
            //{
            //    Console.WriteLine(item);
            //}



            //VeriYaz();
            //VeriYaz("Ben Geldim");

            //"Toplama İşlemi Başlıyor"._EkranaYaz();

            //var toplam=Topla(10, 5);

            //Console.WriteLine("Toplam {0}",toplam);
            //Console.WriteLine($"Toplam {toplam}");

            //var adi = "Turgut";
            //adi._EkranaYaz();

            #endregion

            int a;
            bool b;

            VeriIslemleri veri;
            veri = new VeriIslemleri();
            veri.IslemYap(10, 20, 1);
            veri.IslemYap(10, 20, 2);
            veri.IslemYap(20, 10, 3);
            veri.IslemYap(20, 5, 4);
            

            Console.ReadLine();
        }

        public static void VeriYaz()
        {
            Console.WriteLine("Deneme Verisi");
        }

        public static void VeriYaz(string veri1)
        {
            Console.WriteLine(veri1);
        }

        public static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static void _EkranaYaz(this string veri)
        {
             Console.WriteLine(veri);
        }

        //Ekrana İşlem Seçiniz
        //1 Toplama
        //2 Çıkarma
        //3 Çarpma
        //4 Bölme

        //İki Sayı alınsın ekrandan
        //10 + 5 = 20;
        //Mini hesap makinası



    }
}
