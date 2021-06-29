using System;

namespace Methods
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            string[] malzemeler = new string[] { "baharat", "süt ürünleri", "oyuncaklar", "temizlik malzemeleri" };
            for (int i = 0; i < malzemeler.Length; i++)
            {
                Console.WriteLine("string dizisi:" + malzemeler[i]);
            }

            magaza malzeme = new magaza();
            malzeme.urunadi = "sarelle";
            malzeme.urunfiyati = 80.99;
            malzeme.urunmiktari = 10;
            malzeme.urunsepettemi = true;

            magaza malzeme2 = new magaza();
            malzeme2.urunadi = "çokokrem";
            malzeme2.urunfiyati = 35.99;
            malzeme2.urunmiktari = 17;
            malzeme2.urunsepettemi = false;

            magaza malzeme3 = new magaza();
            malzeme3.urunadi = "nutella";
            malzeme3.urunfiyati = 75.99;
            malzeme3.urunmiktari = 12;
            malzeme3.urunsepettemi = true;

            magaza malzeme4 = new magaza();
            malzeme4.urunadi = "hobby";
            malzeme4.urunfiyati = 10.99;
            malzeme4.urunmiktari = 32;
            malzeme4.urunsepettemi = false;

            Console.WriteLine("--------eskiler ---------");

            //instance örnek klas
            //encapsulation
            SepetManager x = new SepetManager();
            x.Ekle(malzeme);
            x.Ekle(malzeme2);
            x.Ekle(malzeme3);

            //int, decimal, float, double, bool = değerler
            //array, class, interface = referanslar
            Console.WriteLine("--------eskiler ---------");
            magaza[] market = new magaza[] { malzeme, malzeme2, malzeme3, malzeme4 };
            foreach (var magaza in market)
            {
                Console.WriteLine(magaza.urunadi + ":" +
                magaza.urunmiktari + "adedi:" + magaza.urunfiyati + "TL");
                if (magaza.urunsepettemi == true)
                {
                    Console.WriteLine("Ürün Zaten Sepette");
                }
                else
                {
                    Console.WriteLine("Ürün Sepetinizde yok :(");
                }
            }
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 330 };
            sayilar1 = sayilar2;
            sayilar2[1] = 999;
            Console.WriteLine("Sayı değerleri" + sayilar1[2]);
        }


    }
}
