using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Queue;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> myQ = new Queue<int>();
            myQ.Enqueue(1);
            myQ.Enqueue(2);
            myQ.Enqueue(5);
            Console.WriteLine(myQ.ToString());  // print '1, 2, 5'
            Console.WriteLine(myQ.Length.ToString()); // print '3'
            int value = myQ.Dequeue(); // value is nu 1
            foreach (int elem in myQ)
            {
                Console.WriteLine(elem.ToString()); // print '2' en dan '5'
            }

            Queue<string> myStringQ = new Queue<string>();
            Console.WriteLine(myStringQ.IsEmpty.ToString()); // print 'true'
            myStringQ.Enqueue("eerste");
            myStringQ.Enqueue("drie");
            myStringQ.Enqueue("woordjes");
            Console.WriteLine(myStringQ.First.ToString()); // print 'eerste'
            Console.WriteLine(myStringQ.Last.ToString()); // print 'woordjes'
            Console.WriteLine(myStringQ.IsEmpty.ToString()); // print 'false'
            Console.ReadLine();

        }
    }
}
