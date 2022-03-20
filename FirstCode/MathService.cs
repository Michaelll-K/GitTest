using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCode
{
    class MathService
    {

        public event EventHandler<MathPerformedEventArgs> MathPerformed;


        public double AddNumbers(double v1, double v2)
        {
            MathPerformed(this, new MathPerformedEventArgs(v1 + v2));
            return v1 + v2;
        }
        public double MultiplyNumbers(double v1, double v2)
        {
            MathPerformed(this, new MathPerformedEventArgs(v1 * v2));
            return v1 * v2;
        }
    }
}
