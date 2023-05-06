
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


TreeNode rootNode = new TreeNode(2);
rootNode.left = new TreeNode(7, new TreeNode(12, new TreeNode(1, null, new TreeNode(10,null,null)),null), new TreeNode(6, new TreeNode(5, null, null), new TreeNode(11, null, new TreeNode(13, null,null))));
rootNode.right = new TreeNode(5, null, null);





//AddNode(rootNode, 2);
//AddNode(rootNode, 7);
//AddNode(rootNode, 1);
//AddNode(rootNode, 3);
//AddNode(rootNode, 6);
//AddNode(rootNode, 9);

Console.WriteLine(DiameterOfBinaryTree(rootNode));

int DiameterOfBinaryTree(TreeNode root)
{
    int dia = 0;
    Height(root, ref dia);

    return dia > 0 ? dia - 1 : dia;

}



int Height(TreeNode node,ref int diameter)
{

    if (node == null)
        return 0;

    if (node.left == null && node.right == null)
        return 1;

    int leftHand = Height(node.left, ref diameter);
    int rightHand = Height(node.right, ref diameter);

    diameter = Math.Max(leftHand + rightHand + 1, diameter);

    return Math.Max(leftHand, rightHand) + 1;


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

