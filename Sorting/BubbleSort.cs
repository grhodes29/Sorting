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

        private int Min { get; set; }
        private int Max { get; set; }

        private int Size { get; set; }

        /// <summary>
        /// DESCRIPTION: n squared operations. Very inefficient
        /// 1000 member array will take 1 million operations to sort. Ouch!!
        /// </summary>
        public BubbleSort()
        {

            Size = 10;
            Min = 1;
            Max = 100;

            InitializeArray();

        }

        private void InitializeArray()
        {
            IntegerArray = new int[Size];

            Random _r = new Random();

            for (int i = 0; i < IntegerArray.Length; i++)
            {
                IntegerArray[i] = _r.Next(Min, Max);
            }

        }

        public BubbleSort(int size, int min, int max) 
        {

            Size = size;
            Min = min;
            Max = max;

            InitializeArray();

        }

        public void Sort() {

            // example
            // Passes - 3,7,4,4,6,8,5; 3,4,7,4,6,8,5; 3,4,4,7,6,8,5; 3,4,4,6,7,8,5; 3,4,4,6,7,5,8; 3,4,4,6,5,7,8; 
            // Pass 1 - 3,4,4,6,5,7,8
            // Pass 2 - 3,4,4,5,6,7,8
            // Pass 3 - 3,4,4,5,6,7,8 -- no swaps 

            //int index = 0;
            //bool SwapOccurred = false;
            //bool IsMultipleElements = IntegerArray.Length > 1 ? true: false;
            //while(SwapOccurred)
            //{
            //    // watch out of bounds index exception
            //    // do forward comparison
            //    // need to move all the way to end for array

            //    // is index valid ????
            //    while (index <= IntegerArray.Length - 1) {
            //        // is index valid ???
            //        if (index - 1 <= IntegerArray.Length - 1)
            //        {
            //            if (IntegerArray[index] > IntegerArray[index - 1])
            //            {

            //            }
            //        }
            //    }


            //}


            //LargestInteger = IntegerArray[Size];

            int temp = 0;

            for (int write = 0; write < IntegerArray.Length; write++)
            {
                for (int sort = 0; sort < IntegerArray.Length - 1; sort++)
                {
                    if (IntegerArray[sort] > IntegerArray[sort + 1])
                    {
                        // capture forward one in temp
                        temp = IntegerArray[sort + 1]; 
                        // swap forward for current
                        IntegerArray[sort + 1] = IntegerArray[sort];
                        // current becomes temp
                        IntegerArray[sort] = temp;

                    }
                }
            }

        }


    }
}
