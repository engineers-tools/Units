namespace Units
{
    public static class UnitExtensions
    {
        public static double Convert(this double value, UnitName from, UnitName to)
        {
            return UnitsTable.Convert(value, from, to);
        }

        public static double ToPerUnit(this double value, double baseValue)
        {
            return UnitsTable.ToPerUnit(value, baseValue);
        }
    }
}