namespace Programmering
{
    class Løkker
    {
        public void ForLøkke()
        {
            Console.WriteLine("For løkke:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }



        public void WhileLøkke()
        {
            Console.WriteLine("While løkke:");
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public void DoWhileLøkke()
        {
            Console.WriteLine("Do while løkke:");
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 10);
        }

        public void ForEachLøkke()
        {
            Console.WriteLine("For each løkke:");
            string[] navne = { "Anders", "Bente", "Carsten" };
            foreach (string navn in navne)
            {
                Console.WriteLine(navn);
            }
        }
    }
}