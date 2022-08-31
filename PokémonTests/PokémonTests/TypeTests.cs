using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokémonCalculator.model.types;
using Type = PokémonCalculator.model.types.Type;

namespace PokémonTests
{
    [TestClass]
    public class TypeTests
    {
        [TestMethod]
        public void TestNormal()
        {
            Type type = Normal.Instance;
            Assert.AreEqual(1, type.GetChart()[Types.Normal]);
            Assert.AreEqual(2, type.GetChart()[Types.Fighting]);
            Assert.AreEqual(1, type.GetChart()[Types.Flying]);
            Assert.AreEqual(1, type.GetChart()[Types.Poison]);
            Assert.AreEqual(1, type.GetChart()[Types.Ground]);
            Assert.AreEqual(1, type.GetChart()[Types.Rock]);
            Assert.AreEqual(1, type.GetChart()[Types.Bug]);
            Assert.AreEqual(0, type.GetChart()[Types.Ghost]);
            Assert.AreEqual(1, type.GetChart()[Types.Steel]);
            Assert.AreEqual(1, type.GetChart()[Types.Fire]);
            Assert.AreEqual(1, type.GetChart()[Types.Water]);
            Assert.AreEqual(1, type.GetChart()[Types.Grass]);
            Assert.AreEqual(1, type.GetChart()[Types.Electric]);
            Assert.AreEqual(1, type.GetChart()[Types.Psychic]);
            Assert.AreEqual(1, type.GetChart()[Types.Ice]);
            Assert.AreEqual(1, type.GetChart()[Types.Dragon]);
            Assert.AreEqual(1, type.GetChart()[Types.Dark]);
            Assert.AreEqual(1, type.GetChart()[Types.Fairy]);
        }
        [TestMethod]
        public void TestFighting()
        {
            Type type = Fighting.Instance;
            Assert.AreEqual(1, type.GetChart()[Types.Normal]);
            Assert.AreEqual(1, type.GetChart()[Types.Fighting]);
            Assert.AreEqual(2, type.GetChart()[Types.Flying]);
            Assert.AreEqual(1, type.GetChart()[Types.Poison]);
            Assert.AreEqual(1, type.GetChart()[Types.Ground]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Rock]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Bug]);
            Assert.AreEqual(1, type.GetChart()[Types.Ghost]);
            Assert.AreEqual(1, type.GetChart()[Types.Steel]);
            Assert.AreEqual(1, type.GetChart()[Types.Fire]);
            Assert.AreEqual(1, type.GetChart()[Types.Water]);
            Assert.AreEqual(1, type.GetChart()[Types.Grass]);
            Assert.AreEqual(1, type.GetChart()[Types.Electric]);
            Assert.AreEqual(2, type.GetChart()[Types.Psychic]);
            Assert.AreEqual(1, type.GetChart()[Types.Ice]);
            Assert.AreEqual(1, type.GetChart()[Types.Dragon]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Dark]);
            Assert.AreEqual(2, type.GetChart()[Types.Fairy]);
        }
        [TestMethod]
        public void TestFlying()
        {
            Type type = Flying.Instance;
            Assert.AreEqual(1, type.GetChart()[Types.Normal]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Fighting]);
            Assert.AreEqual(1, type.GetChart()[Types.Flying]);
            Assert.AreEqual(1, type.GetChart()[Types.Poison]);
            Assert.AreEqual(0, type.GetChart()[Types.Ground]);
            Assert.AreEqual(2, type.GetChart()[Types.Rock]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Bug]);
            Assert.AreEqual(1, type.GetChart()[Types.Ghost]);
            Assert.AreEqual(1, type.GetChart()[Types.Steel]);
            Assert.AreEqual(1, type.GetChart()[Types.Fire]);
            Assert.AreEqual(1, type.GetChart()[Types.Water]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Grass]);
            Assert.AreEqual(2, type.GetChart()[Types.Electric]);
            Assert.AreEqual(1, type.GetChart()[Types.Psychic]);
            Assert.AreEqual(2, type.GetChart()[Types.Ice]);
            Assert.AreEqual(1, type.GetChart()[Types.Dragon]);
            Assert.AreEqual(1, type.GetChart()[Types.Dark]);
            Assert.AreEqual(1, type.GetChart()[Types.Fairy]);
        }
        [TestMethod]
        public void TestPoison()
        {
            Type type = Poison.Instance;
            Assert.AreEqual(1, type.GetChart()[Types.Normal]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Fighting]);
            Assert.AreEqual(1, type.GetChart()[Types.Flying]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Poison]);
            Assert.AreEqual(2, type.GetChart()[Types.Ground]);
            Assert.AreEqual(1, type.GetChart()[Types.Rock]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Bug]);
            Assert.AreEqual(1, type.GetChart()[Types.Ghost]);
            Assert.AreEqual(1, type.GetChart()[Types.Steel]);
            Assert.AreEqual(1, type.GetChart()[Types.Fire]);
            Assert.AreEqual(1, type.GetChart()[Types.Water]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Grass]);
            Assert.AreEqual(1, type.GetChart()[Types.Electric]);
            Assert.AreEqual(2, type.GetChart()[Types.Psychic]);
            Assert.AreEqual(1, type.GetChart()[Types.Ice]);
            Assert.AreEqual(1, type.GetChart()[Types.Dragon]);
            Assert.AreEqual(1, type.GetChart()[Types.Dark]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Fairy]);
        }
        [TestMethod]
        public void TestGround()
        {
            Type type = Ground.Instance;
            Assert.AreEqual(1, type.GetChart()[Types.Normal]);
            Assert.AreEqual(1, type.GetChart()[Types.Fighting]);
            Assert.AreEqual(1, type.GetChart()[Types.Flying]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Poison]);
            Assert.AreEqual(1, type.GetChart()[Types.Ground]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Rock]);
            Assert.AreEqual(1, type.GetChart()[Types.Bug]);
            Assert.AreEqual(1, type.GetChart()[Types.Ghost]);
            Assert.AreEqual(1, type.GetChart()[Types.Steel]);
            Assert.AreEqual(1, type.GetChart()[Types.Fire]);
            Assert.AreEqual(2, type.GetChart()[Types.Water]);
            Assert.AreEqual(2, type.GetChart()[Types.Grass]);
            Assert.AreEqual(0, type.GetChart()[Types.Electric]);
            Assert.AreEqual(1, type.GetChart()[Types.Psychic]);
            Assert.AreEqual(2, type.GetChart()[Types.Ice]);
            Assert.AreEqual(1, type.GetChart()[Types.Dragon]);
            Assert.AreEqual(1, type.GetChart()[Types.Dark]);
            Assert.AreEqual(1, type.GetChart()[Types.Fairy]);
        }
        [TestMethod]
        public void TestRock()
        {
            Type type = Rock.Instance;
            Assert.AreEqual(0.5, type.GetChart()[Types.Normal]);
            Assert.AreEqual(2, type.GetChart()[Types.Fighting]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Flying]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Poison]);
            Assert.AreEqual(2, type.GetChart()[Types.Ground]);
            Assert.AreEqual(1, type.GetChart()[Types.Rock]);
            Assert.AreEqual(1, type.GetChart()[Types.Bug]);
            Assert.AreEqual(1, type.GetChart()[Types.Ghost]);
            Assert.AreEqual(2, type.GetChart()[Types.Steel]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Fire]);
            Assert.AreEqual(2, type.GetChart()[Types.Water]);
            Assert.AreEqual(2, type.GetChart()[Types.Grass]);
            Assert.AreEqual(1, type.GetChart()[Types.Electric]);
            Assert.AreEqual(1, type.GetChart()[Types.Psychic]);
            Assert.AreEqual(1, type.GetChart()[Types.Ice]);
            Assert.AreEqual(1, type.GetChart()[Types.Dragon]);
            Assert.AreEqual(1, type.GetChart()[Types.Dark]);
            Assert.AreEqual(1, type.GetChart()[Types.Fairy]);
        }
        [TestMethod]
        public void TestBug()
        {
            Type type = Bug.Instance;
            Assert.AreEqual(1, type.GetChart()[Types.Normal]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Fighting]);
            Assert.AreEqual(2, type.GetChart()[Types.Flying]);
            Assert.AreEqual(1, type.GetChart()[Types.Poison]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Ground]);
            Assert.AreEqual(2, type.GetChart()[Types.Rock]);
            Assert.AreEqual(1, type.GetChart()[Types.Bug]);
            Assert.AreEqual(1, type.GetChart()[Types.Ghost]);
            Assert.AreEqual(1, type.GetChart()[Types.Steel]);
            Assert.AreEqual(2, type.GetChart()[Types.Fire]);
            Assert.AreEqual(1, type.GetChart()[Types.Water]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Grass]);
            Assert.AreEqual(1, type.GetChart()[Types.Electric]);
            Assert.AreEqual(1, type.GetChart()[Types.Psychic]);
            Assert.AreEqual(1, type.GetChart()[Types.Ice]);
            Assert.AreEqual(1, type.GetChart()[Types.Dragon]);
            Assert.AreEqual(1, type.GetChart()[Types.Dark]);
            Assert.AreEqual(1, type.GetChart()[Types.Fairy]);
        }
        [TestMethod]
        public void TestGhost()
        {
            Type type = Ghost.Instance;
            Assert.AreEqual(0, type.GetChart()[Types.Normal]);
            Assert.AreEqual(0, type.GetChart()[Types.Fighting]);
            Assert.AreEqual(1, type.GetChart()[Types.Flying]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Poison]);
            Assert.AreEqual(1, type.GetChart()[Types.Ground]);
            Assert.AreEqual(1, type.GetChart()[Types.Rock]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Bug]);
            Assert.AreEqual(2, type.GetChart()[Types.Ghost]);
            Assert.AreEqual(1, type.GetChart()[Types.Steel]);
            Assert.AreEqual(1, type.GetChart()[Types.Fire]);
            Assert.AreEqual(1, type.GetChart()[Types.Water]);
            Assert.AreEqual(1, type.GetChart()[Types.Grass]);
            Assert.AreEqual(1, type.GetChart()[Types.Electric]);
            Assert.AreEqual(1, type.GetChart()[Types.Psychic]);
            Assert.AreEqual(1, type.GetChart()[Types.Ice]);
            Assert.AreEqual(1, type.GetChart()[Types.Dragon]);
            Assert.AreEqual(2, type.GetChart()[Types.Dark]);
            Assert.AreEqual(1, type.GetChart()[Types.Fairy]);
        }
        [TestMethod]
        public void TestSteel()
        {
            Type type = Steel.Instance;
            Assert.AreEqual(0.5, type.GetChart()[Types.Normal]);
            Assert.AreEqual(2, type.GetChart()[Types.Fighting]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Flying]);
            Assert.AreEqual(0, type.GetChart()[Types.Poison]);
            Assert.AreEqual(2, type.GetChart()[Types.Ground]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Rock]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Bug]);
            Assert.AreEqual(1, type.GetChart()[Types.Ghost]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Steel]);
            Assert.AreEqual(2, type.GetChart()[Types.Fire]);
            Assert.AreEqual(1, type.GetChart()[Types.Water]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Grass]);
            Assert.AreEqual(1, type.GetChart()[Types.Electric]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Psychic]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Ice]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Dragon]);
            Assert.AreEqual(1, type.GetChart()[Types.Dark]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Fairy]);
        }
        [TestMethod]
        public void TestFire()
        {
            Type type = Fire.Instance;
            Assert.AreEqual(1, type.GetChart()[Types.Normal]);
            Assert.AreEqual(1, type.GetChart()[Types.Fighting]);
            Assert.AreEqual(1, type.GetChart()[Types.Flying]);
            Assert.AreEqual(1, type.GetChart()[Types.Poison]);
            Assert.AreEqual(2, type.GetChart()[Types.Ground]);
            Assert.AreEqual(2, type.GetChart()[Types.Rock]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Bug]);
            Assert.AreEqual(1, type.GetChart()[Types.Ghost]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Steel]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Fire]);
            Assert.AreEqual(2, type.GetChart()[Types.Water]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Grass]);
            Assert.AreEqual(1, type.GetChart()[Types.Electric]);
            Assert.AreEqual(1, type.GetChart()[Types.Psychic]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Ice]);
            Assert.AreEqual(1, type.GetChart()[Types.Dragon]);
            Assert.AreEqual(1, type.GetChart()[Types.Dark]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Fairy]);
        }
        [TestMethod]
        public void TestWater()
        {
            Type type = Water.Instance;
            Assert.AreEqual(1, type.GetChart()[Types.Normal]);
            Assert.AreEqual(1, type.GetChart()[Types.Fighting]);
            Assert.AreEqual(1, type.GetChart()[Types.Flying]);
            Assert.AreEqual(1, type.GetChart()[Types.Poison]);
            Assert.AreEqual(1, type.GetChart()[Types.Ground]);
            Assert.AreEqual(1, type.GetChart()[Types.Rock]);
            Assert.AreEqual(1, type.GetChart()[Types.Bug]);
            Assert.AreEqual(1, type.GetChart()[Types.Ghost]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Steel]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Fire]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Water]);
            Assert.AreEqual(2, type.GetChart()[Types.Grass]);
            Assert.AreEqual(2, type.GetChart()[Types.Electric]);
            Assert.AreEqual(1, type.GetChart()[Types.Psychic]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Ice]);
            Assert.AreEqual(1, type.GetChart()[Types.Dragon]);
            Assert.AreEqual(1, type.GetChart()[Types.Dark]);
            Assert.AreEqual(1, type.GetChart()[Types.Fairy]);
        }
        [TestMethod]
        public void TestGrass()
        {
            Type type = Grass.Instance;
            Assert.AreEqual(1, type.GetChart()[Types.Normal]);
            Assert.AreEqual(1, type.GetChart()[Types.Fighting]);
            Assert.AreEqual(2, type.GetChart()[Types.Flying]);
            Assert.AreEqual(2, type.GetChart()[Types.Poison]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Ground]);
            Assert.AreEqual(1, type.GetChart()[Types.Rock]);
            Assert.AreEqual(2, type.GetChart()[Types.Bug]);
            Assert.AreEqual(1, type.GetChart()[Types.Ghost]);
            Assert.AreEqual(1, type.GetChart()[Types.Steel]);
            Assert.AreEqual(2, type.GetChart()[Types.Fire]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Water]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Grass]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Electric]);
            Assert.AreEqual(1, type.GetChart()[Types.Psychic]);
            Assert.AreEqual(2, type.GetChart()[Types.Ice]);
            Assert.AreEqual(1, type.GetChart()[Types.Dragon]);
            Assert.AreEqual(1, type.GetChart()[Types.Dark]);
            Assert.AreEqual(1, type.GetChart()[Types.Fairy]);
        }
        [TestMethod]
        public void TestElectric()
        {
            Type type = Electric.Instance;
            Assert.AreEqual(1, type.GetChart()[Types.Normal]);
            Assert.AreEqual(1, type.GetChart()[Types.Fighting]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Flying]);
            Assert.AreEqual(1, type.GetChart()[Types.Poison]);
            Assert.AreEqual(2, type.GetChart()[Types.Ground]);
            Assert.AreEqual(1, type.GetChart()[Types.Rock]);
            Assert.AreEqual(1, type.GetChart()[Types.Bug]);
            Assert.AreEqual(1, type.GetChart()[Types.Ghost]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Steel]);
            Assert.AreEqual(1, type.GetChart()[Types.Fire]);
            Assert.AreEqual(1, type.GetChart()[Types.Water]);
            Assert.AreEqual(1, type.GetChart()[Types.Grass]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Electric]);
            Assert.AreEqual(1, type.GetChart()[Types.Psychic]);
            Assert.AreEqual(1, type.GetChart()[Types.Ice]);
            Assert.AreEqual(1, type.GetChart()[Types.Dragon]);
            Assert.AreEqual(1, type.GetChart()[Types.Dark]);
            Assert.AreEqual(1, type.GetChart()[Types.Fairy]);
        }
        [TestMethod]
        public void TestPsychic()
        {
            Type type = Psychic.Instance;
            Assert.AreEqual(1, type.GetChart()[Types.Normal]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Fighting]);
            Assert.AreEqual(1, type.GetChart()[Types.Flying]);
            Assert.AreEqual(1, type.GetChart()[Types.Poison]);
            Assert.AreEqual(1, type.GetChart()[Types.Ground]);
            Assert.AreEqual(1, type.GetChart()[Types.Rock]);
            Assert.AreEqual(2, type.GetChart()[Types.Bug]);
            Assert.AreEqual(2, type.GetChart()[Types.Ghost]);
            Assert.AreEqual(1, type.GetChart()[Types.Steel]);
            Assert.AreEqual(1, type.GetChart()[Types.Fire]);
            Assert.AreEqual(1, type.GetChart()[Types.Water]);
            Assert.AreEqual(1, type.GetChart()[Types.Grass]);
            Assert.AreEqual(1, type.GetChart()[Types.Electric]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Psychic]);
            Assert.AreEqual(1, type.GetChart()[Types.Ice]);
            Assert.AreEqual(1, type.GetChart()[Types.Dragon]);
            Assert.AreEqual(2, type.GetChart()[Types.Dark]);
            Assert.AreEqual(1, type.GetChart()[Types.Fairy]);
        }
        [TestMethod]
        public void TestIce()
        {
            Type type = Ice.Instance;
            Assert.AreEqual(1, type.GetChart()[Types.Normal]);
            Assert.AreEqual(2, type.GetChart()[Types.Fighting]);
            Assert.AreEqual(1, type.GetChart()[Types.Flying]);
            Assert.AreEqual(1, type.GetChart()[Types.Poison]);
            Assert.AreEqual(1, type.GetChart()[Types.Ground]);
            Assert.AreEqual(2, type.GetChart()[Types.Rock]);
            Assert.AreEqual(1, type.GetChart()[Types.Bug]);
            Assert.AreEqual(1, type.GetChart()[Types.Ghost]);
            Assert.AreEqual(2, type.GetChart()[Types.Steel]);
            Assert.AreEqual(2, type.GetChart()[Types.Fire]);
            Assert.AreEqual(1, type.GetChart()[Types.Water]);
            Assert.AreEqual(1, type.GetChart()[Types.Grass]);
            Assert.AreEqual(1, type.GetChart()[Types.Electric]);
            Assert.AreEqual(1, type.GetChart()[Types.Psychic]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Ice]);
            Assert.AreEqual(1, type.GetChart()[Types.Dragon]);
            Assert.AreEqual(1, type.GetChart()[Types.Dark]);
            Assert.AreEqual(1, type.GetChart()[Types.Fairy]);
        }
        [TestMethod]
        public void TestDragon()
        {
            Type type = Dragon.Instance;
            Assert.AreEqual(1, type.GetChart()[Types.Normal]);
            Assert.AreEqual(1, type.GetChart()[Types.Fighting]);
            Assert.AreEqual(1, type.GetChart()[Types.Flying]);
            Assert.AreEqual(1, type.GetChart()[Types.Poison]);
            Assert.AreEqual(1, type.GetChart()[Types.Ground]);
            Assert.AreEqual(1, type.GetChart()[Types.Rock]);
            Assert.AreEqual(1, type.GetChart()[Types.Bug]);
            Assert.AreEqual(1, type.GetChart()[Types.Ghost]);
            Assert.AreEqual(1, type.GetChart()[Types.Steel]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Fire]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Water]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Grass]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Electric]);
            Assert.AreEqual(1, type.GetChart()[Types.Psychic]);
            Assert.AreEqual(2, type.GetChart()[Types.Ice]);
            Assert.AreEqual(2, type.GetChart()[Types.Dragon]);
            Assert.AreEqual(1, type.GetChart()[Types.Dark]);
            Assert.AreEqual(2, type.GetChart()[Types.Fairy]);
        }
        [TestMethod]
        public void TestDark()
        {
            Type type = Dark.Instance;
            Assert.AreEqual(1, type.GetChart()[Types.Normal]);
            Assert.AreEqual(2, type.GetChart()[Types.Fighting]);
            Assert.AreEqual(1, type.GetChart()[Types.Flying]);
            Assert.AreEqual(1, type.GetChart()[Types.Poison]);
            Assert.AreEqual(1, type.GetChart()[Types.Ground]);
            Assert.AreEqual(1, type.GetChart()[Types.Rock]);
            Assert.AreEqual(2, type.GetChart()[Types.Bug]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Ghost]);
            Assert.AreEqual(1, type.GetChart()[Types.Steel]);
            Assert.AreEqual(1, type.GetChart()[Types.Fire]);
            Assert.AreEqual(1, type.GetChart()[Types.Water]);
            Assert.AreEqual(1, type.GetChart()[Types.Grass]);
            Assert.AreEqual(1, type.GetChart()[Types.Electric]);
            Assert.AreEqual(0, type.GetChart()[Types.Psychic]);
            Assert.AreEqual(1, type.GetChart()[Types.Ice]);
            Assert.AreEqual(1, type.GetChart()[Types.Dragon]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Dark]);
            Assert.AreEqual(2, type.GetChart()[Types.Fairy]);
        }
        [TestMethod]
        public void TestFairy()
        {
            Type type = Fairy.Instance;
            Assert.AreEqual(1, type.GetChart()[Types.Normal]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Fighting]);
            Assert.AreEqual(1, type.GetChart()[Types.Flying]);
            Assert.AreEqual(2, type.GetChart()[Types.Poison]);
            Assert.AreEqual(1, type.GetChart()[Types.Ground]);
            Assert.AreEqual(1, type.GetChart()[Types.Rock]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Bug]);
            Assert.AreEqual(1, type.GetChart()[Types.Ghost]);
            Assert.AreEqual(2, type.GetChart()[Types.Steel]);
            Assert.AreEqual(1, type.GetChart()[Types.Fire]);
            Assert.AreEqual(1, type.GetChart()[Types.Water]);
            Assert.AreEqual(1, type.GetChart()[Types.Grass]);
            Assert.AreEqual(1, type.GetChart()[Types.Electric]);
            Assert.AreEqual(1, type.GetChart()[Types.Psychic]);
            Assert.AreEqual(1, type.GetChart()[Types.Ice]);
            Assert.AreEqual(0, type.GetChart()[Types.Dragon]);
            Assert.AreEqual(0.5, type.GetChart()[Types.Dark]);
            Assert.AreEqual(1, type.GetChart()[Types.Fairy]);
        }
    }
}
