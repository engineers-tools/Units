using System;
using System.Collections.Generic;

namespace Units
{
    public static class UnitsTable
    {
        /// <sumary>
        /// Returns a list of predefined Units
        /// </summary>
        public static List<Unit> Units 
        { 
            get
            {
                return new List<Unit>()
                {
                    // Current
                    new Unit() { Name = UnitName.microAmpere, Symbol = "uA", Family = UnitFamily.Current, Base = 0.000001 },
                    new Unit() { Name = UnitName.miliAmpere, Symbol = "mA", Family = UnitFamily.Current, Base = 0.001 },
                    new Unit() { Name = UnitName.Ampere, Symbol = "A", Family = UnitFamily.Current, Base = 1.0 },
                    new Unit() { Name = UnitName.kiloAmpere, Symbol = "kA", Family = UnitFamily.Current, Base = 1000.0 },
                    // Voltage
                    new Unit() { Name = UnitName.microVolt, Symbol = "uV", Family = UnitFamily.Voltage, Base = 0.000001 },
                    new Unit() { Name = UnitName.miliVolt, Symbol = "mV", Family = UnitFamily.Voltage, Base = 0.001 },
                    new Unit() { Name = UnitName.Volt, Symbol = "V", Family = UnitFamily.Voltage, Base = 1.0 },
                    new Unit() { Name = UnitName.kiloVolt, Symbol = "kV", Family = UnitFamily.Voltage, Base = 1000.0 },
                    // Aparent Power
                    new Unit() { Name = UnitName.miliVoltAmpere, Symbol = "mVA", Family = UnitFamily.AparentPower, Base = 0.001 },
                    new Unit() { Name = UnitName.VoltAmpere, Symbol = "VA", Family = UnitFamily.AparentPower, Base = 1.0 },
                    new Unit() { Name = UnitName.kiloVoltAmpere, Symbol = "kVA", Family = UnitFamily.AparentPower, Base = 1000.0 },
                    new Unit() { Name = UnitName.MegaVoltAmpere, Symbol = "MVA", Family = UnitFamily.AparentPower, Base = 1000000.0 },
                    // Real Power
                    new Unit() { Name = UnitName.miliWatt, Symbol = "mW", Family = UnitFamily.RealPower, Base = 0.001 },
                    new Unit() { Name = UnitName.Watt, Symbol = "W", Family = UnitFamily.RealPower, Base = 1.0 },
                    new Unit() { Name = UnitName.kiloWatt, Symbol = "kW", Family = UnitFamily.RealPower, Base = 1000.0 },
                    new Unit() { Name = UnitName.MegaWatt, Symbol = "MW", Family = UnitFamily.RealPower, Base = 1000000.0 },
                    // Length
                    new Unit() { Name = UnitName.milimetre, Symbol = "mm", Family = UnitFamily.Length, Base = 0.001 },
                    new Unit() { Name = UnitName.centimetre, Symbol = "cm", Family = UnitFamily.Length, Base = 0.01 },
                    new Unit() { Name = UnitName.metre, Symbol = "m", Family = UnitFamily.Length, Base = 1.0 },
                    new Unit() { Name = UnitName.kilometre, Symbol = "km", Family = UnitFamily.Length, Base = 1000.0 },
                    new Unit() { Name = UnitName.inch, Symbol = "in", Family = UnitFamily.Length, Base = 0.0254 },
                    new Unit() { Name = UnitName.foot, Symbol = "ft", Family = UnitFamily.Length, Base = 0.3048 },
                    new Unit() { Name = UnitName.yard, Symbol = "yd", Family = UnitFamily.Length, Base = 0.9144 },
                    new Unit() { Name = UnitName.mile, Symbol = "ml", Family = UnitFamily.Length, Base = 1609.34 },
                };
            }
        }

        /// <sumary>
        /// Retrieves a Unit by its Name
        /// </summary>
        /// <param name="name">UnitName to be searched for </param>
        public static Unit GetByName(UnitName name)
        {
            var unit = Units.Find(u => u.Name.Equals(name));
            return unit == null ? new NullUnit() : unit;
        }

        public static Unit GetBySymbol(string symbol)
        {
            var unit = Units.Find(u => u.Symbol.Equals(symbol, StringComparison.CurrentCultureIgnoreCase));
            return unit == null ? new NullUnit() : unit;
        }

        public static double Convert(double value, UnitName from, UnitName to)
        {
            var fromUnit = GetByName(from);
            var toUnit = GetByName(to);

            if (fromUnit.Family != toUnit.Family) throw new Exception(string.Format("Error: Units of family {0} cannot be converted to units of family {1}.",fromUnit.Family, toUnit.Family));
        
            return value * (fromUnit.Base / toUnit.Base);
        }
    }
}