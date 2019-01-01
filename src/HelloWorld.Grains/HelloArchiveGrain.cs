using HelloWorld.Interfaces;
using Orleans;
using Orleans.Providers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HelloWorld.Grains
{
    [StorageProvider(ProviderName = "MemoryStoreGrain")]
    public class HelloArchiveGrain : Grain<GreetingArchive>, IHelloArchive
    {
        public async Task<string> SayHello(string greeting)
        {
            this.State.Greetings.Add(greeting);
            await WriteStateAsync();
            return $"你说的是: '{greeting}', 我的说是: Hello!";
        }

        public async Task<IEnumerable<string>> GetGreetings()
        {
            await base.ReadStateAsync();
            Console.WriteLine($"HelloArchiveGrain的值是：{this.GetPrimaryKeyString()}");
            return this.State.Greetings;
        }
    }

    public class GreetingArchive
    {
        public List<string> Greetings { get; } = new List<string>();
    }
}
