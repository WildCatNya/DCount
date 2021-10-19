using System;

namespace DCount
{
    class DItem
    {
        public readonly string Order;
        public readonly string Date;
        public readonly string Time;
        public readonly string Text;
        public readonly string TimeTaken;
        public DItem(string order, string date, string time, string text, string timeTaken)
        {
            Order = order;
            Date = date;
            Time = time;
            Text = text;
            TimeTaken = timeTaken;
        }
        public DItem(string order, string date, string time)
        {
            Order = order;
            Date = date;
            Time = time;
        }
        public DateTime FullDate
        {
            get
            {
                if (DateTime.TryParse($"{Date} {Time}", out DateTime result))
                {
                    return result;
                }
                else
                {
                    throw new Exception("Входные данные имели не верный формат");
                }
            }
        }
    }
}