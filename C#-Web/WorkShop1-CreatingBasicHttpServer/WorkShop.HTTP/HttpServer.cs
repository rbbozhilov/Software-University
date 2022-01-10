using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using WorkShop.HTTP.Contracts;

namespace WorkShop.HTTP
{
    public class HttpServer : IHttpServer
    {

        private IDictionary<string, Func<HttpRequest, HttpResponse>> routeTable = new Dictionary<string, Func<HttpRequest, HttpResponse>>();

        public HttpServer()
        {

        }


        public void AddRoute(string path, Func<HttpRequest, HttpResponse> action)
        {

            if (this.routeTable.ContainsKey(path))
            {
                this.routeTable[path] = action;
            }

            else
            {
                this.routeTable.Add(path, action);
            }


        }

        public async Task StartAsync(int port)
        {

            TcpListener tcpListener = new TcpListener(IPAddress.Loopback, port);

            tcpListener.Start();

            while (true)
            {
                TcpClient client = await tcpListener.AcceptTcpClientAsync();

                ProcessClientAsync(client);
            }


        }

        private async Task ProcessClientAsync(TcpClient tcpClient)
        {
            var stream = tcpClient.GetStream();

            using (stream)
            {

                List<byte> data = new List<byte>();
                byte[] buffer = new byte[HttpConstants.sizeBuffer];
                int position = 0;

                while (true)
                {

                    int count = await stream.ReadAsync(buffer, position, buffer.Length);
                    position += count;


                    if (count < buffer.Length)
                    {

                        var bufferWithData = new byte[count];
                        Array.Copy(buffer, bufferWithData, count);
                        data.AddRange(bufferWithData);
                        break;

                    }

                    else
                    {
                        data.AddRange(buffer);
                    }


                }

                var request = Encoding.UTF8.GetString(data.ToArray());


                Console.WriteLine(request);
                
                var getCustomRequest = new HttpRequest(request);

                var responseHtml = "<h1> Welcome to our site </h1>";
                var responseBodyBufferBytes = GetBytes(responseHtml);

                HttpResponse response;

                if (routeTable.ContainsKey(getCustomRequest.Path))
                {
                    var action = routeTable[getCustomRequest.Path];

                    response = action(getCustomRequest);
                }
                else
                {
                    //Not Found 404
                    var bodyHtmlNotFound = "<h1> Sorry wrong path you write try again! </h1>";
                    response = new HttpResponse(HttpStatusCode.NotFound, "text/html", GetBytes(bodyHtmlNotFound));
                }


                var responseHTTPBufferBytes = GetBytes(response.ToString());

                await stream.WriteAsync(responseHTTPBufferBytes);
                await stream.WriteAsync(response.Body);


                tcpClient.Close();
            }

        }

        private byte[] GetBytes(string text)
        {
            return Encoding.UTF8.GetBytes(text);
        }
    }
}
