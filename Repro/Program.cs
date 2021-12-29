// See https://aka.ms/new-console-template for more information
using Alethic.Kademlia;
using ClassLibrary1;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;

class Test
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var logger = NullLogger.Instance;

        var localPeer = new byte[32] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32 };
        var hostOptions = new KHostOptions<KNodeId256>
        {
            NodeId = new KNodeId256(localPeer),
            NetworkId = 0,
            Endpoints = new Uri[] { }
        };
        var host = new KHost<KNodeId256>(Options.Create(hostOptions), logger);
        var invokerPolicy = new KInvokerPolicy<KNodeId256>(logger);
        var invoker = new KInvoker<KNodeId256>(host, invokerPolicy);
        var Router = new KFixedTableRouter<KNodeId256>(Options.Create(new KFixedTableRouterOptions { }), host, invoker, logger);

        var num = await Class1.FindPeerAsync(Router);
    }
}