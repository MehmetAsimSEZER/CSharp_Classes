using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Classes
{
    class ErişimBelirleyiciler_KurucuFonksiyonlar
    {
        static void Main(string[] args)
        {

            Calisan1 calisan = new Calisan1("Ayşe", "Kara", 123456, "IK");

            calisan.calisanBilgileri();

            Console.WriteLine("******************");

            Calisan1 calisan2 = new Calisan1();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 654321;
            calisan2.Departman = "IK";

            calisan2.calisanBilgileri();

            Console.WriteLine("******************");

            Calisan1 calisan1 = new Calisan1();
            calisan1.Ad = "Asım";
            calisan1.Soyad = "Sezer";

            calisan1.calisanBilgileri();
        }
        
    }

    class Calisan1
    {
        public string Ad; 

        public string Soyad;

        public int No;

        public string Departman;

        public Calisan1(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }

        public Calisan1(string ad, string soyad )
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }


        public Calisan1()
        {

        }
        public void calisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı:{0}", Ad);
            Console.WriteLine("Çalışanın Soyadı:{0}", Ad);
            Console.WriteLine("Çalışanın Numarası:{0}", No);
            Console.WriteLine("Çalışanın Departmanı:{0}", Departman);
        }
    }
}
