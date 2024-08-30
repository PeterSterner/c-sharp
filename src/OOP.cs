namespace Programmering
{
    class Dyr
    {
        string navn;
        int alder;
        int vægt;
        string art;

        public Dyr(string navn, int alder, int vægt, string art)
        {
            this.navn = navn;
            this.alder = alder;
            this.vægt = vægt;
            this.art = art;
        }

        public void InfoOmDyr()
        {
            Console.WriteLine($"Dyret hedder {navn}, er {alder} år gammelt, vejer {vægt} kg og er en {art}");
        }
    }
}