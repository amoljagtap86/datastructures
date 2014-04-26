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
    }
}
