using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akaryakit_Projesi
{
    class Program
    {
        static void Main(string[] args)
        {
            double dizel = 6.12, benzin = 6.55, lpg = 3.33;
            double dizeltank = 1000, benzintank = 1000, lpgtank = 1000;
            double satismiktari;
            char anamenusecim = '0', altmenusecim = '0', akaryakitfiyatguncelle = '0', akaryakitsatistipi = '0';
        MENU:
            Console.WriteLine("Akaryakit Satis Takip");
            Console.WriteLine(".....................");
            Console.WriteLine("1- Birim Fiyat Goster");
            Console.WriteLine("2- Birim Fiyat Guncelle");
            Console.WriteLine("3- Akaryakit Satisi Yap");
            Console.WriteLine("4- Depo Durumunu Goster");
            Console.WriteLine("5- Toplam Satislari Goster");
            Console.WriteLine("6- Cikis");

            Console.WriteLine("Seciminizi Yapiniz[1,2,3,4,5,6]: ");
            anamenusecim = Convert.ToChar(Console.ReadLine());
            if (anamenusecim == '1')
            {
                Console.Clear();
                Console.WriteLine(">>>Seciminiz: 1");
                Console.WriteLine("---Birim Fiyatlar Listesi---");
                Console.WriteLine("Dizel (D) TL/Litre : {0}", dizel);
                Console.WriteLine("Benzin (B) TL/Litre : {0}", benzin);
                Console.WriteLine("LPG (L) TL/Litre : {0}", lpg);

            ALTMENU:
                Console.WriteLine("Seciminizi Yapiniz [1: Ana Menuye Don, 2: Programi Kapat]");
                altmenusecim = Convert.ToChar(Console.ReadLine());
                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;

                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("1 ve 2 Secenekleri Disinda Yanlis Bir Secim Yaptiniz");
                    goto ALTMENU;

                }


            }
            else if (anamenusecim == '2')
            {
                Console.Clear();
                Console.WriteLine(">>>Seciminiz: 2");
                Console.WriteLine("---Birim Fiyat Guncelleme---");
            AKARYAKITTIPI:
                Console.WriteLine("Akaryakit Tipini Seciniz{D, B, L]:");
                akaryakitfiyatguncelle = Convert.ToChar(Console.ReadLine());
                if (akaryakitfiyatguncelle == 'D' || akaryakitfiyatguncelle == 'd')
                {
                    Console.WriteLine("Dizel (D) : {0} TL/Litre", dizel);
                    Console.WriteLine("Dizel Yakit Icin Yani Fiyat Giriniz");
                    dizel = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Degisiklik Yapilmistir");
                    Console.WriteLine("Dizel (D) : {0} TL/ Litre", dizel);

                }
                else if (akaryakitfiyatguncelle == 'B' || akaryakitfiyatguncelle == 'b')
                {
                    Console.WriteLine("Benzin (B) : {0} TL/Litre", benzin);
                    Console.WriteLine("Benzin Yakit Icin Yani Fiyat Giriniz");
                    benzin = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Degisiklik Yapilmistir");
                    Console.WriteLine("Benzin (B) : {0} TL/ Litre", benzin);

                }
                else if (akaryakitfiyatguncelle == 'L' || akaryakitfiyatguncelle == 'l')
                {
                    Console.WriteLine("LPG (L) : {0} TL/Litre", lpg);
                    Console.WriteLine("LPG Yakit Icin Yani Fiyat Giriniz");
                    lpg = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Degisiklik Yapilmistir");
                    Console.WriteLine("LPG (L) : {0} TL/ Litre", lpg);

                }
                else
                {
                    Console.WriteLine("D, B ,L Disinda Yanlis Bir Secim Yaptiniz.");
                    goto AKARYAKITTIPI;

                }
            ALTMENU:
                Console.WriteLine("Seciminizi Yapiniz [1: Ana Menuye Don, 2: Programi Kapat]");
                altmenusecim = Convert.ToChar(Console.ReadLine());
                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;

                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("1 ve 2 Secenekleri Disinda Yanlis Bir Secim Yaptiniz");
                    goto ALTMENU;

                }
            }
            else if (anamenusecim == '3')
            {
                Console.Clear();
                Console.WriteLine(">>>Secimini : 3");
                Console.WriteLine("---Akaryakit Satis Islemleri---");
            AKARYAKITSATIS:
                Console.WriteLine("Akaryakit Tipini Seciniz [D,B,L]");
                akaryakitsatistipi = Convert.ToChar(Console.ReadLine());
                if (akaryakitsatistipi == 'D' || akaryakitsatistipi == 'd')
                {
                    if (dizeltank == 0)
                    {
                        Console.WriteLine("Yakit tankinda dizel yakit kalmamistir");
                        goto MENU;

                    }
                    else
                    {
                        Console.WriteLine("Ne kadarli bir yakit alacaksiniz:");
                        satismiktari = Convert.ToDouble(Console.ReadLine());
                        if (dizeltank < satismiktari)
                        {
                            Console.WriteLine("Yakit tankinda {0} litre yakit vardir. Islem yapilamadi", dizeltank);
                            goto MENU;

                        }
                        else if (satismiktari <= dizeltank)
                        {
                            dizeltank = dizeltank - satismiktari;
                            Console.WriteLine("Yakit Dolumu Yapilmistir.");
                            Console.WriteLine("Dizel Tankinda {0} litre yakit kalmistir", dizeltank);

                        }
                    }

                }
                else if (akaryakitsatistipi == 'B' || akaryakitsatistipi == 'b')
                {
                    if (benzintank == 0)
                    {
                        Console.WriteLine("Yakit tankinda benzin yakit kalmamistir");
                        goto MENU;

                    }
                    else
                    {
                        Console.WriteLine("Ne kadarlik bir yakit alacaksiniz:");
                        satismiktari = Convert.ToDouble(Console.ReadLine());
                        if (benzintank < satismiktari)
                        {
                            Console.WriteLine("Yakit tankinda {0} litre yakit vardir. Islem yapilamadi", benzintank);
                            goto MENU;

                        }
                        else if (satismiktari <= benzintank)
                        {
                            benzintank = benzintank - satismiktari;
                            Console.WriteLine("Yakit Dolumu Yapilmistir.");
                            Console.WriteLine("Dizel Tankinda {0} litre yakit kalmistir", benzintank);

                        }
                    }

                }
                else if (akaryakitsatistipi == 'L' || akaryakitsatistipi == 'l')
                {
                    if (lpgtank == 0)
                    {
                        Console.WriteLine("Yakit tankinda LPG kalmamistir");
                        goto MENU;

                    }
                    else
                    {
                        Console.WriteLine("Ne kadarlik bir yakit alacaksiniz:");
                        satismiktari = Convert.ToDouble(Console.ReadLine());
                        if (lpgtank < satismiktari)
                        {
                            Console.WriteLine("Yakit tankinda {0} litre yakit vardir. Islem yapilamadi", lpgtank);
                            goto MENU;

                        }
                        else if (satismiktari <= lpgtank)
                        {
                            lpgtank = lpgtank - satismiktari;
                            Console.WriteLine("Yakit Dolumu Yapilmistir.");
                            Console.WriteLine("Dizel Tankinda {0} litre yakit kalmistir", lpgtank);

                        }
                    }

                }
                else
                {
                    Console.WriteLine("Hatali Bir Secim Yaptiniz");
                    goto AKARYAKITSATIS;

                }
            ALTMENU:
                Console.WriteLine("Seciminizi Yapiniz [1: Ana Menuye Don, 2: Programi Kapat]");
                altmenusecim = Convert.ToChar(Console.ReadLine());
                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;

                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("1 ve 2 Secenekleri Disinda Yanlis Bir Secim Yaptiniz");
                    goto ALTMENU;

                }
            }

            else if (anamenusecim == '4')
            {
                Console.Clear();
                Console.WriteLine(">>>Seciminiz : 4");
                Console.WriteLine("---Depo Durumu---");
                Console.WriteLine("Dizel Yakit Tanki %{0] Doludur ", (dizeltank / 10));
                Console.WriteLine("Benzin Yakit Tanki %{0] Doludur ", (benzintank / 10));
                Console.WriteLine("LPG Yakit Tanki %{0] Doludur ", (lpgtank / 10));

            ALTMENU:
                Console.WriteLine("Seciminizi Yapiniz [1: Ana Menuye Don, 2: Programi Kapat]");
                altmenusecim = Convert.ToChar(Console.ReadLine());
                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;

                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("1 ve 2 Secenekleri Disinda Yanlis Bir Secim Yaptiniz");
                    goto ALTMENU;

                }
            }
            else if (anamenusecim == '5')
            {
                Console.Clear();
                Console.WriteLine(">>>Seciminiz : 5");
                Console.WriteLine("---Toplam Satis Durumu---");
                Console.WriteLine("Satilan Toplam Dizel Yakit: {0} ", 1000 - dizeltank);
                Console.WriteLine("Dizel Yakit Tutari: {0}", ((1000 - dizeltank) * dizel));
                double dizelyakittutar = ((1000 - dizeltank) * dizel);
                Console.WriteLine("Satilan Toplam Benzin Yakit: {0} ", 1000 - benzintank);
                Console.WriteLine("Benzin Yakit Tutari; {0}", ((1000 - benzintank) * benzintank));
                double benzinyakittutar = ((1000 - benzintank) * benzintank);
                Console.WriteLine("Satilan Toplam LPG Yakit: {0} ", 1000 - lpgtank);
                Console.WriteLine("LPG Yakit Tutari: {0}", ((1000 - lpgtank) * lpgtank));
                double lpgyakittutar = ((1000 - lpgtank) * lpgtank);
                Console.WriteLine("______________________________________________");
                Console.WriteLine("Toplam Tutar : {0}", dizelyakittutar + benzinyakittutar + lpgyakittutar);

            ALTMENU:
                Console.WriteLine("Seciminizi Yapiniz [1: Ana Menuye Don, 2: Programi Kapat]");
                altmenusecim = Convert.ToChar(Console.ReadLine());
                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;

                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("1 ve 2 Secenekleri Disinda Yanlis Bir Secim Yaptiniz");
                    goto ALTMENU;
                }
            }
            else if (anamenusecim=='6')
            {
                Environment.Exit(0);

            }
        }
    }
}
