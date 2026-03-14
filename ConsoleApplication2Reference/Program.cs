using MyCodeLibrary;

Console.WriteLine("Hello, World!");

Scrape myScrape = new Scrape();
string value = myScrape.ScrapeWebpage("http://gembird.rs");
Console.WriteLine(value);

Console.ReadLine();



// https://www.youtube.com/watch?v=0QUgvfuKvWU