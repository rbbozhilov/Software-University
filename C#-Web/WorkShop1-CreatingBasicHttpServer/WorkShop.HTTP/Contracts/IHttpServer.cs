using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop.HTTP.Contracts
{
    public interface IHttpServer
    {

        void AddRoute(string path, Func<HttpRequest, HttpResponse> action);

        Task StartAsync(int port);


    }
}
