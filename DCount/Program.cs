using System;

namespace DCount
{
    class Program
    {
        private static readonly DateTime _timeNow = DateTime.Now;
        private static readonly string _path = "DCount.txt";
        static void Main()
        {
            Insert insert = new Insert(_timeNow, _path);
            insert.Write();
        }
    }
}