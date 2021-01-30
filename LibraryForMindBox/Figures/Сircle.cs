using LibraryForMindBox.Tools;
using System.Collections.Generic;

namespace LibraryForMindBox.Figures
{
    public class Сircle : Figure<double>
    {
        public Сircle(dynamic radius)
        {
            ClientMeasurments = new List<double>() { (double)radius };
        }
        public override double CalculatesFigureArea()
        {
            if (!CheckListMeasurements.AreInequalityZeroOrLess(ClientMeasurments)) { return double.NaN; }
            return UseFormula.AreaByCircleRadius(ClientMeasurments[0]);
        }
    }
}
