namespace Programmering
{
    class Lister
    {
        public static void ListeEksempler()
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

        public static void ListerIListerEksempler()
        {
            List<List<int>> tal = [[1, 2, 3], [4, 5, 6]];
            // udskriv tal[1][2] = 6
            Console.WriteLine(tal[1][2]);
            // udskriv alle tal
            foreach (List<int> l in tal)
            {
                foreach (int i in l)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}