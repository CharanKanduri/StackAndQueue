using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating object for stack and queue operations
            StackAndQueueOperations stack = new StackAndQueueOperations();

            //Push operations
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            //Display operation
            Console.Write("\n-----DISPLAYING STACK ELEMENTS-----\n\n");
            stack.Display();

        }
    }
}
