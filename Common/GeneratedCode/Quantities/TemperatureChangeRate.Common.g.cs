﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.InternalHelpers;
using UnitsNet.Units;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     Temperature change rate is the ratio of the temperature change to the time during which the change occurred (value of temperature changes per unit time).
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
#if WINDOWS_UWP
    public sealed partial class TemperatureChangeRate : IQuantity
#else
    public partial struct TemperatureChangeRate : IQuantity, IComparable, IComparable<TemperatureChangeRate>
#endif
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly TemperatureChangeRateUnit? _unit;

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public TemperatureChangeRateUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        static TemperatureChangeRate()
        {
            BaseDimensions = new BaseDimensions(0, 0, -1, 0, 1, 0, 0);
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="numericValue">The numeric value  to contruct this quantity with.</param>
        /// <param name="unit">The unit representation to contruct this quantity with.</param>
        /// <remarks>Value parameter cannot be named 'value' due to constraint when targeting Windows Runtime Component.</remarks>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        private
#else
        public
#endif
        TemperatureChangeRate(double numericValue, TemperatureChangeRateUnit unit)
        {
            if(unit == TemperatureChangeRateUnit.Undefined)
              throw new ArgumentException("The quantity can not be created with an undefined unit.", nameof(unit));

            _value = Guard.EnsureValidNumber(numericValue, nameof(numericValue));
            _unit = unit;
        }

        #region Properties

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType => QuantityType.TemperatureChangeRate;

        /// <summary>
        ///     The base unit of TemperatureChangeRate, which is DegreeCelsiusPerSecond. All conversions go via this value.
        /// </summary>
        public static TemperatureChangeRateUnit BaseUnit => TemperatureChangeRateUnit.DegreeCelsiusPerSecond;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions
        {
            get;
        }

        /// <summary>
        ///     All units of measurement for the TemperatureChangeRate quantity.
        /// </summary>
        public static TemperatureChangeRateUnit[] Units { get; } = Enum.GetValues(typeof(TemperatureChangeRateUnit)).Cast<TemperatureChangeRateUnit>().Except(new TemperatureChangeRateUnit[]{ TemperatureChangeRateUnit.Undefined }).ToArray();

        /// <summary>
        ///     Get TemperatureChangeRate in CentidegreesCelsiusPerSecond.
        /// </summary>
        public double CentidegreesCelsiusPerSecond => As(TemperatureChangeRateUnit.CentidegreeCelsiusPerSecond);

        /// <summary>
        ///     Get TemperatureChangeRate in DecadegreesCelsiusPerSecond.
        /// </summary>
        public double DecadegreesCelsiusPerSecond => As(TemperatureChangeRateUnit.DecadegreeCelsiusPerSecond);

        /// <summary>
        ///     Get TemperatureChangeRate in DecidegreesCelsiusPerSecond.
        /// </summary>
        public double DecidegreesCelsiusPerSecond => As(TemperatureChangeRateUnit.DecidegreeCelsiusPerSecond);

        /// <summary>
        ///     Get TemperatureChangeRate in DegreesCelsiusPerMinute.
        /// </summary>
        public double DegreesCelsiusPerMinute => As(TemperatureChangeRateUnit.DegreeCelsiusPerMinute);

        /// <summary>
        ///     Get TemperatureChangeRate in DegreesCelsiusPerSecond.
        /// </summary>
        public double DegreesCelsiusPerSecond => As(TemperatureChangeRateUnit.DegreeCelsiusPerSecond);

        /// <summary>
        ///     Get TemperatureChangeRate in HectodegreesCelsiusPerSecond.
        /// </summary>
        public double HectodegreesCelsiusPerSecond => As(TemperatureChangeRateUnit.HectodegreeCelsiusPerSecond);

        /// <summary>
        ///     Get TemperatureChangeRate in KilodegreesCelsiusPerSecond.
        /// </summary>
        public double KilodegreesCelsiusPerSecond => As(TemperatureChangeRateUnit.KilodegreeCelsiusPerSecond);

        /// <summary>
        ///     Get TemperatureChangeRate in MicrodegreesCelsiusPerSecond.
        /// </summary>
        public double MicrodegreesCelsiusPerSecond => As(TemperatureChangeRateUnit.MicrodegreeCelsiusPerSecond);

        /// <summary>
        ///     Get TemperatureChangeRate in MillidegreesCelsiusPerSecond.
        /// </summary>
        public double MillidegreesCelsiusPerSecond => As(TemperatureChangeRateUnit.MillidegreeCelsiusPerSecond);

        /// <summary>
        ///     Get TemperatureChangeRate in NanodegreesCelsiusPerSecond.
        /// </summary>
        public double NanodegreesCelsiusPerSecond => As(TemperatureChangeRateUnit.NanodegreeCelsiusPerSecond);

        #endregion

        #region Static

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit DegreeCelsiusPerSecond.
        /// </summary>
        public static TemperatureChangeRate Zero => new TemperatureChangeRate(0, BaseUnit);

        /// <summary>
        ///     Get TemperatureChangeRate from CentidegreesCelsiusPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static TemperatureChangeRate FromCentidegreesCelsiusPerSecond(double centidegreescelsiuspersecond)
#else
        public static TemperatureChangeRate FromCentidegreesCelsiusPerSecond(QuantityValue centidegreescelsiuspersecond)
#endif
        {
            double value = (double) centidegreescelsiuspersecond;
            return new TemperatureChangeRate(value, TemperatureChangeRateUnit.CentidegreeCelsiusPerSecond);
        }

        /// <summary>
        ///     Get TemperatureChangeRate from DecadegreesCelsiusPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static TemperatureChangeRate FromDecadegreesCelsiusPerSecond(double decadegreescelsiuspersecond)
#else
        public static TemperatureChangeRate FromDecadegreesCelsiusPerSecond(QuantityValue decadegreescelsiuspersecond)
#endif
        {
            double value = (double) decadegreescelsiuspersecond;
            return new TemperatureChangeRate(value, TemperatureChangeRateUnit.DecadegreeCelsiusPerSecond);
        }

        /// <summary>
        ///     Get TemperatureChangeRate from DecidegreesCelsiusPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static TemperatureChangeRate FromDecidegreesCelsiusPerSecond(double decidegreescelsiuspersecond)
#else
        public static TemperatureChangeRate FromDecidegreesCelsiusPerSecond(QuantityValue decidegreescelsiuspersecond)
#endif
        {
            double value = (double) decidegreescelsiuspersecond;
            return new TemperatureChangeRate(value, TemperatureChangeRateUnit.DecidegreeCelsiusPerSecond);
        }

        /// <summary>
        ///     Get TemperatureChangeRate from DegreesCelsiusPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static TemperatureChangeRate FromDegreesCelsiusPerMinute(double degreescelsiusperminute)
#else
        public static TemperatureChangeRate FromDegreesCelsiusPerMinute(QuantityValue degreescelsiusperminute)
#endif
        {
            double value = (double) degreescelsiusperminute;
            return new TemperatureChangeRate(value, TemperatureChangeRateUnit.DegreeCelsiusPerMinute);
        }

        /// <summary>
        ///     Get TemperatureChangeRate from DegreesCelsiusPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static TemperatureChangeRate FromDegreesCelsiusPerSecond(double degreescelsiuspersecond)
#else
        public static TemperatureChangeRate FromDegreesCelsiusPerSecond(QuantityValue degreescelsiuspersecond)
#endif
        {
            double value = (double) degreescelsiuspersecond;
            return new TemperatureChangeRate(value, TemperatureChangeRateUnit.DegreeCelsiusPerSecond);
        }

        /// <summary>
        ///     Get TemperatureChangeRate from HectodegreesCelsiusPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static TemperatureChangeRate FromHectodegreesCelsiusPerSecond(double hectodegreescelsiuspersecond)
#else
        public static TemperatureChangeRate FromHectodegreesCelsiusPerSecond(QuantityValue hectodegreescelsiuspersecond)
#endif
        {
            double value = (double) hectodegreescelsiuspersecond;
            return new TemperatureChangeRate(value, TemperatureChangeRateUnit.HectodegreeCelsiusPerSecond);
        }

        /// <summary>
        ///     Get TemperatureChangeRate from KilodegreesCelsiusPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static TemperatureChangeRate FromKilodegreesCelsiusPerSecond(double kilodegreescelsiuspersecond)
#else
        public static TemperatureChangeRate FromKilodegreesCelsiusPerSecond(QuantityValue kilodegreescelsiuspersecond)
#endif
        {
            double value = (double) kilodegreescelsiuspersecond;
            return new TemperatureChangeRate(value, TemperatureChangeRateUnit.KilodegreeCelsiusPerSecond);
        }

        /// <summary>
        ///     Get TemperatureChangeRate from MicrodegreesCelsiusPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static TemperatureChangeRate FromMicrodegreesCelsiusPerSecond(double microdegreescelsiuspersecond)
#else
        public static TemperatureChangeRate FromMicrodegreesCelsiusPerSecond(QuantityValue microdegreescelsiuspersecond)
#endif
        {
            double value = (double) microdegreescelsiuspersecond;
            return new TemperatureChangeRate(value, TemperatureChangeRateUnit.MicrodegreeCelsiusPerSecond);
        }

        /// <summary>
        ///     Get TemperatureChangeRate from MillidegreesCelsiusPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static TemperatureChangeRate FromMillidegreesCelsiusPerSecond(double millidegreescelsiuspersecond)
#else
        public static TemperatureChangeRate FromMillidegreesCelsiusPerSecond(QuantityValue millidegreescelsiuspersecond)
#endif
        {
            double value = (double) millidegreescelsiuspersecond;
            return new TemperatureChangeRate(value, TemperatureChangeRateUnit.MillidegreeCelsiusPerSecond);
        }

        /// <summary>
        ///     Get TemperatureChangeRate from NanodegreesCelsiusPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static TemperatureChangeRate FromNanodegreesCelsiusPerSecond(double nanodegreescelsiuspersecond)
#else
        public static TemperatureChangeRate FromNanodegreesCelsiusPerSecond(QuantityValue nanodegreescelsiuspersecond)
#endif
        {
            double value = (double) nanodegreescelsiuspersecond;
            return new TemperatureChangeRate(value, TemperatureChangeRateUnit.NanodegreeCelsiusPerSecond);
        }


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="TemperatureChangeRateUnit" /> to <see cref="TemperatureChangeRate" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>TemperatureChangeRate unit value.</returns>
#if WINDOWS_UWP
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static TemperatureChangeRate From(double value, TemperatureChangeRateUnit fromUnit)
#else
        public static TemperatureChangeRate From(QuantityValue value, TemperatureChangeRateUnit fromUnit)
#endif
        {
            return new TemperatureChangeRate((double)value, fromUnit);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(TemperatureChangeRateUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            if(!(obj is TemperatureChangeRate)) throw new ArgumentException("Expected type TemperatureChangeRate.", nameof(obj));

            return CompareTo((TemperatureChangeRate)obj);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        int CompareTo(TemperatureChangeRate other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another TemperatureChangeRate within the given absolute or relative tolerance.
        ///     </para>
        ///     <para>
        ///     Relative tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a percentage of this quantity's value. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison. A relative tolerance of 0.01 means the absolute difference must be within +/- 1% of
        ///     this quantity's value to be considered equal.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within +/- 1% of a (0.02m or 2cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Relative);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Absolute tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a fixed number in this quantity's unit. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within 0.01 of a (0.01m or 1cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Absolute);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        ///     </para>
        /// </summary>
        /// <param name="other">The other quantity to compare to.</param>
        /// <param name="tolerance">The absolute or relative tolerance value. Must be greater than or equal to 0.</param>
        /// <param name="comparisonType">The comparison type: either relative or absolute.</param>
        /// <returns>True if the absolute difference between the two values is not greater than the specified relative or absolute tolerance.</returns>
        public bool Equals(TemperatureChangeRate other, double tolerance, ComparisonType comparisonType)
        {
            if(tolerance < 0)
                throw new ArgumentOutOfRangeException("tolerance", "Tolerance must be greater than or equal to 0.");

            double thisValue = (double)this.Value;
            double otherValueInThisUnits = other.As(this.Unit);

            return UnitsNet.Comparison.Equals(thisValue, otherValueInThisUnits, tolerance, comparisonType);
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current TemperatureChangeRate.</returns>
        public override int GetHashCode()
        {
            return new { Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(TemperatureChangeRateUnit unit)
        {
            if(Unit == unit)
                return Convert.ToDouble(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDouble(converted);
        }

        /// <summary>
        ///     Converts this TemperatureChangeRate to another TemperatureChangeRate with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A TemperatureChangeRate with the specified unit.</returns>
        public TemperatureChangeRate ToUnit(TemperatureChangeRateUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new TemperatureChangeRate(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double AsBaseUnit()
        {
            switch(Unit)
            {
                case TemperatureChangeRateUnit.CentidegreeCelsiusPerSecond: return (_value) * 1e-2d;
                case TemperatureChangeRateUnit.DecadegreeCelsiusPerSecond: return (_value) * 1e1d;
                case TemperatureChangeRateUnit.DecidegreeCelsiusPerSecond: return (_value) * 1e-1d;
                case TemperatureChangeRateUnit.DegreeCelsiusPerMinute: return _value/60;
                case TemperatureChangeRateUnit.DegreeCelsiusPerSecond: return _value;
                case TemperatureChangeRateUnit.HectodegreeCelsiusPerSecond: return (_value) * 1e2d;
                case TemperatureChangeRateUnit.KilodegreeCelsiusPerSecond: return (_value) * 1e3d;
                case TemperatureChangeRateUnit.MicrodegreeCelsiusPerSecond: return (_value) * 1e-6d;
                case TemperatureChangeRateUnit.MillidegreeCelsiusPerSecond: return (_value) * 1e-3d;
                case TemperatureChangeRateUnit.NanodegreeCelsiusPerSecond: return (_value) * 1e-9d;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double AsBaseNumericType(TemperatureChangeRateUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
                case TemperatureChangeRateUnit.CentidegreeCelsiusPerSecond: return (baseUnitValue) / 1e-2d;
                case TemperatureChangeRateUnit.DecadegreeCelsiusPerSecond: return (baseUnitValue) / 1e1d;
                case TemperatureChangeRateUnit.DecidegreeCelsiusPerSecond: return (baseUnitValue) / 1e-1d;
                case TemperatureChangeRateUnit.DegreeCelsiusPerMinute: return baseUnitValue*60;
                case TemperatureChangeRateUnit.DegreeCelsiusPerSecond: return baseUnitValue;
                case TemperatureChangeRateUnit.HectodegreeCelsiusPerSecond: return (baseUnitValue) / 1e2d;
                case TemperatureChangeRateUnit.KilodegreeCelsiusPerSecond: return (baseUnitValue) / 1e3d;
                case TemperatureChangeRateUnit.MicrodegreeCelsiusPerSecond: return (baseUnitValue) / 1e-6d;
                case TemperatureChangeRateUnit.MillidegreeCelsiusPerSecond: return (baseUnitValue) / 1e-3d;
                case TemperatureChangeRateUnit.NanodegreeCelsiusPerSecond: return (baseUnitValue) / 1e-9d;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

        #region Parsing

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static TemperatureChangeRate Parse(string str)
        {
            return ParseInternal(str, null);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out TemperatureChangeRate result)
        {
            return TryParseInternal(str, null, out result);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static TemperatureChangeRateUnit ParseUnit(string str)
        {
            return ParseUnitInternal(str, null);
        }

        public static bool TryParseUnit(string str, out TemperatureChangeRateUnit unit)
        {
            return TryParseUnitInternal(str, null, out unit);
        }

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        internal static TemperatureChangeRate ParseInternal(string str, [CanBeNull] IFormatProvider provider)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));

            provider = provider ?? UnitSystem.DefaultCulture;

            return QuantityParser.Parse<TemperatureChangeRate, TemperatureChangeRateUnit>(str, provider,
                delegate(string value, string unit, IFormatProvider formatProvider2)
                {
                    var parsedValue = double.Parse(value, formatProvider2);
                    var parsedUnit = ParseUnitInternal(unit, formatProvider2);
                    return From(parsedValue, parsedUnit);
                }, (x, y) => From(x.DegreesCelsiusPerSecond + y.DegreesCelsiusPerSecond, BaseUnit));
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        internal static bool TryParseInternal([CanBeNull] string str, [CanBeNull] IFormatProvider provider, out TemperatureChangeRate result)
        {
            result = default(TemperatureChangeRate);

            if(string.IsNullOrWhiteSpace(str))
                return false;

            provider = provider ?? UnitSystem.DefaultCulture;

            return QuantityParser.TryParse<TemperatureChangeRate, TemperatureChangeRateUnit>(str, provider,
                delegate(string value, string unit, IFormatProvider formatProvider2, out TemperatureChangeRate parsedTemperatureChangeRate )
                {
                    parsedTemperatureChangeRate = default(TemperatureChangeRate);

                    if(!double.TryParse(value, NumberStyles.Any, formatProvider2, out var parsedValue))
                        return false;

                    if(!TryParseUnitInternal(unit, formatProvider2, out var parsedUnit))
                        return false;

                    parsedTemperatureChangeRate = From(parsedValue, parsedUnit);
                    return true;
                }, (x, y) => From(x.DegreesCelsiusPerSecond + y.DegreesCelsiusPerSecond, BaseUnit), out result);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        internal static TemperatureChangeRateUnit ParseUnitInternal(string str, IFormatProvider provider = null)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));

            var unitSystem = UnitSystem.GetCached(provider);
            var unit = unitSystem.Parse<TemperatureChangeRateUnit>(str.Trim());

            if (unit == TemperatureChangeRateUnit.Undefined)
            {
                var newEx = new UnitsNetException("Error parsing string. The unit is not a recognized TemperatureChangeRateUnit.");
                newEx.Data["input"] = str;
                newEx.Data["provider"] = provider?.ToString() ?? "(null)";
                throw newEx;
            }

            return unit;
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <param name="unit">The parsed unit if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        internal static bool TryParseUnitInternal(string str, IFormatProvider provider, out TemperatureChangeRateUnit unit)
        {
            unit = TemperatureChangeRateUnit.Undefined;

            if(string.IsNullOrWhiteSpace(str))
                return false;

            var unitSystem = UnitSystem.GetCached(provider);
            if(!unitSystem.TryParse<TemperatureChangeRateUnit>(str.Trim(), out unit))
                return false;

            if(unit == TemperatureChangeRateUnit.Undefined)
                return false;

            return true;
        }

        #endregion

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(Unit);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using current UI culture and two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <returns>String representation.</returns>
        public string ToString(TemperatureChangeRateUnit unit)
        {
            return ToString(unit, null, 2);
        }

        /// <summary>
        /// Represents the largest possible value of TemperatureChangeRate
        /// </summary>
        public static TemperatureChangeRate MaxValue => new TemperatureChangeRate(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of TemperatureChangeRate
        /// </summary>
        public static TemperatureChangeRate MinValue => new TemperatureChangeRate(double.MinValue, BaseUnit);

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public QuantityType Type => TemperatureChangeRate.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => TemperatureChangeRate.BaseDimensions;
    }
}
