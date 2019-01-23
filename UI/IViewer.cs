using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public interface IViewer
    {
        void ShowMessage(string s);

        void ShowNumbers(string[] arr);
    }
}
