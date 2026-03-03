internal class Program
{
    private static void Main(string[] args)
    {
        Trening();
    }

    private static void Trening()
    {
        double nagib =0;
        double brzina =0 ;

        Console.WriteLine($"Trening je poceo nagib je {nagib} % , brzina je {brzina} ");

        bool nastavljamo = true;

        do
        {
            Console.WriteLine("Da li nastavljamo dalje ? DA , NE");
            string userInput = Console.ReadLine().Trim().ToLower();

            if (userInput == "da")
            {
                nastavljamo = true;
                Console.WriteLine($"Da li povecamo nagib ? Trenutno je {nagib}");
                Console.WriteLine("Unesite novi nagib");
                string userNagib = Console.ReadLine().Trim();

                double output;
                if (double.TryParse(userNagib, out output))
                {
                    Console.WriteLine($"Trening je poceo nagib je {userNagib} % , brzina je {brzina} ");
                }

                else
                {
                    Console.WriteLine("Greska sa nagibom");
                }
            }
            else
            {
                nastavljamo = false;
                Console.WriteLine("Hvala sto ste bili na traci");
            }

        } while (nastavljamo);
    }
}