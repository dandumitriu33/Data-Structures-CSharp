﻿using System;
using DataStructuresPractice.HashMap;
using DataStructuresPractice.Heap;
using DataStructuresPractice.Tree;

namespace DataStructuresPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            #region HashTable HashMap Dictionary manual implementation
            // HashTable (HashMap, Dictionary)

            //var h = new DataStructuresPractice.HashMap.HashTable<int>(4);

            //Console.WriteLine(h.GetBucketByKey("One"));
            //Console.WriteLine(h.GetBucketByKey("Two"));
            //Console.WriteLine(h.GetBucketByKey("Three"));

            //h.Add("One", 1);
            //h.Add("Two", 2);
            //h.Add("Three", 3);

            //Console.WriteLine(h.Get("One"));
            //Console.WriteLine(h.Get("Two"));
            //Console.WriteLine(h.Get("Three"));

            //try
            //{
            //    Console.WriteLine(h.Get("Four"));
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Console.WriteLine(h.Remove("Three"));
            //Console.WriteLine(h.Remove("Three"));
            //Console.WriteLine(h.Remove("Two"));
            //Console.WriteLine(h.Remove("Two"));
            #endregion

            #region Trie w/ find prefix and find word
            //Trie.Trie t = new Trie.Trie();
            //t.CreateRoot();
            //Console.WriteLine("The list of words is: abc, abgl, cdf, abcd, lmn.");
            //t.Add("abc".ToCharArray());
            //t.Add("abgl".ToCharArray());
            //t.Add("cdf".ToCharArray());
            //t.Add("abcd".ToCharArray());
            //t.Add("lmn".ToCharArray());

            //string search1 = "ab";
            //bool findPrefix1 = t.FindPrefix(search1.ToCharArray());
            //Console.WriteLine($"The search for '{search1}' resulted in: {findPrefix1}");
            //string search2 = "lo";
            //bool findPrefix2 = t.FindPrefix(search2.ToCharArray());
            //Console.WriteLine($"The search for '{search2}' resulted in: {findPrefix2}");

            //string searchWord1 = "lmn";
            //bool findWord1 = t.FindWord(searchWord1.ToCharArray());
            //Console.WriteLine($"The search for '{searchWord1}' resulted in: {findWord1}");
            //string searchWord2 = "ab";
            //bool findWord2 = t.FindWord(searchWord2.ToCharArray());
            //Console.WriteLine($"The search for '{searchWord2}' resulted in: {findWord2}");
            //string searchWord3 = "cdf";
            //bool findWord3 = t.FindWord(searchWord3.ToCharArray());
            //Console.WriteLine($"The search for '{searchWord3}' resulted in: {findWord3}");
            //string searchWord4 = "ghi";
            //bool findWord4 = t.FindWord(searchWord4.ToCharArray());
            //Console.WriteLine($"The search for '{searchWord4}' resulted in: {findWord4}");
            #endregion

            #region Binary Search Tree

            //BinaryTree binaryTree = new BinaryTree();

            //binaryTree.Add(1);
            //binaryTree.Add(2);
            //binaryTree.Add(7);
            //binaryTree.Add(3);
            //binaryTree.Add(10);
            //binaryTree.Add(5);
            //binaryTree.Add(8);

            //Node node = binaryTree.Find(5);
            //int depth = binaryTree.GetTreeDepth();

            //Console.WriteLine("PreOrder Traversal:");
            //binaryTree.TraversePreOrder(binaryTree.Root);
            //Console.WriteLine();

            //Console.WriteLine("InOrder Traversal:");
            //binaryTree.TraverseInOrder(binaryTree.Root);
            //Console.WriteLine();

            //Console.WriteLine("PostOrder Traversal:");
            //binaryTree.TraversePostOrder(binaryTree.Root);
            //Console.WriteLine();

            //binaryTree.Remove(7);
            //binaryTree.Remove(8);

            //Console.WriteLine("PreOrder Traversal After Removing Operation:");
            //binaryTree.TraversePreOrder(binaryTree.Root);
            //Console.WriteLine();
            #endregion

            #region MinHeap

            MinHeap minimum = new MinHeap(11);
            minimum.Add(11);
            minimum.Add(10);
            minimum.Add(7);
            minimum.Add(9);
            minimum.Add(5);
            minimum.Add(6);
            minimum.Add(4);
            minimum.Add(8);
            minimum.Add(2);
            minimum.Add(3);
            minimum.Add(1);

            Console.WriteLine($"The minimum is: {minimum.Peek()}");

            #endregion

        }
    }
}
