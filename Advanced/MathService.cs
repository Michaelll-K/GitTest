using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Advanced
{
    class MathService
    {
        //public event EventHandler<MathPerformedEventArgs> MathPerformed;
        public Action<double> MathPerformed;

        public void CalculateNumbers(double v1, double v2, Func<double, double, double> calc)
        {
            Timer timer = new Timer(5000);
            //MathPerformed(this, new MathPerformedEventArgs { Result = v1 * v2 });
            MathPerformed(calc(v1, v2));
        }
    }


}
