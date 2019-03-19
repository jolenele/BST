using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class BSTQueue
    {
        QueueNode head;
        public BSTQueue()
        {
            head = null;
        }
        public void enqueue(BSTNode curr)
        {
            QueueNode newNode = new QueueNode(curr);
            if(head == null)
            {
                head = newNode;
                return;
            }
            QueueNode temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp = newNode;
        }
        public BSTNode dequeue()
        {
            if(head != null)
            {
                BSTNode val = head.nodeData;
                head = head.next;
                return val;
            }
            Console.WriteLine("Head==null");
            return null;
        }
        public bool empty()
        {
            return head == null;
        }
    }
}
