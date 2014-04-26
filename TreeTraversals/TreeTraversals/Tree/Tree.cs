namespace TreeTraversals.Tree
{
    public class Tree
    {
        private string TraversedString { get; set; }

        public Node Root { get; set; }

        //V-L-R
        public string GetPreOrderTraversal()
        {
            TraversedString = string.Empty;
            return PerformPreOrderTraversal(Root);
        }

        //L-V-R
        public string GetInOrderTraversal()
        {
            TraversedString = string.Empty;
            return PerformInOrderTraversal(Root);
        }

        //L-R-V
        public string GetPostOrderTraversal()
        {
            TraversedString = string.Empty;
            return PerformPostOrderTraversal(Root);
        }

        private string PerformPostOrderTraversal(Node node)
        {
            if (node.Left != null)
            {
                PerformPostOrderTraversal(node.Left);
            }

            if (node.Right != null)
            {
                PerformPostOrderTraversal(node.Right);
            }

            TraversedString += node.Value;

            return TraversedString;
        }

        private string PerformPreOrderTraversal(Node node)
        {
            if (node != null)
            {
                TraversedString += node.Value;
            }

            if (node.Left != null)
            {
                PerformPreOrderTraversal(node.Left);
            }

            if (node.Right != null)
            {
                PerformPreOrderTraversal(node.Right);
            }
            return TraversedString;
        }

        private string PerformInOrderTraversal(Node node)
        {
            if (node.Left != null)
            {
                PerformInOrderTraversal(node.Left);
            }
            TraversedString += node.Value;
            if (node.Right != null)
            {
                PerformInOrderTraversal(node.Right);
            }
            return TraversedString;
        }
    }
}