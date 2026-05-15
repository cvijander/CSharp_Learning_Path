namespace performing_reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reflection allows us to inspect types and to see what they are just like type of and get type");
            Console.WriteLine();
            Console.WriteLine("IsSubClassOf()");
            Console.WriteLine("Allows you to determine whether a class inherits from a parent (or grnadparent ) class");
            Console.WriteLine();
            Console.WriteLine("IsInstanceOfType()");
            Console.WriteLine("Same idea, but allows you to work  with instances of classes (ratrher than classes)");
            Console.WriteLine();
            Console.WriteLine("IsAssignableFrom()");
            Console.WriteLine("Determines whether an instance of a specified type can be assigned to an instance of the current type");






            var mbr = new MasterBedroom() { Width = 10, Length = 12 };

            Console.WriteLine(mbr.GetType().ToString());

            Console.WriteLine(typeof(MasterBedroom).ToString());

            Console.WriteLine(typeof(Kitchen).IsSubclassOf(typeof(Room)));
            // da li je klasa Kitchen dete od klase Room 

            Console.WriteLine(typeof(MasterBedroom).IsSubclassOf(typeof(Bedroom)));
            // da li je maste dete od bedroma jeste 

            Console.WriteLine(typeof(MasterBedroom).IsSubclassOf(typeof(Room)));
            // jeste mada je to unuk ali opet jeste 

            Console.WriteLine(typeof(MasterBedroom).IsSubclassOf(typeof(Kitchen)));
            // rezxutlat je false, jer oni pripadaju room ali nisu bas na istoj grani 

            Console.WriteLine(typeof(MasterBedroom).IsInstanceOfType(mbr));
            // vraca true 


            Console.WriteLine();
            Console.WriteLine(typeof(MasterBedroom).IsInstanceOfType(mbr)); // true 
            Console.WriteLine(typeof(Bedroom).IsInstanceOfType(mbr));  // true
            Console.WriteLine(typeof(Room).IsInstanceOfType(mbr)); // true 
            Console.WriteLine(typeof(Kitchen).IsInstanceOfType(mbr)); // false 

            Console.WriteLine();

            Console.WriteLine(typeof(MasterBedroom).IsAssignableFrom(typeof(Bedroom)));
            // false   masterBedrum test1 = new MasterBedrom

            Console.WriteLine(typeof(Bedroom).IsAssignableFrom(typeof(MasterBedroom))); // ovo vraca true.. mada je malo treba bolje skapirati o cemu je pricao 


            Console.WriteLine("320 - 1316 -- pogledati opet ");

            Console.ReadLine();
        }
    }

    class Room
    {

        public int Width { get; set; }
        public int Length { get; set; }
    }

    class Kitchen :Room
    {

    }

    class Bedroom :Room
    {

    }

    class GuestRoom :Bedroom
    {

    }

    class MasterBedroom :Bedroom
    {

    }

}

// https://www.youtube.com/watch?v=KrV-jg-p1nk&list=PLqT8wAi-pOx62b1ITQTnf7fqbzKrNqz7O&index=9 
