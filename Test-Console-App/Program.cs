using System;

namespace Test_Console_App
{
    class Program
    {   

        static void sayHey()
        {
            Console.WriteLine("hey");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void PrintName(string name, int age)
        {
            Console.WriteLine($"Hello, {name}, {age + 5}");
        }
    }
}
