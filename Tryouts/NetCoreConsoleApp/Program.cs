using NetStandardClassLibrary;
using System;

namespace NetCoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!, without this the world would come to an end DON'T REMOVE IT :-).");
            Console.WriteLine(value: new StaticInvoker().Get());
        }
    }
}
