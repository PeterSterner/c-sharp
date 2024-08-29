namespace Programmering
{
    class HejNavn
    {
        public void Kør()
        {
            Console.WriteLine("Hvad er dit navn?");
            string? navn = Console.ReadLine();
            if (navn == null)
            {
                Console.WriteLine("Du har ikke indtastet noget navn");
                return;
            }
            Console.WriteLine("Hej " + navn);

        }
    }
}