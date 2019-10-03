using System;

namespace PeriodicTable.Units
{
    public class Mass : IComparable, IComparable<Mass>, IEquatable<Mass>, IConvertible
    {
        public const double MaxValue = 4294967295;
        public const double MinValue = 0;
        private double Value;

        public MassUnits Units { get; set; }

        #region Implicity Operators

        public static implicit operator double(Mass value) => value.Value;
        public static explicit operator int(Mass value) => Convert.ToInt32(value.Value);

        public static implicit operator Mass(int v)
        {
            return new Mass(Convert.ToUInt32(v));
        }
        public static implicit operator Mass(double v)
        {
            return new Mass(v);
        }
        #endregion

        #region Constructor
        public Mass(double value)
        {
            Units = MassUnits.Kilogram;
            Value = value;
        }

        public Mass(double value, MassUnits unit)
        {
            Units = unit;
            Value = value;
        }

        #endregion

        #region others
        public static double Parse(Mass value)
        {
            return value.Value;
        }

        #endregion

        #region IComparable

        public int CompareTo(Mass value)
        {
            if (value == null)
                return 1;
            if (value is Mass)
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

        public bool Equals(Mass other)
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
                case MassUnits.Nanogram: return Value + "nG";
                case MassUnits.Microgram: return Value + "uG";
                case MassUnits.Milligram: return Value + "mG";
                case MassUnits.Gram: return Value + "g";
                case MassUnits.Kilogram: return Value + "kg";
                case MassUnits.Tonne: return Value + " tonnes";
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
            return Value;
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
