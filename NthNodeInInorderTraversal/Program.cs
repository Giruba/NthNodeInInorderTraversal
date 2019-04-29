using System;

namespace NthNodeInInorderTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nth node in Inorder traversal!");
            Console.WriteLine("------------------------------");

            
            try{
                BinarySearchTree binarySearchTree = GetBinarySearchTreeFromInput();
                Console.WriteLine("Enter the nth node to be found in Inorder traversal");
                int nthNode = int.Parse(Console.ReadLine().Trim());
                binarySearchTree.PrintNthNodeinInorder(binarySearchTree.GetBinarySearchTreeRoot(), 0, nthNode);
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }


            Console.ReadLine();
        }

        private static BinarySearchTree GetBinarySearchTreeFromInput() {
            Console.WriteLine("Enter the number of nodes in the binary search tree");
            BinarySearchTree binarySearchTree = null;
            try{
                int numberNodes = int.Parse(Console.ReadLine().Trim());
                binarySearchTree = new BinarySearchTree(null);
                Console.WriteLine("Enter the elements of the " +
                    "binary search tree separated by space, comma" +
                    " or semi-colon");
                String[] elements = Console.ReadLine().Split(' ', ',', ';');
                for (int index = 0; index < numberNodes; index++) {
                    binarySearchTree.SetBinarySearchTreeRoot(binarySearchTree.Insert(binarySearchTree.GetBinarySearchTreeRoot(),
                        int.Parse(elements[index])));
                }

            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }
            return binarySearchTree;
        }
    }
}
