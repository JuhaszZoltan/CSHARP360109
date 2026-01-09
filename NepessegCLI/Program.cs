using System.Text;

const string SrcPath = "..\\..\\..\\resources\\adatok-utf8.txt";

List<Orszag> orszagok = [];

using StreamReader sr = new(SrcPath, Encoding.UTF8);
_ = sr.ReadLine();
while (!sr.EndOfStream) orszagok.Add(new(sr.ReadLine()));

Console.WriteLine($"\n4.\nfeladat beolvasott orszagok szama: {orszagok.Count}");

var f5 = orszagok.Single(o => o.Orszagnev == "Kína").Nepsuruseg;
Console.WriteLine($"\n5. feladat:\nKina nepsurusege: {f5} fo/km^2");

var f6 = orszagok.Single(o => o.Orszagnev == "Kína").Nepesseg
    - orszagok.Single(o => o.Orszagnev == "India").Nepesseg;
Console.WriteLine($"\n6. feladat:\nKinaban {f6} fovel elnek tobben, mint Indiaban");

var f7 = orszagok.OrderBy(o => o.Nepesseg).ToList()[^3];
Console.WriteLine($"\n7. feladat:\n3. legnepesebb orszag: {f7.Orszagnev}, lakossaga: {f7.Nepesseg} fo");

var f8 = orszagok.Where(o => o.KoncentraltLakossag);
Console.WriteLine("\n8. feladat: koncentralt lakossagu orszagok:");
foreach (var orszag in f8) Console.WriteLine($"\t{orszag.Orszagnev} ({orszag.Fovaros})");
