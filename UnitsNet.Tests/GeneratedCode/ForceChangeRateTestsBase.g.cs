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
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Linq;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of ForceChangeRate.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ForceChangeRateTestsBase
    {
        protected abstract double CentinewtonsPerSecondInOneNewtonPerSecond { get; }
        protected abstract double DecanewtonsPerMinuteInOneNewtonPerSecond { get; }
        protected abstract double DecanewtonsPerSecondInOneNewtonPerSecond { get; }
        protected abstract double DecinewtonsPerSecondInOneNewtonPerSecond { get; }
        protected abstract double KilonewtonsPerMinuteInOneNewtonPerSecond { get; }
        protected abstract double KilonewtonsPerSecondInOneNewtonPerSecond { get; }
        protected abstract double MicronewtonsPerSecondInOneNewtonPerSecond { get; }
        protected abstract double MillinewtonsPerSecondInOneNewtonPerSecond { get; }
        protected abstract double NanonewtonsPerSecondInOneNewtonPerSecond { get; }
        protected abstract double NewtonsPerMinuteInOneNewtonPerSecond { get; }
        protected abstract double NewtonsPerSecondInOneNewtonPerSecond { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CentinewtonsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double DecanewtonsPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double DecanewtonsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double DecinewtonsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double KilonewtonsPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double KilonewtonsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double MicronewtonsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double MillinewtonsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double NanonewtonsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double NewtonsPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double NewtonsPerSecondTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ForceChangeRate((double)0.0, ForceChangeRateUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ForceChangeRate(double.PositiveInfinity, ForceChangeRateUnit.NewtonPerSecond));
            Assert.Throws<ArgumentException>(() => new ForceChangeRate(double.NegativeInfinity, ForceChangeRateUnit.NewtonPerSecond));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ForceChangeRate(double.NaN, ForceChangeRateUnit.NewtonPerSecond));
        }

        [Fact]
        public void NewtonPerSecondToForceChangeRateUnits()
        {
            ForceChangeRate newtonpersecond = ForceChangeRate.FromNewtonsPerSecond(1);
            AssertEx.EqualTolerance(CentinewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.CentinewtonsPerSecond, CentinewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(DecanewtonsPerMinuteInOneNewtonPerSecond, newtonpersecond.DecanewtonsPerMinute, DecanewtonsPerMinuteTolerance);
            AssertEx.EqualTolerance(DecanewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.DecanewtonsPerSecond, DecanewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(DecinewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.DecinewtonsPerSecond, DecinewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(KilonewtonsPerMinuteInOneNewtonPerSecond, newtonpersecond.KilonewtonsPerMinute, KilonewtonsPerMinuteTolerance);
            AssertEx.EqualTolerance(KilonewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.KilonewtonsPerSecond, KilonewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(MicronewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.MicronewtonsPerSecond, MicronewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(MillinewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.MillinewtonsPerSecond, MillinewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(NanonewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.NanonewtonsPerSecond, NanonewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(NewtonsPerMinuteInOneNewtonPerSecond, newtonpersecond.NewtonsPerMinute, NewtonsPerMinuteTolerance);
            AssertEx.EqualTolerance(NewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.NewtonsPerSecond, NewtonsPerSecondTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, ForceChangeRate.From(1, ForceChangeRateUnit.CentinewtonPerSecond).CentinewtonsPerSecond, CentinewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.From(1, ForceChangeRateUnit.DecanewtonPerMinute).DecanewtonsPerMinute, DecanewtonsPerMinuteTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.From(1, ForceChangeRateUnit.DecanewtonPerSecond).DecanewtonsPerSecond, DecanewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.From(1, ForceChangeRateUnit.DecinewtonPerSecond).DecinewtonsPerSecond, DecinewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.From(1, ForceChangeRateUnit.KilonewtonPerMinute).KilonewtonsPerMinute, KilonewtonsPerMinuteTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.From(1, ForceChangeRateUnit.KilonewtonPerSecond).KilonewtonsPerSecond, KilonewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.From(1, ForceChangeRateUnit.MicronewtonPerSecond).MicronewtonsPerSecond, MicronewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.From(1, ForceChangeRateUnit.MillinewtonPerSecond).MillinewtonsPerSecond, MillinewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.From(1, ForceChangeRateUnit.NanonewtonPerSecond).NanonewtonsPerSecond, NanonewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.From(1, ForceChangeRateUnit.NewtonPerMinute).NewtonsPerMinute, NewtonsPerMinuteTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.From(1, ForceChangeRateUnit.NewtonPerSecond).NewtonsPerSecond, NewtonsPerSecondTolerance);
        }

        [Fact]
        public void FromNewtonsPerSecond_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ForceChangeRate.FromNewtonsPerSecond(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => ForceChangeRate.FromNewtonsPerSecond(double.NegativeInfinity));
        }

        [Fact]
        public void FromNewtonsPerSecond_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ForceChangeRate.FromNewtonsPerSecond(double.NaN));
        }

        [Fact]
        public void As()
        {
            var newtonpersecond = ForceChangeRate.FromNewtonsPerSecond(1);
            AssertEx.EqualTolerance(CentinewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.As(ForceChangeRateUnit.CentinewtonPerSecond), CentinewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(DecanewtonsPerMinuteInOneNewtonPerSecond, newtonpersecond.As(ForceChangeRateUnit.DecanewtonPerMinute), DecanewtonsPerMinuteTolerance);
            AssertEx.EqualTolerance(DecanewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.As(ForceChangeRateUnit.DecanewtonPerSecond), DecanewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(DecinewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.As(ForceChangeRateUnit.DecinewtonPerSecond), DecinewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(KilonewtonsPerMinuteInOneNewtonPerSecond, newtonpersecond.As(ForceChangeRateUnit.KilonewtonPerMinute), KilonewtonsPerMinuteTolerance);
            AssertEx.EqualTolerance(KilonewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.As(ForceChangeRateUnit.KilonewtonPerSecond), KilonewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(MicronewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.As(ForceChangeRateUnit.MicronewtonPerSecond), MicronewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(MillinewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.As(ForceChangeRateUnit.MillinewtonPerSecond), MillinewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(NanonewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.As(ForceChangeRateUnit.NanonewtonPerSecond), NanonewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(NewtonsPerMinuteInOneNewtonPerSecond, newtonpersecond.As(ForceChangeRateUnit.NewtonPerMinute), NewtonsPerMinuteTolerance);
            AssertEx.EqualTolerance(NewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.As(ForceChangeRateUnit.NewtonPerSecond), NewtonsPerSecondTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var newtonpersecond = ForceChangeRate.FromNewtonsPerSecond(1);

            var centinewtonpersecondQuantity = newtonpersecond.ToUnit(ForceChangeRateUnit.CentinewtonPerSecond);
            AssertEx.EqualTolerance(CentinewtonsPerSecondInOneNewtonPerSecond, (double)centinewtonpersecondQuantity.Value, CentinewtonsPerSecondTolerance);
            Assert.Equal(ForceChangeRateUnit.CentinewtonPerSecond, centinewtonpersecondQuantity.Unit);

            var decanewtonperminuteQuantity = newtonpersecond.ToUnit(ForceChangeRateUnit.DecanewtonPerMinute);
            AssertEx.EqualTolerance(DecanewtonsPerMinuteInOneNewtonPerSecond, (double)decanewtonperminuteQuantity.Value, DecanewtonsPerMinuteTolerance);
            Assert.Equal(ForceChangeRateUnit.DecanewtonPerMinute, decanewtonperminuteQuantity.Unit);

            var decanewtonpersecondQuantity = newtonpersecond.ToUnit(ForceChangeRateUnit.DecanewtonPerSecond);
            AssertEx.EqualTolerance(DecanewtonsPerSecondInOneNewtonPerSecond, (double)decanewtonpersecondQuantity.Value, DecanewtonsPerSecondTolerance);
            Assert.Equal(ForceChangeRateUnit.DecanewtonPerSecond, decanewtonpersecondQuantity.Unit);

            var decinewtonpersecondQuantity = newtonpersecond.ToUnit(ForceChangeRateUnit.DecinewtonPerSecond);
            AssertEx.EqualTolerance(DecinewtonsPerSecondInOneNewtonPerSecond, (double)decinewtonpersecondQuantity.Value, DecinewtonsPerSecondTolerance);
            Assert.Equal(ForceChangeRateUnit.DecinewtonPerSecond, decinewtonpersecondQuantity.Unit);

            var kilonewtonperminuteQuantity = newtonpersecond.ToUnit(ForceChangeRateUnit.KilonewtonPerMinute);
            AssertEx.EqualTolerance(KilonewtonsPerMinuteInOneNewtonPerSecond, (double)kilonewtonperminuteQuantity.Value, KilonewtonsPerMinuteTolerance);
            Assert.Equal(ForceChangeRateUnit.KilonewtonPerMinute, kilonewtonperminuteQuantity.Unit);

            var kilonewtonpersecondQuantity = newtonpersecond.ToUnit(ForceChangeRateUnit.KilonewtonPerSecond);
            AssertEx.EqualTolerance(KilonewtonsPerSecondInOneNewtonPerSecond, (double)kilonewtonpersecondQuantity.Value, KilonewtonsPerSecondTolerance);
            Assert.Equal(ForceChangeRateUnit.KilonewtonPerSecond, kilonewtonpersecondQuantity.Unit);

            var micronewtonpersecondQuantity = newtonpersecond.ToUnit(ForceChangeRateUnit.MicronewtonPerSecond);
            AssertEx.EqualTolerance(MicronewtonsPerSecondInOneNewtonPerSecond, (double)micronewtonpersecondQuantity.Value, MicronewtonsPerSecondTolerance);
            Assert.Equal(ForceChangeRateUnit.MicronewtonPerSecond, micronewtonpersecondQuantity.Unit);

            var millinewtonpersecondQuantity = newtonpersecond.ToUnit(ForceChangeRateUnit.MillinewtonPerSecond);
            AssertEx.EqualTolerance(MillinewtonsPerSecondInOneNewtonPerSecond, (double)millinewtonpersecondQuantity.Value, MillinewtonsPerSecondTolerance);
            Assert.Equal(ForceChangeRateUnit.MillinewtonPerSecond, millinewtonpersecondQuantity.Unit);

            var nanonewtonpersecondQuantity = newtonpersecond.ToUnit(ForceChangeRateUnit.NanonewtonPerSecond);
            AssertEx.EqualTolerance(NanonewtonsPerSecondInOneNewtonPerSecond, (double)nanonewtonpersecondQuantity.Value, NanonewtonsPerSecondTolerance);
            Assert.Equal(ForceChangeRateUnit.NanonewtonPerSecond, nanonewtonpersecondQuantity.Unit);

            var newtonperminuteQuantity = newtonpersecond.ToUnit(ForceChangeRateUnit.NewtonPerMinute);
            AssertEx.EqualTolerance(NewtonsPerMinuteInOneNewtonPerSecond, (double)newtonperminuteQuantity.Value, NewtonsPerMinuteTolerance);
            Assert.Equal(ForceChangeRateUnit.NewtonPerMinute, newtonperminuteQuantity.Unit);

            var newtonpersecondQuantity = newtonpersecond.ToUnit(ForceChangeRateUnit.NewtonPerSecond);
            AssertEx.EqualTolerance(NewtonsPerSecondInOneNewtonPerSecond, (double)newtonpersecondQuantity.Value, NewtonsPerSecondTolerance);
            Assert.Equal(ForceChangeRateUnit.NewtonPerSecond, newtonpersecondQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ForceChangeRate newtonpersecond = ForceChangeRate.FromNewtonsPerSecond(1);
            AssertEx.EqualTolerance(1, ForceChangeRate.FromCentinewtonsPerSecond(newtonpersecond.CentinewtonsPerSecond).NewtonsPerSecond, CentinewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.FromDecanewtonsPerMinute(newtonpersecond.DecanewtonsPerMinute).NewtonsPerSecond, DecanewtonsPerMinuteTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.FromDecanewtonsPerSecond(newtonpersecond.DecanewtonsPerSecond).NewtonsPerSecond, DecanewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.FromDecinewtonsPerSecond(newtonpersecond.DecinewtonsPerSecond).NewtonsPerSecond, DecinewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.FromKilonewtonsPerMinute(newtonpersecond.KilonewtonsPerMinute).NewtonsPerSecond, KilonewtonsPerMinuteTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.FromKilonewtonsPerSecond(newtonpersecond.KilonewtonsPerSecond).NewtonsPerSecond, KilonewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.FromMicronewtonsPerSecond(newtonpersecond.MicronewtonsPerSecond).NewtonsPerSecond, MicronewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.FromMillinewtonsPerSecond(newtonpersecond.MillinewtonsPerSecond).NewtonsPerSecond, MillinewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.FromNanonewtonsPerSecond(newtonpersecond.NanonewtonsPerSecond).NewtonsPerSecond, NanonewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.FromNewtonsPerMinute(newtonpersecond.NewtonsPerMinute).NewtonsPerSecond, NewtonsPerMinuteTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.FromNewtonsPerSecond(newtonpersecond.NewtonsPerSecond).NewtonsPerSecond, NewtonsPerSecondTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ForceChangeRate v = ForceChangeRate.FromNewtonsPerSecond(1);
            AssertEx.EqualTolerance(-1, -v.NewtonsPerSecond, NewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(2, (ForceChangeRate.FromNewtonsPerSecond(3)-v).NewtonsPerSecond, NewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(2, (v + v).NewtonsPerSecond, NewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(10, (v*10).NewtonsPerSecond, NewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(10, (10*v).NewtonsPerSecond, NewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(2, (ForceChangeRate.FromNewtonsPerSecond(10)/5).NewtonsPerSecond, NewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(2, ForceChangeRate.FromNewtonsPerSecond(10)/ForceChangeRate.FromNewtonsPerSecond(5), NewtonsPerSecondTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ForceChangeRate oneNewtonPerSecond = ForceChangeRate.FromNewtonsPerSecond(1);
            ForceChangeRate twoNewtonsPerSecond = ForceChangeRate.FromNewtonsPerSecond(2);

            Assert.True(oneNewtonPerSecond < twoNewtonsPerSecond);
            Assert.True(oneNewtonPerSecond <= twoNewtonsPerSecond);
            Assert.True(twoNewtonsPerSecond > oneNewtonPerSecond);
            Assert.True(twoNewtonsPerSecond >= oneNewtonPerSecond);

            Assert.False(oneNewtonPerSecond > twoNewtonsPerSecond);
            Assert.False(oneNewtonPerSecond >= twoNewtonsPerSecond);
            Assert.False(twoNewtonsPerSecond < oneNewtonPerSecond);
            Assert.False(twoNewtonsPerSecond <= oneNewtonPerSecond);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ForceChangeRate newtonpersecond = ForceChangeRate.FromNewtonsPerSecond(1);
            Assert.Equal(0, newtonpersecond.CompareTo(newtonpersecond));
            Assert.True(newtonpersecond.CompareTo(ForceChangeRate.Zero) > 0);
            Assert.True(ForceChangeRate.Zero.CompareTo(newtonpersecond) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ForceChangeRate newtonpersecond = ForceChangeRate.FromNewtonsPerSecond(1);
            Assert.Throws<ArgumentException>(() => newtonpersecond.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ForceChangeRate newtonpersecond = ForceChangeRate.FromNewtonsPerSecond(1);
            Assert.Throws<ArgumentNullException>(() => newtonpersecond.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = ForceChangeRate.FromNewtonsPerSecond(1);
            var b = ForceChangeRate.FromNewtonsPerSecond(2);

 // ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            var a = ForceChangeRate.FromNewtonsPerSecond(1);
            var b = ForceChangeRate.FromNewtonsPerSecond(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = ForceChangeRate.FromNewtonsPerSecond(1);
            Assert.True(v.Equals(ForceChangeRate.FromNewtonsPerSecond(1), NewtonsPerSecondTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ForceChangeRate.Zero, NewtonsPerSecondTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ForceChangeRate newtonpersecond = ForceChangeRate.FromNewtonsPerSecond(1);
            Assert.False(newtonpersecond.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ForceChangeRate newtonpersecond = ForceChangeRate.FromNewtonsPerSecond(1);
            Assert.False(newtonpersecond.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(ForceChangeRateUnit.Undefined, ForceChangeRate.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(ForceChangeRateUnit)).Cast<ForceChangeRateUnit>();
            foreach(var unit in units)
            {
                if(unit == ForceChangeRateUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(ForceChangeRate.BaseDimensions is null);
        }
    }
}
