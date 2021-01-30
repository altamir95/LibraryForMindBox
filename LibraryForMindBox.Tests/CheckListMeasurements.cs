using System.Collections.Generic;
using Xunit;

namespace LibraryForMindBox.Tests
{
    public class CheckListMeasurements
    {
        [Fact]
        public void ForInequalityZeroOrLess()
        {
            // Arrange
            double SideA = 0;
            double SideB = -4;
            double SideC = 5;
            List<double> Measurements;
            bool result = true;
            // Act
            Measurements = new List<double> { SideA, SideB, SideC };
            foreach (double m in Measurements)
            {
                if (m <= 0)
                {
                    result = false;
                }
            }
            // Assert
            Assert.False(result);
        }
        [Fact]
        public void ForRealitySuchTriangle()
        {
            double SideA = 3;
            double SideB = 4;
            double SideC = 55;
            bool result;
            // Act
            if (SideA < SideB + SideC && SideB < SideA + SideC && SideC < SideA + SideB)
            {
                result = true;
            }
            result = false;
            // Assert
            Assert.False(result);
        }
    }
}
