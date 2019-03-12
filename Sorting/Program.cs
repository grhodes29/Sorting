using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {

            BubbleSort bs = new BubbleSort(10, 1, 1000);
            bs.Sort();

            Console.ReadLine();

        }
    }
}
