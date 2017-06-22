using NFluent;
using NUnit.Framework;

namespace SolidExercices.Tests
{
    public class CalculatorShould
    {
        [Test]
        public void CalculateASum()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("1+2,3");
            Check.That(result).IsEqualTo(3.3);
            var result1 = calculator.Calculate("1+70");
            Check.That(result1).IsEqualTo(71);
            var result2 = calculator.Calculate("1 + 35,4 + 4,6 + 4");
            Check.That(result2).IsEqualTo(45);
            var result3 = calculator.Calculate("1+70");
            Check.That(result3).IsNotEqualTo(45);
        }
    }
}
