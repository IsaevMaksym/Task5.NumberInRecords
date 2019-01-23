using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Resourses
{
    class Digits
    {
        public static Dictionary<ushort, string> upTo_20 = new Dictionary<ushort, string>()
        {
            { 0, "zero" },
            { 1, "one" },
            { 2, "two" },
            { 3, "three" },
            { 4, "four" },
            { 5, "five" },
            { 6, "six" },
            { 7, "seven" },
            { 8, "eight" },
            { 9, "nine" },
            { 10, "ten" },
            { 11, "eleven" },
            { 12, "twelve" },
            { 13, "thirteen" },
            { 14, "fourteen" },
            { 15, "fifteen" },
            { 16, "sixteen" },
            { 17, "seventeen" },
            { 18, "eighteen" },
            { 19, "nineteen" },        
        };

        public static Dictionary<ushort, string> equalsTo1000 = new Dictionary<ushort, string>()
        {
            {0, "" },
            { 1, "thousands" },
            { 2, "millions" },
            { 3, "billions" },
            { 4, "trillions" },
            { 5, "quadrillions" },
        };

        public static Dictionary<ushort, string> thirdDigitInNum  = new Dictionary<ushort, string>()
        {
            { 0, "" },
            { 1, "one" },
            { 2, "two" },
            { 3, "three" },
            { 4, "four" },
            { 5, "five" },
            { 6, "six" },
            { 7, "seven" },
            { 8, "eight" },
            { 9, "nine" },
         
        };

        public static Dictionary<ushort, string> tensNum = new Dictionary<ushort, string>()
        {
            { 2, "twenty" },
            { 3, "thirty" },
            { 4, "forty" },
            { 5, "fifty" },
            { 6, "sixty" },
            { 7, "seventy" },
            { 8, "eighty" },
            { 9, "ninety" }
        };

    }
}
    