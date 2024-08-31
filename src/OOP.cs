namespace Programmering
{
    class Dyr(string navn, int alder, int vægt, string art) : IDyr
    {
        public string Navn { get; set; } = navn;
        public int Alder { get; set; } = alder;
        public int Vægt { get; set; } = vægt;
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

        public void Gø(int antalGange)
        {
            for (int i = 0; i < antalGange; i++)
            {
                Console.WriteLine("Vov vov vov - jeg er en hund og hedder " + Navn);
            }
        }

        public new void InfoOmDyr()
        {
            Console.WriteLine($"Hunden hedder {Navn}, er {Alder} år gammel, vejer {Vægt} kg og er en {Art}");
        }
    }

    class Kat(string navn, int alder, int vægt) : Dyr(navn, alder, vægt, "Kat")
    {
        public void Mjav()
        {
            Console.WriteLine("Mjav mjav - jeg er en kat og hedder " + Navn);
        }
    }

    interface IDyr
    {
        string Navn { get; set; }
        int Alder { get; set; }
        int Vægt { get; set; }
        string Art { get; }
        void InfoOmDyr();

    }

}