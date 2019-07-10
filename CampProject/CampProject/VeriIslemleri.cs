using System;
namespace CampProject
{
    public class VeriIslemleri
    {
        private void VeriYaz(string veri)
        {
            Console.WriteLine(veri);
        }

        /// <summary>
        /// Toplama işlemi 1, Çarpma 2, Bölme 3, Çıkarma 4
        /// </summary>
        /// <param name="sayi1"></param>
        /// <param name="sayi2"></param>
        public bool IslemYap(int sayi1,int sayi2,int islem)
        {
            try
            {
                switch (islem)
                {
                    case 1:
                        {
                            VeriYaz("Toplama İşlemi : " + (sayi1 + sayi2).ToString());
                        }
                        break;
                    case 2:
                        {
                            VeriYaz("Çarpma İşlemi : " + (sayi1 * sayi2).ToString());
                        }
                        break;
                    case 3:
                        {
                            VeriYaz("Bölme İşlemi : " + (sayi1 / sayi2).ToString());
                        }
                        break;
                    case 4:
                        {
                            VeriYaz("Çıkarma İşlemi : " + (sayi1 - sayi2).ToString());
                        }
                        break;
                    default:
                        break;
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
