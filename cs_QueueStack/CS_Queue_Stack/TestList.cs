
using System;

namespace CS_Queue_Stack
{
    class TestList<T>
    {
        private const string ERROR_ADD_ITEM = "There is a problem adding an item";
        private const string ERROR_REMOVE_ITEM = "There was an issue removing an item";
        private const string EMPTY_PRINT_QUEUE = "The Queue is empty\n";
        private const string ERROR_PEEK_ERROR = "There was an issue getting the next queued value";

        public void RunQueueTest()
        {
            Queue<Item> myQueue = new Queue<Item>();
            Util.PrintData("Testing Queue...");
            TestMethod(AddItem(ref myQueue, "firstItem", "11111111"));
            Util.PrintData(GetCount(ref myQueue));
            TestMethod(PrintList(ref myQueue));

            TestMethod(RemoveItem(ref myQueue));
            Util.PrintData(GetCount(ref myQueue));
            TestMethod(PrintList(ref myQueue));

            TestMethod(AddItem(ref myQueue, "firstItem", "11111111"));
            TestMethod(AddItem(ref myQueue, "secondItem", "22222222"));
            TestMethod(AddItem(ref myQueue, "thirdItem", "33333333"));
            Util.PrintData(GetCount(ref myQueue));
            TestMethod(PrintList(ref myQueue));

            TestMethod(Peek(ref myQueue));

            Util.PrintData(GetCount(ref myQueue));

            TestMethod(RemoveItem(ref myQueue));
            Util.PrintData(GetCount(ref myQueue));
            TestMethod(Peek(ref myQueue));
            TestMethod(PrintList(ref myQueue));
        }

        public void RunStackTest()
        {
            Stack<Item> myStack = new Stack<Item>();
            Util.PrintData("Testing Stack...");
            TestMethod(AddItem(ref myStack, "firstItem", "11111111"));

            Util.PrintData(GetCount(ref myStack));
            TestMethod(PrintList(ref myStack));

            TestMethod(RemoveItem(ref myStack));
            Util.PrintData(GetCount(ref myStack));
            TestMethod(PrintList(ref myStack));

            TestMethod(AddItem(ref myStack, "firstItem", "11111111"));
            TestMethod(AddItem(ref myStack, "secondItem", "22222222"));
            TestMethod(AddItem(ref myStack, "thirdItem", "33333333"));
            Util.PrintData(GetCount(ref myStack));
            TestMethod(PrintList(ref myStack));

            TestMethod(Peek(ref myStack));

            Util.PrintData(GetCount(ref myStack));

            TestMethod(RemoveItem(ref myStack));
            Util.PrintData(GetCount(ref myStack));
            TestMethod(Peek(ref myStack));
            TestMethod(PrintList(ref myStack));
        }

        private string AddItem(ref Queue<Item> passQ, string passName, string passNumber)
        {
            Item item = new Item(ref passName, ref passNumber);
            Util.PrintData("Adding Item: " + item.ToString());
            return CheckError(passQ.Enqueue(ref item), ERROR_ADD_ITEM);
        }

        private string AddItem(ref Stack<Item> passStack, string passName, string passNumber)
        {
            Item item = new Item(ref passName, ref passNumber);
            Util.PrintData("Adding Item: " + item.ToString());
            return CheckError(passStack.Push(ref item), ERROR_ADD_ITEM);
        }

        private string RemoveItem(ref Queue<Item> passQ)
        {
            Item item = new Item();
            string err = CheckError(passQ.Dequeue(ref item), ERROR_REMOVE_ITEM);
            Util.PrintData("Removed Item: " + item.ToString());
            return err;
        }

        private string RemoveItem(ref Stack<Item> passStack)
        {
            Item item = new Item();
            string err = CheckError(passStack.Pop(ref item), ERROR_REMOVE_ITEM);
            Util.PrintData("Removed Item: " + item.ToString());
            return err;
        }

        private void TestMethod(string errorMessage)
        {
            if (errorMessage != null)
            { Console.WriteLine(errorMessage); }
        }

        public string PrintList(ref Queue<Item> passStructure)
        {
            return CheckError(passStructure.PrintListToConsole(), EMPTY_PRINT_QUEUE);
        }

        public string PrintList(ref Stack<Item> passStack)
        {
            return CheckError(passStack.PrintListToConsole(), EMPTY_PRINT_QUEUE);
        }

        private string CheckError(bool isSuccess, string error)
        {
            return (!isSuccess) ? error : null;
        }

        private string Peek(ref Queue<Item> passQ)
        {
            Item item = new Item();
            string err = CheckError(passQ.Peek(ref item), ERROR_PEEK_ERROR);
            Util.PrintData("Peeking at the next Item in Queue: " + item.ToString());
            return err;
        }

        private string Peek(ref Stack<Item> passStack)
        {
            Item item = new Item();
            string err = CheckError(passStack.Peek(ref item), ERROR_PEEK_ERROR);
            Util.PrintData("Peeking at the next Item in Stack: " + item.ToString());
            return err;
        }

        private string GetCount(ref Queue<Item> passStructure)
        {
            return "Queue Count: " + passStructure.Count;
        }

        private string GetCount(ref Stack<Item> passStructure)
        {
            return "Stack Count: " + passStructure.Count;
        }

    }
}
