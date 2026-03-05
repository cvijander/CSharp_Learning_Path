internal class Program
{
    private static void Main(string[] args)
    {
        SklopiPC();
    }

    private static void SklopiPC()
    {
        bool josKomponenti = true;


        do
        {
            Console.WriteLine("Unesite neki od brojeva ili vec 99 za kraj ");
            string userInput = Console.ReadLine().Trim();

            josKomponenti = ObradiOdgovor(userInput);


        } while (josKomponenti);

        Console.WriteLine("Hvala na koriscenju");

    }

    private static bool ObradiOdgovor(string input )
    {
        switch (input)
        {
            case "1":                
                Console.WriteLine("Dodali ste procesor");
                return true;


            case "2":
                Console.WriteLine("Maticna");
                return true;


            case "3":
                
                Console.WriteLine("Napajanje");
                return true;


            case "99":
                
                Console.WriteLine("Kraj");
                return false;

            default:
                return true;

        }
    }
}