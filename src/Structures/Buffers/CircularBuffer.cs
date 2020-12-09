using Structures.Interfaces;

namespace Structures.Buffers
{
    // A buffer that when constructed has a max capacity of storage.
    // When max capacity is reached it will continue writing to the buffer but it will restart from the 1st index
    // This buffer deletes data when full
    // Reading from this buffer, will read from the oldest added element.
    public class CircularBuffer<T> : IBuffer<T>
    {
        public int Capacity { get { return buffer.Length; } }
        public bool IsEmpty { get { return end == start; } }
        public bool IsFull { get { return (end + 1) % buffer.Length == start; } }

        private T[] buffer;
        private int start;
        private int end;

        // Default constructor with a capacity of 10 if no capacity is supplied.
        public CircularBuffer() : this(capacity:10)
        {            
        }

        // Constructor
        public CircularBuffer(int capacity)
        {
            buffer = new T[capacity+1];
            start = 0;
            end = 0;
        }

        // Write to buffer
        public void Write(T value) {
            buffer[end] = value;
            end = (end+1) % buffer.Length;

            if (end == start) {
                start = (start + 1) % buffer.Length;
            }
        }

        // Read from buffer
        public T Read() {
            var result = buffer[start];

            start = (start + 1) % buffer.Length;

            return result;
        }
    }
}