using System;

namespace Units
{
    public static class Units
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine(UnitsTable.GetByName(UnitName.kiloVolt).Symbol);
                Console.WriteLine(UnitsTable.Convert(1.0, UnitName.kiloAmpere, UnitName.Volt));
            }
            catch (System.Exception e)
            {
                //Console.WriteLine(e.Source.ToString());
                Console.WriteLine(e.Message);
            }

            //Console.ReadKey();
        } 
    }
}