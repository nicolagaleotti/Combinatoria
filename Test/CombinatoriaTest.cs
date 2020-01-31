using Microsoft.VisualStudio.TestTools.UnitTesting;
using Libreria;
using System.Numerics;

namespace Test
{
    [TestClass]
    public class CombinatoriaTest
    {
        [TestMethod]
        public void FattorialeTest()
        {
            int fatt = 2;
            BigInteger risposta = Libreria.Combinatoria.Fattoriale(fatt);
            Assert.AreEqual(2, risposta);
        }
    }
}
