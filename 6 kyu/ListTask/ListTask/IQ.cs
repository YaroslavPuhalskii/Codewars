﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Bob is preparing to pass IQ test.
The most frequent task in this test is to find out which one of the given numbers
differs from the others. Bob observed that one number usually differs from the others in evenness.
Help Bob — to check his answers, he needs a program that among the given numbers finds one that is
different in evenness, and return a position of this number.

! Keep in mind that your task is to help Bob solve a real IQ test, which means indexes
of the elements start from 1 (not 0)

Examples:
IQ.Test("2 4 7 8 10") => 3 // Third number is odd, while the rest of the numbers are even
IQ.Test("1 2 1 1") => 2 // Second number is even, while the rest of the numbers are odd
*/
namespace ListTask
{
    public class IQ
    {
        public static int Test(string numbers)
        {
            var c = numbers.Split(' ').Select(x => int.Parse(x)).ToList();
            int index = c.Where(x => x % 2 == 0).Select(x => x).Count() > 1
                ? c.IndexOf(c.Where(x => x % 2 == 1).FirstOrDefault())
                : c.IndexOf(c.Where(x => x % 2 == 0).FirstOrDefault());
            return index + 1;
        }
    }
}
