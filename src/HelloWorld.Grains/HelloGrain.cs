using HelloWorld.Interfaces;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System;
using Orleans;

namespace HelloWorld.Grains
{
    /// <summary>
    /// Orleans grain implementation class HelloGrain.
    /// </summary>
    public class HelloGrain : Orleans.Grain, IHello
    {
        private readonly ILogger logger;

        public HelloGrain(ILogger<HelloGrain> logger)
        {
            this.logger = logger;
        }  

        Task<string> IHello.SayHello(string greeting)
        {
            Console.WriteLine($"HelloGrain的Identity值是{this.GetPrimaryKeyLong(out string msg)}");
            logger.LogInformation($"HelloGrain 接收到的消息是'{greeting}'");
            return Task.FromResult($"你说的是：'{greeting}', 我说的是： Hello!");
        }
    }
}
