using System.Text;

namespace _09_Lab9
{
    internal class Program
    {
        public class Tree
        {
            public int Data;
            public Tree Left;
            public Tree Right;
        }
        public static int SummaElements(Tree root)
        {
            if (root == null)
                return 0;
            else
            {
                int count = 0;
                count += SummaElements(root.Left);
                count += SummaElements(root.Right);
                return count + root.Data;
            }
        }
        public static Tree AddNode(int inputDataNode, Tree root)
        {
            if (root == null)
            {
                root = new Tree();
                root.Data = inputDataNode;
                root.Left = null;
                root.Right = null;
            }
            else
            {
                if (inputDataNode < root.Data)
                {
                    root.Left = AddNode(inputDataNode, root.Left);
                }
                else if (inputDataNode > root.Data)
                {
                    root.Right = AddNode(inputDataNode, root.Right);
                }
            }
            return root;
        }
        public static void PrintLeaves(Tree root)
        {
            if (root != null)
            {
                //if (root.Left == null && root.Right == null)
                //{
                    Console.Write(root.Data + " ");
                //}
                PrintLeaves(root.Left);
                PrintLeaves(root.Right);
            }
        }

        public static Tree FillTree(Tree root, int count, int left, int right) {
            for (int i = 0; i < count; i++) {
                root = AddNode(new Random().Next(left, right), root);
            }
            return root;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Tree root = null;
            int countElements = 7;
            int left = -100;
            int right = 100;
            root = FillTree(root, countElements, left, right);
            Console.WriteLine("Дерево: ");
            PrintLeaves(root);

            Console.WriteLine("\n\nСума елементів : " + SummaElements(root));
        }
    }
}
