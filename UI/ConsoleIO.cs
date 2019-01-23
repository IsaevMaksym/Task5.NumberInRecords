using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class ConsoleIO : IViewer
    {
        private const string PRESS_ANY_KEY = "Press any key...";

        void IViewer.ShowMessage(string s)
        {
            Console.WriteLine(s);
            Console.WriteLine(PRESS_ANY_KEY);
            Console.ReadKey();
        }

        void IViewer.ShowNumbers(string[] arr)
        {
            foreach (string s in arr)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine(PRESS_ANY_KEY);
            Console.ReadKey();
        }
    }
}
