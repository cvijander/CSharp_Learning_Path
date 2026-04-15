namespace ThinkingLikeAnOOPConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

                  
           
            ChooseToDisplayMainMenu();           

        }

        public static void MainPage()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("1. Classes, Objects, Properties, Methods");
            Console.WriteLine("2. Private, Public, Static, Instance ");
            Console.WriteLine("3. Inheritance, Abstract, Intefface");
            Console.WriteLine("4. Object BASED Programming");
            Console.WriteLine();



            Console.WriteLine();
            Console.WriteLine("Object oriented programming transcend code in so much that it transcends any give programming language per se");
            Console.WriteLine();

            Console.WriteLine("OO is a mindset");
            Console.WriteLine("A philosophy which drives a way of thinking");
            Console.WriteLine("A world view about problems and solutions");
            Console.WriteLine("A path with a North star");
            Console.WriteLine("Guidance and principles on how to achieve overarching objectives");
            Console.WriteLine();


            Console.WriteLine();
            Console.WriteLine("Object-oriented programming provides a process on how to discover and implement a conceptual machine to realize that desired output.");
            Console.WriteLine("How to decompose a problem in the real world and then build some sort of abstraction in this etherial world in our minds. ");
            Console.WriteLine("Abstraction of that real world problem, and than we will build that abstraction using principles,patterns , that will actually sum up important tenants of object-oriented programming. ");
            Console.WriteLine("Then the end result is that we have designed conceptually designed machine that takes raw materials like data input from the user, and converts those into thinks like data that has been processed,mesaging, activities and so on");
            Console.WriteLine("Those will have meaning in the living world, even if that is a conceptual world like the account world");
            Console.WriteLine();


            Console.WriteLine();
            Console.WriteLine("Software dev religion");
            Console.WriteLine("In other worlds , ita age old wisdom - not a rulebook - that gives you guidance that you must apply situactionally for your specific problem domain.");

            Console.WriteLine();
            Console.WriteLine("Require devotion");
            Console.WriteLine("People devote their entire careers practicing and learning more about Object Orientation and how to apply it in a give situation");
            Console.WriteLine();


            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Goals");
            Console.WriteLine("1. Improve Modularity");
            Console.WriteLine("2. Improve process of Analysis, a Design and Communication of a Problem Domain and a Software Solution");
            Console.ResetColor();
            Console.WriteLine();


            Console.WriteLine("Modularity");
            Console.WriteLine();
            Console.WriteLine("Goal is to incease code modularity");
            Console.WriteLine("\"A change in one module shouldn't break things in other modules\"");
            Console.WriteLine("Improve code maintance, adding or removing features will not break the entire application. It allows us to withstand the impact of change");
            Console.WriteLine("It allows us to build new features, and to make changes to existing features faster and more reliably");
            Console.WriteLine("Enable code reuse");
            Console.WriteLine("* Code Maintenance - adding or removing features, \"change\", faster, more reliably");
            Console.WriteLine("* Enable Code Re-user - packageable and re-useable");
            Console.WriteLine("* Enable Team Collaboration - code broken up into small bits that many can work on, specialists");
            Console.WriteLine("* Enable easier integration - easily abstract and isolate large systems so they can be intechanged");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("2. Improve process of analysis, a Design and Communication of a Problem Domain and a Software Solution");
            Console.WriteLine();
            Console.WriteLine("* Improving the process of breaking down a problem domain and designing a candidate solution and communiaction it to others.");
            Console.WriteLine();
            Console.WriteLine("Using this techiques, these ideas, we begin to look for boundaries in the system and look for the needs and responsabilities");
            Console.WriteLine("Look for a major players are in the system. It also provides a method of decomposition of a problem into smaller pieces.");
            Console.WriteLine("Now once we have identified the major players, and we have kind of begin to give them responsabilities .");
            Console.WriteLine("Here is a need in a system, who should be responsible for it  - further decomposotion of the system into delegating the responsobilities to a given method inside an object. ");
            Console.ReadLine();
        }

        private static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("1 Opcija ");
            Console.WriteLine("2 Opcija");
            Console.WriteLine("3 Opcija");
            Console.WriteLine("4 Opcija");
            Console.WriteLine("5 Opcija");
            Console.WriteLine("Odaberite opcciju od 1 do 5");
        }

        public static void ChooseToDisplayMainMenu()
        {
            bool displayMenu = true;

            while(displayMenu)
            {
                MainMenu();

                string userInput = Console.ReadLine();
                string filteredUserInput = userInput.Trim();

                displayMenu = UserOption(filteredUserInput);
            }
        }

        private static bool UserOption(string input)
        {
                     

            switch (input)
            {
                case "1":
                    MainPage();
                    return true;

                case "2":
                    Console.Clear();
                    Console.WriteLine("Uneli ste 2");
                    Console.ReadLine();
                    return true;

                case "3":
                    Console.Clear();
                    Console.WriteLine("Uneli ste 3");
                    Console.ReadLine();
                    return true;

                case "4":
                    Console.Clear();
                    Console.WriteLine("Uneli ste 4");
                    Console.ReadLine();
                    return true;

                case "5":
                    Console.Clear();
                    Console.WriteLine("Uneli ste  5 napustate program");
                    Console.ReadLine();
                    return false;               

                default:
                    
                    Console.WriteLine("Greska");
                    Console.ReadLine();
                    return true;
            }
           
        }
    }
}
