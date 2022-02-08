using System;

namespace _01_ClassAndPoketOOB
{
    class MyClass
    {
        public int field;

        public void Method()
        {
            Console.WriteLine(field);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass();
            a.field = 1;
            a.Method();

            Console.ReadKey();
        }
    }
}
