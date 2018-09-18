using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltBilletLibrary;

namespace StorebaeltTests
{
    [TestClass]
    public class StorebaeltTest
    {
        [TestMethod]
        public void TestStorebaeltRabatMandag()
        {
            //arrange 17-09-2018 er en mandag
            Storeb�ltsBil sbb = new Storeb�ltsBil("AA12345", DateTime.Parse("17-09-2018"), true);

            //act
            double result = sbb.RabatPris();

            //assert
            Assert.AreEqual(228, result);
        }

        [TestMethod]
        public void TestStorebaeltRabatL�rdag()
        {
            //arrange 15-09-2018 er en l�rdag
            Storeb�ltsBil sbb = new Storeb�ltsBil("AA12345", DateTime.Parse("15-09-2018"), true);

            //act
            double result = sbb.RabatPris();

            //assert
            Assert.AreEqual(182.4, result);
        }
    }
}
