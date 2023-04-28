



ListNode MiddleNode(ListNode head)
{
    #region firstBadWay
    int count = 0;
    ListNode temp = head;

    while(temp != null)
    {
        count++;
        temp = temp.next;
    }

    int middle = (count / 2);

    for (int i = 0; i <= middle; i++)
    {
        if (i == middle)
            return head;

        head = head.next;
    }

    return head;

    #endregion

    #region secondGoodWay

    //Create two pointer called fast and slow

    ListNode slow = head;
    ListNode fast = head.next;

    while(fast != null)
    {
        slow = slow.next;
        fast = fast.next;

        if(fast != null)
        {
            fast = fast.next;
        }

    }
    return slow;
    #endregion
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
