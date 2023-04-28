






ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));

ListNode newHead = ReverseList(head);


Console.ReadLine();


ListNode ReverseList(ListNode head)
{
    // Iteratively solution

    //ListNode prev = null;
    //ListNode curr = node;

    //while(curr != null)
    //{
    //    ListNode temp = curr.next;
    //    curr.next = prev;

    //    prev = curr;
    //    curr = temp;
    //}

    //return prev ;

    ////////////////////////////////////////////////////////////////////

    // Recursively solution


    if (head == null)
        return null;

    ListNode temp = head;

    if(head.next != null)
    {
        temp = ReverseList(head.next);
        temp.next = head;
        head.next = null;
    }

    return temp;
        


}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}