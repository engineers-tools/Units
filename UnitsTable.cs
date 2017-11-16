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
                    // Energy
                    new Unit() { Name = UnitName.Joule, Symbol = "J", Family = UnitFamily.Energy, Base = 1 },
                    new Unit() { Name = UnitName.Calorie, Symbol = "cal", Family = UnitFamily.Energy, Base = 4.184 },
                    // Resistance
                    new Unit() { Name = UnitName.Ohm,     Symbol="Ohm", Family = UnitFamily.Resistance, Base = 1.0 },
                    new Unit() { Name = UnitName.miliOhm, Symbol="mOhm", Family = UnitFamily.Resistance, Base = 0.001 },
                    new Unit() { Name = UnitName.microOhm,Symbol="uOhm", Family = UnitFamily.Resistance, Base = 0.000001 },
                    new Unit() { Name = UnitName.kiloOhm, Symbol="kOhm", Family = UnitFamily.Resistance, Base = 1000.0 },
                    new Unit() { Name = UnitName.MegaOhm, Symbol="MOhm", Family = UnitFamily.Resistance, Base = 1000000.0 },
                    new Unit() { Name = UnitName.TeraOhm, Symbol="TOhm", Family = UnitFamily.Resistance, Base = 1000000000.0 },
                    // Length
                    new Unit() { Name = UnitName.milimetre, Symbol = "mm", Family = UnitFamily.Length, Base = 0.001 },
                    new Unit() { Name = UnitName.centimetre, Symbol = "cm", Family = UnitFamily.Length, Base = 0.01 },
                    new Unit() { Name = UnitName.metre, Symbol = "m", Family = UnitFamily.Length, Base = 1.0 },
                    new Unit() { Name = UnitName.kilometre, Symbol = "km", Family = UnitFamily.Length, Base = 1000.0 },
                    new Unit() { Name = UnitName.inch, Symbol = "in", Family = UnitFamily.Length, Base = 0.0254 },
                    new Unit() { Name = UnitName.foot, Symbol = "ft", Family = UnitFamily.Length, Base = 0.3048 },
                    new Unit() { Name = UnitName.yard, Symbol = "yd", Family = UnitFamily.Length, Base = 0.9144 },
                    new Unit() { Name = UnitName.mile, Symbol = "mi", Family = UnitFamily.Length, Base = 1609.34 },
                    // Time
                    new Unit() { Name = UnitName.milisecond, Symbol = "ms", Family = UnitFamily.Time, Base = 0.001 },
                    new Unit() { Name = UnitName.second, Symbol = "sec", Family = UnitFamily.Time, Base = 1.0 },
                    new Unit() { Name = UnitName.minute, Symbol = "min", Family = UnitFamily.Time, Base = 60.0 },
                    new Unit() { Name = UnitName.hour, Symbol = "hr", Family = UnitFamily.Time, Base = 3600.0 },
                    new Unit() { Name = UnitName.day, Symbol = "day", Family = UnitFamily.Time, Base = 86400.0 },
                    new Unit() { Name = UnitName.week, Symbol = "wk", Family = UnitFamily.Time, Base = 604800.0 },
                    new Unit() { Name = UnitName.month, Symbol = "mth", Family = UnitFamily.Time, Base = 2628000.0 },
                    new Unit() { Name = UnitName.year, Symbol = "yr", Family = UnitFamily.Time, Base = 31536000.0 },
                    // Volume
                    new Unit() { Name = UnitName.mililitre, Symbol = "ml", Family = UnitFamily.Volume, Base = 0.001 },
                    new Unit() { Name = UnitName.litre, Symbol = "l", Family = UnitFamily.Volume, Base = 1.0 },
                    new Unit() { Name = UnitName.ounce_US, Symbol = "oz(US)", Family = UnitFamily.Volume, Base = 0.0295735 },
                    new Unit() { Name = UnitName.pint_US, Symbol = "pt(US)", Family = UnitFamily.Volume, Base = 0.473176 },
                    new Unit() { Name = UnitName.quart_US, Symbol = "qt(US)", Family = UnitFamily.Volume, Base = 0.946353 },
                    new Unit() { Name = UnitName.Gallon_US, Symbol = "gal(US)", Family = UnitFamily.Volume, Base = 3.78541 },
                    new Unit() { Name = UnitName.ounce_UK, Symbol = "oz(UK)", Family = UnitFamily.Volume, Base = 0.0284131 },
                    new Unit() { Name = UnitName.pint_UK, Symbol = "pt(UK)", Family = UnitFamily.Volume, Base = 0.568261 },
                    new Unit() { Name = UnitName.quart_UK, Symbol = "qt(UK)", Family = UnitFamily.Volume, Base = 1.13652 },
                    new Unit() { Name = UnitName.Gallon_UK, Symbol = "gal(UK)", Family = UnitFamily.Volume, Base = 4.54608785742778 },
                    new Unit() { Name = UnitName.cubic_metre, Symbol = "m^3", Family = UnitFamily.Volume, Base = 1000.0 },
                    new Unit() { Name = UnitName.cubic_foot, Symbol = "ft^3", Family = UnitFamily.Volume, Base = 28.3167843034326 },
                    new Unit() { Name = UnitName.cubic_inch, Symbol = "in^3", Family = UnitFamily.Volume, Base = 0.016387027953375346 },
                    // Area
                    new Unit() { Name = UnitName.square_inch, Symbol = "in^2", Family = UnitFamily.Area, Base = 0.00064516 },
                    new Unit() { Name = UnitName.square_foot, Symbol = "ft^2", Family = UnitFamily.Area, Base = 0.092903 },
                    new Unit() { Name = UnitName.square_yard, Symbol = "yd^2", Family = UnitFamily.Area, Base = 0.836127 },
                    new Unit() { Name = UnitName.square_metre, Symbol = "m^2", Family = UnitFamily.Area, Base = 1.0 },
                    new Unit() { Name = UnitName.square_kilometre, Symbol = "km^2", Family = UnitFamily.Area, Base = 1000000.0 },
                    new Unit() { Name = UnitName.square_mile, Symbol = "mi^2", Family = UnitFamily.Area, Base = 2590000.0 },
                    new Unit() { Name = UnitName.Hectare, Symbol = "H", Family = UnitFamily.Area, Base = 10000.0 },
                    new Unit() { Name = UnitName.Acre, Symbol = "Ac", Family = UnitFamily.Area, Base = 4046.86 },
                    // Speed
                    new Unit() { Name = UnitName.kilometre_per_hour, Symbol = "km/h", Family = UnitFamily.Speed, Base = 1.0 },
                    new Unit() { Name = UnitName.foot_per_second, Symbol = "ft/s", Family = UnitFamily.Speed, Base = 1.09728 },
                    new Unit() { Name = UnitName.mile_per_hour, Symbol = "mph", Family = UnitFamily.Speed, Base = 1.60934 },
                    new Unit() { Name = UnitName.Knot, Symbol = "Kt", Family = UnitFamily.Speed, Base = 1.852 },
                    new Unit() { Name = UnitName.metre_per_second, Symbol = "m/s", Family = UnitFamily.Speed, Base = 3.6 },
                    // Temperature
                    new Unit() { Name = UnitName.Degree_Celsius, Symbol = "oC", Family = UnitFamily.Temperature, Base = 1.0 },
                    new Unit() { Name = UnitName.Degree_Farenheit, Symbol = "oF", Family = UnitFamily.Temperature, Base = 1.0 },
                    new Unit() { Name = UnitName.Degree_Kelvin, Symbol = "K", Family = UnitFamily.Temperature, Base = 1.0 },
                    // Pressure
                    new Unit() { Name = UnitName.Pascal, Symbol = "Pa", Family = UnitFamily.Pressure, Base = 1.0 },
                    new Unit() { Name = UnitName.Bar, Symbol = "bar", Family = UnitFamily.Pressure, Base = 100000.0 },
                    new Unit() { Name = UnitName.Atmosphere, Symbol = "atm", Family = UnitFamily.Pressure, Base = 101325.0 },
                    new Unit() { Name = UnitName.Pounds_per_Square_inch, Symbol = "psi", Family = UnitFamily.Pressure, Base = 6894.76 },
                    new Unit() { Name = UnitName.Torr, Symbol = "torr", Family = UnitFamily.Pressure, Base = 133.322 },
                    // Mass
                    new Unit() { Name = UnitName.miligram, Symbol = "mg", Family = UnitFamily.Mass, Base = 0.000001 },
                    new Unit() { Name = UnitName.gram, Symbol = "g", Family = UnitFamily.Mass, Base = 0.001 },
                    new Unit() { Name = UnitName.kilogram, Symbol = "kg", Family = UnitFamily.Mass, Base = 1.0 },
                    new Unit() { Name = UnitName.Tonne, Symbol = "tonne", Family = UnitFamily.Mass, Base = 1000.0 },
                    new Unit() { Name = UnitName.Ton_UK, Symbol = "ton(UK)", Family = UnitFamily.Mass, Base = 1016.05 },
                    new Unit() { Name = UnitName.Ton_US, Symbol = "ton(US)", Family = UnitFamily.Mass, Base = 907.185 },
                    new Unit() { Name = UnitName.Stone, Symbol = "st", Family = UnitFamily.Mass, Base = 6.35029 },
                    new Unit() { Name = UnitName.Pound, Symbol = "lb", Family = UnitFamily.Mass, Base = 0.452592 },
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

            // Temperature conversion formulas
            if(fromUnit.Family == UnitFamily.Temperature)
            {
                if(fromUnit == toUnit)
                {
                    return value;
                }
                else if (fromUnit.Name == UnitName.Degree_Farenheit && toUnit.Name == UnitName.Degree_Celsius)
                {
                    return (value - 32.0) * (5/9);
                } 
                else if (fromUnit.Name == UnitName.Degree_Celsius && toUnit.Name == UnitName.Degree_Farenheit)
                {
                    return (value - 32.0) / (1.8);
                }
                else if (fromUnit.Name == UnitName.Degree_Kelvin && toUnit.Name == UnitName.Degree_Celsius)
                {
                    return value - 273.15;
                }
                else if (fromUnit.Name == UnitName.Degree_Celsius && toUnit.Name == UnitName.Degree_Kelvin)
                {
                    return value + 273.15;
                }
                else if (fromUnit.Name == UnitName.Degree_Kelvin && toUnit.Name == UnitName.Degree_Farenheit)
                {
                    return value.Convert(UnitName.Degree_Kelvin, UnitName.Degree_Celsius).Convert(UnitName.Degree_Celsius,UnitName.Degree_Farenheit);
                }
                else if (fromUnit.Name == UnitName.Degree_Farenheit && toUnit.Name == UnitName.Degree_Kelvin)
                {
                    return value.Convert(UnitName.Degree_Farenheit, UnitName.Degree_Celsius).Convert(UnitName.Degree_Celsius,UnitName.Degree_Kelvin);
                }
            }

            // Default conversion
            return value * (fromUnit.Base / toUnit.Base);
        }

        public static double ToPerUnit(double value, double baseValue)
        {
            if (baseValue == 0) throw new Exception("The base value cannot be zero.");

            return value / baseValue;
        }
    }
}