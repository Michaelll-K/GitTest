namespace BudowniczyRobotów_Builder
{
    public class Wepon
    {
        [DisplayProperty("Nazwa broni: ")]
        public string Name { get; set; }
        [DisplayProperty("Obrażenia: ")]
        public int DMG { get; set; }
        [DisplayProperty("Zasięg: ")]
        public double Range { get; set; }

        public Wepon(string name, int dmg, double range)
        {
            Name = name;
            DMG = dmg;
            Range = range;
        }

        public Wepon()
        {

        }
    }
}