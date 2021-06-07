using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
namespace ASD_chatter
{
    public class LimitedQueu<T> : LinkedList<T>
    {
        readonly ConcurrentQueue<T> queue = new ConcurrentQueue<T>();

        public int Size { get; private set; }

        public LimitedQueu(int size)
        {
            Size = size;
        }

        public void Enqueue(T obj)
        {
            queue.Enqueue(obj);

            while (queue.Count > Size)
            {
                T outObj;
                queue.TryDequeue(out outObj);
            }
        }
    }
}
