using ClassLibraryTest;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            new Class1().WriteFile(true);

            Console.ReadKey();
        }
    }
}
