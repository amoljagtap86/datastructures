namespace ThreadedBinaryTreeTraversals.ThreadedBinaryTree
{
    public class Tree
    {
        public Node HeaderNode { get; set; }

        public string GetInOrderTraversal()
        {
            var node = HeaderNode.Left;
            string inOrder = string.Empty;

            while (node != HeaderNode)
            {
                if (node.IsVisited == false)
                {
                    node.IsVisited = true;
                    if (node.HasLeftChild)
                    {
                        node = node.Left;
                        continue;
                    }
                }
                inOrder += node.Value;
                node = node.Right;
            }
            return inOrder;
        }
    }
}
