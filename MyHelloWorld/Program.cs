using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //HelloWorld();
            WorkingWIthIntergers();
        }

        private static void HelloWorld()
        {
            String addtional_string = "By akebonolove";
            Console.WriteLine($"HelloWorld {addtional_string}");
        }

        private static void WorkingWIthIntergers()
        {
            int max = int.MaxValue;
            int what = max + 3;
            Console.WriteLine($"max = {max}, max+3 = {what}, min = {int.MinValue}");
        }
    }
}
