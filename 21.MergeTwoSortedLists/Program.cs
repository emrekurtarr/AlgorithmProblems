



ListNode root1 = new ListNode(1, new ListNode(2, new ListNode(4, null)));

ListNode root2 = new ListNode(1, new ListNode(3, new ListNode(4, null)));

Console.WriteLine(MergeTwoLists(root1, root2).val);





ListNode MergeTwoLists(ListNode list1, ListNode list2)
{
    ListNode root = new ListNode();
    ListNode temp = root;

    while(list1 != null && list2 != null)
    {
        if(list1.val >= list2.val)
        {
            root.next = list2;
            list2 = list2.next;
        }
        else
        {
            root.next = list1;
            list1 = list1.next;
        }

        root = root.next;

    }


    if (list1 != null)
        root.next = list1;
    else if (list2 != null)
        root.next = list2;

    return temp.next ;


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



   



