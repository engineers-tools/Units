# Units
If you've ever needed to use units of measure in your C# project, this repository is for you.

**Units** is a rather simple but useful library that becomes handy when your project needs to manage and convert between units.

The library includes a class definition for a Unit, two enumerations to declare Unit Names and Unit Families, a Units Table and some extension methods.

## Classes

There are a couple of ways this library can be used. Some examples are used in the *Program.cs* file. If you have *dotnet* on your system, you can run
it from the command prompt by typing:
`> dotnet run`

The *Unit* class defines the basic properties of a unit and it is designed so you can use it as a POCO in a database mapping system (i.e. Entity Framework).

The *UnitsTable* static class defines units that can be retrieved and is used for conversion operations.

Each *Unit* has a *Base* property which is used for all unit conversions. The one convention that has to be followed is that for each *Family* of units,
there has to be one, and only one, *Unit* that has a *Base* value of 1 (one). All other units in that family should have a *Base* that translates to that
*Unit*.

For example, in the *Length* family, *metre* is chosen to have a *Base* of 1. Other *Units* then should have a *Base* referenced to the *metre*,
i.e., a *kilometre* should have a *Base* of 1000.0, a *centimetre* a base of 0.01 and so on.

## Usage

The simplest way to use the conversion funciton, is to use either the static method or the extension method.
```
// Convert a unit using the static function
Console.WriteLine(UnitsTable.Convert(1.0, UnitName.mile, UnitName.kilometre));

// Convert a double variable using extension method
double myNumber = 1.536;
Console.WriteLine(myNumber.Convert(UnitName.inch,UnitName.centimetre));
```