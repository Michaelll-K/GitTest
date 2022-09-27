using System;

namespace BudowniczyRobotów_Builder
{
    [AttributeUsage(AttributeTargets.Property)]
    internal class DisplayPropertyAttribute : Attribute
    {
        public string DisplayName { get; set; }

        public DisplayPropertyAttribute(string display)
        {
            DisplayName = display;
        }
    }
}