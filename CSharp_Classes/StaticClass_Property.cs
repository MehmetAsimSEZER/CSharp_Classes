using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Classes
{
    class StaticClass_Property
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı :{0}", Calisan3.CalisanSayisi);

            Calisan3 calisan3 = new Calisan3("Ayşe", "Yılmaz", "IK");
            Console.WriteLine("Çalışan Sayısı :{0}", Calisan3.CalisanSayisi);
            Calisan3 calisan4 = new Calisan3("Ayşe", "Yılmaz", "IK");
            Calisan3 calisan5 = new Calisan3("Ayşe", "Yılmaz", "IK");
            Console.WriteLine("Çalışan Sayısı :{0}", Calisan3.CalisanSayisi);

            Console.WriteLine("Toplama işlemi sonucu: {0}", Islemler.Topla(100, 200));
            Console.WriteLine("Çıkarma işlemi sonucu: {0}", Islemler.Çıkar(300, 200));
        }
    }

    class Calisan3
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }

        private string Isim;

        private string Soyisim;

        private string Departman;

        static Calisan3()
        {
            calisanSayisi =0;
        }

        public Calisan3(string ısim, string soyisim, string departman)
        {
            Isim = ısim;
            Soyisim = soyisim;
            Departman = departman;
            calisanSayisi ++;
        }
    }


    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static long Çıkar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
