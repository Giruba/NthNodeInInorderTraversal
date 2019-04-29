using System;
using System.Collections.Generic;
using System.Text;

namespace NthNodeInInorderTraversal
{
    class BinarySearchTreeNode
    {
        int data;
        BinarySearchTreeNode left;
        BinarySearchTreeNode right;

        public BinarySearchTreeNode(int data) {
            this.data = data;
        }

        public void SetBinarySearchTreeNodeData(int data) {
            this.data = data;
        }

        public int GetBinarySearchTreeNodeData(){
            return data;
        }

        public BinarySearchTreeNode GetBinarySearchTreeNodeLeft() {
            return left;
        }

        public BinarySearchTreeNode GetBinarySearchTreeNodeRight() {
            return right;
        }

        public void SetBinarySearchNodeLeft(BinarySearchTreeNode binarySearchTreeNode) {
            left = binarySearchTreeNode;
        }

        public void SetBinarySearchNodeRight(BinarySearchTreeNode binarySearchTreeNode) {
            right = binarySearchTreeNode;
        }
    }
}
