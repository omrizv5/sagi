using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.CollectionsLib;

namespace sagi
{
    class Program
    {

        public static void Trim (Node<int> lst) //assuming lst length is at least 4
        {
            Node<int> p = lst;
            int count = 0;
            while (p != null)
            {
                count++;
                p = p.GetNext();
            }
            p = lst;

            if (count % 2 == 0)
            {
                //trim middle
                int middle = (count / 2) - 1;
                while (middle > 1) // go until middle = 1 meaning p is one before middle
                {
                    p = p.GetNext();
                    middle--;
                }

                int v1, v2;
                v1 = p.GetNext().GetValue();
                v2 = p.GetNext().GetNext().GetValue();
                if (v1>v2)
                {
                    Node<int> Temp = p.GetNext();
                    p.SetNext(Temp.GetNext());
                } else //v2>v1
                {
                    Node<int> Temp = p.GetNext().GetNext();
                    p.GetNext().SetNext(Temp.GetNext());
                }

            } else
            {
                // trim end
                while (p.GetNext().GetNext() != null)
                {
                    p = p.GetNext();
                }
                p.SetNext(null);

                p = lst;
                p = p.GetNext();
                lst = p;
            }
            while (p != null)
            {
                Console.WriteLine(p.GetValue());
                p = p.GetNext();
            }
        }

        public static void RemoveBig(Node<int> lst, int n)
        {
            int currentMax;
            Node<int> p = lst;

            for (int i = 0; i < n; i++)
            {
                currentMax = 0;
                while (p != null)
                {
                    if (p.GetValue() > currentMax) currentMax = p.GetValue();
                    p = p.GetNext();
                }
                p = lst;
                while (p.GetNext().GetValue() != currentMax) //על מנת "לקפוץ" מעל התא עם המספר המקסימלי יש להגיע לתא שלפניו
                {
                    p = p.GetNext();
                }
                p.SetNext(p.GetNext().GetNext());
                p = lst;

            }

            while (p != null)
            {
                Console.WriteLine(p.GetValue());
                p = p.GetNext();
            }
        }

        static void Main(string[] args)
        {

            Node<int> ex = new Node<int>(4);
            Node<int> ex2 = new Node<int>(3, ex);
            Node<int> ex3 = new Node<int>(15, ex2);
            Node<int> ex4 = new Node<int>(1, ex3);
            Node<int> ex5 = new Node<int>(2, ex4);

            RemoveBig(ex5, 3);
        }






        public static int test (int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int i = 0; i < n; i++)
                {

                }
            }
            // O1 = independent
            // oN = DEPENDANT
            // o N^2 = DANGER
            // o Log
        }


    }
}
