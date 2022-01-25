using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ArithmeticMeanInRange;


namespace ArithmeticMeanInRangeTest
{
    public class CalculationTest
    {
        [Fact]
        public void ShouldReturn_SameArrExcept_LastNumberEqual_5()
        {

            Assert.Equal(Calculation.SearchValueInArr(new[] { 1, 2, 3, 4, 5 }, 2), new[] { 1, 2, 3, 4, 4 });

        }
        [Fact]

        public void ShouldReurunArr()
        {
            Assert.Equal(Calculation.SearchValueInArr(new[] {6,9,12,5,3,4}, 3), new[] {9, 8, 7, 6, 6, 4});
        }
    }
}
