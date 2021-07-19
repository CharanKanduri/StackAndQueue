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
        public int Display()
        {
            Node temp = top;
            int count = 0;
            while (temp != null)
            {
                count++;
                Console.WriteLine("Stack element at {0} is: {1}", count, temp.data);
                temp = temp.next;
            }
            return count;
        }

        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("\nStack is empty! Nothing to Pop");
                return;
            }
            Console.WriteLine("\n***POPPED ELEMENT***\n{0}", Peek());
            top = top.next;
        }

        //Peek at top element and return
        public int Peek()
        {
            if (top == null)
            {
                Console.WriteLine("No element in stack to pop");
                return -1;
            }
            return top.data;
        }
    }
}
