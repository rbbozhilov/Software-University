using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncExercise
{
    public class Program
    {
        const string newLine = "\r\n";

        static void Main(string[] args)
        {

            TcpListener tcp = new TcpListener(IPAddress.Loopback, 2929);
            tcp.Start();

            while (true)
            {

                var client = tcp.AcceptTcpClient();
                ProcessingClientAsync(client);

            }
        }

        static async Task ProcessingClientAsync(TcpClient client)
        {
            using (var stream = client.GetStream())
            {
                byte[] buffer = new byte[10000];
                var length = await stream.ReadAsync(buffer, 0, buffer.Length);
                string requestString = Encoding.UTF8.GetString(buffer, 0, length);
                Console.WriteLine(requestString);
                Thread.Sleep(5000);
                string html = "<h1> Hello we are Lion <h1>" + newLine + "<h2> So cool </h2>" + $"<h3>Current DateTime {DateTime.UtcNow}</h3>" + "<form action = /mecho method=post> <input name=text/> <input password=password/> <input type=submit /> </form>";
                string serverResponse = "HTTP/1.1 200 OK" + newLine + "Server: LionServer2021" + newLine + "Content-Type: text/html; charset=utf-8" + newLine + "Content-Length: " + html.Length + newLine + newLine + html + newLine;

                byte[] responseBytes = Encoding.UTF8.GetBytes(serverResponse);
                await stream.WriteAsync(responseBytes);
            }
        }

    }
}
