using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNunit;

namespace User
{
    namespace User.Tests
    {
        [TestFixture]
        public class Class1
        {
            [Test]
            public void AdditionalCorrectValue()
            {
                Calculators calculator = new Calculators();
                Assert.That(calculator.Additional(40, 50) == 90);
            }
            [Test]
            public void SubtractionlCorrectValue()
            {
                Calculators calculator = new Calculators();
                Assert.That(calculator.Subtraction(450, 50) == 400);
            }
            [Test]
            public void MiltiplicationCorrectValue()
            {
                Calculators calculator = new Calculators();
                Assert.That(calculator.Miltiplication(40, 2) == 80);
            }
            [Test]
            public void DivisionCorrectValue()
            {
                Calculators calculator = new Calculators();
                Assert.That(calculator.Division(40, 2) == 20);
            }



        }
    }
}
