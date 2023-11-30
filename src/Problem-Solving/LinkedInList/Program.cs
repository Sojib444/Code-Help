
NodeList head = new(10);
NodeList tail = new(99);
//NodeList second = new(20);
//NodeList third = new(20);

//head.next = second;
//second.next = third;

//Lets Insert left of the head
head.IsertAtTail(ref head, ref tail,300);
head.IsertAtHead(ref head, ref tail, 1000);
head.IsertAtHead(ref head, ref tail, 23);
head.IsertAtHead(ref head, ref tail, 1042400);

NodeList temp = head;

while (temp != null)
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

    public void IsertAtHead(ref NodeList head, ref NodeList tail, int data)
    {
        if (head == null)
        {
            head.data = data;
            head.next = tail;
        }
        else
        {
            NodeList newNode = new NodeList(data);
            newNode.next = head;
            head = newNode;
        }         
    }

    public void IsertAtTail(ref NodeList head, ref NodeList tail, int data)
    {
        if (head == null)
        {
            head.data = data;
            head.next = null;
        }
        else
        {
            NodeList newNode = new NodeList(data);
            newNode.next = tail;
        }

    }
}





