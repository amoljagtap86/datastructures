using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThreadedBinaryTreeTraversals.ThreadedBinaryTree;

namespace ThreadedBinaryTreeTraversals.Tests
{
    [TestClass]
    public class InOrderTreeTraversalTests
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

        [TestMethod]
        public void CanTraverseTreeWithLeftSubTree()
        {
            var tree = new Tree();

            var headerNode = new Node();
            headerNode.Right = headerNode;
            const string nodeValue = "A";


            var levelOneNode = new Node();
            var levelTwoNode = new Node();

            var rootNode = new Node
            {
                Left = levelOneNode,
                Right = headerNode,
                Value = nodeValue,
                HasLeftChild = true,
            };

            levelOneNode.Left = levelTwoNode;
            levelOneNode.Right = rootNode;
            levelOneNode.Value = "B";
            levelOneNode.HasLeftChild = true;

            levelTwoNode.Left = headerNode;
            levelTwoNode.Right = levelOneNode;
            levelTwoNode.Value = "C";

            headerNode.Left = rootNode;
            tree.HeaderNode = headerNode;

            Assert.AreEqual("CBA", tree.GetInOrderTraversal());
        }


        [TestMethod]
        public void CanTraverseTreeWithRightSubTree()
        {
            var tree = new Tree();

            var headerNode = new Node();
            headerNode.Right = headerNode;
            const string nodeValue = "A";


            var levelOneNode = new Node();
            var levelTwoNode = new Node();

            var rootNode = new Node
            {
                Left = headerNode,
                Right = levelOneNode,
                Value = nodeValue,
                HasRightChild = true,
            };

            levelOneNode.Right = levelTwoNode;
            levelOneNode.Left = rootNode;
            levelOneNode.Value = "B";
            levelOneNode.HasRightChild = true;

            levelTwoNode.Right = headerNode;
            levelTwoNode.Left = levelOneNode;
            levelTwoNode.Value = "C";

            headerNode.Left = rootNode;
            tree.HeaderNode = headerNode;

            Assert.AreEqual("ABC", tree.GetInOrderTraversal());
        }
    }
}
