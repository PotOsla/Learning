using System;

public class KeepHydrated
{
    public static int Litres(double time)
    {
        double Litres = 0.5;
        int litintime = (int)(Math.Floor(time) * Litres);
        return litintime;
    }
}