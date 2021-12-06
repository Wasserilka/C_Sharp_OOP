namespace Урок_5
{
    internal class RationalNumber
    {
        public int Numerator;
        public int Fraction;

        public RationalNumber(int Numerator, int Fraction)
        {
            this.Numerator = Numerator;
            this.Fraction = Fraction;
        }

        public static bool operator ==(RationalNumber RationalNumber1, RationalNumber RationalNumber2) => RationalNumber1.Numerator == RationalNumber2.Numerator && RationalNumber1.Fraction == RationalNumber2.Fraction;
        public static bool operator !=(RationalNumber RationalNumber1, RationalNumber RationalNumber2) => !(RationalNumber1 == RationalNumber2);

        public static bool operator >(RationalNumber RationalNumber1, RationalNumber RationalNumber2) => 
            (RationalNumber1.Numerator > RationalNumber2.Numerator && RationalNumber1.Fraction == RationalNumber2.Fraction)
            || (RationalNumber1.Numerator >= RationalNumber2.Numerator && RationalNumber1.Fraction < RationalNumber2.Fraction)
            || (RationalNumber1.Numerator * RationalNumber2.Fraction > RationalNumber2.Numerator * RationalNumber1.Fraction && RationalNumber1.Fraction > RationalNumber2.Fraction);
        public static bool operator <(RationalNumber RationalNumber1, RationalNumber RationalNumber2) => !(RationalNumber1 > RationalNumber2);

        public static bool operator >=(RationalNumber RationalNumber1, RationalNumber RationalNumber2) =>
            (RationalNumber1.Numerator >= RationalNumber2.Numerator && RationalNumber1.Fraction <= RationalNumber2.Fraction)
            || (RationalNumber1.Numerator * RationalNumber2.Fraction > RationalNumber2.Numerator * RationalNumber1.Fraction && RationalNumber1.Fraction > RationalNumber2.Fraction);
        public static bool operator <=(RationalNumber RationalNumber1, RationalNumber RationalNumber2) => 
            (RationalNumber1.Numerator <= RationalNumber2.Numerator && RationalNumber1.Fraction <= RationalNumber2.Fraction)
            || (RationalNumber1.Numerator * RationalNumber2.Fraction < RationalNumber2.Numerator * RationalNumber1.Fraction && RationalNumber1.Fraction > RationalNumber2.Fraction);

        public static RationalNumber operator +(RationalNumber RationalNumber1, RationalNumber RationalNumber2) => 
            new (RationalNumber1.Numerator * RationalNumber2.Fraction + RationalNumber2.Numerator * RationalNumber1.Fraction, RationalNumber1.Fraction * RationalNumber2.Fraction);
        public static RationalNumber operator -(RationalNumber RationalNumber1, RationalNumber RationalNumber2) => 
            new (RationalNumber1.Numerator * RationalNumber2.Fraction - RationalNumber2.Numerator * RationalNumber1.Fraction, RationalNumber1.Fraction * RationalNumber2.Fraction);

        public static RationalNumber operator ++(RationalNumber RationalNumber) => new(RationalNumber.Numerator + RationalNumber.Fraction , RationalNumber.Fraction);
        public static RationalNumber operator --(RationalNumber RationalNumber) => new(RationalNumber.Numerator - RationalNumber.Fraction, RationalNumber.Fraction);

        public static explicit operator float(RationalNumber RationalNumber) => (float)RationalNumber.Numerator / RationalNumber.Fraction;
        public static explicit operator int(RationalNumber RationalNumber) => RationalNumber.Numerator / RationalNumber.Fraction;
        public override string ToString() => $"{Numerator}/{Fraction}";
        public override bool Equals(object obj) => base.Equals(obj);
        public override int GetHashCode() => base.GetHashCode();

        public static RationalNumber operator *(RationalNumber RationalNumber1, RationalNumber RationalNumber2) =>
            new(RationalNumber1.Numerator * RationalNumber2.Numerator, RationalNumber1.Fraction * RationalNumber2.Fraction);
        public static RationalNumber operator /(RationalNumber RationalNumber1, RationalNumber RationalNumber2) =>
            new(RationalNumber1.Numerator * RationalNumber2.Fraction, RationalNumber1.Fraction * RationalNumber2.Numerator);
        public static int operator %(RationalNumber RationalNumber1, RationalNumber RationalNumber2)
        {
            var part = RationalNumber1 / RationalNumber2;
            return part.Numerator % part.Fraction;
        }
    }
}
