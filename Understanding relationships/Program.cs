namespace Understanding_relationships
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("People eho are codependent");
            Console.WriteLine("Wikipedia says excessive reliance on othe people for approval and a sense of identity leads to all sorts of issues for humans");
            Console.WriteLine("They become enablers for each other with regards  to substance abuse like alcoholism, drugs, gambling, addictions");
            Console.WriteLine("Less over like immaturity or irresponsibility or even underachievement");
            Console.WriteLine();
            Console.WriteLine("But objects can form unhealty relationships with each other as well");
            Console.WriteLine("Some dependency is completely necessary ");
            Console.WriteLine("No object is an island unto itself");
            Console.WriteLine("Object should and must collaborate together");
            Console.WriteLine("But when a relationship becomes unhealthy is when we begin to notice certain telltale signs of unbreakable codependence, which in programming circle is known as coupling");
            Console.WriteLine("So we should strive to design objects that have low coupling");
            Console.WriteLine();
            Console.WriteLine("The most obvious sign of an unhlethy relationship is when we notice that one concrete object is directly creating and instance of another concrete object in order to collaborate with each other");
            Console.WriteLine("Now that could be a helathy relationship if two objects are living in the same neighborhood like we discussed several lessons ago");
            Console.WriteLine("Remember with boundaries. So from a domain responsability and application responsability perspective, if you have two objects in the same domain responsability and in the same architectual layer , then you are probabbly ok");
            Console.WriteLine();
            Console.WriteLine("But if two objects are engaged in interboudary relationships and one creating a concrete instance of the other one using the new keyword, then you might have a problem , and you probably want to break that dependency");
            Console.WriteLine();
            Console.WriteLine("First is when a domain specific object has a direct dependency on a application specific object");
            Console.WriteLine("Then we violated the separation of concerns principle");
            Console.WriteLine("In this particular case violating ther saparation of concerns principle mean is problematic because our domain layer is now permanently bolted onto a implementation of our persistence layer");
            Console.WriteLine("Because we used the new keyword to create directly create a concrete object from one layer in another layer ");
            Console.WriteLine("This will limit us in several different ways ");
            Console.WriteLine("It is going to limit us our ability to swap out implementations of our persistent objects, which in turn limits our ability to unit test our domain object and grow confident in its ability to implement the fine print");
            Console.WriteLine("We will solve it thorough inversion of control and dependency injection");
            Console.WriteLine();
            Console.WriteLine("We have a car, which I would classify as a domain object.");
            Console.WriteLine("But we see it does have a method where it is creating a new incance of this other class called CarPersitence to file ");
            Console.WriteLine("Ant this is what I would call an application specific object");
            Console.WriteLine("The object would probably live in another project in our solution");
            Console.WriteLine("It would be typically be a class library that we would assign  the responsability of being a persistence layer");
            Console.WriteLine();
            Console.WriteLine("");
            Console.WriteLine("414 -1057 ali pogledaj ponovo");

            var car = new Car() { Make = "GMC", Model = "Yukon", Year = 2013 };


            Console.WriteLine("Finished");


            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public void Save()
        {
            // here is the problem !! 
            var file = new CarPersistenceToFile();

            // "NEW is GLUE"

            file.SaveCar(this);
        }
    }

    class CarPersistenceToFile
    {
        public void SaveCar (Car car)
        {
            var record = $"{car.Make} {car.Model} {car.Year}";
            string path = @"C:\Couplingecxample";
            DirectoryInfo di = Directory.CreateDirectory(path);
            System.IO.File.WriteAllText(@"C:\CouplingExample\Car.txt", record);
        }
    }
}



// https://www.youtube.com/watch?v=yQR-3U8bBoM&list=PLqT8wAi-pOx7X3i6Vynm57MCwFpQWJdP9&index=20