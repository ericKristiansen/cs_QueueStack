using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Queue_Stack
{
    class LinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int count;

        public int Count => count;

        //Serve Peek Functionality
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

        //add to back of list
        public bool AppdendTail(ref T passData)
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

        public bool AppendHead(ref Node<T> passNode)
        {
            bool result = false;
            Node<T> second = head;
            try
            {
                head = passNode;
                head.Next = second;
                result = true;
            }
            catch (Exception ex)
            { Console.WriteLine(ex.ToString() + Environment.NewLine); }
            count++;
            return result;
        }

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

        //GetMatchingString
        public bool GetMatchingData(string passSearchString, ref Node<T> passNode)
        {
            bool result = false;
            try
            {
                if (head != null)
                {
                    Node<T> current = head;
                    while (current != null && !result)
                    {
                        if (current.ToString().Equals(passSearchString))
                        {
                            passNode = current;
                            result = true;
                        }
                        else
                        {
                            current = current.Next;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return result;
        }

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
