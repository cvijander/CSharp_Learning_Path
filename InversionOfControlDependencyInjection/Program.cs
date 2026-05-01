namespace InversionOfControlDependencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How to break up an unhealthy relationship between two of our objects ");
            Console.WriteLine("We invert the control of dependencies instead of as we  have here. Instead The domain object depending on our persistence object ,we are going to flip the dependency so that the persisten object depends on the domain object instead");
            Console.WriteLine("When the domain object knows that it needs services from the persistence layer architectually, it must rely on an outsider to coordinate that interaction and inject that dependency into it");
            Console.WriteLine("Whenever we want to unit test that domain object it is coupled too strongly to the persistence layer object");
            Console.WriteLine("It can't be isolated and we can't examine it to make sure that it by itself will fullfill tha as i have been using the terms the details  of the contract");
            Console.WriteLine("So we have to rewrite the domain object and help it rehabiliate it so that it will say I know I need some help ");
            Console.WriteLine("I am not going to be tied down to just one object because that not healthy for me. Instead I am going to publish contract and an interface ");
            Console.WriteLine();
            Console.WriteLine("First thing is we are going to define an interface. And this is from the perspective of the consumer of the service");
            Console.WriteLine("Car is going to consume the services of a persistence object. So it needs to be the one defining what the contract terms are ");
            Console.WriteLine("Right there between car nad car persistence , we will put interface ");
            Console.WriteLine("The next step is then for any class that wants to be persistence for the car it need to implement this interface");
            Console.WriteLine("We are allowing to CarPersistence class to inherit interface");
            Console.WriteLine("Now in the car class we are going to remove a direct dependency ");
            Console.WriteLine("In class car we are going to construct dependency injection ");
            Console.WriteLine("In class car we are defining \"  private IICarPersistence _carPersistence; \"");
            Console.WriteLine("With this we created a private field , this will hold on to a reference of what object we are going to use to do the persistence");
            Console.WriteLine("Here in constructor , i am going to demand that you give me that object ");
            Console.WriteLine("We are going to pass it in as an argument to the constructor and then we will hold to an reference to it ");
            Console.WriteLine("In Car constructor we are passing CarPersistece  and inside we are asising carPersistence to _carPersistence");
            Console.WriteLine("Now we can change to var file = _carPerisitance  or even beter to only _carPersisitence.SaveCar()");




            Console.WriteLine("251 - 1317");



            var car = new Car() { Make = "GMC", Model = "Yukon", Year = 2013 };
            car.Save();


            Console.WriteLine("Finished");


            Console.ReadLine();


            Console.ReadLine();
        }
    }


    class Car
    {
        private IICarPersistence _carPersistence;
        
        public Car (IICarPersistence carPersistence)
        {
            _carPersistence = carPersistence;
        }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public void Save()
        {
            // var file = new CarPersistenceToFile();

            var file = _carPersistence;

            file.SaveCar(this);
        }
    }

     interface IICarPersistence
    {
        void SaveCar(Car car);

    }

    class CarPersistenceToFile :IICarPersistence
    {
        public void SaveCar(Car car)
        {
            var record = $"{car.Make} {car.Model} {car.Year}";
            string path = @"C:\Couplingecxample";
            DirectoryInfo di = Directory.CreateDirectory(path);
            System.IO.File.WriteAllText(@"C:\CouplingExample\Car.txt", record);
        }
    }
}



// https://www.youtube.com/watch?v=U01S2M42usU&list=PLqT8wAi-pOx7X3i6Vynm57MCwFpQWJdP9&index=21 