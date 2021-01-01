using System;
using Xunit;
using SimpleAPI.Controllers;


namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();

        [Fact]
        public void Get_Return_Something_Else()
        {
            //Arrange
            var expected = "Something else";


            //Act
            var actual = controller.Get(2).Value;

            //Assert

            Assert.Equal(expected, actual);
        }

        //[Fact]
        //public void Test1()
        //{

        //}
    }
}
