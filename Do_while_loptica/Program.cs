internal class Program
{
    private static void Main(string[] args)
    {
        BacanjeLoptice();
    }

    private static void BacanjeLoptice()
    {
        int brojac = 0;

        bool doneoLopticu = true;

        do
        {
            brojac++;
            Console.WriteLine($"Bacio si lopticu. Ovo je bacanje broj {brojac}.");

            Console.WriteLine("Da li je Vucko doneo lopticu ? DA / NE");
            string userInput = Console.ReadLine().Trim().ToLower();

            if (userInput == "da")
            {
                doneoLopticu = true;
            }
            else
            {
                doneoLopticu = false;
            }

        }
        while (doneoLopticu);

        Console.WriteLine($"Vucko se umorio. Ukupno bacanja {brojac}");
    }
    
}