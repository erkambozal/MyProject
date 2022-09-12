// See https://aka.ms/new-console-template for more information
string kategoriEtiketi = "Kategori";
int ogrenciSayisi = 3200;
double faiz = 1.45;
bool sistemeGirisYapmisMi = false;
double dolarDun = 7.55;
double dolarBugun = 7.45;

if (dolarDun > dolarBugun) 
{
    Console.WriteLine("Azalış Butonu");
}
else if (dolarDun < dolarBugun)
{
    Console.WriteLine("Artış Butonu");
}
else
{
    Console.WriteLine("Değişmedi");
}

if (sistemeGirisYapmisMi == true)
{
    Console.WriteLine("Kullanıcı Ayarları Butonu");
}
else if (sistemeGirisYapmisMi == false)
{
    Console.WriteLine("Giriş Yap Butonu");
}

Console.WriteLine(kategoriEtiketi);

