using System.Diagnostics;

internal class Program
{

    private static string k = "";

    private static void Main(string[] args)
    {

        string j = "";
        
        for (int i =0; i < 10; i++)
        {
            j = i.ToString();
            k = i.ToString();
            Console.WriteLine(i);


            if (i == 9)
            {
                string l = i.ToString();
                Console.WriteLine(l);
            }
           // Console.WriteLine(l);
        }

        //Console.WriteLine(i);
        Console.WriteLine($"Outside of the scope {j} ");
        Console.WriteLine($"Outside od for loop {k}");
        HelperMethod();
        Console.ReadLine();
        
    }

    static void HelperMethod()
    {
        Console.WriteLine($"Value of k from the Helpermethod():  {k}" );
    }
}


// 5 sati 
