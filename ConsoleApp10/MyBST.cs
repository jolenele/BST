using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class MyBST
    {
        BSTNode root;
        public MyBST()
        {
            root = null;
        }
        public void insert(int n)
        {
            root = insertWorker(root, n);
        }
        private BSTNode insertWorker(BSTNode curr, int n)
        {
            if (curr == null) return new BSTNode(n);
            if (n < curr.data) curr.left = insertWorker(curr.left, n);
            if (n > curr.data) curr.right = insertWorker(curr.right, n);
            return curr;
        }
        public int search(int n)
        {
            return searchWorker(root, n);
        }
        private int searchWorker(BSTNode curr, int n)
        {
            //if (key.data == root.data) return key.data;
            //if (key.data < root.data) key.left = search(key.left);
            //if (key.data > root.data) key.right = search(key.right);
            if (curr == null) return -1;
            if (curr.data == n) return curr.data;
            if (n < curr.data) return searchWorker(curr.left, n);
            return searchWorker(curr.right, n);
        }
        private int searchNonRec(int n)
        {
            BSTNode curr = root;
            while (curr != null)
            {
                if (curr.data == n) return n;
                if (curr.data < n) curr = curr.right;
                else curr = curr.left;
            }
            return -1;
        }
        private void InOrderTrav(BSTNode curr)
        {   
            //BSTNode curr;
            //if (root == null) curr = root;
            //if (root.left < ) curr = root.left;
            //if (root.right >) curr = root.right;
            if (root == null) return;
            InOrderTrav(curr.left);
            Console.Write("{0} ",curr.data);
            InOrderTrav(curr.right);
        }
        private void PreOrderTrav(BSTNode curr)
        {
            if (root == null) return;
            Console.Write("{0} ", curr.data);
            PreOrderTrav(curr.left);
            PreOrderTrav(curr.right);
        }
        private void PostOrderTrav(BSTNode curr)
        {
            if (root == null) return;
            PreOrderTrav(curr.left);
            PreOrderTrav(curr.right);
            Console.Write("{0} ", curr.data);
        }
        public void LevelOrder()
        {
            BSTNode curr;
            BSTQueue Q = new BSTQueue();
            Q.enqueue(root);
            while (!Q.empty())
            {
                curr = Q.dequeue();
                Console.Write("{0} ", curr.data);
                if (curr.left != null) Q.enqueue(curr.left);
                if (curr.right != null) Q.enqueue(curr.right);
            }
            Console.WriteLine();
        }
    }
}
