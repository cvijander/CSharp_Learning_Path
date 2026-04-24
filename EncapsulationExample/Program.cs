namespace EncapsulationExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car() { MyProperty = 7 };
            car.Display();
            Console.ReadLine();
        }
    }

    class Car
    {
        private int myVar;

        public int MyProperty
        {
            get {
                // Only reveal this to 
                // users with certain rights 
                // in the system 
                // if (User.Role = "Admin")

                return myVar; }
            set {
                // Does this value make sense ? 
                // if (value < 0 or > 2000)

                myVar = value; }
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
