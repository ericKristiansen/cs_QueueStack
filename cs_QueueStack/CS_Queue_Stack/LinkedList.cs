
using System;

namespace CS_Queue_Stack
{
    /// <summary>
    /// This class exists to perform the necessary methods
    /// of a linked list.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class LinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int count;

        public int Count => count;

        /// <summary>
        /// Retrieve the head data without removing the data
        /// from the list.
        /// </summary>
        /// <param name="passData"></param>
        /// <returns></returns>
        public bool GetHeadData(ref T passData)
        {
            bool result = false;
            if (head != null)
            {
                try
                {
                    passData = head.Data;
                    result = true;
                }
                catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            }
            return result;
        }

        /// <summary>
        /// Retrieve the tail data without removing it
        /// from the list
        /// </summary>
        /// <param name="passData"></param>
        /// <returns></returns>
        public bool GetTail(ref T passData)
        {
            bool result = false;
            if (head != null)
            {
                try
                {
                    passData = tail.Data;
                    result = true;
                }
                catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            }
            return result;
        }

        /// <summary>
        /// Append data to the tail of the list.
        /// </summary>
        /// <param name="passData"></param>
        /// <returns></returns>
        public bool AppendTail(ref T passData)
        {
            Node<T> node = new Node<T>(ref passData);
            bool result = false;
            try
            {
                if (tail == null)
                {
                    head = tail = node;
                }
                else
                {
                    tail.Next = node;
                    tail = node;
                }
                count++;
                result = true;
            }
            catch (Exception ex)
            { Console.WriteLine(ex.ToString() + Environment.NewLine); }

            return result;
        }

        /// <summary>
        /// Append data to the head of the list.
        /// </summary>
        /// <param name="passData"></param>
        /// <returns></returns>
        public bool AppendHead(ref T passData)
        {
            bool result = false;
            Node<T> second = head;
            Node<T> node = new Node<T>(ref passData);
            try
            {
                head = node;
                head.Next = second;
                result = true;
            }
            catch (Exception ex)
            { Console.WriteLine(ex.ToString() + Environment.NewLine); }
            count++;
            return result;
        }

        /// <summary>
        /// Remove data from the head of the list.
        /// </summary>
        /// <param name="passData"></param>
        /// <returns></returns>
        public bool RemoveHead(ref T passData)
        {
            bool result = false;

            if (head != null) //no data
            {
                try
                {
                    passData = head.Data;
                    Node<T> second = null;

                    if (head.Next == null) //one data item
                    {
                        head = tail = null;
                    }
                    else //multiple data items 
                    {
                        second = head.Next;
                        head = null;
                        head = second;
                    }
                    count--;
                    result = true;
                }
                catch (Exception ex)
                { Console.WriteLine(ex.ToString()); }
            }

            return result;
        }

        /// <summary>
        /// Remove data from the tail of the list.
        /// </summary>
        /// <param name="passData"></param>
        /// <returns></returns>
        public bool RemoveTail(ref T passData)
        {
            bool result = false;

            if (tail != null)
            {
                try
                {
                    Node<T> current = head;
                    Node<T> previous = null;
                    passData = tail.Data;
                    if (current.Next == null) //only one node
                    {
                        head = tail = null;
                    }
                    else //more than one node
                    {
                        while (current.Next != null)
                        {
                            previous = current;
                            current = current.Next;
                        }

                        tail = previous;
                        tail.Next = null;
                    }
                    count--;
                    result = true;
                }
                catch (Exception ex)
                { Console.WriteLine(ex.ToString()); }
            }

            return result;
        }

        /// <summary>
        /// Search the list for the matching data.
        /// </summary>
        /// <param name="passSearchString"></param>
        /// <param name="passNode"></param>
        /// <returns></returns>
        public bool GetMatchingData(ref T passData, string passSearchString)
        {
            bool result = false;

            if (head != null)
            {
                try
                {
                    Node<T> current = head;
                    while (current != null && !result)
                    {
                        if (current.ToString().Contains(passSearchString))
                        {
                            passData = current.Data;
                            result = true; //stopping condition
                        }
                        else
                        {
                            if (current.Next != null)
                            {
                                current = current.Next;
                            }
                            else
                            {
                                current = null; //stopping condition
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

            return result;
        }

        /// <summary>
        /// Print the list to the console.
        /// </summary>
        /// <returns></returns>
        public bool PrintListToConsole()
        {
            bool result = false;
            Node<T> current = head;
            try
            {
                if (current != null)
                {
                    Console.WriteLine("List of Data: ");
                    Console.WriteLine("************************");
                    while (current != null)
                    {
                        Console.WriteLine(current.ToString());
                        if (current.Next != null)
                        { current = current.Next; }
                        else
                        { current = null; }
                    }
                    Console.WriteLine("************************" + Environment.NewLine);
                    result = true;
                }
            }
            catch (Exception ex)
            { Console.WriteLine(ex.ToString() + Environment.NewLine); }

            return result;
        }

        /// <summary>
        /// Get the existing list as a string value.
        /// </summary>
        /// <returns></returns>
        public string GetListAsString()
        {
            string resultString = "************************" + Environment.NewLine;
            resultString += "List of Data: " + Environment.NewLine;
            Node<T> current = head;

            while (current != null)
            {
                resultString += current.ToString() + Environment.NewLine;
                if (current.Next != null)
                { current = current.Next; }
                else
                { current = null; }
            }

            resultString += "************************" + Environment.NewLine;
            return resultString;
        }
    }
}
