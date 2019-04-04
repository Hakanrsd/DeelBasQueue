using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Queue<T> : IEnumerable<T>
    {
        public int Length { get; set; }
        public T First
        {
            get
            {
                return FirstNode.Item;
            }
        }
        public T Last
        {
            get
            {
                return LastNode.Item;
            }
        }
        public bool IsEmpty
        {
            get
            {
                return FirstNode == null;
            }
        }
        public QueueNode<T> FirstNode { get; set; }
        public QueueNode<T> LastNode { get; set; }

        public Queue()
        {
            this.Length = 0;
        }
        public void Enqueue(T NewLast)
        {
            QueueNode<T> NewNode = new QueueNode<T>(NewLast, null);
            if (this.LastNode != null)
            {
                this.LastNode.Next = NewNode;
            }
            else
            {
                this.FirstNode = NewNode;
            }
            this.Length += 1;
            this.LastNode = NewNode;

        }
        public T Dequeue()
        {
            T LeastRecent = this.FirstNode.Item;
            this.FirstNode = this.FirstNode.Next;
            if (this.FirstNode.Next == null)
            {
                this.LastNode = null;
            }
            this.Length -= 1;

            return LeastRecent;
        }

        public override string ToString()
        {
            StringBuilder ReturnQueue = new StringBuilder(this.First.ToString());
            QueueNode<T> NextNode = this.FirstNode.Next;
            for (int i = 1; i < this.Length; i++)
            {
                ReturnQueue.Append("," + NextNode.Item.ToString());
                NextNode = NextNode.Next;
            }
            return ReturnQueue.ToString();
        }

        public IEnumerator<T> GetEnumerator()
        {
            QueueNode<T> current = FirstNode;
            while (current != null)
            {
                yield return current.Item;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();

        }
    }
}