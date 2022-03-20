using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCode
{
    class Program
    {
        static void Main(string[] args)
        {
            MathService service = new MathService();

            new List<IMathPerformedServices> {
                new LoggingServices(), new NotificationService()
            }.ForEach(serv => service.MathPerformed += serv.OnMathPerformed);

            service.AddNumbers(4, 5);
            service.MultiplyNumbers(2, 5);



            Console.ReadKey();
        }
    }
}
