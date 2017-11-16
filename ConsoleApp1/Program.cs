using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Node
    {
        public int data;
        public Node right;
        public Node left;

    }
    class BST
    {
        public Node root;
        public BST(int data) { root = CreateNode(data); }
        private Node CreateNode(int data)
        {
            Node temp = new Node();
            temp.data = data;
            temp.right = null;
            temp.left = null;
            return temp;
        }
        public void Insert(int data)
        {
            Node current = root;

            while (true)
            {
                if (data > current.data)
                {
                    if (current.right == null) break;
                    current = current.right;
                }
                else  
                {
                    if (current.left == null) break;
                    current = current.left;
                }
                

            }
            Node temp = new Node();
            temp = CreateNode(data);
            if(data > current.data )
            {
                current.right = temp;

            }
            else
            {
                current.left = temp;

            }
        }

            public void Preorder(Node root)
        {
            if (root != null)
            {
                Console.Write(root.data+" ");
                Preorder(root.left);
                Preorder(root.right);
            }
        }
    }



    class Program
    {


        static void Main(string[] args)
        {


            BST a = new BST(10);
            a.Insert(3);
            a.Insert(5);
            a.Insert(11);
            a.Insert(12);
            a.Insert(13);
            a.Insert(15);

            int[] c = new int [10] ;
            Console.WriteLine(c.GetLength(0));
            Console.WriteLine(a.GetType());
            a.Preorder(a.root);
            Console.ReadKey();
        }

   
    }
}
