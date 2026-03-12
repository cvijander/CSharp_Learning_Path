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

        Car myCar = new Car();
        myCar.DoSomething();
        Console.ReadLine();
        
    }

    static void HelperMethod()
    {
        Console.WriteLine($"Value of k from the Helpermethod():  {k}" );
    }
}

class Car
{
    public void DoSomething()
    {
        Console.WriteLine(helperMethod());
    }

    private string helperMethod()
    {
        return "Hello World from Car class";
    }
}


// 5 sati od 5 do 5:18
// https://www.youtube.com/watch?v=0QUgvfuKvWU