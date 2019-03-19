using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class QueueNode
    {
        public BSTNode nodeData;
        public QueueNode next;
        public QueueNode(BSTNode curr)
        {
            nodeData = curr;
            next = null;
        }
    }
}
