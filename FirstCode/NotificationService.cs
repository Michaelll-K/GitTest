using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCode
{
    class NotificationService : IMathPerformedServices
    {
        public void OnMathPerformed(object sender, MathPerformedEventArgs args)
        {
            Console.WriteLine("Notification " + args.MathResult);
        }
    }
}
