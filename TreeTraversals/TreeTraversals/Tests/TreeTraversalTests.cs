using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreeTraversals.Tree;

namespace TreeTraversals.Tests
{
    [TestClass]
    public class TreeTraversalTests
    {
        [TestMethod]
        public void CanTraverseSingleNode()
        {
            var singleNodeTree = new Tree.Tree();
            var rootNode = new Node { Value = "A" };

            singleNodeTree.Root = rootNode;

            Assert.AreEqual("A", singleNodeTree.GetPreOrderTraversal());
            Assert.AreEqual("A", singleNodeTree.GetInOrderTraversal());
            Assert.AreEqual("A", singleNodeTree.GetPostOrderTraversal());
        }

        [TestMethod]
        public void CanTraverseTreeWithHeightOne()
        {
            var singleNodeTree = new Tree.Tree();
            var rootNode = new Node { Value = "A" };
            var leftNode = new Node { Value = "B" };
            var rightNode = new Node { Value = "C" };
            rootNode.Left = leftNode;
            rootNode.Right = rightNode;

            singleNodeTree.Root = rootNode;

            Assert.AreEqual("ABC", singleNodeTree.GetPreOrderTraversal());
            Assert.AreEqual("BAC", singleNodeTree.GetInOrderTraversal());
            Assert.AreEqual("BCA", singleNodeTree.GetPostOrderTraversal());
        }

        [TestMethod]
        public void CanTraverseTreeWithOnlyLeftSubtree()
        {
            var singleNodeTree = new Tree.Tree();
            var rootNode = new Node { Value = "P" };
            var levelOneNode = new Node { Value = "Q" };
            var levelTwoNode = new Node { Value = "R" };
            levelOneNode.Left = levelTwoNode;
            rootNode.Left = levelOneNode;
            singleNodeTree.Root = rootNode;

            Assert.AreEqual("PQR", singleNodeTree.GetPreOrderTraversal());
            Assert.AreEqual("RQP", singleNodeTree.GetInOrderTraversal());
            Assert.AreEqual("RQP", singleNodeTree.GetPostOrderTraversal());
        }

        [TestMethod]
        public void CanTraverseTreeWithOnlyRightSubtree()
        {
            var singleNodeTree = new Tree.Tree();
            var rootNode = new Node { Value = "P" };
            var levelOneNode = new Node { Value = "Q" };
            var levelTwoNode = new Node { Value = "R" };
            levelOneNode.Right = levelTwoNode;
            rootNode.Right = levelOneNode;
            singleNodeTree.Root = rootNode;

            Assert.AreEqual("PQR", singleNodeTree.GetPreOrderTraversal());
            Assert.AreEqual("PQR", singleNodeTree.GetInOrderTraversal());
            Assert.AreEqual("RQP", singleNodeTree.GetPostOrderTraversal());
        }
    }
}
