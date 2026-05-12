namespace inheritance_Base_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If we want to extend the parent method in child method, we can call \"base\" ");
            Console.WriteLine("We are taking the original implementation by calling the bases version of do work and then just tacking on some additional code after that");
            Console.WriteLine();
            Console.WriteLine("Base");
            Console.WriteLine("Base keyword is used to access members of the base class from within a derived class");



            var employee = new Employee();
            employee.DoWork();
            Console.WriteLine("");


            var dev = new SoftwareDeveloper();
            dev.DoWork();
            Console.WriteLine("");

            Console.ReadLine();

        }
    }

    class Employee
    {
        public virtual void DoWork()
        {
            Console.Write("Working");
        }
    }

    class SoftwareDeveloper :Employee
    {
        public override void DoWork()
        {
            base.DoWork();
            Console.WriteLine("... on software development");
        }
    }
}


// https://www.youtube.com/watch?v=U_Yee5nu7pk&list=PLqT8wAi-pOx62b1ITQTnf7fqbzKrNqz7O&index=4