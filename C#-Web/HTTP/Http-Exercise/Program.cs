using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Http_Exercise
{
    class Program
    {
        static async Task Main(string[] args)
        {

            //Get html response by typing some url
            Console.Write("Type here your full browser URL : ");
            string url = Console.ReadLine();
            Console.WriteLine(await GetHtmlResponse(url));

            //Checking status and headers of this url address

            await CheckingStatusAndHeaders(url);

        }


        public static async Task<string> GetHtmlResponse(string url)
        {
            HttpClient client = new HttpClient();

            return await client.GetStringAsync(url);
        }

        public static async Task CheckingStatusAndHeaders(string url)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);

            Console.WriteLine(response.StatusCode);
            Console.WriteLine(response.Headers);

        }


    }
}
