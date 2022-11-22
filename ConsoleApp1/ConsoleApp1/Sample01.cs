using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Sample01
    {
        public async Task Start()
        {
            Console.WriteLine("Start");
            await FinalResultCaller();
        }
        public async Task FinalResultCaller()
        {
            var result = await finalResult(2);
            Console.WriteLine($"Result is {result}");
        }
        public Task<int> finalResult(int sleepFor)
        {
            return Task.Run(() =>
            {
                Thread.Sleep(1000 * sleepFor);
                return 10;
            });
        }

        public async Task Print(string message)
        {
            await Task.Delay(3000);
            Console.WriteLine(message);
        }
    }



}
