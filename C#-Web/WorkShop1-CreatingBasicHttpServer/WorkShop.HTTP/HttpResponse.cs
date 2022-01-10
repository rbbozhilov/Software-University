using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop.HTTP
{
    public class HttpResponse
    {

        public HttpResponse(HttpStatusCode statusCode, string contentType, byte[] body)
        {

            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }


            this.StatusCode = statusCode;
            this.Body = body;

            this.Cookies = new List<Cookie>();

            this.Headers = new List<Header>()
            {
                new Header("Content-Type",contentType),
                new Header("Content-Length",this.Body.Length.ToString())
            };

        }

        public HttpStatusCode StatusCode { get; set; }


        public ICollection<Header> Headers { get; set; }

        public ICollection<Cookie> Cookies { get; set; }

        public byte[] Body { get; set; }


        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append($"HTTP/1.1 {(int)this.StatusCode} {this.StatusCode}" + HttpConstants.newLine);

            foreach (var header in this.Headers)
            {
                builder.Append(header.ToString() + HttpConstants.newLine);
            }

            foreach (var cookie in this.Cookies)
            {
                builder.Append("Set-Cookie: " + cookie.ToString()+HttpConstants.newLine);
            }

            builder.Append(HttpConstants.newLine);

            return builder.ToString();
        }



    }
}
