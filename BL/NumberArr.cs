using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class NumberArr
    {
        private Number[] _numbers;
        private string[] _numbersString;

        public NumberArr(params long[] numberSequence)
        {            
            _numbers = new Number[numberSequence.Length];

            for (int i = 0; i < numberSequence.Length; i++)
            {
                _numbers[i] = new Number(numberSequence[i]);
            }
        }

        public string[] GetConvertedNumbersArr()
        {
            if (_numbers == null)
            {
                return _numbersString;
            }

            _numbersString = new string[_numbers.Length];

            for (int i = 0; i < _numbers.Length; i++)
            {
                _numbersString[i] = _numbers[i].GetConvertedNumber();
            }

            return _numbersString;
        }

    }
}
