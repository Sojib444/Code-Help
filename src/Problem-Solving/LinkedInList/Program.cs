
NodeList head = new(10);
NodeList list1 = new(20);
NodeList list2 = new(30);
NodeList list3 = new(40);

head.next = list1;
list1.next = list2;
list2.next = list3;
list3.next = null;

NodeList temp = head;

while(temp.next != null)
{
    Console.WriteLine(temp.data);
    temp = temp.next;
}

public class NodeList
{
    public NodeList()
    {
        data = 0;
        next = null;
    }

    public NodeList(int data)
    {
        this.data = data;
        this.next = null;
    }
    public int data { get; set; }
    public NodeList? next { get; set; }
}





