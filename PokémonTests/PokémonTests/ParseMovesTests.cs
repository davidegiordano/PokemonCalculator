using PokémonCalculator.persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonTests
{
    [TestClass]
    public class ParseMovesTests
    {
        private static ParseMoves parser;

        [TestInitialize]
        public void TestInitialize()
        {
            parser = ParseMoves.Instance;
        }

        [TestMethod]
        public void TestParseMoves()
        {
            Assert.AreEqual(767, parser.GetAllMoves().Count);
            Assert.AreEqual(508, parser.GetDamagingMoves().Count);
            Assert.AreEqual(37, parser.GetFixedDamageMoves().Count);
        }

        [TestMethod]
        public void TestGetMove()
        {
            Assert.AreEqual((uint)75, parser.GetMove("Rock Slide").Power);
            Assert.AreEqual((uint)90, parser.GetMove("Rock Slide").Accuracy);
            Assert.AreEqual((uint)60, parser.GetMove("Aerial Ace").Power);
            Assert.AreEqual(null, parser.GetMove("Aerial Ace").Accuracy);
            Assert.AreEqual(null, parser.GetMove("Sonic Boom").Power);
            Assert.AreEqual((uint)90, parser.GetMove("Sonic Boom").Accuracy);
            Assert.AreEqual(true, parser.GetMove("Sonic Boom").IsFixedDamage);
        }
    }
}
