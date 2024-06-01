using System;
using System.IO.MemoryMappedFiles;


public class TTriangle
{
    TPoint p1, p2, p3;

    //--.
    public TTriangle() 
    {
    }
    public TTriangle(TPoint p1, TPoint p2, TPoint p3)
    {
        this.p1 = p1;
        this.p2 = p2;
        this.p3 = p3;
    }

    //--.
    public  (double sideLen1, double sideLen2, double sideLen3) getSedeLength()
    {
        double sideLen1 = p1.Distance(p2);
        double sideLen2 = p2.Distance(p3);
        double sideLen3 = p3.Distance(p1);

        return (sideLen1, sideLen2, sideLen3);
    }

    //--.
    public double Perimetr()
    {
        var resSlen = getSedeLength();
        return resSlen.sideLen1 + resSlen.sideLen2 + resSlen.sideLen3;
    }

    //--.
    public double Square()
    {
        var (a, b, c) = getSedeLength();

        //--. полупериметр
        double p = (a + b + c) / 2;

        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    //--.
    public bool Valid()
    {
        //--.
        var (side1Len, side2Len, side3Len) = getSedeLength();

            if ((side1Len + side2Len) <= side3Len ||
                (side2Len + side3Len) <= side1Len ||
                (side3Len + side1Len) <= side2Len)
                return false;

            return true;

    }

}