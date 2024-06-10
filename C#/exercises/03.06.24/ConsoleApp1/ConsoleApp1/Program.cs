using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Node
    {
        int value;
        Node next;
        public Node(int value, Node next)
        {
            this.value = value;
            this.next = next;
        }
        public void SetValue(int value)
        {
            this.value = value;
        }
        public int GetValue()
        {
            return this.value;
        }
        public void SetNext(Node next)
        {
            this.next = next;
        }
        public Node GetNext()
        {
            return this.next;
        }
    }
    internal class Program
    {
        static Random rnd = new Random();
        static void Show(Node first)
        {
            while (first != null)
            {
                Console.Write(first.GetValue() + " ");
                first = first.GetNext();
            }
            Console.WriteLine();
        }
        static Node BuildList()
        {
            Node o = new Node(111, null);
            Node ezer = o;
            int listLen = rnd.Next(4, 8);
            while (listLen != 0)
            {
                Node t = new Node(rnd.Next(11, 77), null);
                ezer.SetNext(t);
                ezer = ezer.GetNext();
                listLen--;
            }
            return o;
        }
        static void ShowEvens(Node first)
        {
            while (first != null)
            {
                if (first.GetValue() % 2 == 0)
                    Console.Write(first.GetValue() + " ");
                first = first.GetNext();
            }
            Console.WriteLine();
        }
        static int EvensSubOdds(Node first)
        {
            int retRes = 0;
            first = first.GetNext();
            while (first != null)
            {
                if (first.GetValue() % 2 == 0)
                    retRes += first.GetValue();
                else
                    retRes -= first.GetValue();
                first = first.GetNext();
            }
            return retRes;
        }
        //  3 4 5 6 7 8 9 1     ====>   (4+6+8) - (3+5+7+9+1)
        static void Main(string[] args)
        {
            Node l1 = BuildList();
            Show(l1);
            ShowEvens(l1);
            Console.WriteLine(EvensSubOdds(l1));
            Console.WriteLine();
            Node l2 = BuildList();
            Show(l2);
            ShowEvens(l2);
            Console.WriteLine(EvensSubOdds(l2));
        }
    }
}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp12
//{
//    class Node
//    {
//        int value;
//        Node next;
//        public Node(int value, Node next)
//        {
//            this.value = value;
//            this.next = next;
//        }
//        public void SetValue(int value)
//        {
//            this.value = value;
//        }
//        public int GetValue()
//        {
//            return this.value;
//        }
//        public void SetNext(Node next)
//        {
//            this.next = next;
//        }
//        public Node GetNext()
//        {
//            return this.next;
//        }
//    }
//    internal class Program
//    {
//        static Random rnd = new Random();
//        static void Show(Node first)
//        {
//            while (first != null)
//            {
//                Console.Write(first.GetValue() + " ");
//                first = first.GetNext();
//            }
//            Console.WriteLine();
//        }
//        static Node BuildList()
//        {
//            Node o = new Node(111, null);
//            Node ezer = o;
//            int listLen = rnd.Next(4, 8);
//            while (listLen != 0)
//            {
//                Node t = new Node(rnd.Next(11, 77), null);
//                ezer.SetNext(t);
//                ezer = ezer.GetNext();
//                listLen--;
//            }
//            return o;
//        }
//        static void ShowEvens(Node first)
//        {
//            while (first != null)
//            {
//                if (first.GetValue() % 2 == 0)
//                    Console.Write(first.GetValue() + " ");
//                first = first.GetNext();
//            }
//            Console.WriteLine();
//        }
//        static int EvensSubOdds(Node first)
//        {
//            int retRes = 0;
//            first = first.GetNext();
//            while (first != null)
//            {
//                if (first.GetValue() % 2 == 0)
//                    retRes += first.GetValue();
//                else
//                    retRes -= first.GetValue();
//                first = first.GetNext();
//            }
//            return retRes;
//        }
//        static void ShowRev(Node first)
//        {
//            int i = 0;
//            Node ezer = first;
//            while (first.GetNext() != null)
//            {
//                first = first.GetNext();
//                i++;
//            }
//            Console.WriteLine(first.GetValue());
//        }
//        static void Main(string[] args)
//        {
//            Node l1 = BuildList();
//            Show(l1);
//            ShowEvens(l1);
//            Console.WriteLine(EvensSubOdds(l1));
//            Console.WriteLine();
//            Node l2 = BuildList();
//            Show(l2);
//            ShowEvens(l2);
//            Console.WriteLine(EvensSubOdds(l2));
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Diagnostics.CodeAnalysis;
//using System.Linq;
//using System.Security;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp5
//{
//    internal class Program
//    {
//        static int CountDigits(int x)
//        {
//            if (x > 9)
//                return 1 + CountDigits(x / 10);
//            return 1;
//        }
//        static void Main(string[] args)
//        {
//            ShowY(123456789);
//            Console.WriteLine(CountDigits(123456789));
//            //Node l1 = BuildList();
//            //Show(l1);
//            //ShowRev(l1);
//            //ShowRevRec(l1.GetNext());
//            //Console.WriteLine();
//            //ShowEvensFirst(l1.GetNext());
//            ////ShowEvens(l1);
//            //Console.WriteLine(EvensSubOdds(l1));
//            //Console.WriteLine();
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp12
//{
//    class Person
//    {
//        string name;
//        string id;

//        public Person(string name, string id)
//        {
//            this.name = name;
//            this.id = id;
//        }
//        public string GetName() { return this.name; }
//        public void SetName(string name) { this.name = name; }
//        public string GetId() { return this.id; }
//        public void SetId(string id) {  this.id = id; }
//        static void Main(string[] args)
//        {
//            Person person = new Person("David", "1234");
//            Console.WriteLine("" + person.GetName() + " : " + person.GetId());
//            person.SetId("09890");
//            person.SetName("Moshe");
//            Console.WriteLine("" + person.GetName() + " : " + person.GetId());
            
//        }
       
            
//    }
//}


