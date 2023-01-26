using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    //Declare a delegate type
    delegate int Operation(int x, int y);
    internal class Delegate
    {
        public void delegatesE()
        {
            //create a instance of the delegate that refers to the Add method.
            Operation op = Add;

            int result = op(3, 4);
            Console.WriteLine(result);
        }

        //A method thatmatches that delegate's signature
        static int Add(int x, int y) => x + y;
    }
}



//In C#, a delegate is a type that represents a reference to a method. 
//Delegates are used to pass methods as arguments to other methods, and to create event-handler methods.        
