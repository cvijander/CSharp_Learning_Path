internal class Program
{
    private static void Main(string[] args)
    {
        KalkulatorKomponenti();
    }

    private static void KalkulatorKomponenti()
    {
        int total = 0;

        bool josKomponenata = true;

        do
        {
            Console.WriteLine("Unesite cenu za sledecu komponentu: ili vec 0 za kraj kupovine ");
            int cena = int.Parse(Console.ReadLine().Trim());

            if (cena != 0)
            {
                total = total +cena;
                josKomponenata = true;
            }
            else
            {
                josKomponenata = false;
            }
           
        } while (josKomponenata);

        Console.WriteLine($"Vas racun je {total}");
    }
}