using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGetPackageExample
{
    public class Calculator
    {
        private int _result = 0;

        public int Result { get { return _result; } }

        public int Add(int number)
        {
            return _result = _result + number;
        }

        public int Substract(int number)
        {
            return _result = _result - number;
        }
    }
}
