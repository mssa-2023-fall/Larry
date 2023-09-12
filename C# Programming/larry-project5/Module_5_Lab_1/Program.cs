using System;
using System.Collections.Generic;

namespace Module_5_Lab
{
    public class GenericCollections
    {

        public static void Main()
        {
            var newConditions = new GenericCollections();
            newConditions.Conditions();
        }
        public void Conditions()
        {
            //Define a Stack
            Stack<int> someStack = new Stack<int>();
            //push onto the stack
            someStack.Push(1);
            someStack.Push(2);
            someStack.Push(3);
            //output all
            foreach (var s in someStack)
            {
                Console.WriteLine($"All elements in someStack: {s}");
            }
            //pop from stack
            someStack.Pop();
            Console.WriteLine($"\nMost recent element in someStack after a Pop: ({someStack.Peek()})\n");
            //Create a queue object
            Queue<int> someQueue = new Queue<int>();
            //Enqueue
            someQueue.Enqueue(124);
            someQueue.Enqueue(125);
            someQueue.Enqueue(126);
            //Dequeue
            foreach (var s in someQueue)
            {
                Console.WriteLine($"All elements in someQueue: {s}");
            }
            Console.WriteLine($"\nRunning Dequeue will remove: ({someQueue.Dequeue()}) : removing it now..");
            //Iterate
            Console.WriteLine("\nDisplaying queue");
            foreach (var s in someQueue)
            {
                Console.WriteLine(s);
            }

            //Implement stack with LinkedList
            LinkedList<string> someLList = new LinkedList<string>();
            someLList.AddFirst("a");
            someLList.AddLast("z");
            Console.WriteLine("\nAll elements in LinkedList: ");
            foreach (var s in someLList)
            {
                Console.WriteLine(s);
            }









            Console.ReadLine();

        }
    }
}

        