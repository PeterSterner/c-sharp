namespace Programmering
{
    class Lister
    {
        public void ListeEksempler()
        {
            List<string> navne = new List<string>();
            navne.Add("Hans");
            navne.Add("Trine");
            navne.Add("Jens");
            navne.Add("Lone");


            foreach (string navn in navne)
            {
                Console.WriteLine(navn);
            }

            navne.Remove("Jens");

            Console.WriteLine();

            foreach (string navn in navne)
            {
                Console.WriteLine(navn);
            }

            navne.Insert(2, "Jens");

            Console.WriteLine();

            foreach (string navn in navne)
            {
                Console.WriteLine(navn);
            }

            navne.Sort();

            Console.WriteLine();

            foreach (string navn in navne)
            {
                Console.WriteLine(navn);
            }

            navne.Reverse();

            Console.WriteLine();

            foreach (string navn in navne)
            {
                Console.WriteLine(navn);
            }

            Console.WriteLine("Antal navne: " + navne.Count);
        }
    }
}