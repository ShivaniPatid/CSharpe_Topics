using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDemo
{
    internal class ArithmeticOperation
    {
        //use dynamic to avoid compile time checking
        public T Division<T>(T a, T b)
        {

            //var res = a / b;  //Generic do not support the arithamatic operation i.e we use dynamic 
            dynamic a1 = a;
            dynamic b1 = b;
            dynamic res = a1 / b1;

            //Console.WriteLine("Division is "+res);
            return res;
        }
    }
}
