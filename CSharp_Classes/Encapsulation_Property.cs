using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Classes
{
    class Encapsulation_Property
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Ayşe";
            ogrenci.Soyisim = "Yılmaz";
            ogrenci.OgrenciNo = 293;
            ogrenci.Sinif = 3;
            ogrenci.OgrenciBilgileriGetir();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriGetir();

            Ogrenci ogrenci1 = new Ogrenci("Deniz", "Arda", 256, 1);
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriGetir();
        }
    }

    class Ogrenci
    {
        private string isim;

        private string soyisim;

        private int ogrenciNo;

        private int sinif;

        public string Isim { get; set; }

        public string Soyisim { get; set; }

        public int OgrenciNo { get; set; }

        public int Sinif 
        {
            get => sinif;
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir.");
                    sinif = 1;
                }
                else
                {
                    sinif = value;
                }
            } 
        }

        public Ogrenci()
        {
                
        }

        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public void OgrenciBilgileriGetir()
        {
            Console.WriteLine("********* Öğrenci Bilgileri ***********");
            Console.WriteLine("Öğrenci Adı    :{0}",this.Isim);
            Console.WriteLine("Öğrenci Soyadı :{0}",this.Soyisim);
            Console.WriteLine("Öğrenci No     :{0}",this.OgrenciNo);
            Console.WriteLine("Öğrenci Sınıfı :{0}",this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }

        public void SinifDusur()
        {
            this.Sinif = this.Sinif + 1;
        }
    }
}
