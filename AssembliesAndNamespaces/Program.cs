internal class Program
{
    private static void Main(string[] args)
    {
        string text = "A class is something";
        System.IO.File.WriteAllText(@"D:\Dev\csharp\CSharp_Learning_Path\AssembliesAndNamespaces\WriteText.txt", text);

        Console.WriteLine("Hello, World!");
        Console.ReadLine();
    }
}