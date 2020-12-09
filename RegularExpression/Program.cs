using System;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            string line="";            


            while (true)
            {
                line = Console.ReadLine();
                Console.WriteLine(line.isTime());
            }
        }
    }
}
