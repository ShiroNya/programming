﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //declared variables
            int[] myArray = new int[] { 100, 20, 1, 600, 300, 33, 71, 92 };


            /* ****************************************** *
             * Counts array before it is sorted by bubble *
             * ****************************************** */
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }



            Console.ReadKey();
        }
    }
}