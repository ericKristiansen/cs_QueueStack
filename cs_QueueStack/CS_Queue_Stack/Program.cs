
using System;

namespace CS_Queue_Stack 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting...");

            TestList myTest = new TestList();

            myTest.RunQueueTest();

            myTest.RunStackTest();

            Console.WriteLine("Ending...");
            Console.ReadLine();
        }
    }
}
