// See https://aka.ms/new-console-template for more information

Console.WriteLine("Anna luku 1:");
int luku1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Anna luku 2:");
int luku2 = Convert.ToInt32(Console.ReadLine());
int tulos = PlusTaiMiinus(luku1, luku2);

Console.WriteLine(luku1 + " ja " + luku2 + " -> " + tulos);

int PlusTaiMiinus(int luku1, int luku2)
{
    if (luku1 > luku2)
        return luku1 - luku2;
    else
        return luku2 - luku1;
}
