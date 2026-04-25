namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The second tenant of object-oriented programming is inheritence ");
            Console.WriteLine("Inheritence is where an object is based on another object borrowing its implementation for some of its responsabilities or creating new specilaed implementations for other responsabilities");
            Console.WriteLine("And perhaps even adding new implementation for responsabilities that are unique to the inheriting object");
            Console.WriteLine();
            Console.WriteLine("Inheritance can also be in form of a contract or an interface");
            Console.WriteLine("So an object can implement one or more interfaces which define properties but more likely define methods that must be implemented to satisfy the conditions of the contract");
            Console.WriteLine();
            Console.WriteLine("When we talk about inheritance there is actually two different kinds of inheritance ");
            Console.WriteLine("* Implementation inheritance");
            Console.WriteLine("* Interface inheritance");
            Console.WriteLine();
            Console.WriteLine("Implementation inheritance.  There is at least two classes in inheritance .There is a parent class and it is child class. ");
            Console.WriteLine("The child deres its functionality, its properties and methods from the parent or that relationship can be described ad a superclass and subclass");
            Console.WriteLine("Superclass which has a number of methods and properties , and you have subclass which inherits all of those ");
            Console.WriteLine("Subclass can decide to override some , add additional features for specialization, whatever the case might be");
            Console.WriteLine("There is also a base class and the derived class it all sininims for the same relationship ");


            var car = new Automobile() { Make = "Toyota", Model = "4Runner", Year = 2010 };

            car.Display();

            var suv = new Suv() { Make = "GMC", Model = "Yukon", Year = 2016, DriveMechanism = "4 Wheel drive" };

            suv.Display();


            Console.WriteLine();
            Console.WriteLine("1* At first glance, you might see some benefit in terms of code reuse ");
            Console.WriteLine("2* But override and extend the parts that you nedd to create a specialized version of that object specific to the responsabilities that we as the developers will delefate to that child object in the system");
            Console.WriteLine("3* The flexibility that it gives to collaborations. ");
            Console.WriteLine("We can create similar but different implementations of the machinery thats needed to create and object that has some variances");
            Console.WriteLine("Implementation inheritance makes out collaborations much more flexible because we are able to generalize our collaborations between objects allowing for specializes child version of those collaborating object to be used in line of the parent object");
            Console.WriteLine("Larger contribution to the object-oriented programming world is for the generalization and specialization of collaborating objects and this is really half , second half is polymorphism");
            Console.WriteLine("We will see why is it so powerfull when you combine implementation with inheritance with polymorphism");





            Console.ReadLine();



        }
    }

    public class Automobile
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }


        public void Display()
        {
            Console.WriteLine($"Auto: {Make}  {Model} {Year}");
        }
    }

    public class Suv : Automobile
    {
        public string DriveMechanism { get; set; }

        public new void Display()
        {
            Console.WriteLine($"SUV: {Make}  {Model} {Year} {DriveMechanism}");
        }
    }
}


// https://www.youtube.com/watch?v=NCgZJSI3Kog&list=PLqT8wAi-pOx7X3i6Vynm57MCwFpQWJdP9&index=17