using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banka
{
    internal class Program
    {

         //  *   2500 tl parası olacak
         //Bir bankamatik düşünülerek tasarlanacak bir program için
         //Kartlı işlem    1
         //Kartsız işlem   2
         ////********Kartlı işlem bölümü
         //Şifre istenecek => Şifre:ab18
         //==> şifrenin 3 defa yanlış olması halinde sistemden atılacak, değilse Ana Menü
         ////*******************Ana Menü 
         //Para Çekmek için    1
         //Para yatırmak için  2
         //Para Transferleri   3
         //Eğitim Ödemeleri    4
         //Ödemeler            5
         //Bilgi Güncelleme    6
         ////*********************Seçim 1************
         //Bakiye yeterli ise para çekilecek,değilse yetersiz bakiye
         //Ana meüye dönmek için   9
         //Çıkmak için             0
         ////******************Seçim 2***********************
         //Kredi Kartına   1
         //Kendi Hesabınıza yatırmak için  2
         //Ana Menü        9
         //Çıkmak için     0
         ////------------------------------------
         ////----1
         //Kredi kardı için en az 12 haneli kart numarasını girsin
         //bakiye yeterli ise hesaptan kredi kartına para yatırılaca
         //Ana Menü        9
         //Çıkmak için     0
         ////--------------------------
         ////---2
         //hesaba yatırılacak para değeri istenir veişlem gerçekleştirilir
         //Ana Menü        9
         //Çıkmak için     0
         ////*****************************Seçim 3
         //Başka Hesaba EFT    1
         //Başka Hesaba Havale 2
         ////---------------------------------
         ////--1
         //EFT numarası istenecek ve başında tr olmalı ve sonrasında 12 haneli sayı işlemleri doğru ise
         //yatılacak para istenir, hesap uygun ise işlem gerçekleşir değilse
         //Ana Menü        9
         //Çıkmak için     0
         ////-----------------------------
         ////---2
         //hesap için 11 haneli hesap numarası işlemler doğru ise
         //gönderilecek para miktarı, hesap uygun ise transfer olacak ,değilse
         //Ana Menü        9
         //Çıkmak için     0
         ////****************Seçim 4
         //Eğitim Ödemeleri sayfası arızalı
         //Ana Menü        9
         //Çıkmak için     0
         ////****************************Seçim 5
         //Elektrik Faturası       1
         //Telefon Faturası        2
         //İnternet faturası       3
         //Su Faturası             4
         //OGS Ödemeleri           5
         ////-----------------------------------------
         ////---1 => bütün faturala için aşağıdaki şart yeterli
         //fatura tutarı istenir, hesap uygun ise yatırılır değilse
         //Ana Menü        9
         //Çıkmak için     0
         ////-----------------------------------
         ////***************Seçim 6
         //Şifre değiştirmek için 1
         //Şifre değiştirme işlemi gerçekleştirilir
         //Ana Menü        9
         //Çıkmak için     0   
         //*/
        static void Main(string[] args)
        {
            int kartlı_islem = 1;
            int kartsız_islem = 2;
            double bakiye = 2500;
            string sifre = "ab18";


        DON:
            Console.WriteLine("Lütfen asagidaki seçeneklerden birini seçiniz:");
            Console.WriteLine("Kartlı işlem için  1");
            Console.WriteLine("Kartsız islem için 2 ");

            int islem = Convert.ToInt32(Console.ReadLine());

            #region KARTLI_İSLEM

            if (kartlı_islem == islem)
            {
                Console.Clear();
                int hak = 0;
                while (hak < 3)
                {
                    Console.WriteLine("Lütfen sifre giriniz:");
                    string girilen = Console.ReadLine();
                    hak++;
                    if (girilen == sifre)
                    {
                        goto DON2;
                    }
                    if (hak == 3)
                    {
                        Console.WriteLine("Hatalı giriş yaptınız.");
                        goto DON;

                    }
                }

            DON2:
                Console.Clear();
                Console.WriteLine("Lütfen aşağıdaki seçeneklerden birini seçiniz:");
                Console.WriteLine("Para çekmek  1");
                Console.WriteLine("Para yatırmak 2");
                Console.WriteLine("Para transferi 3 ");
                Console.WriteLine("Eğitim Ödemeleri 4");
                Console.WriteLine("Ödemeler 5");
                Console.WriteLine("Bilgi Güncelleme 6");
                Console.WriteLine("Kart Menüsü 7");

                int secilen_islem = Convert.ToInt32(Console.ReadLine());

                if (secilen_islem == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Lütfen çekmek istediğiniz miktarı giriniz:");
                    double cekilecek_miktar = Convert.ToDouble(Console.ReadLine());
                    if (cekilecek_miktar <= bakiye)
                    {
                        Console.WriteLine("Paranız hazırlanıyor lütfen bekleyiniz.");
                        bakiye = bakiye - cekilecek_miktar;
                        Console.WriteLine("Kalan bakiyeniz:" + bakiye);
                        Console.WriteLine("Ana Menü 9");
                        Console.WriteLine("Çıkış  0");
                        int gir = Convert.ToInt32(Console.ReadLine());
                            if (gir == 9)
                            {
                                goto DON2;
                            }
                            else if (gir == 0)
                            {
                                Console.WriteLine("Kart iadesi yapılmaktadır lütfen bekleyiniz.");
                                System.Threading.Thread.Sleep(3000);
                                Environment.Exit(0);
                            
                            
                            }
                    }
                    else
                    {
                        Console.WriteLine("Bakiyeniz yetersiz:((");
                        Console.WriteLine("Ana Menü 9");
                        Console.WriteLine("Çıkış  0");
                        int gir = Convert.ToInt32(Console.ReadLine());
                            if (gir == 9)
                            {
                                goto DON2;
                            }
                            else if (gir == 0)
                            {
                                Console.WriteLine("Kart iadesi yapılmaktadır lütfen bekleyiniz.");
                                System.Threading.Thread.Sleep(3000);
                                Environment.Exit(0);
                            }
                    }
                }
                else if (secilen_islem == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Kredi Kartına 1");
                    Console.WriteLine("Kendi Hesabıma 2");
                    Console.WriteLine("Ana Menü 9");
                    Console.WriteLine("Çıkış 0");
                    int gir = Convert.ToInt32(Console.ReadLine());
                    if (gir == 1)
                    {
                    DON3:
                        Console.Clear();
                        Console.WriteLine("Lütfen kart numarası giriniz:");
                        string kartno = Console.ReadLine();
                        if (kartno.Length == 12)
                        {
                            Console.Clear();
                            Console.WriteLine("Yatırılacak para miktarını giriniz:");
                            double yatırılan = Convert.ToDouble(Console.ReadLine());
                            if (yatırılan <= bakiye)
                            {
                                bakiye -= yatırılan;
                                Console.WriteLine("Bakiyeniz:" + bakiye);
                                Console.WriteLine("Ana menü 9");
                                Console.WriteLine("Çıkış 0");
                                int gir2 = Convert.ToInt32(Console.ReadLine());
                                if (gir2 == 9)
                                {
                                    goto DON2;
                                }
                                else if (gir2 == 0)
                                {
                                    Console.WriteLine("Kart iadesi yapılıyor lütfen bekleyiniz.");
                                    System.Threading.Thread.Sleep(3000);
                                    Environment.Exit(0);
                                }


                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Yetersiz bakiye");
                                Console.WriteLine("Ana menü 9");
                                Console.WriteLine("Çıkış 0");
                                int gir2 = Convert.ToInt32(Console.ReadLine());
                                if (gir2 == 9)
                                {
                                    goto DON2;
                                }
                                else if (gir2 == 0)
                                {
                                    Console.WriteLine("Kart iadesi yapılıyor lütfen bekleyiniz.");
                                    System.Threading.Thread.Sleep(3000);
                                    Environment.Exit(0);
                                }



                            }
                        }
                    }



                    else if (gir == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Yatırmak istediğiniz tutarı giriniz:");
                        double yatırılan = Convert.ToDouble(Console.ReadLine());
                        bakiye = bakiye + yatırılan;
                        Console.WriteLine("Bakiyeniz:" + bakiye);
                        Console.WriteLine("Ana menü 9");
                        Console.WriteLine("Çıkış 0");
                        int gir2 = Convert.ToInt32(Console.ReadLine());
                        if (gir2 == 9)
                        {
                            goto DON2;
                        }
                        else if (gir2 == 0)
                        {
                            Console.WriteLine("Kart iadesi yapılıyor lütfen bekleyiniz.");
                            System.Threading.Thread.Sleep(3000);
                            Environment.Exit(0);
                        }


                    }
                    else if (gir == 9)
                    {
                        goto DON2;
                    }
                    else if (gir == 0)
                    {
                        Console.WriteLine("Kart iadesi yapılıyor lütfen bekleyiniz.");
                        System.Threading.Thread.Sleep(3000);
                        Environment.Exit(0);
                    }



                    }
                    else if (secilen_islem == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("Başka Hesaba EFT 1");
                        Console.WriteLine("Başka Hesaba Havale 2");
                        int gir = Convert.ToInt32(Console.ReadLine());
                        if (gir == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Lütfen iban numarası giriniz:");
                            string girilen = Console.ReadLine();
                            if (girilen.Length == 12)
                            {
                                Console.Clear();
                                Console.WriteLine("Göndermek istediğiniz miktarı giriniz:");
                                double miktar = Convert.ToDouble(Console.ReadLine());
                                bakiye -= miktar;
                                Console.WriteLine("Bakiyeniz:" + bakiye);
                                Console.WriteLine("Ana menü 9");
                                Console.WriteLine("Çıkış 0");
                                int gir2 = Convert.ToInt32(Console.ReadLine());
                                    if (gir2 == 9)
                                    {
                                        goto DON2;
                                    }
                                    else if (gir2 == 0)
                                    {
                                        Console.WriteLine("Kart iadesi yapılıyor lütfen bekleyiniz.");
                                        System.Threading.Thread.Sleep(3000);
                                        Environment.Exit(0);
                                    }


                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Geçersiz bir iban girdiniz.");
                                Console.WriteLine("Ana menü 9");
                                Console.WriteLine("Çıkış 0");
                                int gir2 = Convert.ToInt32(Console.ReadLine());
                                    if (gir2 == 9)
                                    {
                                        goto DON2;
                                    }
                                    else if (gir2 == 0)
                                    {
                                        Console.WriteLine("Kart iadesi yapılıyor lütfen bekleyiniz.");
                                        System.Threading.Thread.Sleep(3000);
                                        Environment.Exit(0);
                                    }

                            }

                        }
                        else if (gir == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Lütfen hesap numarası giriniz:");
                            string hesapno = Console.ReadLine();
                            if (hesapno.Length == 11)
                            {
                                Console.Clear();
                                Console.WriteLine("Göndermek istediginiz miktarı giriniz:");
                                double miktar = Convert.ToDouble(Console.ReadLine());
                                bakiye -= miktar;
                                Console.WriteLine("Transfer başarıyla gerçekleştirildi.");
                                Console.WriteLine("Bakiye:" + bakiye);
                                Console.WriteLine("Ana menü 9");
                                Console.WriteLine("Çıkış 0");
                                int gir2 = Convert.ToInt32(Console.ReadLine());
                                    if (gir2 == 9)
                                    {
                                        goto DON2;
                                    }
                                    else if (gir2 == 0)
                                    {
                                        Console.WriteLine("Kart iadesi yapılıyor lütfen bekleyiniz.");
                                        System.Threading.Thread.Sleep(3000);
                                        Environment.Exit(0);
                                    }

                            }

                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Geçersiz bir hesap numarası girdiniz.");
                                Console.WriteLine("Ana menü 9");
                                Console.WriteLine("Çıkış 0");
                                int gir2 = Convert.ToInt32(Console.ReadLine());
                                    if (gir2 == 9)
                                    {
                                        goto DON2;
                                    }
                                    else if (gir2 == 0)
                                    {
                                        Console.WriteLine("Kart iadesi yapılıyor lütfen bekleyiniz.");
                                        System.Threading.Thread.Sleep(3000);
                                        Environment.Exit(0);
                                    }

                            }



                        }


                    }
                    else if (secilen_islem == 4)
                    {
                        Console.Clear();
                        Console.WriteLine("Eğitim ödemeleri hizmeti arızalıdır\nDaha sonra tekrar deneyiniz.");
                        Console.WriteLine("Ana menü 9");
                        Console.WriteLine("Çıkış 0");
                        int gir2 = Convert.ToInt32(Console.ReadLine());
                            if (gir2 == 9)
                            {
                                goto DON2;
                            }
                            else if (gir2 == 0)
                            {
                                Console.WriteLine("Kart iadesi yapılıyor lütfen bekleyiniz.");
                                System.Threading.Thread.Sleep(3000);
                                Environment.Exit(0);
                            }


                    }
                    else if (secilen_islem == 5)
                    {
                        Console.Clear();
                        Console.WriteLine("Elektrik faturası 1");
                        Console.WriteLine("Telefon faturası 2");
                        Console.WriteLine("İnternet faturası 3");
                        Console.WriteLine("Su faturası 4");
                        Console.WriteLine("OGS Ödemeleri 5");

                        int gir = Convert.ToInt32(Console.ReadLine());

                        if (gir == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Fatura tutarını giriniz:");
                            double miktar = Convert.ToDouble(Console.ReadLine());
                            if (miktar <= bakiye)
                            {
                                Console.Clear();
                                Console.WriteLine("Faturanız ödendi.");
                                bakiye -= miktar;
                                Console.WriteLine("Bakiye:" + bakiye);
                                Console.WriteLine("Ana menü 9");
                                Console.WriteLine("Çıkış 0");
                                int gir2 = Convert.ToInt32(Console.ReadLine());
                                    if (gir2 == 9)
                                    {
                                        goto DON2;
                                    }
                                    else if (gir2 == 0)
                                    {
                                        Console.WriteLine("Kart iadesi yapılıyor lütfen bekleyiniz.");
                                        System.Threading.Thread.Sleep(3000);
                                        Environment.Exit(0);
                                    }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Yetersiz bakiye");
                                Console.WriteLine("Ana menü 9");
                                Console.WriteLine("Çıkış 0");
                                int gir2 = Convert.ToInt32(Console.ReadLine());
                                    if (gir2 == 9)
                                    {
                                        goto DON2;
                                    }
                                    else if (gir2 == 0)
                                    {
                                        Console.WriteLine("Kart iadesi yapılıyor lütfen bekleyiniz.");
                                        System.Threading.Thread.Sleep(3000);
                                        Environment.Exit(0);
                                    }
                            }
                        }
                        else if (gir == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Fatura tutarını giriniz:");
                            double miktar = Convert.ToDouble(Console.ReadLine());
                            if (miktar <= bakiye)
                            {
                                Console.Clear();
                                Console.WriteLine("Faturanız ödendi.");
                                bakiye -= miktar;
                                Console.WriteLine("Bakiye:" + bakiye);
                                Console.WriteLine("Ana menü 9");
                                Console.WriteLine("Çıkış 0");
                                int gir2 = Convert.ToInt32(Console.ReadLine());
                                    if (gir2 == 9)
                                    {
                                        goto DON2;
                                    }
                                    else if (gir2 == 0)
                                    {
                                        Console.WriteLine("Kart iadesi yapılıyor lütfen bekleyiniz.");
                                        System.Threading.Thread.Sleep(3000);
                                        Environment.Exit(0);
                                    }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Yetersiz bakiye");
                                Console.WriteLine("Ana menü 9");
                                Console.WriteLine("Çıkış 0");
                                int gir2 = Convert.ToInt32(Console.ReadLine());
                                    if (gir2 == 9)
                                    {
                                        goto DON2;
                                    }
                                    else if (gir2 == 0)
                                    {
                                        Console.WriteLine("Kart iadesi yapılıyor lütfen bekleyiniz.");
                                        System.Threading.Thread.Sleep(3000);
                                        Environment.Exit(0);
                                        
                                    }
                            }
                        }
                        else if (gir == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("Fatura tutarını giriniz:");
                            double miktar = Convert.ToDouble(Console.ReadLine());
                            if (miktar <= bakiye)
                            {
                                Console.WriteLine("Faturanız ödendi.");
                                bakiye -= miktar;
                                Console.WriteLine("Bakiye:" + bakiye);
                                Console.WriteLine("Ana menü 9");
                                Console.WriteLine("Çıkış 0");
                                int gir2 = Convert.ToInt32(Console.ReadLine());
                                    if (gir2 == 9)
                                    {
                                        goto DON2;
                                    }
                                    else if (gir2 == 0)
                                    {
                                        Console.WriteLine("Kart iadesi yapılıyor lütfen bekleyiniz.");
                                        System.Threading.Thread.Sleep(3000);
                                        Environment.Exit(0);
                                    }

                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Yetersiz bakiye");
                                Console.WriteLine("Ana menü 9");
                                Console.WriteLine("Çıkış 0");
                                int gir2 = Convert.ToInt32(Console.ReadLine());
                                    if (gir2 == 9)
                                    {
                                        goto DON2;
                                    }
                                    else if (gir2 == 0)
                                    {
                                        Console.WriteLine("Kart iadesi yapılıyor lütfen bekleyiniz.");
                                        System.Threading.Thread.Sleep(3000);
                                        Environment.Exit(0);
                                    }
                            }
                        }
                        else if (gir == 4)
                        {
                            Console.Clear(); 
                            Console.WriteLine("Fatura tutarını giriniz:");
                            double miktar = Convert.ToDouble(Console.ReadLine());
                            if (miktar <= bakiye)
                            {
                                Console.Clear();
                                Console.WriteLine("Faturanız ödendi.");
                                bakiye -= miktar;
                                Console.WriteLine("Bakiye:" + bakiye);
                                Console.WriteLine("Ana menü 9");
                                Console.WriteLine("Çıkış 0");
                                int gir2 = Convert.ToInt32(Console.ReadLine());
                                    if (gir2 == 9)
                                    {
                                        goto DON2;
                                    }
                                    else if (gir2 == 0)
                                    {
                                        Console.WriteLine("Kart iadesi yapılıyor lütfen bekleyiniz.");
                                        System.Threading.Thread.Sleep(3000);
                                        Environment.Exit(0);
                                        
                                    }

                            }
                            else
                            {
                                Console.Clear(); 
                                Console.WriteLine("Yetersiz bakiye");
                                Console.WriteLine("Ana menü 9");
                                Console.WriteLine("Çıkış 0");
                                int gir2 = Convert.ToInt32(Console.ReadLine());
                                    if (gir2 == 9)
                                    {
                                        goto DON2;
                                    }
                                    else if (gir2 == 0)
                                    {
                                        Console.WriteLine("Kart iadesi yapılıyor lütfen bekleyiniz.");
                                        System.Threading.Thread.Sleep(3000);
                                        Environment.Exit(0);
                                    }
                            }
                        }
                        else if (gir == 5)
                        {
                            Console.Clear();
                            Console.WriteLine("Fatura tutarını giriniz:");
                            double miktar = Convert.ToDouble(Console.ReadLine());
                            if (miktar <= bakiye)
                            {
                                Console.Clear();
                                Console.WriteLine("Faturanız ödendi.");
                                bakiye -= miktar;
                                Console.WriteLine("Bakiye:" + bakiye);
                                Console.WriteLine("Ana menü 9");
                                Console.WriteLine("Çıkış 0");
                                int gir2 = Convert.ToInt32(Console.ReadLine());
                                    if (gir2 == 9)
                                    {
                                        goto DON2;
                                    }
                                    else if (gir2 == 0)
                                    {
                                        Console.WriteLine("Kart iadesi yapılıyor lütfen bekleyiniz.");
                                        System.Threading.Thread.Sleep(3000);
                                        Environment.Exit(0);
                                    }
                            }
                            else
                            {   
                                Console.Clear();
                                Console.WriteLine("Yetersiz bakiye");
                                Console.WriteLine("Ana menü 9");
                                Console.WriteLine("Çıkış 0");
                                int gir2 = Convert.ToInt32(Console.ReadLine());
                                    if (gir2 == 9)
                                    {
                                        goto DON2;
                                    }
                                    else if (gir2 == 0)
                                    {
                                        Console.WriteLine("Kart iadesi yapılıyor lütfen bekleyiniz.");
                                        System.Threading.Thread.Sleep(3000);
                                        Environment.Exit(0);
                                    }
                            }
                        }
                    }
                    else if (secilen_islem == 6)
                    {
                        Console.Clear();
                        Console.WriteLine("Şifre değiştirmek için 1");
                        Console.WriteLine("Ana menü 9");
                        Console.WriteLine("Çıkış 0");
                        int gir = Convert.ToInt32(Console.ReadLine());

                        if (gir == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Yeni sifre giriniz:");
                            sifre = Console.ReadLine();
                            Console.WriteLine("Şifre başarıyla değiştirildi.");
                            Console.WriteLine("Ana menü 9");
                            Console.WriteLine("Çıkış 0");
                            int gir2 = Convert.ToInt32(Console.ReadLine());
                                if (gir2 == 9)
                                {
                                    goto DON2;
                                }
                                else if (gir2 == 0)
                                {
                                    Console.WriteLine("Kart iadesi yapılıyor lütfen bekleyiniz.");
                                    System.Threading.Thread.Sleep(3000);
                                    Environment.Exit(0);
                                }
                        }
                        else if (gir == 9)
                        {
                            goto DON2;
                        }

                        else if (gir == 0)
                        {
                            Console.WriteLine("Kart iadesi yapılıyor lütfen bekleyiniz.");
                            System.Threading.Thread.Sleep(3000);
                            Environment.Exit(0);

                        }


                        
                    }
                    else if (secilen_islem == 7)
                    {
                        Console.Clear();
                        goto DON;
                    }





                
            }

            #endregion

            #region KARTSIZ_İSLEM
            else if (kartsız_islem == islem)
            {
                Console.Clear();
                Console.WriteLine("Kartsız işlem için şuanda hizmet verilmemektedir.");
                goto DON;
            }
            #endregion


            Console.ReadLine();


        }
    }
}
