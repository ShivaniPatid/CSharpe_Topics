using System;
using System.Reflection;

namespace ReflectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //variable metadeta
            int a = 20;
            Type type = a.GetType();
            Console.WriteLine(type);
            Console.WriteLine(type.Assembly);
            Console.WriteLine(type.Name);
            Console.WriteLine(type.IsValueType);
            Console.WriteLine(type.IsEnum);

            Console.WriteLine();
            Console.WriteLine();

            Type types = typeof(Customer);
            ConstructorInfo[] constructorInfos = types.GetConstructors(BindingFlags.Public | BindingFlags.Instance);
            foreach (ConstructorInfo constructor in constructorInfos)
            {
                Console.WriteLine(constructor);
            }

            Console.WriteLine();
            Console.WriteLine();

            MethodInfo[] methodInfos = types.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            foreach (MethodInfo method in methodInfos)
            {
                Console.WriteLine(method);
            }

            Console.WriteLine();
            Console.WriteLine();

            PropertyInfo[] propertyInfo = types.GetProperties();
            foreach (PropertyInfo property in propertyInfo)
            {
                Console.WriteLine(property);
            }
            Console.ReadLine();

        }
    }
}
