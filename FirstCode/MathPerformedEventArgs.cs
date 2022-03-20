using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCode
{
    class MathPerformedEventArgs : EventArgs
    {
        public double MathResult { get; set; }
        public MathPerformedEventArgs(double result)
        {
            MathResult = result;
        }
    }
}
