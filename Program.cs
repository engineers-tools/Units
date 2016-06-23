using System;

namespace Units
{
    public static class Units
    {
        public static void Main()
        {
            try
            {
                // Create a new Unit
                var myUnit = new Unit() { Name = UnitName.cubic_metre, Symbol = "m^3", Family = UnitFamily.Volume, Base = 1000.0 };

                // Retrieve a unit by its Unit Name
                Console.WriteLine(UnitsTable.GetByName(UnitName.kiloVolt).Symbol);

                // Convert a unit using the static function
                Console.WriteLine(UnitsTable.Convert(1.0, UnitName.mile, UnitName.kilometre));

                // Convert a double varialble using extension method
                var myNumber = (double)1.536;
                Console.WriteLine(myNumber.Convert(UnitName.inch,UnitName.centimetre));
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Type any key to exit ...");
            Console.ReadKey();
        } 
    }
}