



NodeList list = new NodeList(0);
list.AddFirst(10);
list.AddFirst(20);
list.AddFirst(30);

while(list.next != null)
{
    Console.WriteLine(list.data);
    list.head = list.next;
}


//LinkedList<int> nodeLists = new LinkedList<int>();
public class NodeList
{
    public NodeList(int data)
    {
        this.data = data;
    }

    public int data {  get; set; }
    public NodeList next { get; set; }

    public void AddFirst(int data)
    {
        NodeList nodeList = new NodeList(data);

        if(head != null)
        {
            nodeList.next = head;
            head = nodeList;
        }
        else
        {
            head = nodeList;
        }
    }

}
