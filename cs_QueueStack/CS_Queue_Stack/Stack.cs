
namespace CS_Queue_Stack
{
    /* LIFO: Add to Head, Pull from Head*/
    /// <summary>
    /// This class exists to perform 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Stack<T> : LinkedList<T>
    {
        public bool Peek(ref T passData)
        {
            return this.GetHeadData(ref passData);
        }

        public bool Pop(ref T passData)
        {
            return this.RemoveHead(ref passData);
        }

        public bool Push(ref T passData)
        {
            return this.AppendHead(ref passData);
        }

    }
}
