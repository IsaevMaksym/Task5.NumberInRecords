using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Utilities;
using BL.Resourses;

namespace BL
{
    internal class Number
    {
        private const string MINUS = "minus";

        private ushort[] _dividedNumberArr = new ushort[10];
        private readonly bool _isNegative = false;
        private readonly long _num;
        StringBuilder builder = new StringBuilder();

        public Number(long num)
        {
            _isNegative = (num < 0);

            _num = num;

            _dividedNumberArr = Utilities.NumberConverter.GetDividedNum(num);
        }

        public long Num { get; }
        
        public string GetConvertedNumber()
        {
            builder.Append(_num + ": ");

            if (_isNegative)
            {
                builder.Append(MINUS);
            }

            builder.Append(NumberConverter.GetFormatedString(_dividedNumberArr));

            return builder.ToString();
        }

    }
}
