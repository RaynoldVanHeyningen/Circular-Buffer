# Circular-Buffer
A circular buffer implementation.

# Demonstration
Program.cs contains the implementation of a <double> circular buffer using a default capacity of 10 elements.

# Implementation
The implementation has a read and write method to interact with the buffer. There are also some statistical parameters which display the following states of the buffer:
- buffer.Capacity (Shows capacity of created buffer).
- buffer.IsEmpty (Returns true if buffer is empty).
- buffer.IsFull (Returns true if buffer is full).

# Testing
Included are 4 validation tests which verify the following capabilities:
- A newly created buffer is empty
- Buffer is full when reaching set capacity
- Returns data the fifo basis
- Buffer overwrites oldest entries when capacity is exceeded
