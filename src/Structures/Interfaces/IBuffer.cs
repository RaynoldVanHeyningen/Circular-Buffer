using System.Collections.Generic;

namespace Structures.Interfaces
{
    public interface IBuffer<T>
    {
        bool IsEmpty { get; }
        void Write(T value);
        T Read();
    }
}