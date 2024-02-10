// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Entities.Concrete;


Person person1 = new Person();
person1.FirstName = "Engin";
person1.LastName = "Demirog";
person1.DateOfBirthYear = 1985;
person1.NationalIdentity = 123;

SelamVer();

int sonuc = Topla(3,5);


PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);


static void SelamVer(string isim="isimsiz")
{
    Console.WriteLine("Merhaba " + isim);
}

static int Topla(int sayi1, int sayi2)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam : " +sonuc);
    return sonuc;
}