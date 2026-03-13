using System.Net;

internal class Program
{
    private static void Main(string[] args)
    {

        WebClient client = new WebClient();
        string reply = client.DownloadString("https://www.gembird.rs/");

        Console.WriteLine(reply);

        string text = "A class is something";
        System.IO.File.WriteAllText(@"D:\Dev\csharp\CSharp_Learning_Path\AssembliesAndNamespaces\WriteText.txt", reply);

        Console.WriteLine("Hello, World!");
        Console.ReadLine();
    }
}