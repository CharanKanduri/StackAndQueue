using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating object for stack and queue operations
            StackAndQueueOperations queue = new StackAndQueueOperations();

            //Push operations
            int count = 0;
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);

            //Display operation
            Console.Write("\n-----DISPLAYING QUEUE ELEMENTS-----\n\n");
            count = queue.Display();

        }
    }
}
