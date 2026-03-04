internal class Program
{
    private static void Main(string[] args)
    {
        KreirajLozinku();
    }

    private static void KreirajLozinku()
    {
        bool neispravnaLozinka = true;

        do
        {
            Console.WriteLine("Molimo unesite minimuk 8 karaktera  -  napomena * razmak na pocetku i na kraju se ne racuna u lozinku ");
            string userInput = Console.ReadLine().Trim();

            if (userInput.Length >= 8)
            {
                neispravnaLozinka = false;
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Molimo unesite 8 karaktera ");
                neispravnaLozinka = true;
            }


        } while (neispravnaLozinka);

        Console.WriteLine("Hvala na koriscenjeu naseg programa");


    }
}