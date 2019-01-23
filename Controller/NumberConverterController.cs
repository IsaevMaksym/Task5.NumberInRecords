using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller.Utilities;
using UI;
using BL;

namespace Controller
{
    public class NumberConverterController
    {
        const string RULES = "Enter numbers, that have to be converted into records";

        private IViewer _viever;
        private NumberArr _numbers;

        public NumberConverterController()
            : this(new ConsoleIO())
        {
        }

        public NumberConverterController(IViewer viever)
        {
            _viever = viever;
        }

        public void Run(string[] args)
        {
            long[] arr;

            if (ArgsValidator.GetNumsFromInsertedArgs(args, out arr))
            {
                if (arr.Length == 0)
                {
                    _viever.ShowMessage(RULES);                   
                }
                else
                {
                    _numbers = new NumberArr(arr);
                    _viever.ShowNumbers(_numbers.GetConvertedNumbersArr());
                }
            }
            else
            {
                _viever.ShowMessage(RULES);
            }
        }

    }
}
