using System;

namespace BenIkErdoorOpERPOfNiet
{
    
    class Program
    {
        static void Main(string[] args)
        {
            const int AANTAL_TESTEN = 1000;
            int aantalGeslaagd = 0;
            for(int i = 0; i < AANTAL_TESTEN; i++)
            {
                if (Test(15))
                    aantalGeslaagd++;
            }
            Console.WriteLine($"Je bent op {aantalGeslaagd} van de {AANTAL_TESTEN} testen geslaagd.");
        }

        private static bool Test(int aantalVragen)
        {
            DobbelSteenMetVierKanten juistAntwoord = new DobbelSteenMetVierKanten();
            DobbelSteenMetVierKanten gekozenAntwoord = new DobbelSteenMetVierKanten();
            int juistTeller = 0;
            for (int i = 0; i < aantalVragen; i++)
            {
                int juistAntwoord1 = juistAntwoord.Gooi();
                int gekozenAntwoord1 = gekozenAntwoord.Gooi();
                if (juistAntwoord1 == gekozenAntwoord1)
                    juistTeller++;
                Console.WriteLine(juistAntwoord1 + " " + gekozenAntwoord1);
            }
            return juistTeller >= aantalVragen / 2.0;
        }
    }
}
