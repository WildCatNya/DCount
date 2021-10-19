using System;

namespace DCount
{
    class Program
    {
        private static readonly DateTime _timeNow = DateTime.Now;
        static void Main()
        {
            Insert insert = new Insert(_timeNow);
            insert.Write();
        }
    }
}