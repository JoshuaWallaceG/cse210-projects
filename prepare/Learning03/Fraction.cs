public class Fraction
{
    private double _numerator;
    private double _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(double numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    public Fraction(double numerator, double denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public void setNumerator(double numerator)
    {
        _numerator = numerator;
    }

    public double getNumerator()
    {
        return _numerator;
    }

    public void setDenominator(double denominator)
    {
        _denominator = denominator;
    }

    public double getDenominator()
    {
        return _denominator;
    }

    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }
    public double GetDecimalValue()
    {
        return _numerator / _denominator;
    }
}