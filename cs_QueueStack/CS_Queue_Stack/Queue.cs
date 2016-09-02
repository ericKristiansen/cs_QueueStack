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
            return RemoveHead(ref passData);
        }

        public bool Peek(ref T passData)
        {
            return this.GetHeadData(ref passData);
        }
        
    }
}
