﻿using System;
using System.Threading.Tasks;
using WorkShop.HTTP;
using WorkShop.HTTP.Contracts;

namespace MvcFrameworkApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            IHttpServer server = new HttpServer();


            server.AddRoute("/", HomePage);

            server.AddRoute("/about", About);

            server.AddRoute("/users/login", Login);

            await server.StartAsync(2929);
        }

        static HttpResponse HomePage(HttpRequest request)
        {

            throw new NotImplementedException();

        }

        static HttpResponse About(HttpRequest request)
        {

            throw new NotImplementedException();


        }

        static HttpResponse Login(HttpRequest request)
        {

            throw new NotImplementedException();


        }

    }
}
