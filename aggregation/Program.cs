namespace aggregation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Objects sometimes merely collaborate");
            Console.WriteLine("One object need help, it requests help from another object. After they collaborate, the task at hand, they move on with their lives");
            Console.WriteLine("Sometimes , objects share a tighter bond.Like we had in previous lessions ");
            Console.WriteLine();
            Console.WriteLine("There are two special types of relationships that we are going to look at next ");
            Console.WriteLine("Association - that is where you have just a normal collaboration");
            Console.WriteLine("There is relationship between two objects, but each of them ultimately have their own life cycle");
            Console.WriteLine("They dont own each other . There is no other futher relationship between, just one time association");
            Console.WriteLine();
            Console.WriteLine("Aggregation - this is sometimes known as a \"HAS A \" style relationship between objects ");
            Console.WriteLine("It denotes ownership or whole part or a this object is a part of this larger object");
            Console.WriteLine("You have a teacher ,and you have a departments at a give university , and some teacher can exist in muliple departments and a single department can have multiple teacher involved");
            Console.WriteLine("In a sence there is a sense in which departments own teachers. So there is an aggregation ");
            Console.WriteLine("One department can own or have posseed group of multiple teachers , and one teacher could conceivably have multiple departments that belongs to");
            Console.WriteLine("If a teacher were to be eliminated it would not eliminatie the department that she belonged to");
            Console.WriteLine("And vice versa, if you were to eliminate the department, the teacher could find another job at another department in the university");
            Console.WriteLine("But the teacher would still exist");
            Console.WriteLine();
            Console.WriteLine("We are really talking about two properties of the relationship");
            Console.WriteLine("One is life cycle, when do they live and when do they die");
            Console.WriteLine("The other one is ownerships");
            Console.WriteLine("In aggregation there is and ownership between one object and another object, but there is not a direct correlation of life cycle");
            Console.WriteLine("They live and die independent of eachother");

            var car1 = new Automobile();
            var car2 = new Automobile();
            var car3 = new Automobile();

            var person = new Person() { Name = "Bob" };


            var fleet = new Fleet();

            fleet.Automobiles.Add(car1);
            fleet.Automobiles.Add(car2);
            fleet.Automobiles.Add(car3);

            fleet.Owner = person;

            foreach (var auto in fleet.Automobiles)
            {
                auto.Display();
            }

            fleet.Owner.Display();

            // IMPORTANT
            fleet = null;

            Console.WriteLine("Do the aggregated objects still live ? ");


            car1.Display();
            car2.Display();
            car3.Display();

            person.Display();


            Console.ReadLine();

        }
    }

    class Automobile
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public void Display()
        {
            Console.WriteLine($"Auto: {Make}  {Model} {Year}");
        }
    }

    class Person
    {
        public string Name { get; set; }

        public void Display()
        {
            Console.WriteLine($"Person: {Name}");
        }

    }
    class Fleet
    {
        public string Name { get; set; }

        public List<Automobile> Automobiles { get; set; }

        public Person Owner { get; set; }

        public Fleet()
            {
            Automobiles = new List<Automobile>();
        }
    }


}


//  https://www.youtube.com/watch?v=PqSPNC8WqEY&list=PLqT8wAi-pOx7X3i6Vynm57MCwFpQWJdP9&index=22