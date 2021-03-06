using LiveNEntert.Repositories;
using LiveNEntert.Domain;
using Moq;
using System;
using Xunit;

namespace LiveNEntert.Test
{
    public class GetSummary_Tests
    {
        [Fact]
        public void GenerateString_for_values_1_3()
        {
            //Arrange
            var newString = new Summary();
            var p = new Repository(); 
            var d = p.GenerateString(1,3,newString);

            //Act
            int expect = 2;
            var actual = d.Integer;

            //Assert
            Assert.Equal(expect, actual);
        }

        [Fact]
        public void GenerateString_for_default_values()
        {
            //Arrange
            var newString = new Summary();
            var p = new Repository();
            var d = p.GenerateString(0, 1, newString);

            //Act
            int expect = 1;
            var actual = d.Integer;

            //Assert
            Assert.Equal(expect, actual);
        }
    }
}
