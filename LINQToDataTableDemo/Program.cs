using System;

namespace LINQToDataTableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Table demo");
            LinqToDataTable linqToDataTable = new LinqToDataTable();
            linqToDataTable.AddToDataTableDemo();
            Console.ReadKey();
        }
    }
}
