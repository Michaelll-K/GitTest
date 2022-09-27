using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BudowniczyRobotów_Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Create Robot

            Robot robot = Robot
                .NewRobotBuilder()
                .WithName("Cyprian")
                .WithMaterial(Materials.Aluminium)
                .WithWepon(new Wepon("arK34", 13, 10.5))
                .WithHealth("19")
                .WithFunctionality("Robienie")
                .Build();


            robot.ShowRobot();


            // =============================================

            

            Console.ReadLine();
        }
    }
}
