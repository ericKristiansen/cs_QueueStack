using System;

namespace CS_Queue_Stack 
{
    class Program
    {
        static void Main(string[] args)
        {
            Util.PrintData("Starting...");

            TestList<Queue<Item>> myQueueTest = new TestList<Queue<Item>>();

            myQueueTest.RunQueueTest();
            myQueueTest = null;

            TestList<Stack<Item>> myStackTest = new TestList<Stack<Item>>();

            myStackTest.RunStackTest();
            myStackTest = null;

            Util.PrintData("Ending...");
            Console.ReadLine();
        }
    }
}
