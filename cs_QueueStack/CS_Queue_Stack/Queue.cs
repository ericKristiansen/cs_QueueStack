using System;

namespace CS_Queue_Stack
{
    /// <summary>
    /// This class exists to serve FIFO functionality:
    /// Removes from the head, and appends to the tail.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Queue<T> : LinkedList<T>
    {
        public bool Enqueue(ref T passData)
        {
            return this.AppendTail(ref passData);
        }

        public bool Dequeue(ref T passData)
        {
            return RemoveHead(ref passData);
        }

        public bool Peek(ref T passData)
        {
            return this.GetHeadData(ref passData);
        }
        
    }
}
