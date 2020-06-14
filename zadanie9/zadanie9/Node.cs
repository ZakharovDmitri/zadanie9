using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace zadanie9
{
    public class Node<T>
    {
        public Node(int data)
        {
            Data = data;
        }
        public int Data { get; set; }
        public Node<int> Next { get; set; }

        public override string ToString()
        {
            return Data + " ";
        }
    }

    public class CircularLinkedList<T>   // кольцевой связный список
    {
        Node<int> head; // головной/первый элемент
        Node<int> tail; // последний/хвостовой элемент
        int count;  // количество элементов в списке
        int sum = 0;

        // добавление элемента
        public void Add(int data)
        {
            Node<int> node = new Node<int>(data);
            // если список пуст
            if (head == null)
            {
                head = node;
                tail = node;
                tail.Next = head;
            }
            else
            {
                node.Next = head;
                tail.Next = node;
                tail = node;
            }
            count++;
        }
        public bool Remove(int data)
        {
            Node<int> current = head;
            Node<int> previous = null;

            if (IsEmpty) return false;

            do
            {
                if (current.Data.Equals(data))
                {
                    // Если узел в середине или в конце
                    if (previous != null)
                    {
                        // убираем узел current, теперь previous ссылается не на current, а на current.Next
                        previous.Next = current.Next;

                        // Если узел последний,
                        // изменяем переменную tail
                        if (current == tail)
                            tail = previous;
                    }
                    else // если удаляется первый элемент
                    {

                        // если в списке всего один элемент
                        if (count == 1)
                        {
                            head = tail = null;
                        }
                        else
                        {
                            head = current.Next;
                            tail.Next = current.Next;
                        }
                    }
                    count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            } while (current != head);

            return false;
        }

        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool Contains(int data)
        {
            Node<int> current = head;
            if (current == null) return false;
            do
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            while (current != head);
            return false;
        }

        public void ShowList()
        {
            int number = 0;
            if (head == null)
            {
                Console.WriteLine("Пустой список");
                return;
            }
            Node<int> p = head;
            while (number != count)
            {
                Console.WriteLine(p);
                p = p.Next;
                number++;
            }
        }

        public void ShowSum()
        {
            int number = 0;
            if (head == null)
            {
                Console.WriteLine("Пустой список");
                return;
            }
            else
            {
                Node<int> p = head;
                while (number != count)
                {
                    sum += p.Data;
                    p = p.Next;
                    number++;
                }
                Console.WriteLine(sum);
            }
            
        }

        



      
    }
}

