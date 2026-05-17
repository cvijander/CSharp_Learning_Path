using System.Runtime.CompilerServices;

namespace extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Extension methods");
            Console.WriteLine("Exntensiom methods allow you to bolt methods on to the side of any type -- even types in the .Net Framework -- even if that type is sealed");


            var automobile = new Automobile();

            automobile.MyExtensionMethod();

            Console.ReadLine();
        }
    }

    sealed class Automobile
    {
        public void Drive()
        {
            Console.WriteLine("Automobile is driving");
        }
    }

    static class AutomoBileExtensions
    {
        public static void MyExtensionMethod(this Automobile automobile)
        {
            Console.WriteLine("I was able to add an extension method");
            automobile.Drive();
           
        }
    }
}


// https://www.youtube.com/watch?v=Ye2CU-bKi14&list=PLqT8wAi-pOx62b1ITQTnf7fqbzKrNqz7O&index=12 