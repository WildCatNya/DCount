using System;

namespace DCount
{
    class Creator
    {
        private readonly string _row;
        public Creator(string row)
        {
            _row = row;
        }
        public DItem CreateDItem()
        {
            string[] splitted = _row.Split(' ');
            if (splitted.Length != 3 && splitted.Length != 5)
            {
                throw new Exception("Размер массива не равен 5");
            }
            if (splitted.Length == 3)
            {
                return new DItem(splitted[0], splitted[1], splitted[2]);
            }
            return new DItem(splitted[0], splitted[1], splitted[2], splitted[3], splitted[4]);
        }
    }
}