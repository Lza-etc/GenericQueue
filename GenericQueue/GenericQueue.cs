using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class GenericQueue<T> where T : class, new()
    {
        readonly List<T> queue = new();
        int front=-1;
        int rear = -1;
        int size;
        public GenericQueue(int size)
        {
            this.size = size;
        }
        public void Enqueue(T item)
        {
            if (IsFull())
            {
                throw new InvalidOperationException("The queue is full.");
            }
            if (item == null)
            {
                item = new T();
            }
            if (front==-1) front = 0;
            queue.Add(item);
            rear++;
        }
        public void Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("The queue is empty.");
            queue.RemoveAt(0);
            rear--;
            if(rear==-1) front = -1; 
        }
        public bool IsEmpty()
        {
            return front == -1;
        }
        public bool IsFull()
        {
            return rear == size-1;
        }
    }
}
