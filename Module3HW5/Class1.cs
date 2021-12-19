using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Module3HW5
{
    public class Class1
    {
        public async Task<string> ReadHelloAsync()
        {
            return await File.ReadAllTextAsync("hello.txt");
        }

        public async Task<string> ReadWorldAsync()
        {
            return await File.ReadAllTextAsync("world.txt");
        }

        public async Task<string> GetResult()
        {
            var string1 = await ReadHelloAsync();
            var string2 = await ReadWorldAsync();

            return $"{string1} {string2}!";
        }
    }
}
