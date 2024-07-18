using System;
/* Birden çok tanımlama ve koşul yapısı olması durumunda switch case metodu daha kullanışlı ve daha 
 az komplike olması sebebiyle benim için kullanmı ve anlaşılması daha kolaydı. 
Bu yüzden switch case kullanımını daha efektif buldum.*/


//İf Yapısı ile kullanım



int elma = 2;
int armut = 3;
int çilek = 2;
int muz = 4;

Console.WriteLine("Rüya manavına hoş geldiniz");
Console.WriteLine($"Elma = {elma} Tl");
Console.WriteLine($"Armut = {armut} Tl");
Console.WriteLine($"Çilek = {çilek} Tl");
Console.WriteLine($"Muz = {muz} Tl");
Console.WriteLine("Diğer Tüm Meyveler 4 TL");

Console.WriteLine("Hangi meyveyi almak istersiniz ? Elma/Armut/Çilek/Muz/Diğer");
string meyve =Console.ReadLine().ToLower(); 


if (meyve== "elma")
{
    Console.WriteLine($"Seçtiğiniz meyvenin fiyatı {elma} Tldir.");
}
else if (meyve=="armut")
{
    Console.WriteLine($"Seçtiğiniz meyvenin fiyatı {armut} Tldir.");
}
else if (meyve== "muz")
{
    Console.WriteLine($"Seçtiğiniz meyvenin fiyatı {muz} Tldir.");
}
else if (meyve=="çilek")
{
    Console.WriteLine($"Seçtiğiniz meyvenin fiyatı {çilek} Tldir.");
}
else
{
    Console.WriteLine($"Seçtiğiniz meyvenin fiyatı 4 Tldir.");

}

Console.WriteLine("--------------------");



// Switch yapısı ile kullanım


Console.WriteLine("Rüya manavına hoş geldiniz");
Console.WriteLine($"Elma = {elma} Tl");
Console.WriteLine($"Armut = {armut} Tl");
Console.WriteLine($"Çilek = {çilek} Tl");
Console.WriteLine($"Muz = {muz} Tl");
Console.WriteLine("Diğer Tüm Meyveler 4 TL");

Console.WriteLine("Hangi meyveyi almak istersiniz ? Elma/Armut/Çilek/Muz/Diğer");
string meyve2 = Console.ReadLine().ToLower();

switch (meyve2)
{
    case "elma":
        Console.WriteLine($"Seçtiğiniz meyvenin fiyatı {elma} Tldir.");
        break;
    case "armut":
        Console.WriteLine($"Seçtiğiniz meyvenin fiyatı {armut} Tldir.");
        break;
    case "çilek":
        Console.WriteLine($"Seçtiğiniz meyvenin fiyatı {çilek} Tldir.");
        break;
    case "muz":
        Console.WriteLine($"Seçtiğiniz meyvenin fiyatı {muz} Tldir.");
        break;
    case "diğer":
        Console.WriteLine($"Seçtiğiniz meyvenin fiyatı 4 Tldir.");
        break;
}