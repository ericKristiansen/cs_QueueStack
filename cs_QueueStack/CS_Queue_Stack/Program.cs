using System;

namespace CS_Queue_Stack 
{
    class Program
    {
        private static Queue<Item> myQueue;

        private const string ERROR_ADD_ITEM = "There is a problem adding an item";
        private const string ERROR_REMOVE_LAST_ITEM = "There was an issue removing the last item";
        private const string ERROR_REMOVE_FIRST_ITEM = "There was an issue removing the first item";
        private const string EMPTY_PRINT_QUEUE = "The Queue is empty\n";
        private const string ERROR_PEEK_ERROR = "There was an issue getting the next queued value";

        static void Main(string[] args)
        {
            Console.WriteLine("Started...");

            GeneralQueueTest();

            Console.WriteLine("Ending...");
            Console.ReadLine();
        }

        private static void GeneralQueueTest()
        {
            myQueue = new Queue<Item>();

            TestMethod(AddItemQueue("firstItem", "11111111"));
            GetQueueCount();
            myQueue.PrintListToConsole();

            TestMethod(RemoveLastItem());
            GetQueueCount();
            TestMethod(PrintQueue());

            TestMethod(AddItemQueue("firstItem", "11111111"));
            TestMethod(AddItemQueue("secondItem", "22222222"));
            TestMethod(AddItemQueue("thirdItem", "33333333"));
            GetQueueCount();
            TestMethod(PrintQueue());

            TestMethod(PeekQueue());

            TestMethod(RemoveLastItem());
            GetQueueCount();
            TestMethod(PrintQueue());

            TestMethod(RemoveItemQueue());
            TestMethod(PeekQueue());

            GetQueueCount();
            TestMethod(PrintQueue());
        }

        private static void TestMethod(string errorMessage)
        {
            if (errorMessage != null)
            { Console.WriteLine(errorMessage); }
        }

        private static string AddItemQueue(string passName, string passNumber)
        {
            string err = null;
            Item item = new Item(ref passName, ref passNumber);

            if (!myQueue.Enqueue(ref item))
            {
                err = ERROR_ADD_ITEM;
            }
            else
            {
                Console.WriteLine("Added Data: " + passName + " : " + passNumber);
            }
            return err;
        }

        private static string RemoveLastItem()
        {
            Item item = new Item();
            string err = null;
            if (!myQueue.RemoveTail(ref item))
            {
                err = ERROR_REMOVE_LAST_ITEM;
            }
            else
            { Console.WriteLine("removed: " + item.ToString()); }
            return err;
        }

        public static string PrintQueue()
        {
            string err = null;
            if (!myQueue.PrintListToConsole())
            {
                err = EMPTY_PRINT_QUEUE;
            }

            return err;
        }

        private static string RemoveItemQueue()
        {
            string err = null;
            Item item = new Item();
            if (!myQueue.Dequeue(ref item))
            {
                err = ERROR_REMOVE_FIRST_ITEM;
            }
            else
            { Console.WriteLine("removed: " + item.ToString()); }

            return err;
        }

        private static string PeekQueue()
        {
            string err = null;
            Item item = new Item();
            if (!myQueue.Peek(ref item))
            {
                err = ERROR_PEEK_ERROR;
            }
            else { Console.WriteLine("Next Item in Queue: " + item.ToString()); }
            return err;
        }

        private static void GetQueueCount()
        {
            Console.WriteLine("The Queue Count: " + myQueue.Count);
        }
    }
}
