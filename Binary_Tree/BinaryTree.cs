﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    class BinaryTree
    {
        Node root;

        BinaryTree(int key)
        {
            root = new Node(key);
        }

        BinaryTree()
        {
            root = null;
        }

        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();

            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);

            Console.WriteLine();
        }
    }
}
