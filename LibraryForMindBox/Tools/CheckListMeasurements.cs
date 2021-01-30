using System.Collections.Generic;
namespace LibraryForMindBox.Tools
{
    internal static class CheckListMeasurements
    {
        internal static bool AreInequalityZeroOrLess(List<double> Measurements)
        {
            foreach (double m in Measurements)
            {
                if (m <= 0)
                {
                    return false;
                }
            }
            return true;
        }
        internal static bool AreReallyTriangle(List<double> Measurements)
        {
            if (Measurements.Count != 3)
            {
                return false;
            }
            double SideA = Measurements[0];
            double SideB = Measurements[1];
            double SideC = Measurements[2];
            if (SideA < SideB + SideC && SideB < SideA + SideC && SideC < SideA + SideB)
            {
                return true;
            }
            return false;
        }
    }
}
