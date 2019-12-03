using System;

namespace EdifactParser.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting test application");

            Process lProcess = new Process();

            Console.WriteLine("Printing array:");

            Array.ForEach(lProcess.ProcessFirstExecise(), Console.WriteLine);

            Console.ReadLine();
            
        }
    }
}
