using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Root
{
    class Program
    {
        static void Main(string[] args)
        {
            //call the DigitalRoot()
            DigitalRoot();
        }
        static void DigitalRoot()
        {
            //declare a list of strings
            List<int> rootThis = new List<int>() { 2, 4, 6, 10, 12, 14 };
            Console.WriteLine(string.Join(", ", rootThis.Distinct()));
            Console.WriteLine(rootThis.Sum(x => x));
            //Unable to figure out how to reach the Digital Root
            Console.WriteLine(r
            Console.Read();
        }
    }
}
