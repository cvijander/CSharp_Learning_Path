namespace method_hiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Method hidding");
            Console.WriteLine();
            Console.WriteLine("AS operator");
            Console.WriteLine("The \"as\" operator is like a cast operation. However, if the conversion isn't posible , \"as\" returns null instead fo raising an exception");
            Console.WriteLine("We are hiding the child two method , under the right circumstances , ignoer the child version of this method and revert back to parent");
            Console.WriteLine();
            Console.WriteLine("NEW keyword");
            Console.WriteLine("The new keyword is really just for readability, it doesn not do anything except express your intent");
            Console.WriteLine();
            Console.WriteLine("Method hiding means \"hide this verison of the method  and allow the parent's version of method the to shine throught \"");

            var parent = new Parent();
            parent.One();
            parent.Two();


            var child = new Child();
            child.One();
            child.Two();


            Parent manChild = child as Parent;
            Console.WriteLine("-------------");

            manChild.One();
            manChild.Two();


            Console.ReadLine();
        }
    }

    public class Parent
    {
        public virtual void One () {
            Console.WriteLine("Parent.One");
        }

        public void Two()
        {
            Console.WriteLine("Parent.Two");
        }
    }

    public class Child:Parent
    {
        public override void One()
        {
            Console.WriteLine("Child.One");
        }

        public new void Two()
        {

            Console.WriteLine("Child.Two");
        }
    }
}


// https://www.youtube.com/watch?v=JuBw0B_-7Xk&list=PLqT8wAi-pOx62b1ITQTnf7fqbzKrNqz7O&index=10