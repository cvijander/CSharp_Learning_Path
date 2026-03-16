using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {

        Car car1 = new Car();
        car1.Make = "Oldsmobile";
        car1.Model = "Cutlas Supreme";
        car1.VIN = "A1";

        Car car2 = new Car();
        car2.Make = "Geo";
        car2.Model = "Prism";
        car2.VIN = "A2";

        Book b1 = new Book();
        b1.Author = "Robert Tabor";
        b1.Title = "Microsoft .NET XML Web services";
        b1.ISBN = "0-000-00000-0";

        // old style, with an error because wee can put anything in this collections

        // ArrayList are dynamically sized, 
        // cool features sorting, remove items 

        ArrayList myArrayList = new ArrayList();
        myArrayList.Add(car1);
        myArrayList.Add(car2);
        myArrayList.Add(b1);
        myArrayList.Remove(b1);


        foreach (Car car in myArrayList)
        {
            Console.WriteLine(car.Make);// greska jer ne moze da prikaze knjigu kao podatak o kolima 
        }


        // newer style are Collection  List<T> 
        // generic list with specific type 

        List<Car> myList = new List<Car>();
        myList.Add(car1);
        myList.Add(car2);
        //myList.Add(b1);
        // can not att book to a car 

        foreach (Car car in myList)
        {
            Console.WriteLine(car.Model);
        }


        // dictionary 
        // word and definition    key:value 

        // Dictionary <TKey, TValue>



        Console.ReadLine();
        
    }
}

class Car
{
    public string VIN { get; set; }
    public string Make { get; set; }

    public string Model { get; set; }
}

class Book
{
    public string Author { get; set; }
    public string Title { get; set; }

    public string ISBN { get; set; }
}

// https://www.youtube.com/watch?v=0QUgvfuKvWU  5:58 
