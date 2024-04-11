using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace S_Coefficient.Tests
{
    [TestClass]
    public class CalcSfactorTests
    {
        [TestMethod]
        public void TestMalePCHIP()
        {
            var sex = Sex.Male;

            CalcSfactor CalcS = new CalcSfactor();
            CalcS.InterpolationMethod = "PCHIP";

            CalcS.CalcS(sex);
        }

        [TestMethod]
        public void TestMaleLinear()
        {
            var sex = Sex.Male;

            CalcSfactor CalcS = new CalcSfactor();
            CalcS.InterpolationMethod = "線形補間";

            CalcS.CalcS(sex);
        }

        [TestMethod]
        public void TestFemalePCHIP()
        {
            var sex = Sex.Female;

            CalcSfactor CalcS = new CalcSfactor();
            CalcS.InterpolationMethod = "PCHIP";

            CalcS.CalcS(sex);
        }

        [TestMethod]
        public void TestFemaleLinear()
        {
            var sex = Sex.Female;

            CalcSfactor CalcS = new CalcSfactor();
            CalcS.InterpolationMethod = "線形補間";

            CalcS.CalcS(sex);
        }
    }
}
