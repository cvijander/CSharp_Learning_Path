namespace Collaboration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("A well defined object supports a clearly defined role in our system.");
            Console.WriteLine("Design is an iterative and incremental process of envisioning objects and their responsabilities and then inventing flexible collaborations between objects to carry those out");
            Console.WriteLine("When it comes to collaboration like we said, there are at least two parties involved ");
            Console.WriteLine("Two objects collaborate because one or both of the objects need somethning out of that relationship");
            Console.WriteLine("So they work in concert to fulfill larger responsabilities inside of the system");
            Console.WriteLine();
            Console.WriteLine("When we are designing collaborations, we have to consider objects as partners working together and not as isolated individuals");
            Console.WriteLine("It is helpful to look at common kinds of types of roles called \"stereotypes\" to better understand what an object is doing in a collaboration relationship");
            Console.WriteLine("In other words, if we look at all the possible things that object can do, we can boil it down to just basically half a dozen typical activities or responsabilities in any system");
            Console.WriteLine("We oversimplify those responsabilites in order to help us focus on the responsabilities at a higher level. So a higher level of abstraction");
            Console.WriteLine();
            Console.WriteLine("OBJECT ROLE STEREOTYPES");
            Console.WriteLine("Oversimplifying and characterizing to understand an object's role more easily");
            Console.WriteLine("PERSPECTIVE");
            Console.WriteLine("INFORMATION HOLDER     - Knows and provides information");
            Console.WriteLine("STRUCTURER             - Maintains relationship between objects and information about those relationships");
            Console.WriteLine("SERVICE PROVIDER       - Perform work and, in general , offers computing services ");
            Console.WriteLine("COORDINATOR            - Reacts to events by delegating tasks to others");
            Console.WriteLine("CONTROLLER             - Makes decisions and closely directs others actions");
            Console.WriteLine("INTERACER              - Transforms information and requests between distinct parts of our system");

            Console.WriteLine("This stereotypes can be used as roles or responsabilities inside of our system for a particular object");
            Console.WriteLine("It is important to keep in mind that  a single object could fit into one of more of these stereotypes");
            Console.WriteLine("Now if it tries to do too much, then maybe it is time to rethink that particular object");
            Console.WriteLine("On the other hand, if the object is simply and information holder and that's all that it is, it might be critized as being \"anemic\"");
            Console.WriteLine("In another words , it might be critized for not doing enought for the system ");
            Console.WriteLine();
            Console.WriteLine("We might describe objects in terms of how many stereotypes that they actually implement");
            Console.WriteLine();
            Console.WriteLine("We might say that an object is smart when it both encapsulates data and that data affect the desisions that particular object makes and how fulfills its responsability");
            Console.WriteLine("We might say that object is pesky object because it has to ask its collaborators for every little detail to perform its responsabilities");
            Console.WriteLine();
            Console.WriteLine("It is trial and error process whenever you are designing objects in their collaborations");
            Console.WriteLine();
            Console.WriteLine("A well designed object supports a clearly defined role");
            Console.WriteLine("Design is an iterative and inceremental process of envisioning objects and their responsabilities and inventing flexible collaborations");
            Console.WriteLine();
            Console.WriteLine("We have one goal in object design and collaboration design and that is to create well defined objects that support a clearly defined role");
            Console.WriteLine("and we iterate through the incremental process of envisioning objects and their responsabilities and inventing flexibile collaborations");
            Console.WriteLine();










            Console.ReadLine();

        }
    }
}
// https://www.youtube.com/watch?v=XHaCJ0tpJLE&list=PLqT8wAi-pOx7X3i6Vynm57MCwFpQWJdP9&index=10