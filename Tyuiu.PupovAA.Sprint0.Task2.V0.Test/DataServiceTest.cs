using Tyuiu.PupovAA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.PupovAA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassageValid()
        {
            var name = "Артём";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Артём", res);
        }
    }
}
