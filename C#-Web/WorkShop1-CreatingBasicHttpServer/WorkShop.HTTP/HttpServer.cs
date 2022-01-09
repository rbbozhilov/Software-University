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
        private const int sizeBuffer = 4096;
        private const string newLine = "\r\n";

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
                byte[] buffer = new byte[sizeBuffer];
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

                var responseHtml = "<h1> Welcome to our site </h1>";
                var responseBodyBufferBytes = GetBytes(responseHtml);



                var responseHeader = "HTTP/1.1 200 OK" + newLine +
                               "Server: Workshop1-Server" + newLine +
                               "Content-Type: text/html" + newLine +
                               "Content-Length: " + responseBodyBufferBytes.Length + newLine + newLine;

                var responseHTTPBufferBytes = GetBytes(responseHeader);

                await stream.WriteAsync(responseHTTPBufferBytes);
                await stream.WriteAsync(responseBodyBufferBytes);


            }

        }

        private byte[] GetBytes(string text)
        {
            return Encoding.UTF8.GetBytes(text);
        }
    }
}
