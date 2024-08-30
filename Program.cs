// See https://aka.ms/new-console-template for more information
namespace Programmering
{
    class Program
    {
        static void Main(string[] args)
        {

            // HejNavn
            /*       
            HejNavn hejNavn = new HejNavn();
            hejNavn.Kør();
            */

            // DataTyper
            /*
            DataTyper dataTyper = new DataTyper();
            dataTyper.Udskriv(); 
            */

            // Sundhed
            /* 
            Sundhed sundhed = new Sundhed();
            sundhed.BeregnBMI();
            */

            // Løkker
            /*
            Løkker løkker = new Løkker();
            løkker.ForLøkke();
            løkker.WhileLøkke();
            løkker.DoWhileLøkke();
            løkker.ForEachLøkke();
            */

            // Objekt-orienteret eksempel
            Dyr d1 = new Dyr("Fido", 5, 10, "Hund");
            Dyr d2 = new Dyr("Simba", 3, 5, "Kat");
            d1.InfoOmDyr();
            d2.InfoOmDyr();


        }
    }
}

