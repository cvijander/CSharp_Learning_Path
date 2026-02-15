// See https://aka.ms/new-console-template for more information

for ( int i = 0; i < 10; i++ )
{
    Console.WriteLine(i);
    if (i == 7)
    {
        Console.WriteLine("Found 7");
        //break;  - prekidamo petlju, iskacemo iz nje 
        //continue; - nasttavljamo dalje sa svim preostalim brojevima
    }
}

Console.ReadLine();