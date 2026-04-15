namespace Roles
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("APPLICATION DESIGN");
            Console.WriteLine("Using several different complimentary perspectives");
            Console.WriteLine();
            Console.WriteLine("Application    - A set of interacting objects");
            Console.WriteLine("Object         - An implementation of one or more roles");
            Console.WriteLine("Role           - A set of related responsibilities");
            Console.WriteLine("Responsability - An obligation to perform a task or know information");
            Console.WriteLine("Collaboration  - An inraction of objects or roles (or both)");
            Console.WriteLine("Contract       - An agreement outlining the terms of collaboration");


            Console.WriteLine("Each object plays a role. It plays a part of larger conceptual machine");
            Console.WriteLine("We delegate one or more responsabilities to an object and it now has the obligation to  take care or that task or to hold that information");
            Console.WriteLine("We are depending on it to do its job, so that the machine as a whole can function correctly. If he does not do its job, then the machine will have an issue");
            Console.WriteLine("We have a need and we delegate the responsibilities to take care of that need to an object ");
            Console.WriteLine("Whenever we devise our conceptual machine, there might be several different objects. Perhaps i Should use terms classes when i am talking about object here");
            Console.WriteLine("There's several different classes or objects that that could do what we need in a given situation. Perhaps some are better suited than others in a certain situation");
            Console.WriteLine("There might be some interchangebility in the objects or rather the classes that we ll rely on to fill a specific role in our system");
            Console.WriteLine("We choose one, the one that's best suited for our specific need in given area of the system.We rely on it to do its job potentially milions of times without fail");
            Console.WriteLine("Now that object will play an inportant role in our conceptual machine in our system.");
            Console.WriteLine("An object should really be good at just doing a few things");
            Console.WriteLine("And the scope of its capabilities should be fairly narrow focused");
            Console.WriteLine("We might call a well designed very focused object highly cohesive because its entire construction ,its properties, its methods, its events. they are all focused on just accomplishing one little thing");
            Console.WriteLine("Coonversely if we had a single machine capable of taking on several different responsabilities on our assembly line, it sound great, but when we need to maintain that machine");
            Console.WriteLine("This is going to be more complex to fix it whenver its breaks.Is it flexible enought to do everything we will ever need in the future.");
            Console.WriteLine("Is it possible that we are limited ourselves and we are made it more difficult to take that one machine out of our factory and replace it with smaller more focused mashines because we rely on it to do so much fo us ");
            Console.WriteLine("We may describe that machine as low cohesion because it is doing all bu herself ");
            Console.WriteLine();
            Console.WriteLine("So in general in object-oriented programming we want to assign responsabilities to very focused objects that can do one thing and they do them very well");
            Console.WriteLine("That object will play an important role in the system. But if our needs ever change over time, it;s good to know that we can swap out a given object and give it its responsabilities to a similar but diffrenet object");
            Console.WriteLine("That can perform the same role and do the same responsabilities but just do it a little bit differenty- but have little impact on the overall operation of the conceptual system");
            Console.WriteLine("Liskoff substitution principle . The L in the acronym solid  ");
            Console.WriteLine("Perhaps the most important set of principles for modern day object oriented programming ");




            Console.ReadLine();
        }
    }
}


// https://www.youtube.com/watch?v=v_RcAeRSbI8&list=PLqT8wAi-pOx7X3i6Vynm57MCwFpQWJdP9&index=8 