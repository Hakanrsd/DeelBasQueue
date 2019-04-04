using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class QueueNode<T>
    {
        public T Item { get; set; }
        public QueueNode<T> Next { get; set; }

        public QueueNode(T item, QueueNode<T> next)
        {
            this.Item = item;
            this.Next = next;
        }

    }
}
