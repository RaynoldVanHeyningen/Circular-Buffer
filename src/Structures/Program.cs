using Structures.Buffers;
using Structures.Interfaces;
using System;

namespace Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a buffer with a default capacity of 10
            var buffer = new CircularBuffer<double>();
            ProcessInput(buffer);
            ProcessBuffer(buffer);
        }

        // Take input from user and submit to buffer
        private static void ProcessInput(IBuffer<double> buffer)
        {
            while (true)
            {
                var value = 0.0;
                Console.WriteLine("Enter a number to submit to the buffer: ");
                var input = Console.ReadLine();

                if (double.TryParse(input, out value))
                {
                    buffer.Write(value);
                    continue;
                }

                break;
            }
        }

        // Read from buffer and process data
        private static void ProcessBuffer(IBuffer<double> buffer)
        {
            Console.WriteLine("Buffer: ");

            // Read from buffer, till buffer is empty
            while (!buffer.IsEmpty)
            {
                Console.WriteLine($"\t{buffer.Read()}");
            }
        }
    }
}
