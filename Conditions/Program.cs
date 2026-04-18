namespace Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Collaborations are based on contracts.");
            Console.WriteLine("A contract can be explicity defined in terms of a \"method signature\" or an \"interface\"");
            Console.WriteLine("But a contract can be explicity express in terms of its conditions of use and its after effect guarantiees");
            Console.WriteLine("So as the book says, this is fine print of the contract");
            Console.WriteLine("Sometimes this is expressed in terms of data types");
            Console.WriteLine("Since C# is a strongly typed language, it would be difficult to send data to a collaborator that is of the incorrct data type");
            Console.WriteLine("It is defined in its method sigantures the types of input that it will accept");
            Console.WriteLine("In other circumstances like in a dynamic situation , we may not know ahead of time and so it would have to be the fine print would have to be expressed throught runtime exception");
            Console.WriteLine();
            Console.WriteLine("There are implicit ways of enforcing the fine print of the contract and that one of the implicit ways ytou can to that is throught structured exception handling in C#");
            Console.WriteLine("So every component has to trust its collaborators to be able to do the work that it been assigned to do.");
            Console.WriteLine("We have to be able objects have to to able to trust one another");
            Console.WriteLine("So this verification is usually in the form of input validation");
            Console.WriteLine("We are cheking to ensure that the data type is correct data if dynamic types are involved");
            Console.WriteLine("We are checking to ensure that the data is not null as it comes in through our method signature");
            Console.WriteLine("We are checking to ensure that data falls within accepted range of boundaries and so on");
            Console.WriteLine();
            Console.WriteLine("Ideally there would be some declarative way to include this fine print up front");
            Console.WriteLine("Usually it is just sufficient to just use existing exception objects that are buil into NET framework or create custom exceptions that are based on system.exceptions");
            Console.WriteLine("We rely on C# try catch and finally yo safeguard collaborative messages to ensure that they are successful and that they dont violate the fine print of the constract");
            Console.WriteLine("Then finally i guess another way to make sure that objects abide by the fine print of the contract is through unit testing");
            Console.WriteLine("We can make sure that as we refactor our code over time we haven't regressed and introduced some violation of the fine print of the contract for a particular method in our object");
            Console.WriteLine();
            Console.WriteLine("I suppose you caould say each object should provide and after effect guarantee");
            Console.WriteLine("You give me valid input, i guarantee the output");
            Console.WriteLine("We explicity define the after effect guarantees contractually in our method return types");
            Console.WriteLine("We are back to we are acceptin certain input types and we are returnign values of a certain output type. THat only garanties the data type.");
            Console.WriteLine("That' s that may not be enough. Here again we have to make a decision and it usually comes down to how much should the object trust its collaborators ");



        }
    }
}
