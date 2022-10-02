using Calculator;

namespace Calculator.Tests
{
    public class ClacTest
    {
        public ClacTest()
        {

        }
        //---------Addition-----------
        [Fact]
        public void AddTwoNumbers()
        {
            //Arrange
            double num1 = 20;
            double num2 = 6;

            //Act
            double act = Calc.Addition(num1, num2);

            //Assert
            Assert.Equal(26, act);
        }
        [Fact]
        public void AddTwoDecimalNumbers()
        {
            //Arrange
            double num1 = 99.1;
            double num2 = 0.6;

            //Act
            double act = Calc.Addition(90, 9.1);
            double act2 = Calc.Addition(0, 0.6);

            //Assert
            Assert.Equal(num1, act);
            Assert.Equal(num2, act2);
        }

        // Test with theory. Inlinedata has two in values and the last value is the expected result.
        [Theory]
        [InlineData(2.1, 2, 4.1)]// 2.1 + 2 = 4.1
        [InlineData(3.1, -2.5, 0.6)]//3.1 + -2.5=0.6
        [InlineData(4, 2, 6)]
        [InlineData(2.3, 2.2, 4.5)]
        [InlineData(2, 0, 2)]
        [InlineData(0, 0, 0)]
        [InlineData(double.MaxValue, 5, double.MaxValue)]
        [InlineData(-309, -101, -410)]
        public void TestAddIn(double num1, double num2, double expected)
        {
            //Act
            //double act = Calc.Addition(number1, number2);
            //Test the calculator by insert numbers in to the method Add in calculator class.
            //Compare it to the expected result.
            Assert.Equal(expected, Calc.Addition(num1, num2), 1);
        }

        [Fact]
        public void AdditionTestGoodNegativNumbers()
        {
            //Arrange
            double num1 = -6.1;
            double num2 = -13.6;

            //Act
            double result = Calc.Addition(num1, num2);

            //Assert
            Assert.Equal(-19.7, result);
        }

        //----------Subtraction-----------
        [Fact]
        public void SubOneIntAndDecimal()
        {
            //Arrange
            double num1 = 10;
            double num2 = 0.6;

            //Act
            double act = Calc.Subtraction(num1, num2);

            //Assert
            Assert.Equal(9.4, act);
        }

        [Theory]
        [InlineData(2.1, 2, 0.1)]
        [InlineData(3.1, -2.5, 5.6)]
        [InlineData(4, 2, 2)]
        [InlineData(2.3, 2.2, 0.1)]
        [InlineData(2, 0, 2)]
        [InlineData(0, 0, 0)]
        [InlineData(double.MaxValue, 5, double.MaxValue)]
        [InlineData(-309, -101, -208)]
        public void TestSubIn(double num1, double num2, double expected)
        {
            Assert.Equal(expected, Calc.Subtraction(num1, num2), 1);
        }

        [Fact]
        public void SubTestGoodNegativNumbers()
        {
            //Arrange
            double num1 = -6.1;
            double num2 = -13.6;

            //Act
            double result = Calc.Subtraction(num1, num2);

            //Assert
            Assert.Equal(7.5, result);
        }

        //---------------Multiplication-------------
        [Fact]
        public void MultiTwoNumbers()
        {
            //Arrange
            double num1 = 50;
            double num2 = 10.5;

            //Act
            double act = Calc.Multiplication(5, 10);
            double act2 = Calc.Multiplication(2, 5.25);

            //Assert
            Assert.Equal(num1, act);
            Assert.Equal(num2, act2);
        }


        [Fact]
        public void MultiTwoDecimalNumbers()
        {
            //Arrange
            double num1 = 98.2;
            double num2 = 1.6;

            //Act
            double act = Calc.Multiplication(49.1, 2);
            double act2 = Calc.Multiplication(0.8, 2);

            //Assert
            Assert.Equal(num1, act);
            Assert.Equal(num2, act2);
        }

        [Fact]
        public void MultiplicationTestDecimalNegativ()
        {
            //Arrange
            double num1 = -8.1;
            double num2 = 10;

            //Act
            double result = Calc.Multiplication(num1, num2);

            //Assert
            Assert.Equal(-81, result);
        }

        // Test with theory. Inlinedata has two in values and the last value is the expected result.
        [Theory]
        [InlineData(2.1, 2, 4.2)]// 2.1 + 2 = 4.1
        [InlineData(4, 2, 8)]
        [InlineData(2.3, 2.2, 5.06)]
        [InlineData(2, 0, 0)]
        [InlineData(0, 0, 0)]
        public void TestMultiIn(double num1, double num2, double expected)
        {
            Assert.Equal(expected, Calc.Multiplication(num1, num2), 1);
        }

        //-----------------Division-----------------
        [Fact]
        public void DivideTwoNumbers()
        {
            //Arrange
            double num1 = 60;
            double num2 = 5;

            //Act
            double act = Calc.Division(600, 10);
            double act2 = Calc.Division(10, 2);
            double result = Calc.Division(num1, num2);

            //Assert
            Assert.Equal(num1, act);
            Assert.Equal(num2, act2);
            Assert.Equal(12, result);
        }

        [Fact]
        public void DivideWithPrecision()
        {
            //Arrange
            double num1 = 1;
            double num2 = 3;

            //Act
            double result = Calc.Division(num1, num2);

            //Assert
            Assert.Equal(0.33, result, 2);
        }

        //Test of thrown DivideByZeroException
        [Fact]
        public void TestDiviThrowsException()
        {
            //Arrange
            string expectedText = "Division by zero is not possible.";

            //Act
            DivideByZeroException result = Assert.Throws<DivideByZeroException>(() => Calc.Division(0, 0));

            //Assert
            Assert.Equal(expectedText, result.Message);
        }

    }
}