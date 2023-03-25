

TreeNode root = new TreeNode(1);
root.right = new TreeNode(2);
root.left = new TreeNode(2);
root.left.left = new TreeNode(3);
root.right.right = new TreeNode(3);
root.left.left.left = new TreeNode(4);
root.right.right.right = new TreeNode(4);

if (IsBalanced(root))
    Console.WriteLine("Dengeli");
else
    Console.WriteLine("Dengeli değil");





bool IsBalanced(TreeNode root)
{
    if (root == null)
        return true;

    if (Math.Abs(Height(root.left) - Height(root.right)) > 1)
        return false;

    return IsBalanced(root.right) && IsBalanced(root.left);


}

int Height(TreeNode root)
{
    if (root == null)
        return -1;

    int val = 1 + Math.Max(Height(root.right), Height(root.left));

    return val;
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
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}