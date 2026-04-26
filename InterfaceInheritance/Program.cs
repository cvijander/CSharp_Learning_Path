using Microsoft.VisualBasic;
using System.Runtime.ConstrainedExecution;

namespace InterfaceInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interface inheritance is similar to implementation inheritance in this regard when you have multiple objects that share the same basic shape");
            Console.WriteLine("In other words, when they support the same method signatures or properties ");
            Console.WriteLine("Interface inheritance take this whole idea one step further");
            Console.WriteLine();
            Console.WriteLine("Interfaces only define the public members of a class that must be implemented by a class in order to satisfy a contract between two or more object");
            Console.WriteLine("So it is a contract of communication. There is no implementation to fall back on when you create an interface");
            Console.WriteLine("");
            Console.WriteLine("But in superclass - subclass there is  implementation inheritance that  you can always rely on the parents implementation ");
            Console.WriteLine();
            Console.WriteLine("Interface inheritance has a whole different purpose and while it is similar its purpose is different");
            Console.WriteLine("You use intefraces to define an abstraction that breaks a depencency ");
            Console.WriteLine("Interface represents a contract for services that I need rendered or speaking as an object, I need something done.");
            Console.WriteLine("So I will put a contract out there and saay if anybody can work with me, here is the contract that you will have to fill on your side ");
            Console.WriteLine("You have to satisfy on your side. The other object can accept the terms of the contract, and implement the terms of the contract ");
            Console.WriteLine();

            var car = new Car() { Make = "GMC", Model = "Yukon" };
            var book = new Book() { Title = "1984", Author = "Orvel" };
            var shirt = new Shirt { Size = 10 , Color = "Blue"}; 

            // DisplayCar(car);
            // DisplayBook(book);
            DisplayYorself(car);
            DisplayYorself(book);
            DisplayYorself(shirt);


            Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("What happens when I want to add another type of object? ");
            Console.WriteLine("I would have to come in adn create a new helper method for each one of these");
            Console.WriteLine("This seems like not the right place to do that because the code passage could get longer and longer over time");
            Console.WriteLine();
            Console.WriteLine("First of all I don't even have the information necessary yo go off and know what needs to be printed and how it needs to be printed");
            Console.WriteLine("I rather have the information holder who the object that knows the information be the one responsible for formatting and then printing out to screen the value inside of its own instance");
            Console.WriteLine("I need to create like one method  \"static void DisplayYourself\" then you need to implement IDisplayable  ");
            Console.WriteLine("We create interface with \" public interface IDisplayable \" ");
            Console.WriteLine("In the body of interface we will just put method without implmentation  void Display(); ");
            Console.WriteLine("Now in the class we must implement interface with IdIsplayable , and with it it must be implemented all the methods from interface");
            Console.WriteLine("But after that ww will call only one Method ()  \" DispayYourself(car)   DisplayYourself(book)  - which will shown these methods");
            Console.WriteLine("Now the \" DisplayBook and DisplayCar \" are no longer needed , we are using their method implemetation on Car and Book class with method \" Display\" ");
            Console.WriteLine("The result wont be any different , but the way we got there is dramatically different");
            Console.WriteLine();
            Console.WriteLine("And now at this point on the program class doesn;t need too much information about how to display objects that it holds a reference to");
            Console.WriteLine("It is going to depend on the fact that they implement this contract and that they know hoe to display themselves as a result");
            Console.WriteLine();
            Console.WriteLine("Any object that implements a contract can be used. Since any object that implements a contract can be used that means two things");
            Console.WriteLine("First we removed a tight coupling that our object may have to other objects");
            Console.WriteLine("We really see that more here in Displayyourself . There is not a tight coupling .Like it was in methind that belonged to Car or Book. ");
            Console.WriteLine("It is just very generic and we can pass anything into it ");
            Console.WriteLine("Since our object is not coupled and it only depends on a specific coupled in such a way that it depends on a specific object type ,");
            Console.WriteLine("but now any object that implements our Idisplayable contract we can isolate our object more easily ");
            Console.WriteLine("Now if we wantend  to unit test main for example, we could isolate it and then perform utit test  ");
            Console.WriteLine();
            Console.WriteLine("Similar to encapsulation, it keeps our collaboration simple and flexible because we have established clear boundaries ");
            Console.WriteLine("We dont want one object so tightly coupled to another object ");
            Console.WriteLine("Interface inheritance helps us to separate our concerns in clear lines");



        }

        static void DisplayYorself (IDisplayable myObjects)
        {
            myObjects.Display();
        }
        /*
        static void DisplayCar(Car car)
        {
            Console.WriteLine($"Car is : {car.Make}  {car.Model}");
        }

        static void DisplayBook (Book book )
        {
            Console.WriteLine($"Book is : {book.Author} {book.Title}");
        }
        */

    }

    public interface IDisplayable
    {
        void Display();
    }

    public class Car: IDisplayable
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public void Display()
        {
            Console.WriteLine($"Car is : {Make}  {Model}");
        }
    }

    public class Book :IDisplayable
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public void Display()
        {
            Console.WriteLine($"Book is : {Author} {Title}");
        }
    }

    public class Shirt :IDisplayable
    {
        public int Size { get; set; }
        public string Color { get; set; }

        public void Display()
        {
            Console.WriteLine($"Shirt: {Size}   {Color} ");
        }
    }
}

// https://www.youtube.com/watch?v=wxtSD19Kztg&list=PLqT8wAi-pOx7X3i6Vynm57MCwFpQWJdP9&index=18
