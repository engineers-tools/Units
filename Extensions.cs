namespace Units
{
    public static class UnitExtensions
    {
        public static double Convert(this double value, UnitName from, UnitName to)
        {
            return UnitsTable.Convert(value, from, to);
        }
    }
}