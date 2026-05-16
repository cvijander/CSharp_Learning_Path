namespace sealed_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sealed keyword");
            Console.WriteLine("When applied to a class, the sealed modifier prevents other classes from inheriting from it");
            Console.WriteLine();
            Console.WriteLine("When applied to a class member that overrides a virtual member of the base class, it prevents derived classes from overriding specific virtual members");
            Console.WriteLine("Sealed keyworkd for methods can be used only on override methods, we can not use it on virtual , only on derived methods ");
            Console.WriteLine();
           




            Console.ReadLine();
        }
    }

   class Automobile
    {
        public void Drive()
        {
            Console.WriteLine("Automobile is driving.");
        }
    }

    class Car: Automobile
    {

    }

    class Animal
    {
        public virtual void Walk()
        {
            Console.WriteLine("This animal is walking");
        }
    }

    class Feline : Animal
    {
        public sealed override void Walk()
        {
            Console.WriteLine("This feline is prowling");
        }
    }

    class HouseCat : Feline
    {
        public override void Walk()
        {
            Console.WriteLine("THis kitty is pouncing");
        }
    }
}



// https://www.youtube.com/watch?v=QsOUXp8Kk00&list=PLqT8wAi-pOx62b1ITQTnf7fqbzKrNqz7O&index=11