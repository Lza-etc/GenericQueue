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
        readonly T[] queue;
        int front=-1;
        int rear = -1;

        public GenericQueue(int size)
        {
            queue = new T[size];
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
            if (front==-1) 
                front = rear = 0;
            else
                rear=(rear+1)%queue.Length;
            queue[rear]=item;
        }
        public void Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("The queue is empty.");
            Console.WriteLine(queue[front]);
            if (rear==front) front = rear=-1;
            else
            front = (front + 1) % queue.Length;
        }
        public bool IsEmpty()
        {
            return front == -1;
        }
        public bool IsFull()
        {
            return  front==(rear+1)%queue.Length;
        }
    }
}
// size=4
// 0 1 2 3  
// front+ rear+1 % 4 =0
