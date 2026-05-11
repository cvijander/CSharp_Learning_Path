namespace introduction_to_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ineritance is one of the fundamental concepts or tenets of object oriented progamming ");
            Console.WriteLine("Inheritance allows one class which we normally refer to as the base class or our parent class.");
            Console.WriteLine("It take one class that has properties and methods and it allows another class to inherit or to have the same methods and properties ");
            Console.WriteLine("Merely by saying i want to inherit from a class");
            Console.WriteLine("Second class which is usually referred to as the child ot the derived class will inherit the properties and methods of the parent or the base class");
            Console.WriteLine("Child class can extend the parent by adding new properties and methods. ");
            Console.WriteLine("So we can make a specialized version of an automobile called truck");
            Console.WriteLine();
            Console.WriteLine("Inheritance alows us to compose a new objects extending the functionality of parent classes ");
            Console.WriteLine("Inheritance enables polymorphic behaviour");



            Console.WriteLine("124 1049");


            var auto = new Automobile
            {
                Make = "Toyota",
                Model = "4Runner",
                Year = 2017
            };

            auto.Drive();

            var truck = new Truck
            {
                Make = "Toyota",
                Model = "Thundra",
                Year = 2016,
                TowingCapacity = 1000
            };

            truck.Drive();
            truck.Tow();

            Console.ReadLine();
        }

        
    }
    class Automobile
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void Drive()
        {
            Console.WriteLine($"The {Year} {Make}  {Model} is driving");
        }
    }

    class Truck: Automobile
    {
        public int TowingCapacity { get; set; }
        public int CargoSize { get; set; }

        public void Tow()
        {
            Console.WriteLine($"Now we are towing  {TowingCapacity} pounds");
        }
    }
}



//   https://www.youtube.com/watch?v=74Uq5_I-lhA&list=PLqT8wAi-pOx62b1ITQTnf7fqbzKrNqz7O