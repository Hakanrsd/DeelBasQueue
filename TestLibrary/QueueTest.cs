using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Queue;

namespace Test
{
    [TestFixture]
    public class QueueTest
    {
        [TestCase]
        public void Test_Queue_int()
        {
            Queue.Queue<int> myQ = new Queue.Queue<int>();
            myQ.Enqueue(1); myQ.Enqueue(2);
            myQ.Enqueue(3);
            myQ.Enqueue(4);
            Assert.AreEqual(myQ.Length, 4);
            myQ.Dequeue();
            Assert.AreEqual(myQ.Length, 3);
            Assert.AreEqual(myQ.IsEmpty, false);
            var TestList = new List<string>() { "2", "3", "4" };
            int i = 0;

            foreach (int elem in myQ)
            {
                Assert.AreEqual(elem.ToString(), TestList[i]);
                i++;
            }
        }

        [TestCase]
        public void Test_Queue_string()
        {
            Queue.Queue<string> myQ = new Queue.Queue<string>();
            myQ.Enqueue("appels");
            myQ.Enqueue("peren");
            myQ.Enqueue("sinaasappels");
            myQ.Enqueue("kiwi's");
            Assert.AreEqual(myQ.First, "appels");
            myQ.Dequeue();
            Assert.AreEqual(myQ.First, "peren");
        }

    }
}
