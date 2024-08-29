namespace Programmering
{
    class Sundhed
    {
        public void BeregnBMI()
        {
            // Beregn
            Console.WriteLine("Indtast vægt i kg (brug komma):");
            string? vægt = Console.ReadLine();
            Console.WriteLine("Indtast højde i meter (brug komma):");
            string? højde = Console.ReadLine();
            if (vægt == null)
            {
                Console.WriteLine("Du har ikke indtastet noget vægt");
                return;
            }
            else if (højde == null)
            {
                Console.WriteLine("Du har ikke indtastet noget højde");
                return;
            }

            UdskrivBMI(vægt, højde);
        }

        private void UdskrivBMI(string vægt, string højde)
        {
            // Udskriv
            double vægtDouble = Convert.ToDouble(vægt);
            double højdeDouble = Convert.ToDouble(højde);
            double bmi = vægtDouble / (højdeDouble * højdeDouble);
            Console.WriteLine("Din BMI er: " + bmi);
        }

    }
}
