using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop.HTTP
{
    public class HttpRequest
    {

        public HttpRequest(string requestString)
        {
            this.Headers = new List<Header>();
            this.Cookies = new List<Cookie>();

            var lines = requestString.Split(new string[] { HttpConstants.newLine }, StringSplitOptions.None);
            var headers = lines[0];
            var headerLines = headers.Split(' ');
            this.Method = headerLines[0];
            this.Path = headerLines[1];

            int indexOfLines = 1;
            bool isInHeaders = true;
            StringBuilder bodyBuilder = new StringBuilder();

            while (indexOfLines < lines.Length)
            {

                if (string.IsNullOrWhiteSpace(lines[indexOfLines]))
                {
                    isInHeaders = false;
                    indexOfLines++;
                    continue;

                }

                if (isInHeaders)
                {
                    this.Headers.Add(new Header(lines[indexOfLines]));
                }
                else
                {
                    bodyBuilder.AppendLine(lines[indexOfLines]);

                }



                indexOfLines++;

            }

            if (this.Headers.Any(x => x.Name == HttpConstants.RequestCookieHeader))
            {
                var cookiesAsString = this.Headers.FirstOrDefault(x => x.Name == HttpConstants.RequestCookieHeader).Value;

                var cookies = cookiesAsString.Split(new string[] { "; " }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var cookie in cookies)
                {
                    this.Cookies.Add(new Cookie(cookie));
                }

            }

            this.RequestBody = bodyBuilder.ToString();

        }

        public string Path { get; set; }

        public string Method { get; set; }

        public string RequestBody { get; set; }

        public List<Header> Headers { get; set; }

        public List<Cookie> Cookies { get; set; }


    }
}
