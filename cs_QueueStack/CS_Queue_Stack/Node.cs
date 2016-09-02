
namespace CS_Queue_Stack
{
    /// <summary>
    /// This class exists as a wrapper for our data.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Node<T>
    {
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
