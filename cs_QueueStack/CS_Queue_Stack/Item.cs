
namespace CS_Queue_Stack
{

    /// <summary>
    /// This class exists to hold Item data
    /// </summary>
    class Item
    {
        private string name;
        private string number;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        public override string ToString()
        {
            return name + " : " + number;
        }

        public Item()
        {
        }

        public Item(Item passItem)
        {
            CopyItem(ref passItem.name, ref passItem.number);
        }

        public Item(ref string passName, ref string passNumber)
        {
            CopyItem(ref passName, ref passNumber);
        }

        private void CopyItem(ref string passName, ref string passNumber)
        {
            this.name = passName;
            this.number = passNumber;
        }
    }
}
