using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHnadlingexample
{
    internal class TestException
    {
        public static void TestArgumentException(string name)
        {
            try
            {
                string result = name.Substring(name.Length + 2);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
