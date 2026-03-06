using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        //string myString = "My \"so-called\" life";

        //string myString = "What if i need a \n new line? ";

        // string myString = "Go to your :c\\drive";

        // string myString = @"Go to your c:\drive";

        //string myString = String.Format("{0} = {1}", "First", "Second");

        //  string myString = string.Format("{0:C}",123.45); currency 

        //  string myString = string.Format("{0:N}",1234567890); Number

        //  string myString = string.Format("{0:P}", .123); percente

        // string myString = string.Format ("Phone number: {0:(###) ###-####}",1234567890); phone format

        // string myString = " That summer we took threes across the board  ";

        // myString = myString.Substring(6); pocienje od pozicije 6 pa ide dalje 

        // myString = myString.Substring(6, 14);  // pocinjemo od 6 karaktrea idemo do 14 tog

        // myString = myString.ToUpper(); sva velika slova 

        // myString = myString.Replace(" ", "--"); zamena menja prazan string za --
        // myString = myString.Remove(6,14);// uklanja od 6 do 14 

        // myString = String.Format("Length before {0} -- Lenght after {1}",myString.Length, myString.Trim().Length);

       // string myString = "";

        /*
        for (int i = 0; i < 100; i ++)
        {
            myString += "--" + i.ToString();
        }

        */

        StringBuilder myString = new StringBuilder();

        for (int i = 0; i < 100; i++)
        {
            myString.Append("--");
            myString.Append(i);
        }

        Console.WriteLine(myString);
        Console.ReadLine();
    }
}

//  https://www.youtube.com/watch?v=0QUgvfuKvWU