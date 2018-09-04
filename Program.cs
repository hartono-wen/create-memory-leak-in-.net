using System;
using System.Collections.Generic;

namespace CreateMemoryLeakIn.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> messages = new List<string>();
            while (true)
            {
                messages.Add((new Guid()).ToString());
            }
        }
    }
}
