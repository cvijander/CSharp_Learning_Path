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
            Console.WriteLine("Each of resulting rows in that diagram are a layer of system responsability whether presentation domain etc  ");
            Console.WriteLine("Each of resulting columns represent a slice or a spike of application responsability from a domain perspective");
            Console.WriteLine("It creates a bunch of squares and at the border of each square , that repsersents a logical place where interfaces would exist");
            Console.WriteLine();
            Console.WriteLine("Interfaces between different components in the various areas of domain layer and then obviously interfaces between layers as well between the persistence and the domain and trhe presentation");
            Console.WriteLine();
            Console.WriteLine("We are really talking about building some slice of the application, a fully working set of features that span all the architectual layers");
            Console.WriteLine("Building those classes and components that will interact to perform some subset og all the features that we exprect to see in final application and is so doiung we are provdinig a concrete example of an application throught all the architectual layers");
            Console.WriteLine("It will demonstate the interaction of the component neightborhoods across all the parts of the system to create a mini application that can demonstate to the end user or the project sponsor that hey the application is working");
            Console.WriteLine("But it will also be beneficial in so much that it will demonstrate to other developers on the team how the application will be architected in a very tanglible way");
            Console.WriteLine("We can use that to see all of the layers, all of the components come together to build an entire application");
            Console.WriteLine();
            Console.WriteLine("The objects will collaborate mostly within their own layer and typically even within their own neighborhoods , by functionality, by square");
            Console.WriteLine("In any application when objects reside in different layers and they need to collaborate then client objects are usually above server objects ");
            Console.WriteLine("THe message will start at the top and they will flow mostly downward");
            Console.WriteLine("Information however will flow mostly or result will flow mostly upwards");
            Console.WriteLine("And then when messages flow up in those rare cases where that happens, client objects are in lower layers and they are coupled to their server objects");
            Console.WriteLine("This usually menas that there is some eventing mechanism in play there");
            Console.WriteLine();
            Console.WriteLine("Only the topmost layer and the bottom most layer are really are what you woulkd say are exposed to the outside world");
            Console.WriteLine("The top the presentation layer, at the bottom the persistence layer");
            Console.WriteLine("Those are both platform specific");
            Console.WriteLine("On the top you have to display components, whether that be with HTML,WPF or Xamarian etc ");
            Console.WriteLine("And then on very bottom you have device and external system interfaces, whether it to be the network, to a database server, to a cashicn mechanism");
            Console.WriteLine();
            Console.WriteLine("How the notion of collaboration and responsabilities we begin to put things into containers and categories and things start to get sorted out for us as we begin to understand the design of the system");





            
        }
    }
}



// https://www.youtube.com/watch?v=Yk8G5Fqd6Hw&list=PLqT8wAi-pOx7X3i6Vynm57MCwFpQWJdP9&index=14