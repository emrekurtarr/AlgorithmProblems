

//ListNode root = new ListNode(3);
//ListNode l2 = root.next = new ListNode(2);
//l2.next = new ListNode(0);
//ListNode tail = root.next.next.next = new ListNode(-4);
//tail.next = l2;

ListNode root = new ListNode(1);
root.next = new ListNode(2);

Console.WriteLine(HasCycle(root));

bool HasCycle(ListNode head)
{
    ListNode slow = head;
    ListNode fast = head;

    while(fast != null && fast.next != null)
    {
        slow = slow.next;
        fast = fast?.next?.next;

        if (slow == fast)
            return true;
    }

    return false;


}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x)
    {
        val = x;
        next = null;
    }
}