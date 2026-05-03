namespace aggregation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Objects sometimes merely collaborate");
            Console.WriteLine("One object need help, it requests help from another object. After they collaborate, the task at hand, thet move on with their lives");
            Console.WriteLine("Sometimes , objects share a tighter bond.Like we had in previous lessions ");
            Console.WriteLine();
            Console.WriteLine("There are two special types of relationships that we are going to look at next ");
            Console.WriteLine("Association - that is where you have just a normal collaboration");
            Console.WriteLine("There is relationship between two objects, but esch of them ultimately have their own life cycle");
            Console.WriteLine("They dont own each other . There is no other futher relationship between just one time association");
            Console.WriteLine();
            Console.WriteLine("Aggregation - this is sometimes known as a \"HAS A \" style relationship between objects ");
            Console.WriteLine("It denotes ownership or whole part or a this object is a part of this larger object");
            Console.WriteLine("You have a teacher ,and you have a departments at a give university , and some teacher can exist in muliple departments and a single department can have multiple teacher involved");
            Console.WriteLine("In a sence there is a sense in which departments own teachers. So there is an aggregation ");
            Console.WriteLine("One department can own or have posseed group of multiple teachers , and one teacher could conceivably have multiple departments that belongs to");
            Console.WriteLine("If a teacher were to be eliminated it would not eliminatie the department that she belonged to");
            Console.WriteLine("And vice versa, if you were to eliminate the department, the teacher could find another job at another department in the university");
            Console.WriteLine("But the teacher would still exist");
            Console.WriteLine("We are really talkinh about two properties of the relationship");
            Console.WriteLine("One is life cycle, when do they live and when do they die");
            Console.WriteLine("The other one is ownerships");


            Console.ReadLine();

        }
    }
}
