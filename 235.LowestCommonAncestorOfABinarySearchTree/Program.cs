

TreeNode rootNode = new TreeNode(2);
AddNode(rootNode, 1);
//AddNode(rootNode, 8);
//AddNode(rootNode, 0);
//AddNode(rootNode, 4);
//AddNode(rootNode, 7);
//AddNode(rootNode, 9);

Console.WriteLine(LowestCommonAncestor(rootNode, new TreeNode(2), new TreeNode(1)).val);

TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
{
    TreeNode ancestor = null;

    if ((root.val >= p.val && root.val <= q.val) || (root.val <= p.val && root.val >= q.val))
        ancestor = root;

    else if (root.val < q.val && root.val < p.val)
        ancestor = LowestCommonAncestor(root.right, p, q);

    else if (root.val > p.val && root.val > q.val)
        ancestor = LowestCommonAncestor(root.left, p, q);

    return ancestor;
}

void AddNode(TreeNode rootNode, int value)
{
    if (value < rootNode.val)
    {
        if (rootNode.left is null)
        {
            rootNode.left = new TreeNode(value);
        }
        else
        {
            AddNode(rootNode.left, value);
        }
    }
    else
    {
        if (rootNode.right is null)
        {
            rootNode.right = new TreeNode(value);
        }
        else
        {
            AddNode(rootNode.right, value);
        }
    }
}



public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }


}