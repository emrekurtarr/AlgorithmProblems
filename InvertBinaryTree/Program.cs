


TreeNode InvertTree(TreeNode root)
{
    if (root != null)
    {
        if(root.left is not null || root.right is not null)
        {
            TreeNode temp = root.left;
            root.left = root.right;
            root.right = temp;
        }
        
        if(root.right is not null)
        {
            InvertTree(root.right);
        }
        if(root.left is not null)
        {
            InvertTree(root.left);
        }

            

    }
    return root;
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

TreeNode rootNode = new TreeNode(4);
AddNode(rootNode, 2);
AddNode(rootNode, 7);
AddNode(rootNode, 1);
AddNode(rootNode, 3);
AddNode(rootNode, 6);
AddNode(rootNode, 9);

Console.WriteLine(InvertTree(rootNode));






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


