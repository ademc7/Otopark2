using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp41
{
    class Program
    {
        struct otopark
        {
            public string plaka;
            public DateTime giriszamani;
        }
        static void Main(string[] args)
        {
            List<otopark> araclar = new List<otopark>();
            DateTime[] girisayaci = new DateTime[10];
            DateTime zaman = DateTime.Now;
            int aracsayi = 0;

            menu:
            Console.WriteLine("");
            Console.WriteLine("1-Araç Giriş");
            Console.WriteLine("2-Araç Çıkış");
            Console.WriteLine("3-Otopark Araç Plaka Bilgileri");
            string secim = Console.ReadLine();
            Console.Clear();

            if (secim == "1")
            {
                if (aracsayi == 10)
                {
                    Console.WriteLine("Otopark Dolu");
                    Console.WriteLine("");
                    goto menu;
                    Console.ReadLine();
                }
                Console.WriteLine("Araç Plakası");
                otopark arac = new otopark();
                arac.plaka = Console.ReadLine();

                if(araclar.Any(x => x.plaka  == arac.plaka))
                {
                    Console.WriteLine("Bu Araç Plakası Zaten Var!");
                    goto menu;
                }

                arac.giriszamani = DateTime.Now;
                araclar.Add(arac);
                Console.WriteLine("Giriş Yapıldı");
                Console.WriteLine("Giriş Tarihi= " + DateTime.Now.ToString());
                aracsayi++;
                goto menu;
                Console.Clear();
            }
            else if (secim == "2")
            {
                Console.WriteLine("");
                Console.WriteLine("Çıkış Yapacak Araç Plakası Giriniz");
                string cikacak = Console.ReadLine();
                if (araclar.Any(x => x.plaka == cikacak))
                {
                    araclar.RemoveAll(x => x.plaka == cikacak);
                    Console.WriteLine("Çıkış Yapıldı= " + DateTime.Now.ToString());
                    aracsayi--;
                }
                else
                {
                    Console.WriteLine("Araç Bulunamadı!");
                }

            goto menu;
                Console.Clear();
            }
            else if (secim == "3")
            {
                Console.WriteLine("Plakalar");

                if (aracsayi == 0)
                {
                    Console.WriteLine("Otopark Boş");
                }

                foreach (otopark arac in araclar)
                {
                    Console.WriteLine(arac.plaka + " " + arac.giriszamani);
                }
                goto menu;
            }
            else
            {
                Console.WriteLine("Sayınız 1-3 Arasında Olmalıdır!");
            }
            goto menu;
            Console.ReadLine();
        }
    }
}