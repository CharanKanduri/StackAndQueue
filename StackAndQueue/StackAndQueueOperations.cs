using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class StackAndQueueOperations
    {
        Node top;

        //Push data at Top
        public void Push(int data)
        {
            Node newNode = new Node(data);
            top = Add(newNode);
        }

        //Add data at top
        public Node Add(Node newNode)
        {
            if (top == null)
            {
                top = newNode;
            }
            else
            {
                newNode.next = top;
                top = newNode;
            }
            return top;
        }
        //Display stack data
        public void Display()
        {
            Node temp = top;
            int count = 0;
            while (temp != null)
            {
                count++;
                Console.WriteLine("Stack element at {0} is: {1}", count, temp.data);
                temp = temp.next;
            }
        }
    }
}
