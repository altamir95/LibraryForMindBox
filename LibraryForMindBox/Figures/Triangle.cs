using LibraryForMindBox.Tools;
using System;
using System.Collections.Generic;

namespace LibraryForMindBox.Figures
{
    public class Triangle : Figure<double>
    {
        public Triangle(double sideA, double sideB, double sideC)
        {
            ClientMeasurments = new List<double>() { Convert.ToDouble(sideA), Convert.ToDouble(sideB), Convert.ToDouble(sideC) };
        }
        public override double CalculatesFigureArea()
        {
            if (
                !CheckListMeasurements.AreReallyTriangle(ClientMeasurments)
                || !CheckListMeasurements.AreInequalityZeroOrLess(ClientMeasurments)
                )
            {
                return double.NaN;
            }
            return UseFormula.Heron(ClientMeasurments[0], ClientMeasurments[1], ClientMeasurments[2]);
        }
        public bool IsItRightTriangle()
        {
            return UseFormula.Pythagorean(ClientMeasurments[0], ClientMeasurments[1], ClientMeasurments[2]);
        }
    }
}
