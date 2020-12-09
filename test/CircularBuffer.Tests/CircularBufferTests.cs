using Structures.Buffers;
using System;
using Xunit;

namespace Structures.Tests
{
    public class CircularBufferTests
    {
        [Fact]
        public void NewlyCreatedBufferIsEmpty()
        {
            var buffer = new CircularBuffer<double>();
            Assert.True(buffer.IsEmpty);
        }

        [Fact]
        public void BufferOfFiveIsFullAfterFiveWrites()
        {
            var buffer = new CircularBuffer<double>(capacity: 5);         
            buffer.Write(3);
            buffer.Write(3);
            buffer.Write(3);
            buffer.Write(3);
            buffer.Write(3);

            Assert.True(buffer.IsFull);        
        }

        [Fact]
        public void FirstElementAddedGetsReturnedFirst()
        {
            var buffer = new CircularBuffer<double>();
            buffer.Write(1);
            buffer.Write(2);

            Assert.Equal(1, buffer.Read());
            Assert.Equal(2, buffer.Read());
            Assert.True(buffer.IsEmpty);
        }

        [Fact]
        public void DataGetsOverwrittenWhenCapacityExceeded()
        {
            var buffer = new CircularBuffer<double>(capacity: 3);
            var values = new[] { 1, 2, 3, 4, 5};

            foreach (var value in values) buffer.Write(value);

            Assert.Equal(3, buffer.Read());
            Assert.Equal(4, buffer.Read());
            Assert.Equal(5, buffer.Read());
        }
    }
}
