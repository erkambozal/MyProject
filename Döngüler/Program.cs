// See https://aka.ms/new-console-template for more information
string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
string kurs2 = "Programlamaya başlangıç için temel kurs";
string kurs3 = "Java";

string[] kurslar = new string[]
{
  "Yazılım Geliştirici Yetiştirme Kampı","Programlamaya başlangıç için temel kurs","Java"
};
Console.WriteLine(kurslar);


for (int i = 0; i < kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}

foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}
