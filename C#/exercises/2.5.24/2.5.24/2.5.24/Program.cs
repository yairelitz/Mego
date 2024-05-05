//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp3
//{
//    internal class Program
//    {
//        static void Show(int[] m)
//        {
//            for (int i = 0; i < m.Length; i++)
//            {
//                Console.Write(m[i] + "  ");
//            }
//            Console.WriteLine();
//        }
//        static int What(int[] arr)
//        {
//            int x = arr[0];
//            int y = 0;
//            int z = 0;
//            for (int i = 1; i < arr.Length; i++)
//                if (arr[i] > x)
//                {
//                    z = y;
//                    y = x;
//                    x = arr[i];
//                }
//                else
//                    if (arr[i] > y)
//                {
//                    z = y;
//                    y = arr[i];
//                }
//                else
//                        if (arr[i] > z)
//                    z = arr[i];
//            /////////////
//            return x + y + z;
//        }

//        static void Main(string[] args)
//        {
//            int[] arr = { 12, 13, 1, 10, 34, 20, 200 };
//            /*
//            x=13    34      34      200
//            y=12    13      20      34
//            z=10    12      13      20

//            */

//            Console.WriteLine(What(arr));
//            int r = What(arr);
//            Console.WriteLine(r);
//            Show(arr);
//        }
//    }
//}
/*

byte   0 .......  2^8-1             1 bytes
short  -2^15 .......  2^15-1        2 bytes
int    -2^31 .......  2^31-1        4 bytes
long   -2^63 .......  2^63-1        8 bytes

*/









//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp3
//{
//    internal class Program
//    {
//        static void Show(int[] m)
//        {
//            for (int i = 0; i < m.Length; i++)
//            {
//                Console.Write(m[i] + "  ");
//            }
//            Console.WriteLine();
//        }
//        static void Main(string[] args)
//        {
//            int[] a = new int[22];
//            //  0 1 2 3 4  5  6  7
//            //  0 1 3 6 10 15 21 28
//            a[0] = 0;
//            a[1] = 1;
//            for (int i = 2; i < a.Length; i++)
//            {
//                a[i] = a[i - 1] * i;
//            }

//            Show(a);
//        }
//    }
//}
///*

//*/





//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp3
//{
//    internal class Program
//    {
//        static void Show(int[] m)
//        {
//            for (int i = 0; i < m.Length; i++)
//                Console.Write(m[i] + "  ");
//            Console.WriteLine();
//        }
//        static void Main(string[] args)
//        {
//            int[] a = new int[22];
//            a[0] = 20;
//            a[1] = 50;
//            for (int i = 2; i < a.Length; i++)
//                a[i] = a[i - 1] + a[i - 2];
//            Show(a);
//        }
//    }
//}
///*

//*/







//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp3
//{
//    internal class Program
//    {
//        static void Show(int[] m)
//        {
//            for (int i = 0; i < m.Length; i++)
//                Console.Write(m[i] + "  ");
//            Console.WriteLine();
//        }
//        static void Main(string[] args)
//        {
//            int i = 0;
//            int[] a = new int[] { 44, 2, 3, 4, 7, 99, 66 };
//            Show(a);
//            int temp = a[a.Length - 1];
//            for (i = a.Length - 1; i > 0; i--)
//            {
//                a[i] = a[i - 1];
//            }
//            a[0] = temp;
//            Show(a);
//        }
//    }
//}
///*

//*/



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp3
//{
//    internal class Program
//    {
//        static void Show(int[] m)
//        {
//            for (int i = 0; i < m.Length; i++)
//            {
//                Console.Write(m[i] + "  ");
//            }
//            Console.WriteLine();
//        }
//        static void Main(string[] args)
//        {
//            int i = 0;  
//            int[] a = new int[] { 44, 2, 3, 4, 7, 99, 66 };
//            int temp = a[0];
//            for (i = 1; i < a.Length; i++)
//            {
//                a[i-1] = a[i];  
//            }
//            a[i] = temp;
//            //a[a.Length-1] = temp;
//            Show(a);
//        }
//    }
//}
///*

//*/



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] a = new int[] { 44, 2, 3, 4, 7, 99, 66 };
//            int max = a[0];
//            for (int i = 1; i < a.Length; i++)
//            {
//                if (a[i] > max)
//                {
//                    max = a[i];
//                }
//            }
//            Console.WriteLine(max);
//        }
//    }
//}
///*

//*/





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 44, 2, 3, 4, 7, 99, 66 };
            for (int i = 0; i < a.Length; i++)
            {
                //Console.WriteLine("{0}   {1}    {0}   boker tov ", i, a[i]);
                Console.WriteLine(i + "   " + a[i] + "   " + i + "  boker tov");
            }
            Console.WriteLine();
        }
    }
}
///*

//*/








//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int r = 55;
//            int c = 99;
//            for (r = 0; r < 7; r++)
//            {
//                for (c = -1; c < r; c++)
//                {
//                    Console.Write("* ");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}
///*

//*/




//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int i = 88;
//            for (i = 0; i < 5; i++)
//            {
//                Console.WriteLine(i);
//            }
//            Console.WriteLine(i);
//        }
//    }
//}
///*

//*/







//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Enter a number : ");
//            int r = int.Parse(Console.ReadLine());
//            int sum = 0;
//            while (r > 0)
//            {
//                sum += r % 10;
//                r = r / 10;
//            }
//            Console.WriteLine(sum);
//        }
//    }
//}
/*
26587
7
8
5
6
2


*/



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Enter a number^: ");
//            int r = int.Parse(Console.ReadLine());
//            while (r > 0)
//            {
//                int c = r;
//                while (c > 0)
//                {
//                    Console.Write("*");
//                    c--;
//                }
//                Console.WriteLine();
//                r--;
//            }
//        }
//    }
//}





//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int r = 0;
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