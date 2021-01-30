using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryForMindBox.Tools
{
    public static class UseFormula
    {
        public static double AreaByCircleRadius(double Measurment)
        {
            double radius = Measurment;
            return Math.PI * radius * radius;
        }
        public static double Heron(double SideA, double SideB, double SideC)
        {
            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt((p * (p - SideA) * (p - SideB) * (p - SideC)));
        }
        public static bool Pythagorean(double SideA, double SideB, double SideC)
        {
            List<double> Measurments = new List<double>() { SideA, SideB, SideC }.OrderBy(measurement => measurement).ToList();
            double[] legs = { Math.Pow(Measurments[0], 2), Math.Pow(Measurments[1], 2) };
            double hypotenuse = Math.Pow(Measurments[2], 2);
            if (hypotenuse == legs[0] + legs[1]) { return true; } else { return false; }
        }
    }
}
