using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigOExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Examples e = new Examples();
            int[] array = new int[10]{1,2,3,4,5,6,7,8,9,10};
            Console.WriteLine(e.FirstValue(array));
            Console.WriteLine(e.AllValues(array));
            Console.WriteLine(e.FindDistance(array, 3, 8));
            Console.ReadKey();
        }
    }
}
