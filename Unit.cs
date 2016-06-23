namespace Units
{
    public class  Unit
    {
        public UnitName Name { get; set; }
        public UnitFamily Family { get; set; }
        public double Base { get; set; }
        public string Symbol { get; set; }
    }

    public class NullUnit : Unit
    {
        new public UnitName Name { get { return UnitName.Unknown; } }
        new public UnitFamily Family { get { return UnitFamily.Unknown; } }
        new public double Base { get { return 1.0; } }
        new public string Symbol { get { return "Unknown"; } }
    }
}