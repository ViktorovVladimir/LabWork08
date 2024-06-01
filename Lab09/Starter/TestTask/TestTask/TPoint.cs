using System;

public class TPoint
{
    private double x, y;

    //--.
    public TPoint() { }
    //--.
    public TPoint(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    //--.
    public double getX()
    {
        return x;
    }

    //--.
    public double getY()
    {
        return y;
    }

    //--.
    public double Distance(TPoint p)
    {
        return Math.Sqrt(Math.Pow(x - p.x, 2) + Math.Pow(y - p.y, 2));
    }
}