using System.Collections;

namespace Assignment_2_C_
{
    internal class Program
    {
        #region function of question 1
        public static ArrayList reverse (ArrayList list)
        {
            int [] ret = new int[list.Count];
            list.CopyTo(ret);
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = ret[list.Count-1-i];
            }
            return list;
        }

        #endregion

        #region function of question 2
        public static List<int> Even (List<int> list)
        {
            List<int> ret = new List<int>();
            for (int i = 0;i < list.Count;i++)
            {
                if (list[i] %2 == 0)
                    ret.Add(list[i]);
            }
            return ret;
        }
        #endregion
        static void Main(string[] args)
        {
            #region Part 1

            #region Array List
            // ArrayList is a collection class provided by
            // the .NET Framework that is part of the System.Collections namespace. It represents a dynamically sized array that can hold items of any type,
            // making it a flexible data structure for handling lists of objects.

            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add("fatma");
            //list.Add(true);
            #endregion

            #region List
            //List<T> class represents the list of objects which can be accessed by index.
            //It comes under the System.Collections.Generic namespace.
            //List class can be used to create a collection of different types like integers, strings etc.
            //List<T> class also provides the methods to search, sort, and manipulate lists.

            //List<string> list = new List<string>();
            //list.Add("A");
            //list.Add("B");
            //list.Add("C");
            #endregion

            #region linked list
            // LinkedList<T> is a collection that represents a doubly linked list.
            // It is part of the System.Collections. Generic namespace and provides a way
            // to store and manage a sequence of elements with flexible insertion and deletion operations.
            // Unlike arrays or List<T>, LinkedList<T> does not provide indexed access
            // but is optimized for scenarios where you need efficient insertions and deletions.

            //LinkedList<int> list = new LinkedList<int>();
            //list.AddFirst(1);
            //list.AddLast(2);
            //list.AddAfter(list.Find(2), 5);

            #endregion

            #region stack
            //Stack<T> is a generic collection provided by the System.Collections.Generic namespace
            //that represents a last-in, first-out (LIFO) collection of objects.
            //This means that the last item added to the stack is the first one to be removed.
            //It is useful for scenarios where you need to keep track of objects in reverse order of their addition,
            //such as undo functionality, parsing expressions, and backtracking algorithms.

            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Pop();
            #endregion

            #region Queue
            //Queue<T> is a generic collection provided by the System.Collections.Generic namespace
            //that represents a first-in, first-out (FIFO) collection of objects.
            //This means that the first item added to the queue is the first one to be removed.
            //This structure is useful for scenarios where you need to process items in the order they were added,
            //such as task scheduling, buffering, or managing a sequence of events.

            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Dequeue();
            #endregion

            #region compare between collection
             /*
                 Structure	 |  Access |  Insertion/Deletion (End)	| Insertion/Deletion (Middle/Start)	  |  Business Case
                 ----------------------------------------------------------------------------------------------------------
                 Array List	 |   O(1)  |	O(1) (amortized)	    |          O(n)	                      |       Fast access; dynamic resizing; use for read-heavy scenarios
                 Linked List |	 O(n)  |	O(1)	                |          O(1) (with reference)	  |       Frequent insertions/deletions; use for dynamic collections
                 Queue	     |   O(1)  |	O(1)	                |          N/A	                      |       FIFO processing; use for task scheduling, buffering
                 Stack	     |   O(1)  |	O(1)	                |          N/A	                      |       LIFO processing; use for undo mechanisms, expression parsing

             */
            #endregion

            #endregion

            #region Part 2
            #region Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.
            //ArrayList arrayList = new ArrayList();
            //arrayList.AddRange(new[] {1,2,3,4,5});
            //foreach (int i in arrayList)
            //    Console.Write(i + " ");
            //reverse(arrayList);
            //Console.WriteLine("\n=========================");
            //foreach (int i in arrayList)
            //    Console.Write(i + " ");
            #endregion

            #region find and return a new list containing only the even numbers
            //List<int> list = new List<int>();
            //list.AddRange(new[]  { 1, 2, 3 ,4 , 5 , 6, 7 , 8 , 9 });
            //foreach (int i in Even(list))
            //    Console.WriteLine(i);
            #endregion

            #region implement a custom list called FixedSizeList<T>
            //FixedSizeList <int> fixedSizeList = new FixedSizeList<int>(5);
            //fixedSizeList.Add(0);
            //fixedSizeList.Add(1);
            //fixedSizeList.Add(2);
            //fixedSizeList.Add(3);
            //fixedSizeList.Add(4);
            //Console.WriteLine(fixedSizeList.GetValue(3));
            //fixedSizeList.Add(5);
            //Console.WriteLine(fixedSizeList.GetValue(7));
            #endregion
            #endregion
        }
    }
}
