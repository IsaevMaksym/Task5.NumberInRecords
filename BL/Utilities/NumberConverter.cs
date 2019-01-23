using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Resourses;

namespace BL.Utilities
{
    public static class NumberConverter
    {
        private const string HUNDRED_STR = "hundred ";
        private const int HUNDRED_DIVIDER = 100;
                   
        internal static ushort[] GetDividedNum(long num)
        {
            ushort[] arr = new ushort[6];
            int i = 0;

            while (num != 0)
            {
                arr[i] = (ushort)(num % 1000);
                num /= 1000;
                i++;
            }

            return arr;
        }

        internal static string GetFormatedString(ushort[] _numberArr)
        {
            string[] arr = new string[_numberArr.Length];
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < _numberArr.Length; i++)
            {
                if (_numberArr[i] != 0)
                {
                    arr[i] = NumberConverter.ConvertNumToString(_numberArr[i], i);
                }
            }

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                builder.Append(arr[i]);
            }

            return builder.ToString();
        }

        private static string ConvertNumToString(ushort num, int index)
        {            
            StringBuilder stringBuilder = new StringBuilder();
            ushort hundredCoef =(ushort)( num / 100);
                        
            if (hundredCoef!=0)
            {
                stringBuilder.Append(Digits.thirdDigitInNum[hundredCoef].ToString() + " ");
                stringBuilder.Append(HUNDRED_STR);
            }
            
            num %= HUNDRED_DIVIDER;

            if (num < 20)
            {
                stringBuilder.Append(Digits.upTo_20[num].ToString() + " ");
            }
            else
            {
                ushort tmp = (ushort)(num / 10);
                stringBuilder.Append(Digits.tensNum[tmp].ToString() + " ");
                stringBuilder.Append(Digits.upTo_20[(ushort)(num % 10)].ToString() + " ");
            }
            stringBuilder.Append(Digits.equalsTo1000[(ushort)index].ToString() + " ");
            
            return stringBuilder.ToString();
        }
    }
}
