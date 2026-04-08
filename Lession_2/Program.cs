namespace Lession_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Book - Object design - roles, responsabilities and collaborations by Rebecca Wars Brock and Alan McKeen. ");
            Console.WriteLine("It is widely regarded as probably one of the best works that captures the philosophy and the heart of object-oriented analysis, design and programming ");
            Console.WriteLine();
            Console.WriteLine("Object machinery - chapter 1");
            Console.WriteLine("All but the simplest of devices, both hardware and software, are designed from parts. These parts interact according to someone's plan.");
            Console.WriteLine("In a physical machine, these parts touch one another or communicate throught a shared medium. Their interactions may give way to force, transfer motion, or conduct heat");
            Console.WriteLine();
            Console.WriteLine("Software machinery is similar to physical machinery. A software application is constructed from parts. These parts -- software objects -- interact by sending messages to request information or action from others");
            Console.WriteLine("Throughout its lifetime, each object remains reponsible for respoding to a fixed set of requests. To fulfill these request, objects encapsulate scripted responses and the information that they base them on");
            Console.WriteLine("If an object is designed to remember certain facts, it can use them to respond differently to future requests.");
            Console.WriteLine();
            Console.WriteLine("So how do we invent these software machines? ");
            Console.WriteLine();
            Console.WriteLine("Building an object-oriented application means inventing appropriate machinery. We represent real-world information, processes, interactions, relationships");
            Console.WriteLine("Even error by inventing objects that don't exists in the real world");
            Console.WriteLine("We give life and inteligence to inanimate things. We take difficult-to-comprehend real-world objects and split them into simpler, more manageable software ones.");
            Console.WriteLine("We invent new objects");
            Console.WriteLine("Each has a specific role to play in the application. Our measure of success lies in how clearly we invent a software reality that satisfies our application's requirements - and not in how closely it resembles the real wolrd");
            Console.WriteLine("Because they have machine-like behaviours and because they can be plugged together to work in concert, object can be used to build very complex machines");
            Console.WriteLine("To manage this complexity, we divvy the system's behaviours into objects that play well-defined roles. If we keep our focus on the behaviour, we can design the application using several complementaty perspectives:");

            Console.WriteLine("APPLICATION DESIGN");
            Console.WriteLine("Using several different complimentary perspectives");
            Console.WriteLine("PERSPECTIVE");
            Console.WriteLine("APPLICATION     ->   A set of interacting objects");
            Console.WriteLine("OBJECT          ->   An implementation of one or more roles");
            Console.WriteLine("ROLE            ->   A set of related responsabilities");
            Console.WriteLine("RESPONSABILITY  ->   An obligation to perform a task or know information");
            Console.WriteLine("COLLABORATION   ->   An interaction of object or roles (or both )");
            Console.WriteLine("CONTRACT        ->   An agreement outlining the terms of a collaboration");
            Console.WriteLine();

            Console.WriteLine("So how do we invent these software machines?");
            Console.WriteLine();
            Console.WriteLine("We invent new objects.");
            Console.WriteLine("Each has a specific role to play in the application.");
            Console.WriteLine("our measure of success lies in how clearly we invent a software reality that satisfies our application's requirements -- and not in how closely it resembles the real world");

            Console.WriteLine("CRUCIAL METAPHOR: SOFTWARE AS A FACTORY / MACHINE");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Think about a car factory (like General Motors).");
            Console.WriteLine("You start with raw materials. You have conveyor belts, presses, robotic arms.");
            Console.WriteLine("Each piece of machinery (Object) has a specific Responsibility.");
            Console.WriteLine("They must work in sync (Contracts/Collaborations) to produce a complex final product (the Car).");
            Console.WriteLine("Software is exactly the same! We design the machinery to accomplish the end result.");
            Console.WriteLine();



            Console.WriteLine("****************************************");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Preporucena literatura ");
            Console.ResetColor();
            Console.WriteLine("Object design - roles, responsabilities and collaboration");
            Console.WriteLine("Autori: Rebecca Wirst-Brock and Alan McKean");
            Console.WriteLine("****************************************");

            Console.ReadLine();

        }
    }
}
//  https://www.youtube.com/watch?v=E675yvO8yqQ&list=PLqT8wAi-pOx7X3i6Vynm57MCwFpQWJdP9&index=1  