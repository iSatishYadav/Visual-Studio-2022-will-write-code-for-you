using System;
using System.Text;

namespace Vs2022Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StringBuilder sb = new StringBuilder();
            foreach (var item in args)
            {
                sb.AppendLine(item);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
