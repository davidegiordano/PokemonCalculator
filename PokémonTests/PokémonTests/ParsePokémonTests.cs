using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokémonCalculator.model.pokémon;
using PokémonCalculator.model.types;
using PokémonCalculator.persistence;
using Type = PokémonCalculator.model.types.Type;

namespace PokémonTests
{
    [TestClass]
    public class ParsePokémonTests
    {
        private static ParsePokémon parser;

        [TestInitialize]
        public void TestInitialize()
        {
            parser = ParsePokémon.Instance;
        }

        [TestMethod]
        public void TestParsePokémon()
        {
            Assert.AreEqual(1075, parser.GetPokémons().Count);
        }

        [TestMethod]
        public void TestGetPokémon1()
        {
            Pokémon blastoise = parser.GetPokémon("Blastoise");
            Assert.AreEqual((uint)9, blastoise.ID);
            Assert.AreEqual("Blastoise", blastoise.Name);
            Assert.IsTrue(blastoise.Type.Count == 1 && blastoise.Type.Contains(Water.Instance));
            //Assert.AreEqual(new List<Type>() { Water.Instance }, blastoise.Type);
            Assert.AreEqual((uint)530, blastoise.BaseStatTotal);
        }
        [TestMethod]
        public void TestGetPokémon2()
        {
            Pokémon zacianCrowned = parser.GetPokémon("Zacian-Crowned Sword");
            Assert.AreEqual((uint)888, zacianCrowned.ID);
            Assert.AreEqual("Zacian-Crowned Sword", zacianCrowned.Name);
            Assert.IsTrue(zacianCrowned.Type.Count == 2 && zacianCrowned.Type.Contains(Fairy.Instance) && zacianCrowned.Type.Contains(Steel.Instance));
            Assert.AreEqual((uint)720, zacianCrowned.BaseStatTotal);
        }


        [TestMethod]
        public void TestGetPokémonsByGen()
        {
            Assert.AreEqual(151, parser.GetPokémonsByGen(1).Count);
            Assert.IsTrue(parser.GetPokémonsByGen(1).Contains(parser.GetPokémon("Blastoise")));
            Assert.IsFalse(parser.GetPokémonsByGen(1).Contains(parser.GetPokémon("Zacian-Crowned Sword")));
        }

        [TestMethod]
        public void TestGetTop100Pokémons()
        {
            Assert.AreEqual(100, parser.GetTop100Pokémons().Count);
            Assert.IsTrue(parser.GetTop100Pokémons().Contains(parser.GetPokémon("Zacian-Crowned Sword")));
        }
    }
}
