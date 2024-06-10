using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    namespace Queue1
    {
        class Program
        {
            static void SortByStart(Activity[] a)
            {
                for (int i = 0; i < a.Length - 1; i++)
                    for (int k = i + 1; k < a.Length; k++)
                        if (a[i].GetStart() > a[k].GetStart())
                        {
                            Activity temp = a[i];
                            a[i] = a[k];
                            a[k] = temp;
                        }
            }
            static void ShowClasses(Node<Stack<Activity>> c)
            {
                c = c.GetNext();
                while (c != null)
                {
                    Console.WriteLine(c.GetValue());
                    c = c.GetNext();
                }
            }
            static void Main(string[] args)
            {
                Activity[] m = new Activity[4];
                m[0] = new Activity(11, 22);
                m[1] = new Activity(6, 9);
                m[2] = new Activity(13, 14);
                m[3] = new Activity(8, 10);
                SortByStart(m);
                Node<Stack<Activity>> classes = new Node<Stack<Activity>>(new Stack<Activity>());
                Node<Stack<Activity>> ezer = classes;
                Stack<Activity> s1 = new Stack<Activity>();
                s1.Push(m[0]);
                ezer.SetNext(new Node<Stack<Activity>>(s1));
                for (int i = 1; i < m.Length; i++)
                {
                    ezer = classes.GetNext();
                    while (ezer != null)
                    {
                        if (m[i].GetStart() >= ezer.GetValue().Top().GetFinish())
                        {
                            ezer.GetValue().Push(m[i]);
                            break;
                        }
                        if (ezer.GetNext() == null)
                            break;
                        ezer = ezer.GetNext();
                    }
                    if (ezer.GetNext() == null)
                    {
                        ezer.SetNext(new Node<Stack<Activity>>(new Stack<Activity>()));
                        ezer.GetNext().GetValue().Push(m[i]);
                    }
                }
                ShowClasses(classes);
                Console.WriteLine();
            }
        }
    }


    //  list ---- > -111 --> 2 --> 4 --> 3 --> 6 -->7
}
