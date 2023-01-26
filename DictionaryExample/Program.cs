using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("a.01", "C");
            dic.Add("a.02", "C++");
            dic.Add("a.03", "C#");
            foreach(KeyValuePair<string, string> pair in dic)
            {
                Console.WriteLine("{0} and {1}",pair.Key, pair.Value);
            }
        }
    }
}
