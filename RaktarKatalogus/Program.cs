using RaktarKatalogus;
using System.Diagnostics.CodeAnalysis;


List<Termek> osszes = new List<Termek>();
Console.WriteLine("=== Raktárkészlet Rögzítése ===\n");
for (int i=0;i<3;i++)
{
    Console.WriteLine($"Kérem at {i+1}. termék adatai");
    Termek ujTermek = new Termek();
    Console.Write("\tNév: ");
    ujTermek.Nev = Console.ReadLine();
    Console.Write("\tEgységár (Ft): ");
    ujTermek.Ar = int.Parse(Console.ReadLine());
    Console.Write("\tRaktárkészlet (db): ");
    ujTermek.Mennyiseg = int.Parse(Console.ReadLine());
    osszes.Add(ujTermek);
}//4.feladat
double teljesertek = 0;
double atlag = 0;
int osszdb = 0;
foreach (Termek t in osszes)
{
    teljesertek += t.Ar * t.Mennyiseg;
        osszdb += t.Mennyiseg;
}
atlag = teljesertek / osszdb;
