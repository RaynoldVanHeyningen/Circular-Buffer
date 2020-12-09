using Structures.Interfaces;
using System.Collections;
using System.Collections.Generic;

namespace Structures.Buffers
{
    class Buffer<T> : IBuffer<T>
    {
        Queue<T> queue = new Queue<T>();

        public bool IsEmpty { get { return queue.Count == 0; } }

        public T Read()
        {
            return queue.Dequeue();
        }

        public void Write(T value)
        {
            queue.Enqueue(value);
        }
    }
}
