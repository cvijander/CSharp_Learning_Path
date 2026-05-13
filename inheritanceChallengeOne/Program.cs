using System.Numerics;

namespace inheritanceChallengeOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var player = new Player() { Name = "Bob", Strength = 20 };
            var warrior = new Warrior() { Name = "Balter", Strength = 100, Bonus = 10 };
            var wizard = new Wizard() { Name = "Pentagorn", Strength = 50, Energy = 50 };

            var players = new List<Player>();
            players.Add(player);
            players.Add(warrior);
            players.Add(wizard);

            DoBattle(players);

            

            Console.ReadLine();
        }

        static void DoBattle(List<Player> players)
        {
            foreach (var player in players)
            {
                player.Attack();
                Console.WriteLine("");
                    
            }
        }
    }




    class Player
    {
        public string Name { get; set; }

        public int Strength { get; set; }

        
        
        public virtual void Attack()
        {

            Random myRandomDamage = new Random();
            int number =  myRandomDamage.Next(0, Strength);

            Console.WriteLine($"{Name} attacked for {number} damage. ");
        }
    }

    class Warrior : Player
    {
        public int Bonus { get; set; }


        public override void Attack()
        {
            Random myRandomDamage = new Random();
            int number  = myRandomDamage.Next(0, Strength) + Bonus;
            Console.WriteLine($"{Name} charges for {number} damage  (includes +{Bonus} bonus). ");

        }
    }

    class Wizard :Player
    {
        public int Energy { get; set; }

        public override void Attack()
        {
            Random myRandomDamage = new Random();
           int number =  myRandomDamage.Next(0, 10);
            Energy -= number;
            base.Attack();
            Console.WriteLine($"   (Wizard {Name} depleted {number} energy.)");
        }
    }
}



// https://www.youtube.com/watch?v=iw-mBefPgag&list=PLqT8wAi-pOx62b1ITQTnf7fqbzKrNqz7O&index=5