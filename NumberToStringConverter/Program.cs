using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;

namespace NumberToStringConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            args = new string[]
            {
                "123",
                "123456",
                "123456789",

            };

            NumberConverterController controller = new NumberConverterController();

            controller.Run(args);
        }

       
    }
}
