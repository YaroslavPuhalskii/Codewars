﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 };
            Kata.MoveZeroes(arr);

            //int lst = 7775460;
            //PrimeDecomp.factors(lst);

            //String start = "10.0.0.0"; String end = "10.0.1.0";
            //CountIPAddresses.IpsBetween(start, end);

            Console.ReadLine();
        }
    }
}
