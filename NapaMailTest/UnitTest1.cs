using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using c11eindividual.Repositories;

namespace NapaMailTest
{
    [TestClass]
    public class UnitTest1
    {
        MensajeRepository sut = null;

        [TestInitialize]
        public void TestInitilize()
        {
            sut = new MensajeRepository();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var lista = sut.Todos(5);
            Assert.AreEqual(2, lista.Count);
        }
    }
}
