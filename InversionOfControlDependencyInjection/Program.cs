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

            Console.WriteLine("251 - 1317");
            Console.ReadLine();
        }
    }
}



// https://www.youtube.com/watch?v=U01S2M42usU&list=PLqT8wAi-pOx7X3i6Vynm57MCwFpQWJdP9&index=21 