using System.Timers;
using Timer = System.Timers.Timer;

internal class Program
{
    private static void Main(string[] args)
    {
        Timer myTimer = new Timer(2000);

        myTimer.Elapsed += MyTimer_Elapsed;

        myTimer.Start();

        Console.ReadLine();
    }

    private static void MyTimer_Elapsed(object? sender, ElapsedEventArgs e)
    {
        Console.WriteLine($"Elapsed {e.SignalTime:HH:mm:ss.fff}");
    }
}


// https://www.youtube.com/watch?v=0QUgvfuKvWU  720: