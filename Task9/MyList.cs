using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class MyList
    {
        private Node beg;
        private Node tail;
        static Random rnd = new Random();

        public static int Count
        {
            get; private set;
        }

        //добавление элементов в список
        public Node Add(int el)
        {
            if (beg != null)
            {
                Node temp = new Node(el);
                Node t = beg;
                while (t.next != null) t = t.next;
                t.next = temp;
                temp.last = t;
            }
            else beg = new Node(el);
            Count++;
            return beg;
        }

        //создание списка с заданным количеством элементов
        public Node Create(int n, int i)
        {
            if (i <= n)
            {
                Node head = beg;
                head = Add(rnd.Next(-100, 100));
                i++;
                head = Create(n, i++);
                return beg;
            }
            else return beg;
        }

        //рекурсивный метод подсчета количества элементов в списке
        public void Count1()
        {
            int count = 0;
            Node head = beg;
            this.Counter1(count, head);
        }

        void Counter1(int count, Node head)
        {
            if (head != null)
            {
                Node temp = head;
                if (temp.next == null)
                {
                    count++;
                    Console.WriteLine("Количество элементов в списке (рекурсивный метод): " + count);
                }
                else
                {
                    count++;
                    temp = temp.next;
                    Counter1(count, temp);
                }                
            }
            else Console.WriteLine("Количество элементов в списке (рекурсивный метод): " + count);
        }

        //нерекурсивный метод подсчета количества элементов в списке
        public void Count2()
        {
            int count = 0;
            Node head = beg;
            Node temp = head;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            Console.WriteLine("Количество элементов в списке: " + count);
        }
        
        //печать списка
        public void Show()
        {
            if (beg != null)
            {
                Node temp = beg;
                Console.WriteLine("Список:");
                while (temp != null)
                {
                    Console.Write(temp + " ");
                    temp = temp.next;
                }
                Console.WriteLine();
            }
            else Console.WriteLine("Список пуст");
        }
    }

    public class Node
    {
        public int data;
        public Node next, last;

        public Node()
        {
            data = 0;
            next = null;
            last = null;
        }

        public Node(int d)
        {
            data = d;
            next = null;
            last = null;
        }

        public override string ToString()
        {
            return data.ToString() + " ";
        }
    }
}
