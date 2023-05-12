

TreeNode rootNode = new TreeNode(0);
//rootNode.right = new TreeNode(20, new TreeNode(15, null, null), new TreeNode(7, null, null));
//rootNode.left = new TreeNode(9, null, null);

Console.WriteLine(MaxDepth(rootNode));

int MaxDepth(TreeNode root)
{

    if (root == null)
        return 0;
    if (root.right == null && root.left == null)
        return 1;

    int leftDepth = MaxDepth(root.left);
    int rightDepth = MaxDepth(root.right);
    return Math.Max(leftDepth, rightDepth) + 1;

}




public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}