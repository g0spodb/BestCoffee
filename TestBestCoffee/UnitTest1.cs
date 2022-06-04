using Core;
using BestCoffee.Model;

namespace TestBestCoffee
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGettingCoffee()
        {
           DataAccess.GetCoffee();
        }
    }
}