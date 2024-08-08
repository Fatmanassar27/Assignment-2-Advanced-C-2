using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace Demo
{
    internal class Program
    {
        #region Sum function
        //public static int Sum(ArrayList arrayList)
        //{
        //    int sum = 0;
        //    if (arrayList != null)
        //        for (int i = 0; i < arrayList.Count; i++)
        //            sum += (int)arrayList[i];
        //    return sum;
        //}
        #endregion

        #region SumList Function
        //public static int Sum(List <int> list)
        //{
        //    int sum = 0;
        //    if (list != null)
        //        for (int i = 0; i < list.Count; i++)
        //            sum += list[i];
        //    return sum;
        //}
        #endregion


        static void Main(string[] args)
        {
            #region ArrayList
            //ArrayList arrayList = new ArrayList();
            //Console.WriteLine($"Count of array = {arrayList.Count}    Capacity of array = {arrayList.Capacity}");
            //arrayList.Add(1);
            //arrayList.Add(2);
            //arrayList.AddRange(new[] {3,4});
            //Console.WriteLine($"Count of array = {arrayList.Count}    Capacity of array = {arrayList.Capacity}");
            //arrayList.AddRange(new[] {5,6,7});
            //Console.WriteLine($"Count of array = {arrayList.Count}    Capacity of array = {arrayList.Capacity}");

            //arrayList = new ArrayList(5);
            //Console.WriteLine($"Count of array = {arrayList.Count}    Capacity of array = {arrayList.Capacity}");
            //arrayList.AddRange(new[] {3,4,5,6,7,8,9,10});
            //arrayList.Add("fatma");
            //Console.WriteLine($"Count of array = {arrayList.Count}    Capacity of array = {arrayList.Capacity}");
            //arrayList.TrimToSize();
            //Console.WriteLine($"Count of array = {arrayList.Count}    Capacity of array = {arrayList.Capacity}");
            //foreach(var i in arrayList)
            //     Console.WriteLine(i);
            //int Resulet = Sum(arrayList);
            // Console.WriteLine(Resulet);
            #endregion

            #region List
            //List <int> list = new List <int>();
            //Console.WriteLine($"Count of list = {list.Count}    Capacity of list = {list.Capacity}");
            //list.Add(1);
            //list.Add(2);
            //list.AddRange(new[] { 3, 4 });
            //Console.WriteLine($"Count of list = {list.Count}    Capacity of list = {list.Capacity}");
            //list.AddRange(new[] { 5, 6, 7 });
            //Console.WriteLine($"Count of list = {list.Count}    Capacity of list = {list.Capacity}");

            //list = new List<int> (5);
            //Console.WriteLine($"Count of list = {list.Count}    Capacity of list = {list.Capacity}");
            //list.AddRange(new[] { 3, 4, 5, 6, 7, 8, 9, 10 });
            ////list.Add("fatma");   //invalid
            //Console.WriteLine($"Count of list = {list.Count}    Capacity of list = {list.Capacity}");
            //list.TrimExcess();
            //Console.WriteLine($"Count of list = {list.Count}    Capacity of list = {list.Capacity}");
            //foreach (var i in list)
            //    Console.WriteLine(i);
            //for (int i = 0;i < list.Count;i++)
            //    Console.WriteLine(list[i]);
            //int Resulet = Sum(list);
            //Console.WriteLine(Resulet);
            #endregion

            #region List methods
            //List<int> ints = new List<int>() {1,2,3,4};
            //Console.WriteLine($"Count of list = {ints.Count}    Capacity of list = {ints.Capacity}");
            //foreach (int i in ints)
            //    Console.Write($" {i}");
            //Console.WriteLine("\n===============================");
            //ints.Add(5);
            //ints.Insert(2, 8);
            //ints.InsertRange(4,new [] {20,30,40});
            //Console.WriteLine($"Count of list = {ints.Count}    Capacity of list = {ints.Capacity}");
            //foreach (int i in ints)
            //    Console.Write($" {i}");
            //Console.WriteLine("\n===============================");
            //Console.WriteLine( ints.BinarySearch(20));
            //Console.WriteLine( ints.BinarySearch(100));
            //ints.Clear();
            //Console.WriteLine($"Count of list = {ints.Count}    Capacity of list = {ints.Capacity}");
            //Console.WriteLine("\n===============================");
            //ints.InsertRange(0,new [] {20,30,40,20});
            //Console.WriteLine( ints.Contains(100));
            //Console.WriteLine( ints.Contains(20));
            //Console.WriteLine( ints.IndexOf(40));
            //Console.WriteLine( ints.LastIndexOf(20));
            //ints.Reverse();
            //Console.WriteLine("\n===============================");
            //foreach (int i in ints)
            //    Console.Write($" {i}");
            //Console.WriteLine($"\nCount of list = {ints.Count}    Capacity of list = {ints.Capacity}");
            //ints.EnsureCapacity(17);
            //Console.WriteLine($"\nCount of list = {ints.Count}    Capacity of list = {ints.Capacity}");
            //ints.Remove(20);
            //Console.WriteLine("\n===============================");
            //foreach (int i in ints)
            //    Console.Write($" {i}");
            //int[] arr = new int[10];
            //ints.CopyTo( arr);
            //ints.CopyTo( arr, 3 );
            //ints.CopyTo(1, arr, 3,2 );
            //Console.WriteLine("\n===============================");
            //foreach (int i in arr)
            //    Console.Write($" {i}");

            #endregion

            #region Linked List
            //LinkedList<int> list = new LinkedList<int>();
            //Console.WriteLine($"Count of list = {list.Count}");
            //list.AddFirst( 1 );
            //list.AddFirst( 2 );
            //list.AddLast ( 3 );
            //list.AddAfter(list.Find(1), 5);
            //list.AddBefore(list.Find(3), 7);
            //foreach ( int i in list ) 
            //    Console.WriteLine( i );
            //Console.WriteLine($"Count of list = {list.Count}");
            #endregion

            #region stack
            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine("================================");
            //bool s =stack.TryPop(out int element);
            //Console.WriteLine(element);
            //Console.WriteLine(s);
                
            //foreach (int i in stack)
            //    Console.WriteLine(i);
            #endregion

            #region Queue
            //Queue <int> ints = new Queue<int>();
            //ints.Enqueue(1);
            //ints.Enqueue(2);
            //ints.Enqueue(3);
            //ints.Enqueue(4);
            //foreach (int i in ints)
            //    Console.WriteLine(i);
            //Console.WriteLine("================================");
            //bool q = ints.TryPeek(out int e);
            //Console.WriteLine(e);
            //Console.WriteLine(q);
            //Console.WriteLine("================================");
            //Console.WriteLine(ints.Dequeue());
            //Console.WriteLine(ints.Dequeue());
            //Console.WriteLine(ints.Dequeue());
            //Console.WriteLine(ints.Dequeue());
            //Console.WriteLine("================================");
            //bool b = ints.TryDequeue(out int d);
            //Console.WriteLine(d);
            //Console.WriteLine(b);
            
            #endregion

        }
    }
}
