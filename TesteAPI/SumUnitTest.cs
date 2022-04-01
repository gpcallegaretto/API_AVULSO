using API_AVULSO.Controllers;
using API_AVULSO.Model;
using API_AVULSO.Services;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace TesteAPI
{
    public class SumUnitTest
    {
        [Fact]
        public void TestSum()
        {
            //Arrange test
            var mock = new Mock<IMathOperations>();
            decimal v1 = 1;
            decimal v2 = 3.6M;
            decimal valueExpected = 4.6M;
            mock.Setup(x => x.Sum(It.IsAny<decimal>(), It.IsAny<decimal>())).Returns(valueExpected);
            MathOperationsController op = new MathOperationsController(mock.Object);

            //Act test
            decimal result = op.Sum(v1, v2);

            //Assert test
            Assert.Equal(valueExpected, result);
        }
    }
}
