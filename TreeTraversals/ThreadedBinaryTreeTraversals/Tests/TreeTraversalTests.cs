using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThreadedBinaryTreeTraversals.ThreadedBinaryTree;

namespace ThreadedBinaryTreeTraversals.Tests
{
    [TestClass]
    public class TreeTraversalTests
    {
        [TestMethod]
        public void ShouldTraverseSingleNode()
        {
            var tree = new Tree();
            var headerNode = new Node();
            headerNode.Right = headerNode;
            const string nodeValue = "A";
            var rootNode = new Node { Left = headerNode, Right = headerNode, Value = nodeValue };
            headerNode.Left = rootNode;
            tree.HeaderNode = headerNode;
            var inOrderTraversal = tree.GetInOrderTraversal();
            Assert.AreEqual(nodeValue, inOrderTraversal);
        }

        [TestMethod]
        public void CanTraverseTreeWithHeightOne()
        {
            var tree = new Tree();

            var headerNode = new Node();
            headerNode.Right = headerNode;
            const string nodeValue = "A";


            var leftNode = new Node();
            var rightNode = new Node();

            var rootNode = new Node
            {
                Left = leftNode,
                Right = rightNode,
                Value = nodeValue,
                HasLeftChild = true,
                HasRightChild = true
            };

            leftNode.Left = headerNode;
            leftNode.Right = rootNode;
            leftNode.Value = "B";

            rightNode.Left = rootNode;
            rightNode.Right = headerNode;
            rightNode.Value = "C";

            headerNode.Left = rootNode;
            tree.HeaderNode = headerNode;

            Assert.AreEqual("BAC", tree.GetInOrderTraversal());
        }
    }
}
