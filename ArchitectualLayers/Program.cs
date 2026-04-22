namespace ArchitectualLayers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("You can also split up objects into neighborhoods for the purpose of divvying up worload between team members or entire team");
            Console.WriteLine("There was some natural segregation that will occur based on segragation of the objects based on the type of messages that will be sent and the collaboration that will be shared between objects");
            Console.WriteLine("There will be collaboration preferences that objects demonstrate based on the commonality of the work that certain objects will be tasked with handling");
            Console.WriteLine("Architectual perspective that a layer is composed of several collaborating components that are tasked with the same sort of work but more from a system perspective");
            Console.WriteLine("The classic breakdown is persistence, domain layer, presentation, web services, things of that nature");
            Console.WriteLine();
            Console.WriteLine("When it comes to domain objects you may have some natural divisions between the tasks of the domain objects related to their business function");
            Console.WriteLine("The fact of the matter is that these components all fit into a layer of our software called the domain layer");
            Console.WriteLine("Application specific objects live in components that can fit into the persistence layer, the presentation layer, a web services layer");
            Console.WriteLine();
            Console.WriteLine("So when diving up the responsabilities of the system and assigning them to individual objects we have to keep in mind that there are really two perspective");
            Console.WriteLine("First of all there is the domain responsability");
            Console.WriteLine("Second there is the application responsability");
            Console.WriteLine("And inside of the application specific responsability, there might be objects that know how to handle specific object, or domain object or component from a system perspective");
            Console.WriteLine();
            Console.WriteLine("ARCHITECTUAL LAYERS OF RESPONSABILITY");
            Console.WriteLine("Matrix of Application-Specific and Domain-Specific Objects by Architectual Layer ");
            Console.WriteLine("              | Accounting              |    Marketing             |      Retail              |   Tax            <- Domain Responsability ");
            Console.WriteLine("Presentation  | Application Objects     |   Application Objects    |    Application Objects   |   Application Objects ");
            Console.WriteLine("Domain        | Domain Objects          |   Domain Objects         |    Domain Objects        |   Domain Objects   ");
            Console.WriteLine("Persistence   | Application Objects     |   Application Objects    |    Application Objects   |   Application Objects ");

            Console.WriteLine();
            Console.WriteLine("There is a matrix of sorts that begins to evolve on one axis you have the domain responsability and on the other axis you have the application responsability");
            Console.WriteLine("Each of resulting squares that you get  , they represent a component of objects that are build to handle that particular responsability");
            Console.WriteLine("Each of resulting rows in that diagram ");

            Console.WriteLine("3;20  od 823  tako da ima jos da se vozi ");
        }
    }
}



// https://www.youtube.com/watch?v=Yk8G5Fqd6Hw&list=PLqT8wAi-pOx7X3i6Vynm57MCwFpQWJdP9&index=14