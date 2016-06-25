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
                //var myUnit = new Unit() { Name = UnitName.cubic_metre, Symbol = "m^3", Family = UnitFamily.Volume, Base = 1000.0 };

                // Retrieve a unit by its Unit Name
                //Console.WriteLine(UnitsTable.GetByName(UnitName.kiloVolt).Symbol);

                // Convert a unit using the static function
                //Console.WriteLine(UnitsTable.Convert(1.0, UnitName.mile, UnitName.kilometre));

                // Convert a double variable using extension method
                double myNumber = 1.0;
                Console.WriteLine(UnitConversion(myNumber,UnitName.hour,UnitName.minute));
                Console.WriteLine(UnitConversion(myNumber,UnitName.day,UnitName.hour));
                Console.WriteLine(UnitConversion(myNumber,UnitName.week,UnitName.day));
                Console.WriteLine(UnitConversion(myNumber,UnitName.month,UnitName.week));
                Console.WriteLine(UnitConversion(myNumber,UnitName.month,UnitName.day));
                Console.WriteLine(UnitConversion(myNumber,UnitName.year,UnitName.month));
                Console.WriteLine(UnitConversion(myNumber,UnitName.year,UnitName.week));
                Console.WriteLine(UnitConversion(myNumber,UnitName.year,UnitName.day));
                Console.WriteLine(UnitConversion(myNumber,UnitName.year,UnitName.hour));

                Console.WriteLine(UnitConversion(myNumber,UnitName.metre,UnitName.centimetre));
                Console.WriteLine(UnitConversion(myNumber,UnitName.kilometre,UnitName.metre));
                Console.WriteLine(UnitConversion(myNumber,UnitName.mile,UnitName.kilometre));

                Console.WriteLine(UnitConversion(myNumber,UnitName.Degree_Celsius,UnitName.Degree_Farenheit));
                Console.WriteLine(UnitConversion(myNumber,UnitName.Degree_Farenheit,UnitName.Degree_Celsius));
                Console.WriteLine(UnitConversion(myNumber,UnitName.Degree_Celsius,UnitName.Degree_Kelvin));
                Console.WriteLine(UnitConversion(myNumber,UnitName.Degree_Kelvin,UnitName.Degree_Celsius));
                Console.WriteLine(UnitConversion(myNumber,UnitName.Degree_Farenheit,UnitName.Degree_Kelvin));
                Console.WriteLine(UnitConversion(myNumber,UnitName.Degree_Kelvin,UnitName.Degree_Farenheit));
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Type any key to exit ...");
            Console.ReadKey();
        }

        public static string UnitConversion(double value, UnitName from, UnitName to)
        {
            return string.Format("{0} {1} converted to {2} is {3}",value,from,to,value.Convert(from,to));
        }
    }
}