using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo2
{

    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("String Stack: ");
            Stack <string> stack1 = new Stack<string>();
            Console.WriteLine("Push: {0}", stack1.Push("Nadja"));
            Console.WriteLine("Push: {0}", stack1.Push("Reifschneider"));
            stack1.Peek();
            Console.WriteLine("Push: {0}", stack1.Push("Wirtschaftsinformatik"));
            stack1.Peek();
            Console.WriteLine("Pop: {0}", stack1.Pop());
            stack1.Peek();
            Console.WriteLine("Finally, the whole Stack1: ");
            stack1.All();

            Console.WriteLine();

            Console.WriteLine("Int Stack: ");
            Stack<int> stack2 = new Stack<int>();
            Console.WriteLine("Push: {0}", stack2.Push(1));
            Console.WriteLine("Push: {0}", stack2.Push(3));
            Console.WriteLine("Push: {0}", stack2.Push(5));
            stack2.Peek();
            Console.WriteLine("Push: {0}", stack2.Push(7));
            Console.WriteLine("Push: {0}", stack2.Push(9));
            stack2.Push(11);
            stack2.Peek();
            Console.WriteLine("Pop: {0}", stack2.Pop());
            stack2.Peek();
            Console.WriteLine("Pop: {0}", stack2.Pop());
            Console.WriteLine("Pop: {0}", stack2.Pop());
            stack2.Peek();
            Console.WriteLine("Finally, the whole Stack2: ");
            stack2.All();

            Console.WriteLine();

            Console.WriteLine("Double Stack: ");
            Stack<double> stack3 = new Stack<double>();
            stack3.Peek();
            Console.WriteLine("Push: {0}", stack3.Push(1.2));
            Console.WriteLine("Push: {0}", stack3.Push(1.3));
            Console.WriteLine("Push: {0}", stack3.Push(1.4));
            stack3.Peek();
            Console.WriteLine("Pop: {0}", stack3.Pop());
            Console.WriteLine("Pop: {0}", stack3.Pop());
            Console.WriteLine("Pop: {0}", stack3.Pop());
            stack3.Peek();
            Console.WriteLine("Pop: {0}", stack3.Pop());
            Console.WriteLine("Push: {0}", stack3.Push(2.8));
            Console.WriteLine("Push: {0}", stack3.Push(2.9));
            Console.WriteLine("Finally, the whole Stack3: ");
            stack2.All();


            Console.WriteLine();

            
            Stack<Person> stack4 = new Stack<Person>();
            Person p1 = new Person("Nadja", 1996); 
            Console.WriteLine("Push: {0}", stack4.Push(p1));
            Person p2 = new Person("Nina", 1995);
            Console.WriteLine("Push: {0}", stack4.Push(p2));
            Person p3 = new Person("Hans", 1993);
            Console.WriteLine("Push: {0}", stack4.Push(p3));
            stack4.Peek();
            Console.WriteLine("Pop: {0}", stack4.Pop());
            stack4.Peek();
            Console.WriteLine("Finally, the whole Stack4: ");
            stack4.All();

            Console.ReadLine();
            

        }
    }
}
