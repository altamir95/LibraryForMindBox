using System.Collections.Generic;
using System.Linq;

namespace LibraryForMindBox
{
    public abstract class Figure<T>
    {
        private List<T> _clientMeasurements;
        public List<T> ClientMeasurments
        {
            set
            {
                _clientMeasurements = value.ToList();
            }
            get
            {
                return _clientMeasurements;
            }
        }
        public T FigureArea
        {
            get { return CalculatesFigureArea(); }
        }
        public abstract T CalculatesFigureArea();
    }
}
