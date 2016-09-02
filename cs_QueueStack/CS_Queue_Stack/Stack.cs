using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Queue_Stack
{
    /* LIFO: Add to Head, Pull from Head*/
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
