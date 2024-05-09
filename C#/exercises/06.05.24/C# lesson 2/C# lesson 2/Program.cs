using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void F(int x)    //  x=     7965
        {
            if (x > 0)
            {
                F(x / 10);
                Console.WriteLine(x % 10);
            }
        }
        static void Main(string[] args)
        {
            F(783145);
        }
    }
}
/*
7
9
6
5


*/



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp4
//{
//    internal class Program
//    {
//        static void F(int x)    //  x=
//        {
//            if (x > 1)
//            {
//                for (int i = 0; i < x; i++)
//                    Console.Write("*");
//                Console.WriteLine();
//                F(x - 1);
//            }
//            for (int i = 0; i < x; i++)
//                    Console.Write("*");
//            Console.WriteLine();
//        }
//        static void Main(string[] args)
//        {
//            F(14);
//        }
//    }
//}





//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp4
//{
//    internal class Program
//    {
//        //      רקורסיא
//        /*
//        static void F(int x)    //  x=0
//        {
//            if (x > 0)
//            {
//                Console.WriteLine(x);           //  output -
//                F(x - 1);
//                Console.WriteLine(x);           //  output -
//            }
//        }
//        static void F(int x)    //  x=1
//        {
//            if (x > 0)
//            {
//                Console.WriteLine(x);           //  output -
//                F(x - 1);
//                Console.WriteLine(x);           //  output -
//            }
//        }
//        */

//        static void F(int x)    //  x=2
//        {
//            if (x > 0)
//            {
//                Console.WriteLine(x);           //  output  2
//                F(x - 1);
//                Console.WriteLine(x);           //  output  2
//            }
//        }
//        static void Main(string[] args)
//        {
//            F(9);
//        }
//    }
//}







//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp4
//{
//    internal class Program
//    {
//        //      רקורסיא

//        /*static void F(int x)    //  x=0
//        {
//            if (x > 0)
//            {
//                F(x - 1);
//                Console.WriteLine(x);           //  output  2
//            }
//        }
//        static void F(int x)    //  x=1
//        {
//            if (x > 0)
//            {
//                F(x - 1);
//                Console.WriteLine(x);           //  output  1
//            }
//        }*/

//        static void F(int x)    //  x=2
//        {
//            if (x > 0)
//            {
//                F(x - 1);
//                Console.WriteLine(x);           //  output  2
//            }
//        }
//        static void Main(string[] args)
//        {
//            F(2);
//        }
//    }
//}





//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp4
//{
//    internal class Program
//    {
//        //     רקורסיא

//        /*static void F(int x)    //  x=0
//        {
//            if (x > 0)
//            {
//                Console.WriteLine(x);           //  output  2
//                F(x - 1);
//            }
//        }
//        static void F(int x)    //  x=1
//        {
//            if (x > 0)
//            {
//                Console.WriteLine(x);           //  output  1
//                F(x - 1);
//            }
//        }*/

//        static void F(int x)    //  x=2
//        {
//            if (x > 0)
//            {
//                Console.WriteLine(x);           //  output  2
//                F(x - 1);
//            }
//        }
//        static void Main(string[] args)
//        {
//            F(2);
//        }
//    }
//}






//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp4
//{
//    internal class Program
//    {
//        static void Show(int[] x)
//        {
//            for (int i = 0; i < x.Length; i++)
//                Console.Write(x[i] + "  ");
//            Console.WriteLine();
//        }
//        static bool IsSort(int[] x)
//        {
//            for (int i = 1; i < x.Length; i++)
//                if (x[i - 1] > x[i])
//                    return false;
//            return true;
//        }
//        static void What(int[] arr, int num)
//        {
//            int left = 0;
//            int right = arr.Length - 1;
//            while (left != right)
//            {
//                if (arr[left] < num)
//                    left++;
//                else
//                    if (arr[right] > num)
//                    right--;
//                else
//                {
//                    int temp = arr[left];
//                    arr[left] = arr[right];
//                    arr[right] = temp;
//                }
//                Show(arr);
//                Console.WriteLine(left + "  " + right);
//                Console.WriteLine();
//            }
//        }
//        static void What2(int[] arr, int num)
//        {
//            int left = 0;
//            int right = arr.Length - 1;
//            int[] b = new int[arr.Length];
//            for (int i = 0; i < b.Length; i++)
//            {
//                if (arr[i] < num)
//                {
//                    b[left] = arr[i];
//                    left++;
//                }
//                else
//                {
//                    b[right] = arr[i];
//                    right--;
//                }
//                Show(b);
//            }
//        }
//        static bool F(int[] a)
//        {
//            if (a.Length % 2 != 0)
//                return false;
//            int count = 0;
//            for (int i = 0; i < a.Length; i++)
//            {
//                if (a[i] == 0)
//                    return false;
//                if (a[i] > 0)
//                    count++;
//            }
//            if (a.Length / 2 == count)
//                return true;
//            return false;
//        }
//        static void Main(string[] args)
//        {
//            int[] a = { 18, 12, 10, 3, 12, 17, 1 };
//            int[] b = { 18, -12, -10, 3, -12, 17 };
//            bool res = F(a);
//            Console.WriteLine(res);
//            Console.WriteLine(F(b));
//        }
//    }
//}




//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp4
//{
//    internal class Program
//    {
//        static void Show(int[] x)
//        {
//            for (int i = 0; i < x.Length; i++)
//                Console.Write(x[i] + "  ");
//            Console.WriteLine();
//        }
//        static void Main(string[] args)
//        {
//            int[] a = new int[5] { 5121, 28795, 73, 49, 12345 };
//            //                      9      31   10  13    15
//            Show(a);
//            for (int i = 0; i < a.Length; i++)
//            {
//                int sum = 0;
//                while (a[i] != 0)
//                {
//                    sum += (a[i] % 10);
//                    a[i] = (a[i] / 10);
//                }
//                a[i] = sum;
//            }
//            Show(a);
//        }
//    }
//}





//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp4
//{
//    internal class Program
//    {
//        static void Show(int[] x)
//        {
//            for (int i = 0; i < x.Length; i++)
//                Console.Write(x[i] + "  ");
//            Console.WriteLine();
//        }
//        static void Main(string[] args)
//        {
//            int[] a = new int[5] { 5121, 28795, 73, 49, 12345 };
//            //                      9      31   10  13    15
//            Show(a);
//            for (int i = 0; i < a.Length; i++)
//            {
//                int sum = 0;
//                while (a[i] != 0)
//                {
//                    sum += (a[i] % 10);
//                    a[i] = (a[i] / 10);
//                }
//                a[i] = sum;
//            }
//            Show(a);
//        }
//    }
//}





//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp4
//{
//    internal class Program
//    {
//        static void Show(int[] x)
//        {
//            for (int i = 0; i < x.Length; i++)
//                Console.Write(x[i] + "  ");
//            Console.WriteLine();
//        }
//        static int[] F(int[] a, int[] b)
//        {
//            int[] c = new int[a.Length + b.Length];
//            for (int i = 0; i < a.Length; i++)
//            {
//                c[i * 2] = a[i];
//                c[i * 2 + 1] = b[i];
//            }
//            return c;
//        }
//        static void Main(string[] args)
//        {
//            //  a 1 2 3 4 5
//            //  b 99 88 77 66 55
//            //  c   1 99 2 88 3 77 4 66 5 55
//            int[] a = new int[5] { 1, 2, 3, 4, 5 };
//            Show(a);
//            int[] b = new int[5] { 99, 88, 77, 66, 55 };
//            Show(b);
//            int[] r = F(a, b);
//            Show(r);
//        }
//    }
//}




//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp4
//{
//    internal class Program
//    {
//        static void Show(int[] x)
//        {
//            for (int i = 0; i < x.Length; i++)
//                Console.Write(x[i] + "  ");
//            Console.WriteLine();
//        }
//        static void Main(string[] args)
//        {
//            //  a 1 2 3 4 5
//            //  b 99 88 77 66 55
//            //  c   1 99 2 88 3 77 4 66 5 55
//            int[] a = new int[5] { 1, 2, 3, 4, 5 };
//            Show(a);
//            int[] b = new int[5] { 99, 88, 77, 66, 55 };
//            Show(b);
//            int[] c = new int[a.Length + b.Length];
//            for (int i = 0; i < a.Length; i++)
//            {
//                c[i * 2] = a[i];
//                c[i * 2 + 1] = b[i];
//            }
//            Show(c);
//        }
//    }
//}





//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp4
//{
//    internal class Program
//    {
//        static void Show(int[] x)
//        {
//            for (int i = 0; i < x.Length; i++)
//                Console.Write(x[i] + "  ");
//            Console.WriteLine();
//        }
//        static void Main(string[] args)
//        {
//            //  a 1 2 3 4 5
//            //  b 99 88 77 66 55
//            //  c   1 2 3 4 5   55 66 77 88 99
//            int[] a = new int[5] { 1, 2, 3, 4, 5 };
//            Show(a);
//            int[] b = new int[5] { 99, 88, 77, 66, 55 };
//            Show(b);
//            int[] c = new int[a.Length + b.Length];
//            for (int i = 0; i < a.Length; i++)
//            {
//                c[i] = a[i];
//                c[i + a.Length] = b[a.Length - 1 - i];
//                c[c.Length - 1 - i] = b[i];
//            }
//            Show(c);
//        }
//    }
//}




//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp4
//{
//    internal class Program
//    {
//        static void Show(int[] x)
//        {
//            for (int i = 0; i < x.Length; i++)
//                Console.Write(x[i] + "  ");
//            Console.WriteLine();
//        }
//        static void Main(string[] args)
//        {
//            //  a 1 2 3 4 5
//            //  b 99 88 77 66 55
//            //  c   1 2 3 4 5   99 88 77 66 55
//            int[] a = new int[5] { 1, 2, 3, 4, 5 };
//            Show(a);
//            int[] b = new int[5] { 99, 88, 77, 66, 55 };
//            Show(b);
//            int[] c = new int[a.Length + b.Length];
//            for (int i = 0; i < a.Length; i++)
//            {
//                c[i] = a[i];
//                c[i + a.Length] = b[i];
//            }
//            Show(c);
//        }
//    }
//}





//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp4
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int x = 66;
//            while (x > 22)
//            {
//                Console.WriteLine(x);
//                x = x - 20;
//            }
//            Console.WriteLine(x);
//        }
//    }
//}