namespace performing_reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reflection allows us to inspect types and to see what they are just like type of and get type");





            var mbr = new MasterBedroom() { Width = 10, Length = 12 };

            Console.WriteLine(mbr.GetType().ToString());

            Console.WriteLine(typeof(MasterBedroom).ToString());

            Console.WriteLine(typeof(Kitchen).IsSubclassOf(typeof(Room)));
            // da li je klasa Kitchen dete od klase Room 

            Console.WriteLine(typeof(MasterBedroom).IsSubclassOf(typeof(Bedroom)));
            // da li je maste dete od bedroma jeste 

            Console.WriteLine(typeof(MasterBedroom).IsSubclassOf(typeof(Room)));
            // jeste mada je to unuk ali opet jeste 





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
