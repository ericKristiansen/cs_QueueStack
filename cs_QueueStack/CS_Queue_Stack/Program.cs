using System;

namespace CS_Queue_Stack 
{
    class Program
    {
        private static Queue<Item> myQueue;

        private const string ERROR_ADD_ITEM = "There is a problem adding an item";
        private const string ERROR_REMOVE_LAST_ITEM = "There was an issue removing the last item";
        private const string ERROR_REMOVE_FIRST_ITEM = "There was an issue removing the first item";
        private const string ERROR_REMOVE_ITEM = "There was an issue removing an item";
        private const string EMPTY_PRINT_QUEUE = "The Queue is empty\n";
        private const string ERROR_PEEK_ERROR = "There was an issue getting the next queued value";

        static void Main(string[] args)
        {
            PrintData("Starting...");

            QueueTest();

            StackTest();

            PrintData("Ending...");
            Console.ReadLine();
        }

        private static void QueueTest()
        {
            Queue<Item> myQueue = new Queue<Item>();
            PrintData("Testing Queue...");
            TestMethod(AddItem(ref myQueue, "firstItem", "11111111"));
            PrintData(GetCount(ref myQueue));
            TestMethod(PrintList(ref myQueue));

            TestMethod(RemoveItem(ref myQueue));
            PrintData(GetCount(ref myQueue));
            TestMethod(PrintList(ref myQueue));

            TestMethod(AddItem(ref myQueue, "firstItem", "11111111"));
            TestMethod(AddItem(ref myQueue, "secondItem", "22222222"));
            TestMethod(AddItem(ref myQueue, "thirdItem", "33333333"));
            PrintData(GetCount(ref myQueue));
            TestMethod(PrintList(ref myQueue));

            TestMethod(Peek(ref myQueue));

            PrintData(GetCount(ref myQueue));

            TestMethod(RemoveItem(ref myQueue));
            PrintData(GetCount(ref myQueue));
            TestMethod(Peek(ref myQueue));
            TestMethod(PrintList(ref myQueue));

        }

        private static void StackTest()
        {
            Stack<Item> myStack = new Stack<Item>();
            PrintData("Testing Stack...");
            TestMethod(AddItem(ref myStack, "firstItem", "11111111"));
            
            PrintData(GetCount(ref myStack));
            TestMethod(PrintList(ref myStack));

            TestMethod(RemoveItem(ref myStack));
            PrintData(GetCount(ref myStack));
            TestMethod(PrintList(ref myStack));

            TestMethod(AddItem(ref myStack, "firstItem", "11111111"));
            TestMethod(AddItem(ref myStack, "secondItem", "22222222"));
            TestMethod(AddItem(ref myStack, "thirdItem", "33333333"));
            PrintData(GetCount(ref myStack));
            TestMethod(PrintList(ref myStack));

            TestMethod(Peek(ref myStack));

            PrintData(GetCount(ref myStack));

            TestMethod(RemoveItem(ref myStack));
            PrintData(GetCount(ref myStack));
            TestMethod(Peek(ref myStack));
            TestMethod(PrintList(ref myStack));
        }

        private static string AddItem(ref Queue<Item> passQ, string passName, string passNumber)
        {
            Item item = new Item(ref passName, ref passNumber);
            PrintData("Adding Item: " + item.ToString());
            return CheckError(passQ.Enqueue(ref item), ERROR_ADD_ITEM);
        }

        private static string AddItem(ref Stack<Item> passStack, string passName, string passNumber)
        {
            Item item = new Item(ref passName, ref passNumber);
            PrintData("Adding Item: " + item.ToString());
            return CheckError(passStack.Push(ref item), ERROR_ADD_ITEM);
        }

        private static string RemoveItem(ref Queue<Item> passQ)
        {
            Item item = new Item();
            string err = CheckError(passQ.Dequeue(ref item), ERROR_REMOVE_ITEM);
            PrintData("Removed Item: " + item.ToString());
            return err;
        }

        private static string RemoveItem(ref Stack<Item> passStack)
        {
            Item item = new Item();
            string err = CheckError(passStack.Pop(ref item), ERROR_REMOVE_ITEM);
            PrintData("Removed Item: " + item.ToString());
            return err;
        }

        private static void TestMethod(string errorMessage)
        {
            if (errorMessage != null)
            { Console.WriteLine(errorMessage); }
        }

        private static string AddItemQueue(string passName, string passNumber)
        {
            Item item = new Item(ref passName, ref passNumber);
            PrintData("Add Data: " + item.ToString());
            return CheckError(myQueue.Enqueue(ref item), ERROR_ADD_ITEM);
        }

        private static string RemoveLastItem()
        {
            Item item = new Item();
            string err = CheckError(myQueue.RemoveTail(ref item), ERROR_REMOVE_ITEM);
            PrintData("Removed: " + item.ToString()); 
            return err;
        }

        public static string PrintList(ref Queue<Item> passStructure)
        {
            return CheckError(passStructure.PrintListToConsole(),  EMPTY_PRINT_QUEUE);
        }

        public static string PrintList(ref Stack<Item> passStack)
        {
            return CheckError(passStack.PrintListToConsole(), EMPTY_PRINT_QUEUE);
        }

        private static string CheckError(bool isSuccess, string error)
        {
            return  (!isSuccess) ? error : null;
        }

        private static string Peek(ref Queue<Item> passQ)
        {
            Item item = new Item();
            string err = CheckError(passQ.Peek(ref item), ERROR_PEEK_ERROR);
            PrintData("Peeking at the next Item in Queue: " + item.ToString());
            return err;
        }

        private static string Peek(ref Stack<Item> passStack)
        {
            Item item = new Item();
            string err = CheckError(passStack.Peek(ref item), ERROR_PEEK_ERROR);
            PrintData("Peeking at the next Item in Stack: " + item.ToString());
            return err;
        }

        private static string GetCount(ref Queue<Item> passStructure)
        {
            return "Queue Count: " + passStructure.Count;
        }

        private static string GetCount(ref Stack<Item> passStructure)
        {
            return "Stack Count: " + passStructure.Count;
        }

        private static void PrintData(string data)
        {
            Console.WriteLine(data);
        }
    }
}
