
using Business.Concrete;
using Entities.Concrete;

SelamVer("Engin");
SelamVer("Ahmet");
SelamVer("Ayşe");
SelamVer();
int sonuc = Topla();


string ogrenci1 = "Engin";
string ogrenci2 = "Kerem";
string ogrenci3 = "Berkay";

string[] ogrenciler = new string[3];
ogrenciler[0] = "Engin";
ogrenciler[1] = "Kerem";
ogrenciler[2] = "Berkay";

ogrenciler = new string[4];
ogrenciler[3] = "İlker";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

sehirler2 = sehirler1;
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);

Person person1 = new Person();
person1.FirstName = "PELİN";
person1.LastName = "COŞKUN";
person1.DateOfBirthYear = 1998;
person1.NationalIdentity = 2154656565;

Person person2 = new Person();
person2.FirstName = "Murat";


foreach (string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

List<string> yenisehirler1 = new List<string> { "Ankara1", "İstanbul1", "İzmir1" };
yenisehirler1.Add("Adana1");
foreach (var sehir in yenisehirler1)
{
    Console.WriteLine(sehir);
}

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);


static void SelamVer(string isim = "isimsiz")
{
    Console.WriteLine("Merhaba" + isim);
}

static int Topla(int sayi1 = 5, int sayi2 = 10)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam : " + sonuc);
    return sonuc;
}