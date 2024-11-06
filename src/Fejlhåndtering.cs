namespace Programmering
{
    class Fejlhåndtering
    {
        public void Kør()
        {
            // Fejlhåndtering
            try
            {
                int a = 10;
                int b = 0;
                int c = a / b;
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine("Der er sket en fejl: " + ex.Message);
            }
            finally
            {
                System.Console.WriteLine("Dette bliver altid kørt");
            }
        }

        public void KastFejl()
        {
            throw new System.Exception("Der er sket en fejl");
        }

        public void KastFejl2()
        {
            throw new System.AccessViolationException("Der er sket en fejl");
        }

        public void Test()
        {
            try
            {
                KastFejl();
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine("Der er sket en fejl: " + ex.Message);
            }
        }
    }
}