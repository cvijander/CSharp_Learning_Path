class Program
{

    private static string k = "";  // private field

    static void Main(string[] args)
    {
        string j = "";

        for (int i = 0; i < 10; i++)
        {
            j = i.ToString();
            k = i.ToString();
            Console.WriteLine(i);

            if (i ==9)
            {
                string l = i.ToString();
            }
            //Console.WriteLine(l); l je van scopa 
        }
        //Console.WriteLine(i);  i je van scopa 
        Console.WriteLine($"{j} j  it is outside for loop");
        Console.WriteLine($"{k} this is k , outside for loop");

        HelperMethod();

        Car myCar = new Car();
        myCar.DoSomething();
        Console.ReadLine();

    }

     static void HelperMethod ()
    {
        Console.WriteLine($"This is from HelperMethod()  value k is {k}");
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
        return "hello from helper method inside car class";
   }
}