
using System;

namespace CS_Queue_Stack
{
    /// <summary>
    /// This class exists to run tests.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class TestList
    {
        private const string ERROR_ADD_ITEM = "There is a problem adding an item";
        private const string ERROR_REMOVE_ITEM = "There was an issue removing an item";
        private const string EMPTY_PRINT_QUEUE = "The Queue is empty\n";
        private const string ERROR_PEEK = "There was an issue getting the next queued value";
        private const string ERROR_SEARCH = "The item was not found\n";

        /// <summary>
        /// Run a test on a queue.
        /// </summary>
        public void RunQueueTest()
        {
            Item item = new Item();
            Queue<Item> myQueue = new Queue<Item>();
            Console.WriteLine("Testing Queue...");
            TestMethod(AddItem(ref myQueue, new Item("firstItem", "11111111")));
            Console.WriteLine(GetCount(ref myQueue));
            TestMethod(PrintList(ref myQueue));

            if (TestMethod(RemoveItem(ref myQueue, ref item)))
            { Console.WriteLine("Removed Item: " + item.ToString()); }

            Console.WriteLine(GetCount(ref myQueue));
            TestMethod(PrintList(ref myQueue));

            TestMethod(AddItem(ref myQueue, new Item("firstItem", "11111111")));
            TestMethod(AddItem(ref myQueue, new Item("secondItem", "22222222")));
            TestMethod(AddItem(ref myQueue, new Item("thirdItem", "33333333")));
            Console.WriteLine(GetCount(ref myQueue));
            TestMethod(PrintList(ref myQueue));

            if (TestMethod(FindItem(ref myQueue, ref item, "thirdItem")))
            { Console.WriteLine("Item Found: " + item.ToString() + Environment.NewLine); }

            if (TestMethod(FindItem(ref myQueue, ref item, "fourthItem")))
            { Console.WriteLine("Item Found: " + item.ToString() + Environment.NewLine); }

            if (TestMethod(Peek(ref myQueue, ref item)))
            { Console.WriteLine("Peeking at the next Item in Queue: " + item.ToString()); }

            Console.WriteLine(GetCount(ref myQueue));

            if (TestMethod(RemoveItem(ref myQueue, ref item)))
            { Console.WriteLine("Removed Item: " + item.ToString()); }

            if (TestMethod(FindItem(ref myQueue, ref item, "firstItem")))
            { Console.WriteLine("Item Found: " + item.ToString() + Environment.NewLine); }

            Console.WriteLine(GetCount(ref myQueue));
            if (TestMethod(Peek(ref myQueue, ref item)))
            { Console.WriteLine("Peeking at the next Item in Queue: " + item.ToString()); }

            TestMethod(PrintList(ref myQueue));
        }

        /// <summary>
        /// Run a test on a stack.
        /// </summary>
        public void RunStackTest()
        {
            Item item = new Item();
            Stack<Item> myStack = new Stack<Item>();
            Console.WriteLine("Testing Stack...");
            TestMethod(AddItem(ref myStack, new Item("firstItem", "11111111")));

            Console.WriteLine(GetCount(ref myStack));
            TestMethod(PrintList(ref myStack));

            if (TestMethod(RemoveItem(ref myStack, ref item)))
            { Console.WriteLine("Removed Item: " + item.ToString()); }

            Console.WriteLine(GetCount(ref myStack));
            TestMethod(PrintList(ref myStack));

            TestMethod(AddItem(ref myStack, new Item("firstItem", "11111111")));
            TestMethod(AddItem(ref myStack, new Item("secondItem", "22222222")));
            TestMethod(AddItem(ref myStack, new Item("thirdItem", "33333333")));
            Console.WriteLine(GetCount(ref myStack));
            TestMethod(PrintList(ref myStack));

            if (TestMethod(FindItem(ref myStack, ref item, "firstItem")))
            { Console.WriteLine("Item Found: " + item.ToString() + Environment.NewLine); }
            if (TestMethod(FindItem(ref myStack, ref item, "fourthItem")))
            { Console.WriteLine("Item Found: " + item.ToString() + Environment.NewLine); }

            if (TestMethod(Peek(ref myStack, ref item)))
            { Console.WriteLine("Peeking at the next Item in Stack: " + item.ToString()); }

            Console.WriteLine(GetCount(ref myStack));

            if (TestMethod(RemoveItem(ref myStack, ref item)))
            { Console.WriteLine("Removed Item: " + item.ToString()); }

            if (TestMethod(FindItem(ref myStack, ref item, "thirdItem")))
            { Console.WriteLine("Item Found: " + item.ToString() + Environment.NewLine); }

            Console.WriteLine(GetCount(ref myStack));
            if (TestMethod(Peek(ref myStack, ref item)))
            { Console.WriteLine("Peeking at the next Item in Stack: " + item.ToString()); }

            TestMethod(PrintList(ref myStack));
        }

        /// <summary>
        /// Add an item to the queue.
        /// </summary>
        /// <param name="passQ"></param>
        /// <param name="passName"></param>
        /// <param name="passNumber"></param>
        /// <returns></returns>
        private string AddItem(ref Queue<Item> passQ, Item item)
        {
            Console.WriteLine("Adding Item: " + item.ToString());
            return CheckError(passQ.Enqueue(ref item), ERROR_ADD_ITEM);
        }

        /// <summary>
        /// Add an item to the stack.
        /// </summary>
        /// <param name="passStack"></param>
        /// <param name="passName"></param>
        /// <param name="passNumber"></param>
        /// <returns></returns>
        private string AddItem(ref Stack<Item> passStack, Item passItem)
        {
            Console.WriteLine("Adding Item: " + passItem.ToString());
            return CheckError(passStack.Push(ref passItem), ERROR_ADD_ITEM);
        }

        /// <summary>
        /// Remove an item from the queue.
        /// </summary>
        /// <param name="passQ"></param>
        /// <returns></returns>
        private string RemoveItem(ref Queue<Item> passQ, ref Item passItem)
        {
            passItem = new Item();
            return CheckError(passQ.Dequeue(ref passItem), ERROR_REMOVE_ITEM);
        }

        /// <summary>
        /// Remove an item from the stack.
        /// </summary>
        /// <param name="passStack"></param>
        /// <returns></returns>
        private string RemoveItem(ref Stack<Item> passStack, ref Item passItem)
        {
            passItem = new Item();
            return CheckError(passStack.Pop(ref passItem), ERROR_REMOVE_ITEM);
        }

        /// <summary>
        /// Write out the error message to the console if it exists.
        /// </summary>
        /// <param name="errorMessage"></param>
        private bool TestMethod(string errorMessage)
        {
            bool result = true;
            if (errorMessage != null)
            {
                Console.WriteLine(errorMessage);
                result = false;
            }
            return result;
        }

        /// <summary>
        /// Print the list of items in the queue.
        /// </summary>
        /// <param name="passStructure"></param>
        /// <returns></returns>
        public string PrintList(ref Queue<Item> passStructure)
        {
            return CheckError(passStructure.PrintListToConsole(), EMPTY_PRINT_QUEUE);
        }

        /// <summary>
        /// Print the list of items on the stack.
        /// </summary>
        /// <param name="passStack"></param>
        /// <returns></returns>
        public string PrintList(ref Stack<Item> passStack)
        {
            return CheckError(passStack.PrintListToConsole(), EMPTY_PRINT_QUEUE);
        }

        /// <summary>
        /// Return the error message if a given method is not successful.
        /// </summary>
        /// <param name="isSuccess"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        private string CheckError(bool isSuccess, string error)
        {
            return (!isSuccess) ? error : null;
        }

        /// <summary>
        /// Get the next item in the queue without removing it
        /// from the list.
        /// </summary>
        /// <param name="passQ"></param>
        /// <returns></returns>
        private string Peek(ref Queue<Item> passQ, ref Item passItem)
        {
            passItem = new Item();
            return CheckError(passQ.Peek(ref passItem), ERROR_PEEK);
        }

        /// <summary>
        /// Get the next item on the stack without removing
        /// it from the list.
        /// </summary>
        /// <param name="passStack"></param>
        /// <returns></returns>
        private string Peek(ref Stack<Item> passStack, ref Item passItem)
        {
            passItem = new Item();
            return CheckError(passStack.Peek(ref passItem), ERROR_PEEK);
        }

        /// <summary>
        /// Get the number of items in the queue.
        /// </summary>
        /// <param name="passStructure"></param>
        /// <returns></returns>
        private string GetCount(ref Queue<Item> passStructure)
        {
            return "Queue Count: " + passStructure.Count;
        }

        /// <summary>
        /// Get the number of items on the stack
        /// </summary>
        /// <param name="passStructure"></param>
        /// <returns></returns>
        private string GetCount(ref Stack<Item> passStructure)
        {
            return "Stack Count: " + passStructure.Count;
        }

        /// <summary>
        /// Search the queue for the correct item.
        /// </summary>
        /// <param name="passQ"></param>
        /// <param name="passSearchString"></param>
        /// <returns>Returns n string error if the search fails.</returns>
        private string FindItem(ref Queue<Item> passQ, ref Item passItem, string passSearchString)
        {
            Console.WriteLine("Searching For Item: " + passSearchString);
            passItem = new Item();
            return CheckError(passQ.GetMatchingData(ref passItem, passSearchString), ERROR_SEARCH);
        }

        /// <summary>
        /// Search the stack for the correct item.
        /// </summary>
        /// <param name="passStack"></param>
        /// <param name="passSearchString"></param>
        /// <returns>Returns a string error if the search fails</returns>
        private string FindItem(ref Stack<Item> passStack, ref Item passItem, string passSearchString)
        {
            Console.WriteLine("Searching For Item: " + passSearchString);
            passItem = new Item();
            return CheckError(passStack.GetMatchingData(ref passItem, passSearchString), ERROR_SEARCH);
        }

    }
}
