namespace LinkedInList
{
    public class NodeList
    {
        private Node Head;

        public void AddFirst(int data)
        {
            Node node = new Node(data);

            if (Head == null)
            {
                Head = node;
            }
            else
            {
                var current = Head;
                Head = node;
                node.Next = current;
            }
        }

        public void AddLast(int data)
        {
            Node node = new Node(data);

            if (Head == null)
            {
                Head = node;
            }
            else
            {
                Node current = Head;

                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = node;
            }
        }

        public void DisplayAll()
        {
            var tem = Head;

            while (tem != null)
            {
                Console.WriteLine(tem.Data);
                tem = tem.Next;
            }
        }
    }
}
