using PokémonCalculator.model.pokémon;
using PokémonCalculator.model.natures;

namespace PokémonTests
{
    [TestClass]
    public class NatureTests
    {
        [TestMethod]
        public void TestHardy()
        {
            Nature nature = Hardy.Instance;
            Assert.AreEqual(null, nature.IncreasedStat);
            Assert.AreEqual(null, nature.DecreasedStat);
        }
        [TestMethod]
        public void TestDocile()
        {
            Nature nature = Docile.Instance;
            Assert.AreEqual(null, nature.IncreasedStat);
            Assert.AreEqual(null, nature.DecreasedStat);
        }
        [TestMethod]
        public void TestSerious()
        {
            Nature nature = Serious.Instance;
            Assert.AreEqual(null, nature.IncreasedStat);
            Assert.AreEqual(null, nature.DecreasedStat);
        }
        [TestMethod]
        public void TestBashful()
        {
            Nature nature = Bashful.Instance;
            Assert.AreEqual(null, nature.IncreasedStat);
            Assert.AreEqual(null, nature.DecreasedStat);
        }
        [TestMethod]
        public void TestQuirky()
        {
            Nature nature = Quirky.Instance;
            Assert.AreEqual(null, nature.IncreasedStat);
            Assert.AreEqual(null, nature.DecreasedStat);
        }
        [TestMethod]
        public void TestLonely()
        {
            Nature nature = Lonely.Instance;
            Assert.AreEqual(Stats.Attack, nature.IncreasedStat);
            Assert.AreEqual(Stats.Defense, nature.DecreasedStat);
        }
        [TestMethod]
        public void TestBrave()
        {
            Nature nature = Brave.Instance;
            Assert.AreEqual(Stats.Attack, nature.IncreasedStat);
            Assert.AreEqual(Stats.Speed, nature.DecreasedStat);
        }
        [TestMethod]
        public void TestAdamant()
        {
            Nature nature = Adamant.Instance;
            Assert.AreEqual(Stats.Attack, nature.IncreasedStat);
            Assert.AreEqual(Stats.SpecialAttack, nature.DecreasedStat);
        }
        [TestMethod]
        public void TestNaughty()
        {
            Nature nature = Naughty.Instance;
            Assert.AreEqual(Stats.Attack, nature.IncreasedStat);
            Assert.AreEqual(Stats.SpecialDefense, nature.DecreasedStat);
        }
        [TestMethod]
        public void TestBold()
        {
            Nature nature = Bold.Instance;
            Assert.AreEqual(Stats.Defense, nature.IncreasedStat);
            Assert.AreEqual(Stats.Attack, nature.DecreasedStat);
        }
        [TestMethod]
        public void TestRelaxed()
        {
            Nature nature = Relaxed.Instance;
            Assert.AreEqual(Stats.Defense, nature.IncreasedStat);
            Assert.AreEqual(Stats.Speed, nature.DecreasedStat);
        }
        [TestMethod]
        public void TestImpish()
        {
            Nature nature = Impish.Instance;
            Assert.AreEqual(Stats.Defense, nature.IncreasedStat);
            Assert.AreEqual(Stats.SpecialAttack, nature.DecreasedStat);
        }
        [TestMethod]
        public void TestLax()
        {
            Nature nature = Lax.Instance;
            Assert.AreEqual(Stats.Defense, nature.IncreasedStat);
            Assert.AreEqual(Stats.SpecialDefense, nature.DecreasedStat);
        }
        [TestMethod]
        public void TestTimid()
        {
            Nature nature = Timid.Instance;
            Assert.AreEqual(Stats.Speed, nature.IncreasedStat);
            Assert.AreEqual(Stats.Attack, nature.DecreasedStat);
        }
        [TestMethod]
        public void TestHasty()
        {
            Nature nature = Hasty.Instance;
            Assert.AreEqual(Stats.Speed, nature.IncreasedStat);
            Assert.AreEqual(Stats.Defense, nature.DecreasedStat);
        }
        [TestMethod]
        public void TestJolly()
        {
            Nature nature = Jolly.Instance;
            Assert.AreEqual(Stats.Speed, nature.IncreasedStat);
            Assert.AreEqual(Stats.SpecialAttack, nature.DecreasedStat);
        }
        [TestMethod]
        public void TestNaive()
        {
            Nature nature = Naive.Instance;
            Assert.AreEqual(Stats.Speed, nature.IncreasedStat);
            Assert.AreEqual(Stats.SpecialDefense, nature.DecreasedStat);
        }
        [TestMethod]
        public void TestModest()
        {
            Nature nature = Modest.Instance;
            Assert.AreEqual(Stats.SpecialAttack, nature.IncreasedStat);
            Assert.AreEqual(Stats.Attack, nature.DecreasedStat);
        }
        [TestMethod]
        public void TestMild()
        {
            Nature nature = Mild.Instance;
            Assert.AreEqual(Stats.SpecialAttack, nature.IncreasedStat);
            Assert.AreEqual(Stats.Defense, nature.DecreasedStat);
        }
        [TestMethod]
        public void TestQuiet()
        {
            Nature nature = Quiet.Instance;
            Assert.AreEqual(Stats.SpecialAttack, nature.IncreasedStat);
            Assert.AreEqual(Stats.Speed, nature.DecreasedStat);
        }
        [TestMethod]
        public void TestRash()
        {
            Nature nature = Rash.Instance;
            Assert.AreEqual(Stats.SpecialAttack, nature.IncreasedStat);
            Assert.AreEqual(Stats.SpecialDefense, nature.DecreasedStat);
        }
        [TestMethod]
        public void TestCalm()
        {
            Nature nature = Calm.Instance;
            Assert.AreEqual(Stats.SpecialDefense, nature.IncreasedStat);
            Assert.AreEqual(Stats.Attack, nature.DecreasedStat);
        }
        [TestMethod]
        public void TestGentle()
        {
            Nature nature = Gentle.Instance;
            Assert.AreEqual(Stats.SpecialDefense, nature.IncreasedStat);
            Assert.AreEqual(Stats.Defense, nature.DecreasedStat);
        }
        [TestMethod]
        public void TestSassy()
        {
            Nature nature = Sassy.Instance;
            Assert.AreEqual(Stats.SpecialDefense, nature.IncreasedStat);
            Assert.AreEqual(Stats.Speed, nature.DecreasedStat);
        }
        [TestMethod]
        public void TestCareful()
        {
            Nature nature = Careful.Instance;
            Assert.AreEqual(Stats.SpecialDefense, nature.IncreasedStat);
            Assert.AreEqual(Stats.SpecialAttack, nature.DecreasedStat);
        }
    }
}