﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace chat1
{
    public class Program
    {
        public static readonly int port = Common.PortCommon.GetRandAvailablePort();

        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseUrls("http://127.0.0.1:" + port)
                .UseStartup<Startup>()
                .Build();
    }
}