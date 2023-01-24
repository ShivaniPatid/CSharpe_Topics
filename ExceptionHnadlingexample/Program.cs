using System;

namespace ExceptionHnadlingexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestException.TestArgumentException("shi");
            int[] arr = new int[3];

            try
            {
                Console.WriteLine("Enter First Number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                int num2 = Convert.ToInt32(Console.ReadLine());

                arr[0] = 1;
                arr[1] = 2;
                arr[2] = 3;

                int result = num1 / num2;
                Console.WriteLine("Result : "+result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }

}
