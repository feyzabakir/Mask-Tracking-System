using Business.Concrete;
using Entities.Concrete;

namespace Workaround;

class Program
{
    static void Main(string[] args)
    {
        Variables();
        SelamVer("Feyza");
        SelamVer();

        Topla(3,5);
        Topla();

        string ogrenci1 = "Feyza";
        string ogrenci2 = "Nisa";
        string ogrenci13 = "Engin";

        string[] ogrenciler = new string[3];  // [ , , ]    heap: 101
        ogrenciler[0] = "Feyza";
        ogrenciler[1] = "Nisa";
        ogrenciler[2] = "Engin";   // ["Feyza","Nisa","Engin"]

        ogrenciler = new string[4]; // new ile Heap'de yeni bir alan oluşturulur heap : 102
        ogrenciler[3] = "Ali";      // [  ,  ,  ,"Ali"]

        for (int i = 0; i < ogrenciler.Length; i++)
        {
            Console.WriteLine(ogrenciler[i]);
        }

        Person person1 = new Person();
        person1.FirstName = "FEYZA";
        person1.LastName = "BAKIR";
        person1.DateOfBirthYear = 2000;
        person1.NationalIdentity = 123456789;


        Person person2 = new Person();
        person2.FirstName = "ENGİN";
        person2.LastName = "DEMİROĞ";
        person2.DateOfBirthYear = 1985;
        person2.NationalIdentity = 123456789;

        string[] sehirler1 = new[] { "Niğde", "Ankara", "İstanbul" };
        string[] sehirler2 = new[] { "İzmir", "Bursa", "Adana" };

        sehirler2 = sehirler1;    // sehirler2'nin referansı sehirler1 ile aynı oldu
        sehirler1[0] = "Mersin";
        Console.WriteLine(sehirler2[0]);

        int sayi1 = 10;
        int sayi2 = 20;
        sayi2 = sayi1;
        sayi1 = 30;
        Console.WriteLine (sayi2);

        // NOT: stringler referans tiptir.

        foreach (string sehir in sehirler1)
        {
            Console.WriteLine(sehir);
        }

        Console.WriteLine ("\n**************\n");

        // Generic collection
        List<string> yeniSehir = new List<string> {"Samsun", "Ordu", "Rize"};
        yeniSehir.Add("Artvin");
        foreach(var sehir in yeniSehir)
        {
            Console.WriteLine(sehir);
        }

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);


        Console.ReadLine();


    }

    static void SelamVer(string isim="isimsiz")
    {
        Console.WriteLine("Merhaba " + isim);
    }

    static int Topla(int x=1, int y=2)
    {
       int sonuc = x + y;
        Console.WriteLine("Toplam : " + sonuc.ToString());
        return sonuc;
    }



    static void Variables()
    {
        string message = "Merhaba";
        double amount = 1000.5;
        int number = 100;
        bool isTrue = true;

        string name = "Feyza Nur";
        string surname = "Bakır";
        int birthYear = 2000;
        long identityNumber = 12345678999;

        Console.WriteLine(amount * 1.18);
    }

    public class Vatandas
    {
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public int DogumYili { get; set; }

        public long TcNo { get; set; }

    }
}


