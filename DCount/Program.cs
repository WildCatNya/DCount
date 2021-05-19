using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DCount
{
    class Program
    {
        static void Main()
        {
            string path = @"DCount.txt";
            var arr = File.ReadAllLines(path);
            int count = arr.Length + 1;
            var tNow = DateTime.Now;

            if (count == 1)
            {
                File.AppendAllText(path, $"{count}) {tNow}\n");
            }
            else if (count == 2)
            {
                var tBefore = DateTime.Parse(RmvFor2(arr[count - 2].ToString()));
                var tt = tNow - tBefore;
                File.AppendAllText(path, $"{count}) {tNow} Прошло: {tt}\n");
            }
            else
            {
                var tBefore = DateTime.Parse(Rmv(arr[count - 2]));
                var tt = tNow - tBefore;
                File.AppendAllText(path, $"{count}) {tNow} Прошло: {FinRmv(tt.ToString())}\n");
            }
        }
        static string Rmv(string s)
        {
            Regex reg = new Regex(@"\d*\D");
            Match match = reg.Match(s);
            s = s.Replace(match.ToString(), "").Trim();
            reg = new Regex(@"Прошло:\s\S*");
            match = reg.Match(s);
            s = s.Replace(match.ToString().Trim(), "");
            return s;
        }
        static string FinRmv(string s)
        {
            Regex reg = new Regex(@"\d*\D[\d\d:]*");
            Match match = reg.Match(s);
            return match.ToString();
        }
        static string RmvFor2(string s)
        {
            Regex reg = new Regex(@"\d*\D");
            Match match = reg.Match(s);
            s = s.Replace(match.ToString(), "").Trim();
            return s;
        }
    }
}
