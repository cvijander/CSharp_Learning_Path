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
            Console.WriteLine("Than I just want to talk about the different roles that object can play in a system and talk about how we separate concerns out by the type of role ");
            Console.WriteLine("Now this is not object stereotyping. ");
            Console.WriteLine("I m looking at this now from a different facet and there are really two different roles that an object can play . There are \"domain specific objects\" and there are \"application specific object\"");
            Console.WriteLine("Domain specific object");
            Console.WriteLine("Domain specific objects are objects that are used to model real world into an abstraction that we use in our conceptual machinery to create a solution");
            Console.WriteLine("Application specific object");
            Console.WriteLine("Those are objects that are required in order to perform system related tasks. We will use them for persistence for display , whether it be on a computer display or web page");
            Console.WriteLine();
            Console.WriteLine("Domain specific objects are born from an analysis of our problem domain nad these represent again abstractions of the real world specific to our particular type of application");
            Console.WriteLine("Domain objects represent concepts that will probably be familiar to users and exprerts within given specific field of interest");
            Console.WriteLine("The domain is made up of information and services that the user need along withs structures that can relate the two both information and services");
            Console.WriteLine("There are also containters for domain logic or business logic code , logic that is expressed purely in domain terms");
            Console.WriteLine("You can see it those instances, we are speaking now purely in terms of terminology that could be understood by domain expert, a tax expert etc ");
            Console.WriteLine("So those are going to be domain objects. Thay are concerned about the problem domain, not about all the other junk that has to go on to make this into a computer system");
            Console.WriteLine();
            Console.WriteLine("That's where application specific objects come into play .Application specific objects are born purely from our own imagination and are kind of like bridges between the domain world and the software world");
            Console.WriteLine("We are going to write these application specific objects to kind of wrap around the computer world so that it can interact with our domain world");
            Console.WriteLine("We will create a set of objects that interface with the network with the screen,output some file format like HTML or XML , or JSON. It will act with interact with the database for persistence or some cashing etc");
            Console.WriteLine("That the job of an application specific object to kind of be that bridge between the business world and the physical world");
            Console.WriteLine("Entity framework is really a good example of marrying these two world together. Some of this is done automatically for you. It will generate code for you based on some tooling in Visaul studio that will make this whole process a little bit easier");
            Console.WriteLine();
            Console.WriteLine("We may have other objects that perform the role of coordination between the domain and the physical computer system Api. We usually cal those \"Services\"");
            Console.WriteLine("WE may have still other objects that perform more utilitarien functions in the system. This might be a good candidate for reuse ");
            Console.WriteLine("If we need to process a given file in a specific way in our system, there is a cnahce that other people in our organization might need that same processing feature");
            Console.WriteLine("They may need to save the data in a specific file format specific ti your company or maybe just, a file format that' new and nobody else has built a library around");
            Console.WriteLine("And others can then gain the benefit of it by you taking those application specific objects and kind of packaging them up in a certain way and then being able yo share those object in a package with orhers");
            Console.WriteLine("Great example of this is actually JSON.NET  by James Newton King of Newtonoft - even Microsoft new API rely on JSON.NET for handling JSON");
            Console.WriteLine("Ideally, you would collect those object togeher, separating them into neighborhoods of concerns , and then package them up for reuse");


            Console.ReadLine();
        }
    }
}
// https://www.youtube.com/watch?v=x6AHfLJN8SY&list=PLqT8wAi-pOx7X3i6Vynm57MCwFpQWJdP9&index=12