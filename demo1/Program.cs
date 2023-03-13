
Console.WriteLine("Montako lukua:");
int lukujenmäärä = int.Parse(Console.ReadLine());

double summa = 0;  

for (int i = 0; i < lukujenmäärä; i++)
{
    Console.WriteLine("Anna Luku");
    double luku = double.Parse(Console.ReadLine());
    summa += luku;
}

double keskiarvo = summa / lukujenmäärä;
Console.WriteLine("Antamiesi lukujen keskiarvo on: " + keskiarvo);


