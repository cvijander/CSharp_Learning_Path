namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Object oriented programming is all about boundaries and relationships and communication across those bondaries");
            Console.WriteLine("Through the relationships that objects have with one another");
            Console.WriteLine();
            Console.WriteLine("The major tenets of object-oriented programming");
            Console.WriteLine("The word tenet is not a word that we use frequently. It is defined as a principle or a belief, especially one of the main pricniples of a given religion or philosophy");
            Console.WriteLine("We use the term tenant to express some of the highest guiding principles and concepts in object-oriented programming from which all the other things flow that we will learn about");
            Console.WriteLine();
            Console.WriteLine("There are four tenets of object-oriented programming.");
            Console.WriteLine("1. \"Encapsulation\"");
            Console.WriteLine("2. \"Inheritance \" ");
            Console.WriteLine("3. \"Polymorphism \" ");
            Console.WriteLine("4. \"Abstraction \"");
            Console.WriteLine();
            Console.WriteLine("Encapsulation ");
            Console.WriteLine("Encapsulation is a mechanism that is used to hide the implemetation details of a class");
            Console.WriteLine("This will take several different forms");
            Console.WriteLine("Class is made up of information, typically fields of information , and then it is made of functions which we call  object oriented methods ");
            Console.WriteLine("Those methods operate on the information the fields, or use that information in some way to perform a task that we have delegated to it");
            Console.WriteLine("It has a responsability.We have delegated that responsability ");
            Console.WriteLine("We encapsulate the information to be hidden from other classes first of all, and we restict access to that information");
            Console.WriteLine("We restict access to fields, throught use of properties");
            Console.WriteLine();
            Console.WriteLine("Property consist of two parts.It has getter and setter.They are really two methods, although they dont look like methonds in full definition of a property  ");
            Console.WriteLine("We can use these property getters and setter methods as gatekeepers. They protect the data the underlying fields of information to ensure that data is set to a proper value within a certain range of accepted values");
            Console.WriteLine("Perhaps from a getting standpoint it is only available to people with certain permissions in the system ");
            Console.WriteLine("Like shown down in class Car");
            Console.WriteLine();
            Console.WriteLine("We might also encapsulate all of the functionality of a method behind a couple of public methods");
            Console.WriteLine("So we might break up a task that we delegate to a method into several helper methods ");
            Console.WriteLine("We might do it for a number of different reasons, not the least of which is for readability or for just to keep things scoped in a more manageable sort of way");
            Console.WriteLine("We can choose to hide a the private implementation details using the word private and expose one method that will make calls into those private methods, and expose that use the keyword public");
            Console.WriteLine();
            Console.WriteLine("The concept of encapsulation");
            Console.WriteLine("Analogy with a nosy friend, somebody who wants to know a little bit too much about your private life and maybe even wants to insert themselves into your private world");
            Console.WriteLine("We want our objects to have healthy relationships whenver they collaborate with each other");
            Console.WriteLine("An object that share too much information about its own implementation invites others to use the object in unintended ways ");
            Console.WriteLine("Let just say that our private method its tied to uor objects private implementation of its responsabilities");
            Console.WriteLine("If  i were able to call into one of the private methods here, I could never replace car or it would be difficult for me to replace this class with another class because this code knows way too much bout how this class does its job");
            Console.WriteLine("If you try to replace this object with a new version , the entire application becomes broken. Why? Because the object that this interacts with knows way too much about the object that is is interacting with");
            Console.WriteLine("It is abusing the proper contract of a work agreement");
            Console.WriteLine("So your object should share as little as possible in order to do its work");
            Console.WriteLine("This makes for a cleaner collaborative relationship between your object and other objects");
            Console.WriteLine("It means your object can more be more easily replaced with a different object that has the same basic interfaces in terms of the method signatures and such but with a different implementation");
            Console.WriteLine();
            Console.WriteLine("Encapsulation is the first tenant of object-oriented programming. ");
            Console.WriteLine("It contributes to helping us build more maintainable code because it enforces boundaries in a collaborative relationship");





            






            Console.ReadLine();

        }
    }

    class Car
    {
        private int myVar;

        public int MyProperty
        {
            get
            {
                // Only reveal this to 
                // users with certain rights 
                // in the system 
                // if (User.Role = "Admin")

                return myVar;
            }
            set
            {
                // Does this value make sense ? 
                // if (value < 0 or > 2000)

                myVar = value;
            }
        }

        public void Display()
        {
            var value = CreateDisplay();
            Console.WriteLine(value);
        }

        private string CreateDisplay()
        {
            return $"Car: {myVar}";
        }

    }
}


// https://www.youtube.com/watch?v=FG-JDZ5FJa0&list=PLqT8wAi-pOx7X3i6Vynm57MCwFpQWJdP9&index=16