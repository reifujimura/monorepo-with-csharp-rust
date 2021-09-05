using System;

namespace RustFFI.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var ans = RustFFI.Module.RustAdd(1, 2);
            Console.WriteLine($"1 + 2 = {ans}");
        }
    }
}
