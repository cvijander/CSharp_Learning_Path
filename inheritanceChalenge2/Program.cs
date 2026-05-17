namespace inheritanceChalenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pay an hourly employee Bob who work for 40 hours 
            // Bob's hourly rate is $27.50


            // Pay a salaried employee Steve who works one week.
            // Steve's yearly salary is 50,000

            var Bob = new HourlyEmployee();
            Bob.Name = "Bob";
            Bob.HourlyRate = 27.5;
            Bob.HoursWorked = 40;

            List<Employee> employees = new List<Employee>();
            employees.Add(Bob);

            var Steve = new SalariedEmployee();
            Steve.Name = "Steve";
            Steve.YearlySalary = 50000;
            Steve.WeeksWorked = 53;
            employees.Add(Steve);


            PayEmployee(employees);

            Console.ReadLine();
        }

        static void PayEmployee(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                employee.PayEmployee();
            }
        }
    }

   abstract class Employee
    {
        public string Name { get; set; }
        public abstract void PayEmployee();
       
    }

    class HourlyEmployee : Employee
    {
        public double HourlyRate { get; set; }

        public double HoursWorked { get; set; }

        public override void PayEmployee()
        {
           
            double amount = HourlyRate * HoursWorked;
            Console.WriteLine($"{Name} is paying {amount:C} for his work");
        }
    }

    class SalariedEmployee : Employee
    {
        public double YearlySalary { get; set; }

        public double WeeksWorked { get; set; }
        public override void PayEmployee()
        {
            double amount = YearlySalary / WeeksWorked;

            Console.WriteLine($"{Name} si paying {amount:C} for his work");
        }
    }
}



// https://www.youtube.com/watch?v=Ee24JZXYjoQ&list=PLqT8wAi-pOx62b1ITQTnf7fqbzKrNqz7O&index=14