using System.Timers;
using Timer = System.Timers.Timer;

internal class Program
{
    private static void Main(string[] args)
    {
        Timer myTimer = new Timer(2000);

        myTimer.Elapsed += MyTimer_Elapsed;
        myTimer.Elapsed += MyTimer_Elapsed1;

        myTimer.Start();

        Console.WriteLine("Press Enter to remove red event");
        Console.ReadLine();

        myTimer.Elapsed -= MyTimer_Elapsed1;

        Console.ReadLine();
    }

    private static void MyTimer_Elapsed1(object? sender, ElapsedEventArgs e)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Elapsed {e.SignalTime:HH:mm:ss.fff}");
    
     }

    private static void MyTimer_Elapsed(object? sender, ElapsedEventArgs e)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Elapsed {e.SignalTime:HH:mm:ss.fff}");
    }
}


// https://www.youtube.com/watch?v=0QUgvfuKvWU  720: