namespace ComponentsAsNeighborhoodsOfObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Sometimes it is a good idea to package neighborhhods of collaborating objects together inside if component for redistribution or for sharing");
            Console.WriteLine("Component is simply just a reusable package of objects that we defined");
            Console.WriteLine("In a different programming languages and operating system and frameworks this will take different forms");
            Console.WriteLine();
            Console.WriteLine("In the .NET wolrd it usually take the form of \"Class library\"");
            Console.WriteLine("You  have a class library project. When you compile a class library project, it is going to create a net assembly");
            Console.WriteLine("Typically, the net assembly will have a DLL file extension. Inside that assembly, we have a number of classes");
            Console.WriteLine("We defined a neighborhood of classes that all kind of contribute to do something meaningful");
            Console.WriteLine("Like Newtonoft's JSON.NET library - this is a great example of functionality of classes that were compiled together into a component for redistribution");
            Console.WriteLine();
            Console.WriteLine("We also get in .NET world a NuGet - for a distribution from a centralized repository version and dependency management");
            Console.WriteLine("Reuse is one of the benefits of object-oriented programming ");
            Console.WriteLine("This used to be considered the holy grail of object-oriented programming . We write it once, we will never have to write it again");
            Console.WriteLine("It took time and a lot of failuires. That is why we have principles that we have today because a lot of lessons were learned in that time");
            Console.WriteLine("But it would no longer weas the holy grail. It kind of became something that everybody said was impossible to achieve in reality");
            Console.WriteLine("The same is true with neighborhoods of objects. Object should stay in their neighborhood based on their zoning or their purpose.");
            Console.WriteLine("Now in practical terms i suppose it means first of all that ideally components shoud contain either domain specific objects od application specific objects");
            Console.WriteLine("But not both, when you are mixing that boundary then you are definitily oversteping two zones");
            Console.WriteLine();
            Console.WriteLine("Second implication is that i think ideally components shoudl be narrowly foacused on a very specific task");
            Console.WriteLine("Third thing to consider is that ideally component should define interfaces that allow its dependencies to be sent or delivered or injected into it");
            Console.WriteLine();
            Console.WriteLine("Dependency injection and inversion of control");
            Console.WriteLine();
            Console.WriteLine("The fourth observation along these lines is that ideally components should be composed if neighborhoods of objects that are engaged in similar work or have similar goals");
            Console.WriteLine();
            Console.WriteLine("These sorts of things, these neightborhood associations, these zoning laws, will begin to reveal themselves when we begin to look at the types of messages that are going to be excanged betwwen objects");
            Console.WriteLine("Ther will be some natural organic segregation of components based on their common goals");
            Console.WriteLine("Idiom - birds of a feather flock together - should be observed and shoud be honored whnoever we are thinking about packaging classes, objects into own neightborhoods for reuse ");
            Console.WriteLine("Not only does this keep collaborating objects in their own neighborhoods and help reusability, but it is also a mechanism that can be used for human collaboration");
            Console.WriteLine();
            Console.WriteLine("The Ability to divide up a large piece of work and conquer it with several different members or teams, this is one of the things that makes object-oriented programming so appeling");
            Console.WriteLine("It is all possible whenver we are planning ahrad of time and designing our objects and putting them in their natural neighboroods and then repacking those neightborhoods into components for reusability");

            Console.ReadLine();


        }
    }
}


//  https://www.youtube.com/watch?v=PEIdQdvEYvk&list=PLqT8wAi-pOx7X3i6Vynm57MCwFpQWJdP9&index=13