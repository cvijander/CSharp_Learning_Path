internal class Program
{
    private static void Main(string[] args)
    {
        KontrolaTezine();
    }

    private static void KontrolaTezine()
    {
        int tezina = 0;

        bool neispravanPaket = true;

        do
        {
            Console.WriteLine("Unesite tezinu paketa (dozvoljeno od 1 do 20 kg )");
            int userTezina = int.Parse(Console.ReadLine().Trim());

            if (userTezina < 1 || userTezina > 20)
            {
                neispravanPaket = true;
                Console.WriteLine($"Vasa tezina je {userTezina} ");
                tezina += userTezina;
            }
            else
            {
                neispravanPaket = false;
                Console.WriteLine("Greska");
            }


        } while (neispravanPaket);

        Console.WriteLine($"Hvala sto ste koristili program ukupno ste poslali {tezina} kg. ");


    }
}