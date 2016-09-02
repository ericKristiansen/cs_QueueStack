using System;

namespace CS_Queue_Stack
{
    /* FIFO: Remove Head, Append Tail */
    class Queue<T> : LinkedList<T>
    {
        public bool Enqueue(ref T passData)
        {
            return this.AppdendTail(ref passData);
        }

        public bool Dequeue(ref T passData)
        {
            bool result = false;
            try
            {
                result = RemoveHead(ref passData);
            }
            catch (Exception ex)
            { Console.WriteLine(ex.ToString()); }

            return result;
        }

        public bool Peek(ref T passData)
        {
            return this.GetHeadData(ref passData);
        }
        
    }
}
