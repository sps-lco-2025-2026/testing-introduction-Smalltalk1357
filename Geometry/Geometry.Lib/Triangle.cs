namespace Geometry.Lib;

public class Triangle
{
    private int _angleA;
    private int _angleB;
    private int _angleC;
    private int _lengthA;
    private int _lengthB;
    private int _lengthC;
    private string _name;

    public Triangle()
    {
        // Angle A is opposite length A e.t.c.
        
        _name = "Triangle";
        _angleA = 60;
        _angleB = 60;
        _angleC = 60;
        _lengthA = 10;
        _lengthB = 10;
        _lengthC = 10;
    }

    private bool IsValid()
    {
        int intAngles = _angleA + _angleB + _angleC;
        if (intAngles > 180 || intAngles < 0) return false;
        
        if (_lengthA <= 0 || _lengthB <= 0 || _lengthC <= 0) return false;
        
        double sineRuleA = Math.Sin(_angleA) / _lengthA;
        double sineRuleB = Math.Sin(_angleB) / _lengthB;
        double sineRuleC = Math.Sin(_angleC) / _lengthC;

        if (sineRuleA != sineRuleB || sineRuleB != sineRuleC) return false;
        
        return true;
    }

    public bool IsRightAngled()
    {
        if (!IsValid()) return false;
        return _angleA == 90 || _angleB == 90 || _angleC == 90;
    }

    public bool IsEquilateral()
    {
        if (!IsValid()) return false;
        return _angleA == _angleB && _angleB == _angleC;
    }

    public bool IsIsosceles()
    {
        if (!IsValid()) return false;
        if (_angleA == _angleB || _lengthA == _lengthB) return true;
        if (_angleB == _angleC || _lengthB == _lengthC) return true;
        if (_angleA == _angleC || _lengthA == _lengthC) return true;
        return false;
    }

    public double Area()
    {
        if (!IsValid()) return 0;
        return 0.5 * _lengthA * _lengthB * Math.Sin(_angleC);
    }
    
    public override string ToString()
    {
        return _name;
    }
}