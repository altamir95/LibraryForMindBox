using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LibraryForMindBox.Tests
{
   public class UseFormula
    {
        [Fact]
        public void AreaByCircleRadius()
        {
            // Arrange
            double radius = 6;
            double area;
            // Act
            area = Math.PI * radius * radius;
            // Assert
            Assert.True((int)area == 113);
        }
        [Fact]
        public void Heron()
        {
            // Arrange
            double SideA = 4;
            double SideB = 5;
            double SideC = 6;
            double p;
            double area;
            // Act
            p = (SideA + SideB + SideC) / 2;
            area = Math.Sqrt((p * (p - SideA) * (p - SideB) * (p - SideC)));
            // Assert
            Assert.True((int)area == 9);
        }
        [Fact]
        public void Pythagorean()
        {
            // Arrange
            double SideA = 3;
            double SideB = 4;
            double SideC = 5;
            List<double> Measurments;
            double[] legs = new double[2];
            double hypotenuse;
            bool result;
            // Act
            Measurments = new List<double>() { SideA, SideB, SideC }.OrderBy(measurement => measurement).ToList();
            legs[0] = Math.Pow(Measurments[0], 2);
            legs[1] = Math.Pow(Measurments[1], 2);
            hypotenuse = Math.Pow(Measurments[2], 2);
            if (hypotenuse == legs[0] + legs[1]) { result = true; } else { result = false; }
            // Assert
            Assert.True(result);
        }
    }
}
