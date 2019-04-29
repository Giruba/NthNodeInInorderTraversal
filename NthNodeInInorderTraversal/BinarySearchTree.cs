using System;
using System.Collections.Generic;
using System.Text;

namespace NthNodeInInorderTraversal
{
    class BinarySearchTree
    {
        BinarySearchTreeNode root;

        public BinarySearchTree(BinarySearchTreeNode binarySearchTreeNode) {
            root = binarySearchTreeNode;
        }

        public BinarySearchTreeNode GetBinarySearchTreeRoot() {
            return root;
        }

        public void SetBinarySearchTreeRoot(BinarySearchTreeNode binarySearchTreeNode) {
            root = binarySearchTreeNode;
        }

        public BinarySearchTreeNode Insert(BinarySearchTreeNode binarySearchTreeNode, int data) {

            if (binarySearchTreeNode == null) {
                binarySearchTreeNode = new BinarySearchTreeNode(data);
                return binarySearchTreeNode;
            }

            if (binarySearchTreeNode.GetBinarySearchTreeNodeData() < data)
            {
                binarySearchTreeNode.SetBinarySearchNodeRight(
                    Insert(binarySearchTreeNode.GetBinarySearchTreeNodeRight(), data));
            }
            else {
                binarySearchTreeNode.SetBinarySearchNodeLeft(
                    Insert(binarySearchTreeNode.GetBinarySearchTreeNodeLeft(), data));
            }
            return binarySearchTreeNode;
        }

        public void PrintNthNodeinInorder(BinarySearchTreeNode binarySearchTreeNode, int count, int nthValue) {

            if (binarySearchTreeNode == null) return;
            count++;
            PrintNthNodeinInorder(binarySearchTreeNode.GetBinarySearchTreeNodeLeft(), count, nthValue);
            if (count == nthValue) {
                Console.WriteLine("The Nth node's value is "+binarySearchTreeNode.GetBinarySearchTreeNodeData());
                return;
            }
            PrintNthNodeinInorder(binarySearchTreeNode.GetBinarySearchTreeNodeRight(), count, nthValue);
        }
    }
}
