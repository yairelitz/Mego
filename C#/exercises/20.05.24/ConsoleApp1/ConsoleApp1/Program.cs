//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            using System;
//            using System.Collections.Generic;
//            using System.Linq;
//            using System.Text;
//            using System.Threading.Tasks;

//namespace ConsoleApp7
//    {
//        class Talmid
//        {
//            private string fName;
//            int[] grades = new int[5];
//            double ave;
//            public void SetFname(string fName)
//            {
//                this.fName = fName;
//            }
//            public void SetGrades(int[] grades)
//            {
//                this.grades = grades;
//                ave = 0;
//                for (int i = 0; i < grades.Length; i++)
//                    ave = ave + grades[i];
//                ave = ave / grades.Length;
//            }
//            public double GetAve()
//            {
//                return ave;
//            }
//            public string GetFname()
//            {
//                return fName;
//            }
//            public int[] GetGrades()
//            {
//                return this.grades;
//            }
//        }
//        internal class Program
//        {
//            static Random r = new Random();
//            static void ShowBest(Talmid[] k)
//            {
//                double best = k[0].GetAve();
//                int indexOfBest = 0;
//                for (int i = 1; i < k.Length; i++)
//                {
//                    if (best < k[i].GetAve())
//                    {
//                        indexOfBest = i;
//                        best = k[i].GetAve();
//                    }
//                }
//                int[] r = k[indexOfBest].GetGrades();
//                for (int i = 0; i < 5; i++)
//                    Console.WriteLine(r[i]);
//                Console.WriteLine(k[indexOfBest].GetAve());
//            }
//            static void ShowKita(Talmid[] k)
//            {

//            }
//            static void Main(string[] args)
//            {
//                Talmid[] kita = new Talmid[44];
//                for (int i = 0; i < kita.Length; i++)
//                    kita[i] = new Talmid();
//                int[] g = new int[5];
//                for (int i = 0; i < kita.Length; i++)
//                {
//                    for (int j = 0; j < 5; j++)
//                        g[j] = r.Next(0, 101);
//                    kita[i].SetGrades(g);
//                    kita[i].SetFname("RON");
//                }
//                ShowBest(kita);
//            }
//        }
//    }



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp7
//{
//    class Talmid
//    {
//        private string fName;
//        double ave;
//        public void SetFname(string fName)
//        {
//            this.fName = fName;
//        }
//        public void SetAve(double ave)
//        {
//            this.ave = ave;
//        }
//        public double GetAve()
//        {
//            return ave;
//        }
//        public string GetFname()
//        {
//            return fName;
//        }
//    }
//    internal class Program
//    {
//        static void ShowTalmid(Talmid t)
//        {
//            Console.WriteLine(t.GetFname());
//            Console.WriteLine(t.GetAve());
//        }
//        static void Main(string[] args)
//        {
//            Talmid t1 = new Talmid();
//            t1.SetFname("Ron");
//            t1.SetAve(88.66);
//            Talmid t2 = new Talmid();
//            t2.SetFname("Gad");
//            t2.SetAve(66);

//            ShowTalmid(t1);
//            Console.WriteLine(t1.GetFname());
//            Console.WriteLine(t1.GetAve());
//            ShowTalmid(t2);
//            Console.WriteLine(t2.GetFname());
//            Console.WriteLine(t.GetAve());


//        }
//    }
//}





//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp7
//{
//    class Talmid
//    {
//        //  תכונות  properties
//        private string fName;
//        double ave;
//        public void SetFname(string mmm)
//        {
//            fName = mmm;
//        }
//        public string GetFname()
//        {
//            return fName;
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Talmid[] e = new Talmid[10];
//            for (int i = 0; i < e.Length; i++)
//            {
//                e[i] = new Talmid();
//            }
//            Talmid s1;
//            s1 = new Talmid();
//            Talmid t1 = new Talmid();   //  200
//            t1.SetFname("Ronen");
//            Talmid t2 = new Talmid();
//            Console.Write("Enter a name : ");
//            string s = Console.ReadLine();
//            t2.SetFname(s);
//            string f = t1.GetFname();
//            Console.WriteLine(f);
//            Console.WriteLine(t1.GetFname());
//            int p;
//        }
//    }
//}





//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp7
//{
//    class Talmid
//    {
//        //  תכונות  properties
//        private string fName;
//        double ave;
//        public void SetFname(string mmm)
//        {
//            fName = mmm;
//        }
//        public string GetFname()
//        {
//            return fName;
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Talmid s1;
//            s1 = new Talmid();
//            Talmid t1 = new Talmid();   //  200
//            t1.SetFname("Ronen");
//            Talmid t2 = new Talmid();
//            Console.Write("Enter a name : ");
//            string s = Console.ReadLine();
//            t2.SetFname(s);
//            string f = t1.GetFname();
//            Console.WriteLine(f);
//            Console.WriteLine(t1.GetFname());
//            int p;
//        }
//    }
//}







//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp7
//{
//    class Talmid
//    {
//        //  תכונות  properties
//        private string fName;
//        public double ave;
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Talmid[] kita = new Talmid[33];
//            for (int i = 0; i < kita.Length; i++)
//                kita[i] = new Talmid();
//            kita[0].fName = "weg";
//            kita[0].ave = 77.88;
//            kita[1].fName = "ruir";
//            kita[1].ave = 77.88;
//            kita[2].fName = "dszf";
//            kita[2].ave = 90;
//            Console.WriteLine(kita[1].ave);
//        }
//    }
//}






//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp7
//{
//    class Talmid
//    {
//        //  תכונות  properties
//        public string fName;
//        public double ave;
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Talmid[] kita = new Talmid[33];
//            for (int i = 0; i < kita.Length; i++)
//                kita[i] = new Talmid();
//            kita[0].fName = "weg";
//            kita[0].ave = 77.88;
//            kita[1].fName = "ruir";
//            kita[1].ave = 77.88;
//            kita[2].fName = "dszf";
//            kita[2].ave = 90;
//        }
//    }
//}




//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp7
//{
//    class A
//    {
//        //  תכונות  properties
//        public string fName;
//        public int id;
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int t;
//            A x = new A();
//            A y = new A();
//            A[] m = new A[22];
//            x.fName = "wqetfgeqr";
//            y.fName = "fghfw";
//            Console.WriteLine(x.fName);
//            t = 77;
//            Console.WriteLine(y.fName);
//        }
//    }
//}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Clock
    {
        int hour;
        int min;
        public Clock(int hour, int min)
        {
            this.hour = hour;
            this.min = min;
        }
        public int GetHour() { return hour; }
        public int GetMin() { return min; }
        public void SetHour(int hour) { this.hour = hour; }
        public void SetMin(int min) { this.min = min; }
        public int GetInterval()
        {
            int m = 24 * 60;
            int d = hour * 60 + min;
            return m - d;
        }

    }
    internal class Program
    {
        static int GetInterval(Clock c)
        {
            int m = 24 * 60;
            int d = c.GetHour() * 60 + c.GetMin();
            return m - d;
        }
        static void Main(string[] args)
        {
            Clock c1 = new Clock(14, 55);
            Clock c2 = new Clock(19, 35);
            Clock c3 = new Clock(21, 5);
            Console.WriteLine(GetInterval(c1));
            Console.WriteLine(GetInterval(c2));
            Console.WriteLine(GetInterval(c3));
            Console.WriteLine(c1.GetInterval());
            Console.WriteLine(c2.GetInterval());
            Console.WriteLine(c3.GetInterval());
        }
    }
}

    

