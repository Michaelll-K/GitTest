using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudowniczyRobotów_Builder
{
    internal class RobotBuilder
    {
        private string name;
        private Materials materials;
        private string functionality;
        private Wepon wepon;
        private int health;

        internal RobotBuilder WithName(string name)
        {
            this.name = name;
            return this;
        }

        internal RobotBuilder WithMaterial(Materials materials)
        {
            this.materials = materials;
            return this;
        }

        internal RobotBuilder WithFunctionality(string functionality)
        {
            this.functionality = functionality;
            return this;
        }

        internal RobotBuilder WithHealth(string health)
        {
            this.health = Int32.Parse(health);
            return this;
        }

        internal RobotBuilder WithWepon(Wepon wepon)
        {
            this.wepon = wepon;
            return this;
        }

        internal Robot Build()
        {
            return new Robot(name, materials, functionality, wepon, health);
        }
    }
}
