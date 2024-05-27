//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp10
//{
//    class A
//    {
//        int value;
//        A next;
//        public A(int value, A next)
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
//        public void SetNext(A next)
//        {
//            this.next = next;
//        }
//        public A GetNext()
//        {
//            return this.next;
//        }
//    }
//    internal class Program
//    {
//        static Random rnd = new Random();
//        static void Show(A first)
//        {
//            while (first != null)
//            {
//                Console.WriteLine(first.GetValue());
//                first = first.GetNext();
//            }
//        }
//        static A BuildList()
//        {
//            A o = new A(111, null);
//            A ezer = o;
//            Console.Write("More ? ");
//            char yN = char.Parse(Console.ReadLine());
//            while (yN != 'n')
//            {
//                A t = new A(rnd.Next(11, 77), null);
//                ezer.SetNext(t);
//                ezer = ezer.GetNext();
//                Console.Write("More ? ");
//                yN = char.Parse(Console.ReadLine());
//            }
//            return o;
//        }
//        static void Main(string[] args)
//        {
//            A l1 = BuildList();
//            Show(l1);
//        }
//    }
//}
/*
הקצאת זיכרון סטטית
הקצאת זיכרון דינמית
*/





//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp10
//{
//    class A
//    {
//        int value;
//        A next;
//        public A(int value, A next)
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
//        public void SetNext(A next)
//        {
//            this.next = next;
//        }
//        public A GetNext()
//        {
//            return this.next;
//        }
//    }
//    internal class Program
//    {
//        static Random rnd = new Random();
//        static void Main(string[] args)
//        {
//            A o = new A(111, null);
//            A ezer = o;
//            Console.Write("More ? ");
//            int c = int.Parse(Console.ReadLine());
//            while (c > 0)
//            {
//                A t = new A(rnd.Next(11,77), null);
//                o.SetNext(t);
//                o = o.GetNext();
//                Console.Write("More ? ");
//                c = int.Parse(Console.ReadLine());
//            }
//            o = ezer;
//            while(o!= null)
//            {
//                Console.WriteLine(o.GetValue());
//                o = o.GetNext();
//            }
//        }
//    }
//}
///*
//הקצאת זיכרון סטטית
//הקצאת זיכרון דינמית
//*/







//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp10
//{
//    class A
//    {
//        int value;
//        A next;
//        public A(int value, A next)
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
//        public void SetNext(A next)
//        {
//            this.next = next;
//        }
//        public A GetNext()
//        {
//            return this.next;
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            A y = new A(77, null);
//            A o = new A(22, y);
//            o.SetValue(9876);
//            Console.WriteLine(o.GetValue());
//            y.SetValue(112233);
//            Console.WriteLine(y.GetValue());
//            Console.WriteLine(o.GetNext().GetValue());
//        }
//    }
//}
///*
//הקצאת זיכרון סטטית
//הקצאת זיכרון דינמית
//*/










//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp10
//{
//    class A
//    {
//        int value;
//        A next;
//        public A(int value, A next)
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
//        public void SetNext(A next)
//        {
//            this.next = next;
//        }
//        public A GetNext()
//        {
//            return this.next;
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            A y = new A(77, null);
//            A o = new A(22, y);
//            o.SetValue(9876);
//            Console.WriteLine(o.GetValue());
//            y.SetValue(112233);
//            Console.WriteLine(y.GetValue());
//            Console.WriteLine(o.GetNext().GetValue());
//        }
//    }
//}
///*
//הקצאת זיכרון סטטית
//הקצאת זיכרון דינמית
//*/









//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp10
//{
//    class A
//    {
//        int b;
//        A n;
//        public A(int b, A n)
//        {
//            this.b = b;
//            this.n = n;
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            A y = new A(77,null);
//            A o = new A(22,y);
//        }
//    }
//}
///*
//הקצאת זיכרון סטטית
//הקצאת זיכרון דינמית
//*/






using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class A
    {
        int b;
        public A(int b)
        {
            this.b = b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            int g = 9;
            int[] m = new int[55]; m[5] = 33;
            A a1 = new A(44);
            Console.Write("Enter a number : ");
            int size = int.Parse(Console.ReadLine());
            A[] v = new A[size];
            while (size > 0)
            {
                v[size] = new A(77);
                size--;
            }
        }
    }
}
/*
הקצאת זיכרון סטטית
הקצאת זיכרון דינמית







//*

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp10
//{
//    class A
//    {
//        int value;
//        A next;
//        public A(int value, A next)
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
//        public void SetNext(A next)
//        {
//            this.next = next;
//        }
//        public A GetNext()
//        {
//            return this.next;
//        }
//    }
//    internal class Program
//    {
//        static Random rnd = new Random();
//        static void Show(A first)
//        {
//            while (first != null)
//            {
//                Console.Write(first.GetValue() + " ");
//                first = first.GetNext();
//            }
//            Console.WriteLine();
//            while (list.GetNext() != null)
//                list = list.GetNext();
//            list.SetNext(new A(lastVal, null));
//        }
//        static void ShowEvensFirst(A list)
//        {
//            if (list != null)
//            {
//                if (list.GetValue() % 2 == 0)
//                    Console.Write(list.GetValue() + "  ");
//                ShowEvensFirst(list.GetNext());
//                if (list.GetValue() % 2 == 1)
//                    Console.Write(list.GetValue() + "  ");
//            }
//        }
//        static void RevList(A list)
//        {
//            A ezer = new A(111, null);
//            while (list.GetNext() != null)
//            {
//                A ezerFirst = ezer.GetNext();
//                ezer.SetNext(list.GetNext());
//                list.SetNext(list.GetNext().GetNext());
//                ezer.GetNext().SetNext(ezerFirst);
//            }
//            list.SetNext(ezer.GetNext());
//            ezer.SetNext(null);
//        }
//        static void AddAfterBiggest(A list, int newVal)
//        {

//        }
//        static void Main(string[] args)
//        {
//            A l1 = BuildList();
//            Show(l1);
//            RevList(l1);
//            Show(l1);
//            //ShowEvensFirst(l1);
//            //DelThird(l1);
//            //Console.WriteLine();
//            //AddToLast(l1, 3333);
//            //Show(l1);
//        }
//        //  111     1 2 3 4
//        //  111     4 3 2 1