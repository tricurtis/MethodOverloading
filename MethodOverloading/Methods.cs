using System;
using System.Collections.Generic;
using System.Text;

namespace MethodOverloading
{
    internal class Methods
    {
        public static int Add(int x, int y)
        {
            return x + y; }
        }


    public static double Add(double x, double y)
    {
        return x + y;
    }


    public static decimal Add(decimal x, decimal y)
    {
        return x + y;
    }
    



}
