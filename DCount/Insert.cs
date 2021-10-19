using System;
using System.IO;
using System.Linq;

namespace DCount
{
    class Insert
    {
        private static readonly string _path = "DCount.txt";
        private readonly string[] _items;
        private readonly DateTime _timeNow;
        public Insert(DateTime timeNow)
        {
            _items = File.ReadAllLines(_path);
            _timeNow = timeNow;
        }
        private DItem LastDItem
        {
            get { return new Creator(_items.LastOrDefault()).CreateDItem(); }
        }
        private string TimeDifference
        {
            get { return TimeSpanFormat(_timeNow - LastDItem.FullDate); }
        }
        public void Write()
        {
            if (_items.Length == 0)
            {
                File.AppendAllText(_path, $"1) {_timeNow}\n");
            }
            else if (_items.Length == 1)
            {
                File.AppendAllText(_path, $"2) {_timeNow} Прошло: {TimeDifference}\n");
            }
            else
            {
                File.AppendAllText(_path, $"{_items.Length + 1}) {_timeNow} Прошло: {TimeDifference}\n");
            }
        }
        private static string TimeSpanFormat(TimeSpan timeSpan)
        {
            if (timeSpan.Days == 0)
            {
                return timeSpan.ToString(@"hh\:mm\:ss");
            }
            else
            {
                return timeSpan.ToString(@"d\.hh\:mm\:ss");
            }
        }
    }
}