namespace DomainVSApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The principle of separation of concerns.");
            Console.WriteLine("The notion of the separation of concerns is true at so many different levels");
            Console.WriteLine("Whether it be from a macro or a micro perspective");
            Console.WriteLine("At an architectual level, the way that we used it previously ,we saw how useful that idea was");
            Console.WriteLine("but now we are going to apply to a much granular level with regards to objects and responsabilities that we assign to them");
            Console.WriteLine();
            Console.WriteLine("SOLID pattern -");
            Console.WriteLine("each letter is an acronym for one principle of object-oriented programming from an object design perspective");
            Console.WriteLine("S - single responsability principle (SRP) - separation of concerns - A class should have only one reason to change, meaning it should perform exactly one job ");
            Console.WriteLine("O - Open/closed principle (OCP)  - Software entities (classes, modules,functions ) should be open for extension, but closed for modification");
            Console.WriteLine("L - Liskov substituiton principle (LSP) - Derived class must be completely substituatable for their base classes without breaking the application");
            Console.WriteLine("I - Interface segregation principle (ISP) - A class should not be forced to implement interfaces and methods that it does not use");
            Console.WriteLine("D - Dependency Inversion Principle (DIP) - High-level modules should depend on avstraction (like interfaces) not on concrete implementations");
            Console.WriteLine();
            Console.WriteLine("Than I just want to talk about the different roles that object can play in a system and talk about how wr separate concerns out by the type of role ");
            Console.WriteLine("Now this is not object stereotyping. ");
            Console.WriteLine("I m looking at this now from a different facet and there are really two different roles that an object can play . There are \"domain specific objects\" and there are \"application specific object\"");
            Console.WriteLine("Domain specific objects are objects that are used to model real world into an abstraction that we use in our conceptual machinery to create a solution");







            Console.ReadLine();
        }
    }
}
// https://www.youtube.com/watch?v=x6AHfLJN8SY&list=PLqT8wAi-pOx7X3i6Vynm57MCwFpQWJdP9&index=12