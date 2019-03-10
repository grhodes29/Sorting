using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class BubbleSort
    {

        public int[] IntegerArray;

        public int LargestInteger { get; set; }

        public readonly int Size = 10;


        /// <summary>
        /// DESCRIPTION: n squared operations. Very inefficient
        /// 1000 member array will take 1 million operations to sort. Ouch!!
        /// </summary>
        public BubbleSort() {

            IntegerArray = new int[Size];

            Random _r = new Random();

            for (int i = 0; i < IntegerArray.Length; i++)
            {
                IntegerArray[i] = _r.Next(1, 1000);
            }

        }

        public void Sort() {

            // example
            // Passes - 3,7,4,4,6,8,5; 3,4,7,4,6,8,5; 3,4,4,7,6,8,5; 3,4,4,6,7,8,5; 3,4,4,6,7,5,8; 3,4,4,6,5,7,8; 
            // Pass 1 - 3,4,4,6,5,7,8
            // Pass 2 - 3,4,4,5,6,7,8
            // Pass 3 - 3,4,4,5,6,7,8 -- no swaps 

            bool SwapOccurred = false;
            bool IsMultipleElements = IntegerArray.Length > 1 ? true: false;
            while(IsMultipleElements)
            {
                // watch out of bounds index exception
                // do forward comparison
                // need to move all the way to end for array
               

            }


            LargestInteger = IntegerArray[Size];
        }


    }
}
