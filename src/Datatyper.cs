namespace Programmering
{
    class DataTyper
    {

        // Variabler
        int heltal = 10;
        double kommatal = 12.5;
        bool sandtEllerFalsk = true;
        string tekst = "Dette er en tekst";
        char bogstav = 'a';

        public void Udskriv()
        {

            // Udskriv variabler
            Console.WriteLine(heltal);
            Console.WriteLine(kommatal);
            Console.WriteLine(sandtEllerFalsk);
            Console.WriteLine(tekst);
            Console.WriteLine(bogstav);
        }
    }

}