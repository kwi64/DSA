using System;
using System.Collections.Generic;
using System.Text;

namespace NC_03_Stack.LC_155_MinStack
{
    internal interface IQuestion
    {
        abstract void Push(int val);
        void Pop();
        int Top();
        int GetMin();
    }
}
