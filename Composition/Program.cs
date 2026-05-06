namespace Composition
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Final relatioship related topics for this course");
            Console.WriteLine();
            Console.WriteLine("1.  Association , a normal healthy relationship between two objects");
            Console.WriteLine("2.  Aggregation, which is a more permanent relationship where one object keeps references to other instances of objects");
            Console.WriteLine("However if that object were to go away, the objects that it references dont necessarily go away");
            Console.WriteLine("There are two properties of the relationship. There is life cycle , do these live on their own and die on their own");
            Console.WriteLine("Second there is ownership where at some point in time one object will essentialy own references to other ones");
            Console.WriteLine();
            Console.WriteLine("3.  Composition , which is a stronger version of aggregation");
            Console.WriteLine("In composition, the child simply cannot exist without its parent");
            Console.WriteLine("House and rooms . If you destroy the house, the rooms will be also destroyed");
            Console.WriteLine("House and room class, room class is designed inside the boundaries of a house class");
            Console.WriteLine("We have defined a class inside a class, that is one way of denoting ownership of one object to another");
            Console.WriteLine("Composition is both ownership and it denotes lifetime");
            Console.WriteLine("When we destroy the house, the kitchen should be gone as well");
            Console.WriteLine("We have to change the access modifier from public to protected in room class");
            Console.WriteLine("Composition is an interesting way to delegate responsabilities to your application");
            Console.WriteLine();
            Console.WriteLine("Well known idiom  which says \" favor composition over ihneritance\"");
            Console.WriteLine("It is an advice because word favor is used , which means you shoudl prefer");
            Console.WriteLine("Wikipedia page - Composition over inheritance");
            Console.WriteLine("We are calling implementation inheritance , not interface inheritance");
            Console.WriteLine("It says to favor composition over inheritance, is a design principle that gives the design higher flexibility");
            Console.WriteLine("It is more natural to build bussiness domain classes out of various components which means classes than trying to find commonality between them nad creating a family tree");
            Console.WriteLine("Gas pedal and a wheel share very few common traits, yet they are both vital components of a car. ");
            Console.WriteLine("Composition also provides a more stable bussiness domain in the long term as it is less prone to the quirks of the family members");
            Console.WriteLine("It is better to compose what an object can do with  \" a has a \" relationship than extend what it is with an \"is a \" relationship that you get with inheritance");
            Console.WriteLine("Interface inheritance that the initial design is simplified by identifing system object baheviours in separate interfaces instead of creating a hierarhical relationship to distribute behaviours among bussiness domain classes via inheritance");
            Console.WriteLine("This approach more easily accommodates future requiremnt changes that would otherwise require complete restructuring of the bussiness domain classes in the inheritance model");
            Console.WriteLine("Additionaly it avoids problems often associated with relatively minor changes to an inheritance based model that includes several generations of classes");
            Console.WriteLine("When it comes to inheritance , you should use it sparingly");
            Console.WriteLine("In domain context, less inheritence you use it, it is better ");
            Console.WriteLine("In application specific object than it might make sense to employ more inheritance");
            Console.WriteLine("You should prefer the simplicity of composition over inheritance"); 












            Console.WriteLine("1239 - 1456");

            var house = new House();

            //  var room = new House.Room() { Name = "Kitchen" };
            // house.Rooms.Add(room);

            house.AddRoom("Kitchen");

            house.Display();

            Console.WriteLine(house.RoomsCount());

            // Important 

            house = null;

            Console.WriteLine("House is destroyed here");

           //Console.WriteLine(house.RoomsCount());
          //  room.Display();

            Console.ReadLine();
        }
    }

    class House
    {
        protected List<Room> Rooms { get; set; }

        public House()
        {
            Rooms = new List<Room>();
            var room1 = new Room() { Name = "Bedroom 1 " };
            var room2 = new Room() { Name = "Bedroom 2 " };
            var room3 = new Room() { Name = "Bedroom 3 " };
            Rooms.Add(room1);
            Rooms.Add(room2);
            Rooms.Add(room3);
        }

        public void AddRoom(string name)
        {
            var room = new Room() { Name = name };
            Rooms.Add(room);
        }

        public int RoomsCount()
        {
           return  Rooms.Count;
        }

        public void Display()
        {
            foreach (var room in Rooms)
            {
                room.Display();
            }
        }

        // to get this to work as a true Composition
        // example, you have to change from Public
        // to Protected
        // A protected member is accessible within its class 
        // and by derived class intances.
        // In this case, it won't be accessible to the Program class 

        protected class Room
        {
            public string Name { get; set; }

            public void Display()
            {
                Console.WriteLine($"Room: {Name}");
            }
        }
    }
}


// https://www.youtube.com/watch?v=4k50veECCHw&list=PLqT8wAi-pOx7X3i6Vynm57MCwFpQWJdP9&index=23
