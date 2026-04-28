namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The third tenant of object - oriented programming is polymorphism");
            Console.WriteLine("It comes from Greek, it literally means  - many forms or many shapes ");
            Console.WriteLine("Polymorphism allows you to call the same method on different objects as long as it truly the same method");
            Console.WriteLine("The same method signature, same input parameters, same return values or types, same name , so on");
            Console.WriteLine();
            Console.WriteLine("Id three different object all have a different version of the same method, then our caller really doesn not care which object that it is working with");
            Console.WriteLine("All it needs to know is that they all are supporting the same method. It just needs to be able to get a reference to one of those objects and then trust that the calling the method will perform the correct ");
            Console.WriteLine("responsability in the system relative to the purpose of that particular object");
            Console.WriteLine();
            Console.WriteLine("We get printed information about the car and information about the suv ");
            Console.WriteLine("With car with the info from make, model and year");
            Console.WriteLine("For suv we get , make, model, year and driving mechanism   - like it is suposed to get");
            Console.WriteLine();
            Console.WriteLine("In order to withness polymorphic behaviour , we are goig to take a look at this print method");
            Console.WriteLine("Print helper method will take anything of type autombile and present it");
            Console.WriteLine("That will include automobile and suv class ");
            Console.WriteLine("For automobile, we will get the same display we had previous, but for suv we will get the display from car which does not contain the drive method");
            Console.WriteLine("We are getting cars version for display method");
            Console.WriteLine();
            Console.WriteLine("In order to enable polymorphism in our code, we neeed to make two modifications to our code");
            Console.WriteLine("But if we in display method in car put \"virtual\"  then in display method in suv instead \"new\" we put \"override\" ");
            Console.WriteLine("This method can be completely overridden, notjust hidden but it can be even exteneded by derived class");
            Console.WriteLine("We are adding \"virtual\" keyword ");
            Console.WriteLine("Now i derived class we are replacing word \" new \" with word \"override\"");
            Console.WriteLine();
            Console.WriteLine("Then we will get the same result on the starting point ");
            Console.WriteLine("We see the polymorphic behaviour and it behaves correctly");
            Console.WriteLine();
            Console.WriteLine("It is the ability for you to use or to call a given method across multiple different types and for it to actually make a call in and use that particual version of that method");
            Console.WriteLine();
            Console.WriteLine("Polymorphism is our manifestation of our desire to build more flexible collaborations between objects");
            Console.WriteLine("Inflexible collaborations are limiting");
            Console.WriteLine("We are really not relying on a concrete direct reference to a specific object");
            Console.WriteLine("Here in our print method, we are just saying anything that comes down line from automobile. It can be automobile, suv, or engine");
            Console.WriteLine("We are not relying on specific object per se in order to call that method on than objec");
            Console.WriteLine("As long as the object that we pass in her has a method defined with that specific name then it has that specific input and it returns that particular return type");
            Console.WriteLine();
            Console.WriteLine("With polymorphysm - We decoupled the collaboration");





            

            var car = new Automobile { Make = "Hyundai", Model = "Elantra", Year = 2010 };
           // car.Display();
             Print(car);

            var suv = new Suv { Make = "GMC", Model = "Yukon", Year = 2013 };
            suv.DriveMechanism = "4 wheel drive";
            //suv.Display();
             Print(suv);



            Console.ReadLine();
        }

        private static void Print(Automobile auto)
        {
            auto.Display();
        }
    }

    public class Automobile
    {
        // Here i am foregoing the benefit of 
        // encapsulation .. I may not need it 
        // most of the time . 

        public string Make { get; set; }
        public string Model { get; set; }

        public int Year { get; set; }

        // The virtual keyword is used to modify a method, property, indexer,
        // or event declaration and allow for it to be overridden in a derived 
        // class. For ecxample, this method can be overridden by any class 
        // that inherits it: 

        public virtual void Display ()
        {
            Console.WriteLine($"Car: {Make}  {Model} {Year}");
        }
    }

    public class Suv :Automobile
    {
        public string DriveMechanism { get; set; }

        // the override modifier extends the base class method,
        // and the new modifier hides it 

        public override void Display()
        {
            Console.WriteLine($"Suv: {Make} {Model} {DriveMechanism} {Year}");
        }
    }


}


// https://www.youtube.com/watch?v=32Bmcb823gM&list=PLqT8wAi-pOx7X3i6Vynm57MCwFpQWJdP9&index=19