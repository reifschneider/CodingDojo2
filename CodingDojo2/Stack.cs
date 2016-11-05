using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo2
{
    public class Stack<T>
    {
        private class ListItem<T>
        {
            public T data { get; set; }
            public ListItem<T> next { get; set; }
            public ListItem()
            {
                this.next = null;
            }
        }

        private ListItem<T> head = null;

        public T Push(T item)
        {
            ListItem<T> newListItem = new ListItem<T>();
            newListItem.data = item;
            if (head == null)
            {
                head = newListItem;
            }
            else
            {
                newListItem.next = head;
                head = newListItem;
            }
            return newListItem.data;
        }

        public void Peek()
        {
            if (head != null)
                Console.WriteLine("Peek: {0}", head.data);
            else
                Console.WriteLine("Peek: The stack is empty.");
        }


        public T Pop()
        {
            if (head != null)
            {
                T zw = head.data;
                head = head.next;
                return zw;
            }
            else
            {
                Console.WriteLine("Pop: The stack is empty. You cannot remove.");
                return default(T);
            }
        }

        public void All()
        {
            ListItem<T> current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }


    }
}
