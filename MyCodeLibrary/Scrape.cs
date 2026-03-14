using System.Net;

namespace MyCodeLibrary
{
    public class Scrape
    {
        public string ScrapeWebpage (string url)
        {
            return GetWebpage(url);
            
        }

        public string ScrapeWebpage(string url, string filepath)
        {
            string reply = GetWebpage(url);

            System.IO.File.WriteAllText(filepath, reply);

            return reply;

        }

        private string GetWebpage(string url)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString(url);
            return reply;
        }
    }
}

// https://www.youtube.com/watch?v=0QUgvfuKvWU
