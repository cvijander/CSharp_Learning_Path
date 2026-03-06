internal class Program
{
    private static void Main(string[] args)
    {
        DateTime myValue = DateTime.Now;

        //  Console.WriteLine(myValue.ToString());

        //  Console.WriteLine(myValue.ToShortDateString());  datum

        //  Console.WriteLine(myValue.ToShortTimeString()); vreme 

        // Console.WriteLine(myValue.ToLongDateString()); duzi datum 

        //  Console.WriteLine(myValue.ToLongTimeString());   vreme sa sekundama 

        //  Console.WriteLine(myValue.AddDays(3).ToLongDateString()); dodavanje dana

        // Console.WriteLine(myValue.AddHours(3).ToLongTimeString()); dodavanje sati 

        // Console.WriteLine(myValue.AddDays(-5).ToLongDateString()); vracanje dana 

        //  Console.WriteLine(myValue.Month); vraca broj 

        DateTime myBirthday = new DateTime(1985, 2, 26);

        Console.WriteLine(myBirthday.ToShortDateString());

        DateTime myBirthday1 = DateTime.Parse("26/2/1985");

        Console.WriteLine(myBirthday1.ToShortDateString());

        TimeSpan myAge = DateTime.Now.Subtract(myBirthday1);

        Console.WriteLine(myAge.TotalDays);

        Console.ReadLine();

        // https://www.youtube.com/watch?v=0QUgvfuKvWU  4:04
    }
}