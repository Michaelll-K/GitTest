using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCode
{
    class LoggingServices : IMathPerformedServices
    {
        void IMathPerformedServices.OnMathPerformed(object sender, MathPerformedEventArgs args)
        {
            Console.WriteLine("Logging " + args.MathResult);
        }
    }
}
