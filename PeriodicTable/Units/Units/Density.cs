using System;

namespace PeriodicTable.Units.Units
{
    public class Density : IComparable, IComparable<Density>, IEquatable<Density>, IConvertible
    {
        public const double MaxValue = 4294967295;
        public const double MinValue = 0;
        private double Value;

        public DensityUnits Units { get; set; }

        #region Implicity Operators

        public static implicit operator double(Density value) => value.Value;
        public static explicit operator int(Density value) => Convert.ToInt32(value.Value);

        public static implicit operator Density(int v)
        {
            return new Density(Convert.ToUInt32(v));
        }
        public static implicit operator Density(double v)
        {
            return new Density(v);
        }

        #endregion

        #region Constructor
        public Density(double value)
        {
            Units = DensityUnits.GramPerCM3;
            Value = value;
        }

        public Density(double value, DensityUnits unit)
        {
            Units = unit;
            Value = value;
        }
        #endregion

        #region others
        public static double Parse(Density value)
        {
            return value.Value;
        }

        #endregion

        #region IComparable

        public int CompareTo(Density value)
        {
            if (value == null)
                return 1;
            if (value is Density)
            {
                double i = (double)value;
                if (Value < i) return -1;
                if (Value > i) return 1;
                return 0;
            }
            throw new ArgumentException("Arg must be Mass");
        }

        public int CompareTo(object obj)
        {
            if (Equals(obj))
                return 1;
            else return 0;
        }

        #endregion

        #region Override
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public bool Equals(Density other)
        {
            return base.Equals(other);
        }

        public override int GetHashCode()
        {
            return Convert.ToInt32(Value);
        }
        public override string ToString()
        {
            switch (Units)
            {
                case DensityUnits.GramPerCM3: return Value + "g/cm3";
                case DensityUnits.KilogramPerM3: return Value + "kg/m3";
            }
            return Value.ToString();
        }

        #endregion

        #region IConvertible

        public TypeCode GetTypeCode()
        {
            return TypeCode.UInt32;
        }

        public bool ToBoolean(IFormatProvider provider)
        {
            if (Value == 0)
                return false;
            else return true;
        }

        public char ToChar(IFormatProvider provider)
        {
            return (char)Value;
        }

        public sbyte ToSByte(IFormatProvider provider)
        {
            return (sbyte)Value;
        }

        public byte ToByte(IFormatProvider provider)
        {
            return (byte)Value;
        }

        public short ToInt16(IFormatProvider provider)
        {
            return (short)Value;
        }

        public ushort ToUInt16(IFormatProvider provider)
        {
            return (ushort)Value;
        }

        public int ToInt32(IFormatProvider provider)
        {
            return (int)Value;
        }

        public double ToUInt32(IFormatProvider provider)
        {
            return Value;
        }

        public long ToInt64(IFormatProvider provider)
        {
            return (long)Value;
        }

        public ulong ToUInt64(IFormatProvider provider)
        {
            return (ulong)Value;
        }

        public float ToSingle(IFormatProvider provider)
        {
            return (float)Value;
        }

        public double ToDouble(IFormatProvider provider)
        {
            return (double)Value;
        }

        public decimal ToDecimal(IFormatProvider provider)
        {
            return (decimal)Value;
        }

        public DateTime ToDateTime(IFormatProvider provider)
        {
            return new DateTime();
        }

        public string ToString(IFormatProvider provider)
        {
            return base.ToString();
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            return base.GetType();
        }

        uint IConvertible.ToUInt32(IFormatProvider provider)
        {
            return (uint)Value;
        }

        #endregion
    }
}
