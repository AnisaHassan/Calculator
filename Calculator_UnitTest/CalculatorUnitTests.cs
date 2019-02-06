using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorUnitTests
    {

        private calculator uut;

        [SetUp]
        public void SetUp()
        {
            uut = new calculator();
        }

        // TEST AF ADD METODE

        // 1. Med hele tal
        [Test]
        public void Add2And1_Return3()
        {
            uut.a = 2;
            uut.b = 1;
           
            Assert.That(uut.Add(uut.a, uut.b), Is.EqualTo(3));
        }

        // 2. Testcases med hele tal
        [TestCase(1, 2, 3)]
        [TestCase(-3, -1, -4)]
        [TestCase(-1, 2, 1)]
        [TestCase(3, -2, 1)]
        [TestCase(3, 0, 3)]
        [TestCase(6, 6, 12)]
        [TestCase(2, 1, 3)]
        public void AddTestCases(int a, int b, int result)
        {

            Assert.That(uut.Add(a, b), Is.EqualTo(result));
        }

        // 3. ADD med kommatal
        [Test]
        public void Add2_2And1_1_Return3_3()
        {
            uut.a = 2.2;
            uut.b = 1.1;

            Assert.That(uut.Add(uut.a, uut.b), Is.EqualTo(3.3).Within(0.01));
        }




        // TEST SUBTRACT METODE
        // 1. Minus med hele positive tal
        [Test]
        public void Subtract2And2_Return0()
        {
            uut.a = 2;
            uut.b = 2;

            Assert.That(uut.Subtract(uut.a, uut.b), Is.EqualTo(0));
        }

        // 2. SUBTRACT med negativ resultat
        [Test]
        public void Subtract0_0And2_1_Return0()
        {
            uut.a = 0.0;
            uut.b = 2.1;

            Assert.That(uut.Subtract(uut.a, uut.b), Is.EqualTo(-2.1));
        }

        // 3. SUBTRACT med testcases
        [TestCase(3, 1, 2)]
        [TestCase(-3, 0, -3)]
        [TestCase(10, 5, 5)]
        [TestCase(7, -2, 9)]
        [TestCase(3, 0, 3)]
      
        public void SubtractTestCases(int a, int b, int result)
        {

            Assert.That(uut.Subtract(a,b), Is.EqualTo(result));
        }

        // TEST MULTIPLY METODE
        // 1. MULTIPLY med hele tal
        [Test]
        public void Multiply2And2_Return4()
        {
            uut.a = 2;
            uut.b = 2;

            Assert.That(uut.Multiply(uut.a, uut.b), Is.EqualTo(4));
        }

        // 2. MULTIPLY med negative værdier
        [Test]

        public void Multiply_2_And_5_Return4()
        {
            uut.a = -2;
            uut.b = -5;

            Assert.That(uut.Multiply(uut.a, uut.b), Is.EqualTo(10));
        }

        // 3. MULTIPLY med Testcases
        [TestCase(3, 1, 3)]
        [TestCase(5, 2, 10)]
        [TestCase(10, 2, 20)]
        [TestCase(-1, 1, -1)]
        public void MultiplyTestcases(int a, int b, int result)
        {
            Assert.That(uut.Multiply(a,b), Is.EqualTo(result));
        }

        // TEST POWER METODE
        // 1. POWER med hele tal
        [Test]
        public void Power2And3_Return8()
        {
            uut.a = 2;
            uut.b = 3;

            Assert.That(uut.Power(uut.a, uut.b), Is.EqualTo(8));
        }
        // 2. POWER med 0
        [Test()]
        public void Power0And16_Return0()
        {
            uut.a = 0;
            uut.b = 16;

            Assert.That(uut.Power(uut.a, uut.b), Is.EqualTo(0));
        }

        // 3. POWER med Testcases
        [TestCase(2, 1, 2)]
        [TestCase(2, 2, 4)]
        [TestCase(2, 3, 8)]
        public void PowerTestcases(int a, int b, int result)
        {
            Assert.That(uut.Power(a, b), Is.EqualTo(result));
        }

        // TEST DIVIDE METODE
        // 1. DIVIDE med hele tal
        [Test]
        public void Divide_4_By_2_Return2()
        {
            uut.divident = 4;
            uut.divisor = 2;
            Assert.That(uut.Divide(uut.divident, uut.divisor), Is.EqualTo(2));
        }

        // 2. DIVIDE METODE MED 0

        [Test]
        public void Divide_6_By_0_ReturnError()
        {
            Assert.Catch<DivideByZeroException>(() => uut.Divide(6, 0));

        }


        // 3. DIVIDE med testcases
        [TestCase(2, 1, 2)]
        [TestCase(2, 2, 1)]
        [TestCase(10, 5, 2)]
        public void DivideTestcases(int a, int b, int result)
        {
            Assert.That(uut.Divide(a, b), Is.EqualTo(result));
        }


        // Test ACCUMULATOR
        [Test]
        public void AccumulatorReturns4When2And2IsAdded()
        {
            uut.Add(2, 2);
            Assert.That(uut.Accumulator, Is.EqualTo(4));
        }

        // 1. ADD ACCUMULATOR

        [Test]
        public void AddAccumulateAnd9_Return12()
        {
            uut.Add(2, 1);
            uut.addend = 9;

            Assert.That(uut.Add(uut.addend), Is.EqualTo(12));
        }

        [Test]
        // 2. ADD ACCUMULATOR
        public void AddAccumulateAnd1_Return1()
        {
            uut.Add(1, 0);
         
            Assert.That(uut.Add(1), Is.EqualTo(2));
        }

        // 3. ADD ACCUMULATOR
        [Test]
        public void AddAccumulateTestCases()
        {
            uut.Add(-2, -2);
            Assert.That(uut.Add(1), Is.EqualTo(-3));
        }

        // TEST SUBTRACT ACCUMULATOR
        // 1. SUBTRACT ACCUMULATOR
        [Test]
        public void AccumulateAnd32_Return280()
        {
            uut.Subtract(32, 8);
            Assert.That(uut.Subtract(17), Is.EqualTo(7));
        }

        // 2. SUBTRACT ACCUMULATOR NEGATIVE TAL
        [Test]
        public void SubtractAccumulateAnd2_Return_minus8()
        {
            uut.Subtract(-56, 14);
            Assert.That(uut.Subtract(18), Is.EqualTo(-88));
        }


        // 3. SUBTRACT ACCUMULATOR TEST CASES
        [TestCase(3, 1, 2)]
        [TestCase(5, 2, 3)]
        [TestCase(-10, 2, -12)]
        public void SubtractAccumulateTestcases(int a, int b, int result)
        {
            
            Assert.That(uut.Subtract(a, b), Is.EqualTo(result));
        }



        // TEST MULTIPLY ACCUMULATOR
        // 1. MULTIPLY ACCUMULATOR
        [Test]
        public void MulityplyAccumulateAnd8_Return280()
        {
            uut.Multiply(7, 5);
          Assert.That(uut.Multiply(8), Is.EqualTo(280));
        }

        // 2. MULTIPLY ACCUMULATOR NEGATIVE TAL
        [Test]
        public void MulityplyAccumulateAnd2_Return_minus8()
        {
            uut.Multiply(-2, 2);
           Assert.That(uut.Multiply(2), Is.EqualTo(-8));
        }


        // 3. MULTIPLY ACCUMULATOR TEST CASES
        [TestCase(3, 1, 3)]
        [TestCase(5, 2, 10)]
        [TestCase(10, 2, 20)]
        [TestCase(-1, 1, -1)]
        public void MulityplyAccumulateTestcases(int a, int b, int result)
        {
            uut.Multiply(a, b);

            Assert.That(uut.Multiply(1), Is.EqualTo(result));
        }



        // TEST DIVIDE ACCUMULATOR

        [Test]
        public void DivideAccumulateAnd9_Return05()
        {
            uut.Divide(45,9);
            uut.addend = 10;

            Assert.That(uut.Divide(10), Is.EqualTo(0.5));
        }

        // TEST DIVIDE ACCUMULATOR NEGATIVE TAL
        
        public void DivideAccumulateAnd6_Return3()
        {
            uut.Divide(-54, -6);
            uut.addend = -3;

            Assert.That(uut.Divide(uut.addend), Is.EqualTo(3));
        }

        // TEST DIVIDE ACCUMULATOR TEST CASES
        [TestCase(3, 1, 3)]
        [TestCase(68, 17, 4)]
        [TestCase(22, 11, 2)]
        [TestCase(-24, 4, -6)]
        public void DivideAccumulateTestCases(double divident, double divisor, int result)
        {
            uut.Divide(divident,divisor);
          
            Assert.That(uut.Divide(1), Is.EqualTo(result));
        }

        // TEST POWER ACCUMULATOR

        [Test]
        public void PowerAccumulateAnd5_Return128()
        {
            uut.Power(4, 5);
            uut.addend = 8;

            Assert.That(uut.Divide(uut.addend), Is.EqualTo(128));
        }

        //Clear method 
        [Test]
        public void ClearAccumulationForZeroes()
        {
            uut.Clear();
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }
    }

}
