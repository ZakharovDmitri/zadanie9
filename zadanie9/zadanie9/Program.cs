using System;

namespace zadanie9
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularLinkedList<int> l1 = new CircularLinkedList<int>();
            l1.Add(0);
            l1.Add(1);
            l1.Add(2);
            l1.Add(5);
            l1.Add(22);
            l1.Add(44);
            l1.ShowSum();
            l1.ShowList();
        }
    }
}
