namespace Geometry.Lib;

public class Triangle(string name, double angleA, double angleB, double angleC, double lengthA, double lengthB, double lengthC)
{
    // Angle A is opposite length A e.t.c.

    private bool IsValid()
    {
        double intAngles = angleA + angleB + angleC;
        if (intAngles is > 180 or < 0) return false;
        
        if (lengthA <= 0 || lengthB <= 0 || lengthC <= 0) return false;
        
        double sineRuleA = Math.Sin(angleA) / lengthA;
        double sineRuleB = Math.Sin(angleB) / lengthB;
        double sineRuleC = Math.Sin(angleC) / lengthC;

        return !(Math.Abs(sineRuleA - sineRuleB) > 0.001) && !(Math.Abs(sineRuleB - sineRuleC) > 0.001);
    }

    public bool IsRightAngled()
    {
        if (!IsValid()) return false;
        return Math.Abs(angleA - 90) < 0.001 || Math.Abs(angleB - 90) < 0.001 || Math.Abs(angleC - 90) < 0.001;
    }

    public bool IsEquilateral()
    {
        if (!IsValid()) return false;
        return Math.Abs(angleA - angleB) < 0.001 && Math.Abs(angleB - angleC) < 0.001;
    }

    public bool IsIsosceles()
    {
        if (!IsValid()) return false;
        if (Math.Abs(angleA - angleB) < 0.001 || Math.Abs(lengthA - lengthB) < 0.001) return true;
        if (Math.Abs(angleB - angleC) < 0.001 || Math.Abs(lengthB - lengthC) < 0.001) return true;
        if (Math.Abs(angleA - angleC) < 0.001 || Math.Abs(lengthA - lengthC) < 0.001) return true;
        return false;
    }

    public double Area()
    {
        // if (!IsValid()) return 0;
        return 0.5 * lengthA * lengthB * Math.Sin(angleC);
    }
    
    public override string ToString()
    {
        return name;
    }
}