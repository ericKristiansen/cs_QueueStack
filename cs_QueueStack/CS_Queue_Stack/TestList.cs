
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
        private const string ERROR_PEEK_ERROR = "There was an issue getting the next queued value";

        /// <summary>
        /// Run a test on a queue.
        /// </summary>
        public void RunQueueTest()
        {
            Queue<Item> myQueue = new Queue<Item>();
            Console.WriteLine("Testing Queue...");
            TestMethod(AddItem(ref myQueue, "firstItem", "11111111"));
            Console.WriteLine(GetCount(ref myQueue));
            TestMethod(PrintList(ref myQueue));

            TestMethod(RemoveItem(ref myQueue));
            Console.WriteLine(GetCount(ref myQueue));
            TestMethod(PrintList(ref myQueue));

            TestMethod(AddItem(ref myQueue, "firstItem", "11111111"));
            TestMethod(AddItem(ref myQueue, "secondItem", "22222222"));
            TestMethod(AddItem(ref myQueue, "thirdItem", "33333333"));
            Console.WriteLine(GetCount(ref myQueue));
            TestMethod(PrintList(ref myQueue));

            TestMethod(Peek(ref myQueue));

            Console.WriteLine(GetCount(ref myQueue));

            TestMethod(RemoveItem(ref myQueue));
            Console.WriteLine(GetCount(ref myQueue));
            TestMethod(Peek(ref myQueue));
            TestMethod(PrintList(ref myQueue));
        }

        /// <summary>
        /// Run a test on a stack.
        /// </summary>
        public void RunStackTest()
        {
            Stack<Item> myStack = new Stack<Item>();
            Console.WriteLine("Testing Stack...");
            TestMethod(AddItem(ref myStack, "firstItem", "11111111"));

            Console.WriteLine(GetCount(ref myStack));
            TestMethod(PrintList(ref myStack));

            TestMethod(RemoveItem(ref myStack));
            Console.WriteLine(GetCount(ref myStack));
            TestMethod(PrintList(ref myStack));

            TestMethod(AddItem(ref myStack, "firstItem", "11111111"));
            TestMethod(AddItem(ref myStack, "secondItem", "22222222"));
            TestMethod(AddItem(ref myStack, "thirdItem", "33333333"));
            Console.WriteLine(GetCount(ref myStack));
            TestMethod(PrintList(ref myStack));

            TestMethod(Peek(ref myStack));

            Console.WriteLine(GetCount(ref myStack));

            TestMethod(RemoveItem(ref myStack));
            Console.WriteLine(GetCount(ref myStack));
            TestMethod(Peek(ref myStack));
            TestMethod(PrintList(ref myStack));
        }

        /// <summary>
        /// Add an item to the queue.
        /// </summary>
        /// <param name="passQ"></param>
        /// <param name="passName"></param>
        /// <param name="passNumber"></param>
        /// <returns></returns>
        private string AddItem(ref Queue<Item> passQ, string passName, string passNumber)
        {
            Item item = new Item(ref passName, ref passNumber);
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
        private string AddItem(ref Stack<Item> passStack, string passName, string passNumber)
        {
            Item item = new Item(ref passName, ref passNumber);
            Console.WriteLine("Adding Item: " + item.ToString());
            return CheckError(passStack.Push(ref item), ERROR_ADD_ITEM);
        }

        /// <summary>
        /// Remove an item from the queue.
        /// </summary>
        /// <param name="passQ"></param>
        /// <returns></returns>
        private string RemoveItem(ref Queue<Item> passQ)
        {
            Item item = new Item();
            string err = CheckError(passQ.Dequeue(ref item), ERROR_REMOVE_ITEM);
            Console.WriteLine("Removed Item: " + item.ToString());
            return err;
        }

        /// <summary>
        /// Remove an item from the stack.
        /// </summary>
        /// <param name="passStack"></param>
        /// <returns></returns>
        private string RemoveItem(ref Stack<Item> passStack)
        {
            Item item = new Item();
            string err = CheckError(passStack.Pop(ref item), ERROR_REMOVE_ITEM);
            Console.WriteLine("Removed Item: " + item.ToString());
            return err;
        }

        /// <summary>
        /// Write out the error message to the console if it exists.
        /// </summary>
        /// <param name="errorMessage"></param>
        private void TestMethod(string errorMessage)
        {
            if (errorMessage != null)
            { Console.WriteLine(errorMessage); }
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
        private string Peek(ref Queue<Item> passQ)
        {
            Item item = new Item();
            string err = CheckError(passQ.Peek(ref item), ERROR_PEEK_ERROR);
            Console.WriteLine("Peeking at the next Item in Queue: " + item.ToString());
            return err;
        }

        /// <summary>
        /// Get the next item on the stack without removing
        /// it from the list.
        /// </summary>
        /// <param name="passStack"></param>
        /// <returns></returns>
        private string Peek(ref Stack<Item> passStack)
        {
            Item item = new Item();
            string err = CheckError(passStack.Peek(ref item), ERROR_PEEK_ERROR);
            Console.WriteLine("Peeking at the next Item in Stack: " + item.ToString());
            return err;
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

    }
}
