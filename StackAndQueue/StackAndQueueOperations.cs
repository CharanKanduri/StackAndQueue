using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class StackAndQueueOperations
    {
        Node front;

        //Push data at Top
        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            Append(newNode);
        }

        //Add data at top
        public void Append(Node newNode)
        {
            if (front == null)
            {
                front = newNode;
            }
            else
            {
                Node temp = GetLastNode();
                temp.next = newNode;

            }
        }

        public Node GetLastNode()
        {
            Node temp = front;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }


        //Dequeue data from front
        public void Dequeue()
        {
            if (front == null)
            {
                Console.WriteLine("\nQueue is empty! Nothing to Pop");
                return;
            }
            Console.WriteLine("\nDE QUEUED ELEMENT: {0}", front.data);
            front = front.next;
        }
        //Display stack data
        public int Display()
        {
            Node temp = front;
            int count = 0;
            while (temp != null)
            {
                count++;
                Console.WriteLine("Stack element at {0} is: {1}", count, temp.data);
                temp = temp.next;
            }
            return count;
        }
    }
}
