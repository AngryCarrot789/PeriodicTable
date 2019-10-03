using System;

namespace PeriodicTable.Units.Units
{
    public class Temprature : IComparable, IComparable<Temprature>, IEquatable<Temprature>, IConvertible
    {
        public const double MaxValue = 4294967295;
        public const double MinValue = 0;
        private double Value;

        public TempratureUnits Units { get; set; }

        #region Implicity Operators

        public static implicit operator double(Temprature value) => value.Value;
        public static explicit operator int(Temprature value) => Convert.ToInt32(value.Value);

        public static implicit operator Temprature(int v)
        {
            return new Temprature(Convert.ToUInt32(v));
        }
        public static implicit operator Temprature(double v)
        {
            return new Temprature(v);
        }

        #endregion

        #region Constructor
        public Temprature(double value)
        {
            Units = TempratureUnits.Celsius;
            Value = value;
        }

        public Temprature(double value, TempratureUnits unit)
        {
            Units = unit;
            Value = value;
        }

        #endregion

        #region others
        public static double Parse(Temprature value)
        {
            return value.Value;
        }

        #endregion

        #region IComparable

        public int CompareTo(Temprature value)
        {
            if (value == null)
                return 1;
            if (value is Temprature)
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

        public bool Equals(Temprature other)
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
                case TempratureUnits.Celsius: return Value + "°C";
                case TempratureUnits.Kelvin: return Value + " Kelvin";
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
