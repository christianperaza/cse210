public class Fraction
{
    // Private variables/attributes
    private int _top;
    private int _bottom;

    // 3 Constructors
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter top
    public int GetTop()
    {
        return _top;
    }

    // Setter top
    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter bottom
    public int GetBottom()
    {
        return _bottom;
    }
    
    // Setter bottom
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Methods to print the fractions as STRING and DECIMALS
    public void GetFractionString()
    {
        Console.WriteLine($"{_top}/{_bottom}");
    }

    public void GetDecimalValue()
    {
        Console.WriteLine((double)_top / (double)_bottom);
    }

}