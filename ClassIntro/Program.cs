// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Kurs kurs1  = new Kurs();
kurs1.KursAdi = "C#";
kurs1.KursunEgitmeni = "Engin Demiroğ";
kurs1.IzlenmeOrani = 68;

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "C++";
kurs2.KursunEgitmeni = "Engin Demiroğ";
kurs2.IzlenmeOrani = 73;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "Java";
kurs3.KursunEgitmeni = "Engin Demiroğ";
kurs3.IzlenmeOrani = 21;

Kurs[] kurslar = new Kurs[] 
{kurs1,kurs2,kurs3};
foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi);
    Console.WriteLine(kurs.KursunEgitmeni);
    Console.WriteLine(kurs.IzlenmeOrani);
}

Console.WriteLine(kurs1.KursAdi+" "+kurs1.KursunEgitmeni+" "+kurs1.IzlenmeOrani);
Console.WriteLine(kurs2.KursAdi+" "+kurs2.KursunEgitmeni+" "+kurs2.IzlenmeOrani);
Console.WriteLine(kurs3.KursAdi + " " + kurs3.KursunEgitmeni + " " + kurs3.IzlenmeOrani);



class Kurs
{
    public string KursAdi { get; set; }
    public string KursunEgitmeni { get; set; }
    public int IzlenmeOrani { get; set; }
}
