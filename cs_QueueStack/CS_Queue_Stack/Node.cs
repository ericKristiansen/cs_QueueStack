

namespace CS_Queue_Stack
{
    class Node<T>
    {
        //privaate Node next;
        private T data;
        private Node<T> next;

        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        public Node<T> Next
        {
            get { return next; }
            set { next = value; }
        }

        public override string ToString()
        {
            return data.ToString();
        }

        public Node(ref Node<T> passNode)
        {
            this.data = passNode.data;
        }

        public Node(ref T passData)
        {
            this.data = passData;
        }
        public Node()
        {
        }

    }
}
