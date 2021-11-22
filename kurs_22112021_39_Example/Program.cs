using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;
using System.Runtime;

namespace kurs_22112021_39_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList degerlerListesi = new ArrayList();
            Console.WriteLine("Menü");
            Console.WriteLine("1-Değer ekle");
            Console.WriteLine("2-Değer listele");
            Console.WriteLine("3-Değer ara");
            Console.WriteLine("4-Değer düzenle");
            Console.WriteLine("5-Değer sil");
            Console.WriteLine("6-Uygulama çıkış");
            
            do
            {
                int deger = Convert.ToInt32(Console.ReadLine());
                switch (deger)
                {
                    case 1:
                        Console.WriteLine("Eklemek istediğiniz değer");
                        string ekle = Console.ReadLine();
                        degerlerListesi.Add(ekle);
                        Console.WriteLine("Değer eklendi. Eklenen değer: "+ekle);
                        break;
                    case 2:
                        Console.WriteLine("Değerler listeleniyor.");
                        Thread.Sleep(2000);
                        foreach (var item in degerlerListesi)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Aramak istediğiniz değeri giriniz: ");
                        string aramak = Console.ReadLine();
                        if (degerlerListesi.Contains(aramak))
                        {
                            Console.WriteLine("Aranan değer bulundu: " + aramak);
                        }
                        else
                        {
                            Console.WriteLine("Bu değer listeye eklensin mi? e/h");
                            string devam = Console.ReadLine();
                            if (devam=="e")
                            {
                                degerlerListesi.Add(aramak);
                                Console.WriteLine("değer eklendi.");
                            }
                            else
                            {
                                Console.WriteLine("Aranan değer bulunamadı");
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Düzenlemek istediğiniz değeri giriniz");
                        string duzenle = Console.ReadLine();
                        Console.WriteLine("düzenleyeceğiniz değer:");
                        string yeniduzen =Console.ReadLine();

                        if (degerlerListesi.Contains(duzenle))
                        {
                            int indeks = degerlerListesi.IndexOf(duzenle);
                            degerlerListesi[indeks] = yeniduzen;
                            Console.WriteLine("Değeriniz güncellendi");
                        }
                        

                        Console.WriteLine("değer duzenlendi: "+yeniduzen);

                        break;



                    case 5:
                        Console.WriteLine("Silmek istediğiniz değeri giriniz:");
                        int sil = Convert.ToInt32(Console.ReadLine());
                        degerlerListesi.RemoveAt(sil);
                        Console.WriteLine("Değer silindi");

                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Uygulamadan çıkılıyor...");
                        Thread.Sleep(3000);
                        Console.Clear();
                        Console.WriteLine("Yine beklerizzzzz");
                        Thread.Sleep(3000);
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("değerleri kontol ediniz");
                        break;
                }
            } while (true);
           
        }
    }
}
