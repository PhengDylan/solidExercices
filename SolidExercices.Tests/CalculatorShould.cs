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
            Check.That(result).IsEqualTo(3.3m);
            var result1 = calculator.Calculate("1+70");
            Check.That(result1).IsEqualTo(71);
            var result2 = calculator.Calculate("1 + 35,4 + 4,6 + 4");
            Check.That(result2).IsEqualTo(45);
            var result3 = calculator.Calculate("1+70");
            Check.That(result3).IsNotEqualTo(45);
        }

        [Test]
        public void CalculateASub()
        {
            var calculator = new Calculator();
            var resultnormal = calculator.Calculate("2-1");
            Check.That(resultnormal).IsEqualTo(1);
            var resultvirgule = calculator.Calculate("1,4-0,2");
            Check.That(resultvirgule).IsEqualTo(1.2m);
            var resultatplusieurs = calculator.Calculate("100 - 35,4 - 4,6  ");
            Check.That(resultatplusieurs).IsEqualTo(60);
            var reslutatfaux = calculator.Calculate("45-54");
            Check.That(reslutatfaux).IsNotEqualTo(45);
        }
        [Test]
        public void CalculateAMul()
        {
            var calculator = new Calculator();
            var resultnormal = calculator.Calculate("2*2");
            Check.That(resultnormal).IsEqualTo(4);
            var resultvirgule = calculator.Calculate("2,5*4");
            Check.That(resultvirgule).IsEqualTo(10m);
            var resultatplusieurs = calculator.Calculate("100 * 3 * 4  ");
            Check.That(resultatplusieurs).IsEqualTo(1200);
            var reslutatfaux = calculator.Calculate("45*54");
            Check.That(reslutatfaux).IsNotEqualTo(45);
        }
    }
}
