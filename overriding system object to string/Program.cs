namespace overriding_system_object_to_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Every type in the .NET framework or custom types that we create all inherit form a base class called system.object");
            Console.WriteLine("It happens in complitation time");
            Console.WriteLine("We can override To.String method do display anything that we want");



            // D is souble literal

            var employee = new Employee() { Name = "Fernando", HourlyRate = 15D };

            Console.WriteLine(employee.ToString()); // ovo ce da prikaze naziv projekta i. naziv klase Employee 
            Console.WriteLine(employee.GetType().ToString());  // identican prikaz kao i ovo gore, dakle vraca nam koji je ovo tip, tj naziv projekta. klasa 
            Console.WriteLine(employee.ToString());



            Console.ReadLine();
        }
    }

    public class Employee
    {

        public string Name { get; set; }

        public double HourlyRate { get; set; }

        public override string ToString()
        {
            return $"{Name} is paid {HourlyRate}";
        }
    }
}


// https://www.youtube.com/watch?v=udnUBv_GDZs&list=PLqT8wAi-pOx62b1ITQTnf7fqbzKrNqz7O&index=8