using System;
using Xunit;

namespace TheJosephusProblem.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Returns_4_if_groupSize_is_10_and_interval_is_3()
        {
            //Arrange
            int GroupSize = 10;
            int interval = 3;
            int expectedResult = 4;
            var survivor = new LastPersonStanding();

            //Act
            var actualResult = survivor.lastPerson(GroupSize, interval);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void Returns_7_if_groupSize_is_7_and_interval_is_2()
        {
            //Arrange
            int GroupSize = 7;
            int interval = 2;
            int expectedResult = 7;
            var survivor = new LastPersonStanding();

            //Act
            var actualResult = survivor.lastPerson(GroupSize, interval);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
