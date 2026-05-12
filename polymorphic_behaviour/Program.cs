namespace polymorphic_behaviour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If we need a child version of parents method be a little different");
            Console.WriteLine("If we needed it to be specialized and look like it belonged to a child class with other properties");
            Console.WriteLine("Now if we the same method from the parent copy paste to child , and also make a disctintive change ");
            Console.WriteLine("Now whenever we are callind the child method it will be displayed");
            Console.WriteLine();
            Console.WriteLine("But it we want to use polymorhism , it means many shapes ");
            Console.WriteLine("If we created a another method who is   private static void DoDrive(Automobile a)\r\n        {\r\n            a.Drive();\r\n        } ");
            Console.WriteLine("Bu when we call this method  inserting a automobile or a truck, we are getting the same result.. we are getting a drive method from a automobile");
            Console.WriteLine("We are getting an original parent method for both parties");
            Console.WriteLine("In order to override use of child method we need to use two keywords ");
            Console.WriteLine("On the child method , we are gona use override modifier in the method signature");
            Console.WriteLine("This is telling C# compiler, I want you to override base implementation with this implementation");
            Console.WriteLine("But now the method is making a red swuiqly line, meaning there is some isuses ");
            Console.WriteLine("Now in order method to work, we must make it to be virtual, abstract or override");
            Console.WriteLine();
            Console.WriteLine("Override ");
            Console.WriteLine("The override modifier is required to extend or modify the abstract or virtual implementation of an inherited member");
            Console.WriteLine();
            Console.WriteLine("Virtual");
            Console.WriteLine("The virtual keyword modifies a member so it can be overriden in a derived class");
            Console.WriteLine("Virtual means, we have an implementation, but if you want a different implmentation you can override me");










            var auto = new Automobile()
            {
                Make = "Toyota",
                Model = "4Runner",
                Year = 2017,
            };

            auto.Drive();


            var truck = new Truck()
            {
                Make = "Toyota",
                Model = "Thundra",
                Year = 2016,
                TowingCapacity = 1000
            };

            truck.Drive();
            truck.Tow();

            Console.WriteLine("----------------");
            DoDrive(auto);
            DoDrive(truck);

            Console.ReadLine();
        }

        private static void DoDrive(Automobile a)
        {
            a.Drive();
        }
    }

    class Automobile
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public int Year { get; set; }


        public virtual void Drive()
        {
            Console.WriteLine($"The {Year} {Make}  {Model} is driving");
        }
    }

    class Truck : Automobile
    {
        public int TowingCapacity { get; set; }
        public int CargoSize { get; set; }

        public override void Drive()
        {
            Console.WriteLine($"The TRUCK {Year} {Make}  {Model} is hauling");
        }

        public void Tow()
        {
            Console.WriteLine($"Now we are towing  {TowingCapacity} pounds");
        }
    }
}



// https://www.youtube.com/watch?v=hLFfRWYvzzo&list=PLqT8wAi-pOx62b1ITQTnf7fqbzKrNqz7O&index=2