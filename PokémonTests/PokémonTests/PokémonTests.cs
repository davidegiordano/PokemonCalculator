using PokémonCalculator.model.pokémon;
using PokémonCalculator.model.types;
using PokémonCalculator.model.natures;
using Type = PokémonCalculator.model.types.Type;
using Microsoft.VisualBasic;
using System;

namespace PokémonTests
{
    [TestClass]
    public class PokémonTests
    {
        private Pokémon garchomp;
        private Pokémon stakataka;
        private Pokémon blastoise;

        [TestInitialize]
        public void TestInitialize()
        {
            uint level = 78;

            Dictionary<Stats, uint> baseStats = new Dictionary<Stats, uint>();
            baseStats.Add(Stats.HP, 108);
            baseStats.Add(Stats.Attack, 130);
            baseStats.Add(Stats.Defense, 95);
            baseStats.Add(Stats.SpecialAttack, 80);
            baseStats.Add(Stats.SpecialDefense, 85);
            baseStats.Add(Stats.Speed, 102);
            uint total = 600;

            Dictionary<Stats, uint> ivs = new Dictionary<Stats, uint>();
            ivs.Add(Stats.HP, 24);
            ivs.Add(Stats.Attack, 12);
            ivs.Add(Stats.Defense, 30);
            ivs.Add(Stats.SpecialAttack, 16);
            ivs.Add(Stats.SpecialDefense, 23);
            ivs.Add(Stats.Speed, 5);

            Dictionary<Stats, uint> evs = new Dictionary<Stats, uint>();
            evs.Add(Stats.HP, 74);
            evs.Add(Stats.Attack, 190);
            evs.Add(Stats.Defense, 91);
            evs.Add(Stats.SpecialAttack, 48);
            evs.Add(Stats.SpecialDefense, 84);
            evs.Add(Stats.Speed, 23);

            garchomp = new Pokémon(445, "Garchomp", new List<Type>() { Dragon.Instance, Ground.Instance }, level,
                new BaseStats(baseStats, total), 4, new IV(ivs), new EV(evs), Adamant.Instance);

            level = 100;
            baseStats = new Dictionary<Stats, uint>();
            baseStats.Add(Stats.HP, 61);
            baseStats.Add(Stats.Attack, 131);
            baseStats.Add(Stats.Defense, 211);
            baseStats.Add(Stats.SpecialAttack, 53);
            baseStats.Add(Stats.SpecialDefense, 101);
            baseStats.Add(Stats.Speed, 13);
            total = 570;
            stakataka = new Pokémon(805, "Stakataka", new List<Type>() { Rock.Instance, Steel.Instance}, level, new BaseStats(baseStats, total), 7);

            level = 50;
            baseStats = new Dictionary<Stats, uint>();
            baseStats.Add(Stats.HP, 79);
            baseStats.Add(Stats.Attack, 83);
            baseStats.Add(Stats.Defense, 100);
            baseStats.Add(Stats.SpecialAttack, 85);
            baseStats.Add(Stats.SpecialDefense, 105);
            baseStats.Add(Stats.Speed, 78);
            total = 530;
            evs = new Dictionary<Stats, uint>();
            evs.Add(Stats.HP, 252);
            evs.Add(Stats.Attack, 0);
            evs.Add(Stats.Defense, 44);
            evs.Add(Stats.SpecialAttack, 196);
            evs.Add(Stats.SpecialDefense, 4);
            evs.Add(Stats.Speed, 12);
            blastoise = new Pokémon(6, "Blastoise", new List<Type>() { Water.Instance }, level, new BaseStats(baseStats, total), 1, IV.MaxIV(), new EV(evs), Modest.Instance);
        }

        [TestMethod]
        public void TestWeaknesses1()
        {
            Assert.AreEqual(4, garchomp.GetChart()[Types.Ice]);
            Assert.AreEqual(2, garchomp.GetChart()[Types.Fairy]);
            Assert.AreEqual(2, garchomp.GetChart()[Types.Dragon]);
            Assert.IsTrue(garchomp.GetWeaknesses().Contains(Types.Ice));
            Assert.IsTrue(garchomp.GetWeaknesses().Contains(Types.Fairy));
            Assert.IsTrue(garchomp.GetWeaknesses().Contains(Types.Dragon));
        }

        [TestMethod]
        public void TestResistances1()
        {
            Assert.AreEqual(0.5, garchomp.GetChart()[Types.Poison]);
            Assert.AreEqual(0.5, garchomp.GetChart()[Types.Rock]);
            Assert.AreEqual(0.5, garchomp.GetChart()[Types.Fire]);
            Assert.IsTrue(garchomp.GetResistances().Contains(Types.Poison));
            Assert.IsTrue(garchomp.GetResistances().Contains(Types.Rock));
            Assert.IsTrue(garchomp.GetResistances().Contains(Types.Fire));
        }

        [TestMethod]
        public void TestImmunities1()
        {
            Assert.AreEqual(0, garchomp.GetChart()[Types.Electric]);
            Assert.IsTrue(garchomp.GetImmunities().Contains(Types.Electric));
        }

        [TestMethod]
        public void TestStats1()
        {
            Assert.AreEqual((uint) 289, garchomp.HP);
            Assert.AreEqual((uint) 278, garchomp.Attack);
            Assert.AreEqual((uint) 193, garchomp.Defense);
            Assert.AreEqual((uint) 135, garchomp.SpecialAttack);
            Assert.AreEqual((uint) 171, garchomp.SpecialDefense);
            Assert.AreEqual((uint) 171, garchomp.Speed);
        }

        [TestMethod]
        public void TestWeaknesses2()
        {
            Assert.AreEqual(4, stakataka.GetChart()[Types.Fighting]);
            Assert.AreEqual(4, stakataka.GetChart()[Types.Ground]);
            Assert.AreEqual(2, stakataka.GetChart()[Types.Water]);
            Assert.IsTrue(stakataka.GetWeaknesses().Contains(Types.Fighting));
            Assert.IsTrue(stakataka.GetWeaknesses().Contains(Types.Ground));
            Assert.IsTrue(stakataka.GetWeaknesses().Contains(Types.Water));
        }

        [TestMethod]
        public void TestResistances2()
        {
            Assert.AreEqual(0.25, stakataka.GetChart()[Types.Normal]);
            Assert.AreEqual(0.25, stakataka.GetChart()[Types.Flying]);
            Assert.AreEqual(0.5, stakataka.GetChart()[Types.Rock]);
            Assert.AreEqual(0.5, stakataka.GetChart()[Types.Bug]);
            Assert.AreEqual(0.5, stakataka.GetChart()[Types.Psychic]);
            Assert.AreEqual(0.5, stakataka.GetChart()[Types.Ice]);
            Assert.AreEqual(0.5, stakataka.GetChart()[Types.Dragon]);
            Assert.AreEqual(0.5, stakataka.GetChart()[Types.Fairy]);
            Assert.IsTrue(stakataka.GetResistances().Contains(Types.Normal));
            Assert.IsTrue(stakataka.GetResistances().Contains(Types.Flying));
            Assert.IsTrue(stakataka.GetResistances().Contains(Types.Rock));
            Assert.IsTrue(stakataka.GetResistances().Contains(Types.Bug));
            Assert.IsTrue(stakataka.GetResistances().Contains(Types.Psychic));
            Assert.IsTrue(stakataka.GetResistances().Contains(Types.Ice));
            Assert.IsTrue(stakataka.GetResistances().Contains(Types.Dragon));
            Assert.IsTrue(stakataka.GetResistances().Contains(Types.Fairy));
        }

        [TestMethod]
        public void TestImmunities2()
        {
            Assert.AreEqual(0, stakataka.GetChart()[Types.Poison]);
            Assert.IsTrue(stakataka.GetImmunities().Contains(Types.Poison));
        }

        [TestMethod]
        public void TestStats2()
        {
            Assert.AreEqual((uint) 232, stakataka.HP);
            Assert.AreEqual((uint) 267, stakataka.Attack);
            Assert.AreEqual((uint) 427, stakataka.Defense);
            Assert.AreEqual((uint) 111, stakataka.SpecialAttack);
            Assert.AreEqual((uint) 207, stakataka.SpecialDefense);
            Assert.AreEqual((uint) 31, stakataka.Speed);
        }

        [TestMethod]
        public void TestWeaknesses3()
        {
            Assert.AreEqual(2, blastoise.GetChart()[Types.Electric]);
            Assert.AreEqual(2, blastoise.GetChart()[Types.Grass]);
            Assert.IsTrue(blastoise.GetWeaknesses().Contains(Types.Electric));
            Assert.IsTrue(blastoise.GetWeaknesses().Contains(Types.Grass));
        }

        [TestMethod]
        public void TestResistances3()
        {
            Assert.AreEqual(0.5, blastoise.GetChart()[Types.Steel]);
            Assert.AreEqual(0.5, blastoise.GetChart()[Types.Water]);
            Assert.AreEqual(0.5, blastoise.GetChart()[Types.Fire]);
            Assert.AreEqual(0.5, blastoise.GetChart()[Types.Ice]);
            Assert.IsTrue(blastoise.GetResistances().Contains(Types.Steel));
            Assert.IsTrue(blastoise.GetResistances().Contains(Types.Water));
            Assert.IsTrue(blastoise.GetResistances().Contains(Types.Fire));
            Assert.IsTrue(blastoise.GetResistances().Contains(Types.Ice));
        }

        [TestMethod]
        public void TestImmunities3()
        {
            Assert.IsTrue(blastoise.GetImmunities().Count == 0);
        }

        [TestMethod]
        public void TestStats3()
        {
            Assert.AreEqual((uint) 186, blastoise.HP);
            Assert.AreEqual((uint) 92, blastoise.Attack);
            Assert.AreEqual((uint) 126, blastoise.Defense);
            Assert.AreEqual((uint) 143, blastoise.SpecialAttack);
            Assert.AreEqual((uint) 126, blastoise.SpecialDefense);
            Assert.AreEqual((uint) 100, blastoise.Speed);
        }
    }
}
