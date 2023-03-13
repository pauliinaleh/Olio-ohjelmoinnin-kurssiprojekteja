Console.WriteLine("Luokkien yhdistäminen:");

Opintojakso ohjelmointi = new Opintojakso("Olio-ohjelmointi");
Opintojakso englanti = new Opintojakso("Englanti");

Opettaja matti = new Opettaja("Matti Mörkö");
Opettaja hanne = new Opettaja("Hanne Haamu");

ohjelmointi.AsetaOpettaja(matti);
englanti.AsetaOpettaja(hanne);

Oppilas janne = new Oppilas("Janne Holma");
janne.LisaaOpintojakso(ohjelmointi);
janne.LisaaOpintojakso(englanti);

Oppilas laura = new Oppilas("Laura Virtanen");
laura.LisaaOpintojakso(ohjelmointi);
laura.LisaaOpintojakso(englanti);

janne.Tulosta();
Console.WriteLine();
laura.Tulosta();



class Opintojakso
{
    public string Nimi { get; set; }
    public Opettaja Opettaja { get; set; }

    public Opintojakso(string nimi)
    {
        Nimi = nimi;
    }

    public void AsetaOpettaja(Opettaja opettaja)
    {
        Opettaja = opettaja;
    }

    public void Tulosta()
    {
        Console.WriteLine("OJ " + Nimi + " Opettaja " + Opettaja.Nimi);
    }
}

class Oppilas
{
    public string Nimi { get; set; }
    public List<Opintojakso> Opintojaksot { get; set; }

    public Oppilas(string nimi)
    {
        Nimi = nimi;
        Opintojaksot = new List<Opintojakso>();
    }

    public void LisaaOpintojakso(Opintojakso opintojakso)
    {
        Opintojaksot.Add(opintojakso);
    }

    public void Tulosta()
    {
        Console.WriteLine("Oppilas " + Nimi + ", opintojaksot:");
        foreach (Opintojakso opintojakso in Opintojaksot)
        {
            opintojakso.Tulosta();
        }
    }
}

class Opettaja
{
    public string Nimi { get; set; }

    public Opettaja(string nimi)
    {
        Nimi = nimi;
    }
}
