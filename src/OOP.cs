namespace Programmering
{
    class Dyr(string navn, int alder, int vægt, string art)
    {
        public string Navn { get; set; } = navn;
        public int Alder { get; } = alder;
        public int Vægt { get; } = vægt;
        public string Art { get; } = art;

        public void InfoOmDyr()
        {
            Console.WriteLine($"Dyret hedder {Navn}, er {Alder} år gammelt, vejer {Vægt} kg og er en {Art}");
        }
    }

    class Hund(string navn, int alder, int vægt) : Dyr(navn, alder, vægt, "Hund")
    {
        public void Gø()
        {
            Console.WriteLine("Vov vov vov - jeg er en hund og hedder " + Navn);
        }
    }

    class Kat(string navn, int alder, int vægt) : Dyr(navn, alder, vægt, "Kat")
    {
        public void Mjav()
        {
            Console.WriteLine("Mjav mjav - jeg er en kat og hedder " + Navn);
        }
    }
}