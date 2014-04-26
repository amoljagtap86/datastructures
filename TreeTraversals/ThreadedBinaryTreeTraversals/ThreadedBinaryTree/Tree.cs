namespace ThreadedBinaryTreeTraversals.ThreadedBinaryTree
{
    public class Tree
    {
        public Node HeaderNode { get; set; }

        public string GetInOrderTraversal()
        {
            var root = HeaderNode.Left;
            return root.Value;
        }
    }
}
