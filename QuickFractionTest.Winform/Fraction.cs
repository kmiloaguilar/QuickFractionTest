namespace QuickFractionTest.Winform
{
    public class Fraction
    {
        public Fraction()
        {
            Numerator = 1;
            Denominator = 1;
        }

        public Fraction(decimal numerator, decimal denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public decimal Numerator { get; set; }

        public decimal Denominator { get; set; }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.Numerator*f2.Denominator + f2.Numerator*f1.Denominator, f1.Denominator*f2.Denominator);
        }
    }
}