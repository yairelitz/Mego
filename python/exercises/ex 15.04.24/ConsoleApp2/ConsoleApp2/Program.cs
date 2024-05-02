using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Show(int[] m)
        {
            for (int i = 0; i < m.Length; i++)
                Console.Write(m[i] + "  ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] a = new int[22];
            //  0 1 2 3 4  5  6  7
            //  0 1 3 6 10 15 21 28
            a[0] = 20;
            a[1] = 50;
            for (int i = 2; i < a.Length; i++)
                a[i] = a[i - 1] + a[i - 2];
            Show(a);
        }
    }
}
/*

*/











//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        { 
//            Console.Write("Enter a number : ");
//            int r = int.Parse(Console.ReadLine());
//            int s = 0;
//            while (r > 0)
//            {
//                s = s + r % 10;
//                r = r / 10;
//            }
//                Console.WriteLine(s);

//            }

//        }
//    }








//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Enter a number : ");

//        }
//    }
//}







//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//         int r = 0;
//            while (r < 6)
//            {
//                int c = 0;
//                while (c < 11)
//                {
//                    Console.Write("*");
//                    c++;
//                }
//                Console.WriteLine();
//                r++;
//            } 

//        }
//    }
//}
