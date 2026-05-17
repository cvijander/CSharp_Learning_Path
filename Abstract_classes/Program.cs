namespace Abstract_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract ");
            Console.WriteLine("The abstract modifier indicates that the thing being modified has a missing or incomplete implementation");
            Console.WriteLine("The abstract modifier can be used with classes and class members");
            Console.WriteLine();
            Console.WriteLine("Use the abstract modifier in a class declaration to indicate that a class is intended only to be a base class of other classes");
            Console.WriteLine();
            Console.WriteLine("Members marked as abstract, or included in an abstract class, must be implemented by classes that derive from the abstract class");


            // var automobile = new Automobile();

            var car = new Car();
            car.Drive();


            //var animal = new Animal();

            var feline = new Feline();
            feline.Walk();

            Console.ReadLine();
        }
    }

    abstract class Automobile
    {
        public virtual void Drive()
        {
            Console.WriteLine("Driving automobile");
        }
    }

    class Car: Automobile
    {
        public override void Drive()
        {
            base.Drive();
            Console.WriteLine("Override version");
        }
    }

    abstract class Animal
    {
      public  abstract void Walk();
       
    }

    class Feline : Animal
    {
        public override void Walk()
        {
            Console.WriteLine("Feline is pouncing");
        }
    }

}


// https://www.youtube.com/watch?v=qZOKhPCqyQ0&list=PLqT8wAi-pOx62b1ITQTnf7fqbzKrNqz7O&index=13