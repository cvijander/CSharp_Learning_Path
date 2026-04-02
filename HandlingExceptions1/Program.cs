internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            string content = File.ReadAllText(@"D:\Dev\csharp\CSharp_Learning_Path\HandlingExceptions1\Example.txt");
            Console.WriteLine(content);
            
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"There was a problem  ");
            Console.WriteLine("Make sure that the name of the file is named correctly Example.txt");
            Console.WriteLine(ex.Message);
        }

        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine($"There was a problem ");
            Console.WriteLine("Make sure that directory D:\\Dev\\csharp\\CSharp_Learning_Path\\HandlingExceptions1 exists");
            Console.WriteLine(ex.Message);
        }


        catch (Exception ex)
        {
            Console.WriteLine($"There was a problem ");
            Console.WriteLine(ex.Message);
        }
        finally
        {
            // code to finalize 
            // setting object to null 
            // c;psomg database connectisons
            Console.WriteLine("Closing aplication now ...");
        }
        Console.ReadLine();

    }
}

// https://www.youtube.com/watch?v=0QUgvfuKvWU  659 : 