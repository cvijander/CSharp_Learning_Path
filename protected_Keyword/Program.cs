using Microsoft.VisualBasic;

namespace protected_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We can implement helper methods that are accesible for any of our children but not allow any out classes outside of our family of inheritance hierarchy to actually access ");
            Console.WriteLine();
            Console.WriteLine("Protected");
            Console.WriteLine("Protected keyword is a member access modifier that makes a member accessible within its class and by derived class inheritance");



        }
    }

    class Player
    {
        public string Name { get; set; }

        public int Strength { get; set; }
        public virtual void Attack()
        {

            var amount = GenerateRandomNumber(Strength);
            Console.WriteLine($"{Name} attacked for {amount} damage.");
        }

        protected int GenerateRandomNumber (int maxAmount)
        {
            Random random = new Random();
            return random.Next(maxAmount);
        }
    }

    class Warior : Player
    {
        public int Bonus { get; set;  }

        public override void Attack()
        {

            int amount = GenerateRandomNumber(Strength) + Bonus;
            Console.WriteLine($"{Name} charges for {amount} damage (incledes + {Bonus} bonus).");
        }
    }

    class Wizard : Player
    {
        public int Energy { get; set; }

        public override void Attack()
        {
            base.Attack();
            int amount = GenerateRandomNumber(10);
            
            Energy -= amount;

            Console.WriteLine($"   (Wizard {Name}  depleted {amount} energy ).");
        }
    }
}



// https://www.youtube.com/watch?v=1K4AenTog1Q&list=PLqT8wAi-pOx62b1ITQTnf7fqbzKrNqz7O&index=7