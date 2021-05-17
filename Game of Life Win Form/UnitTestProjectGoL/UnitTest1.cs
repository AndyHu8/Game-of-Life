using Game_of_Life_Win_Form;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectGoL
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodInputValidation_Beide50()
        {
            var stringX = "50";
            var stringY = "50";
            var Test = new Menu_newGame();
            bool ergebnis = Test.Input_validationZumTest(stringX, stringY);

            Assert.AreEqual(ergebnis, true);
        }

        [TestMethod]
        public void TestMethodInputValidation_KeineZahlen()
        {
            var stringX = "A";
            var stringY = "%";
            var Test = new Menu_newGame();
            bool ergebnis = Test.Input_validationZumTest(stringX, stringY);

            Assert.AreEqual(ergebnis, false);
        }

        [TestMethod]
        public void TestMethodInputValidation_ZahlUnter1()
        {
            var stringX = "10";
            var stringY = "0";
            var Test = new Menu_newGame();
            bool ergebnis = Test.Input_validationZumTest(stringX, stringY);

            Assert.AreEqual(ergebnis, false);
        }

        [TestMethod]
        public void TestMethodInputValidation_ZahlUeber50()
        {
            var stringX = "10";
            var stringY = "100";
            var Test = new Menu_newGame();
            bool ergebnis = Test.Input_validationZumTest(stringX, stringY);

            Assert.AreEqual(ergebnis, false);
        }
    }
}
