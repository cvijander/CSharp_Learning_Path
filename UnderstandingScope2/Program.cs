internal class Program
{

    private static string k = "";  // private field  privatno polje, slicno propertiju  k je difinisan na nivuo klase program i on je rodjak helper metodi, zato ga i vidi kao i main metodi
    private static void Main(string[] args)
    {
        string j = "";


        for (int i =0; i< 10; i++)
        {
            k = i.ToString();
            j = i.ToString();
            Console.WriteLine(i);

            if (i == 9)
            {
                string l = i.ToString();
                Console.WriteLine($"{l} here is l");
            }
            //Console.WriteLine(l);
        }

        //Console.WriteLine($"{i}"); i je van scopa
        Console.WriteLine($"{j} j is outside of for");
        Console.WriteLine($"{k} k is outside of for loop");

        HelperMethod();

        Console.ReadLine();
    }

    static void HelperMethod()
    {
        Console.WriteLine($"{k} this is value k from Helper method");
    }
}

// https://www.youtube.com/watch?v=0QUgvfuKvWU