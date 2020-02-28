using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using eaw.dtac.commons.armour;
using eaw.dtac.data.armour;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace eaw_dtac.test.commons.armour
{
    [TestClass]
    [TestCategory(TestUtility.TestType.UTILITY)]
    public class ArmourUtilityTest
    {
        private const string ARMOUR_STRING =
            "	\t\tArmor_Default, \n\t\tShield_Default,\n        Shield_Capital,\n        Shield_Frigate,\n        Shield_Corvette,\n        Shield_Fighter,\n        Shield_Tank,\t\t <!-- T2B and 2M -->\n        Shield_SSD,\t\t\t<!-- Shield for Executor --> \n\t\tArmor_Transport, \n\t\tArmor_Fighter, \n\t\tArmor_Hero_Transport,\n\t\tArmor_Missile_Cruiser, \n\t\tArmor_Corellian_Corvette, \n\t\tArmor_Tartan, \n\t\tArmor_Interdictor,\n\t\tArmor_Corellian_Gunboat, \n\t\tArmor_Nebulon_B,\n\t\tArmor_Acclamator,\n\t\tArmor_Pirate_Frigate,\n\t\tArmor_Satellite,\n\t\tArmor_Frigate, \n\t\tArmor_Victory_Class, \n\t\tArmor_Assault_Frigate, \n\t\tArmor_Calamari_Cruiser, \n\t\tArmor_Star_Destroyer, \n\t\tArmor_ATST, \n\t\tArmor_Station, \n\t\tArmor_MPTL, \n\t\tArmor_Infantry, \n\t\tArmor_Mauler, \n\t\tArmor_Hero, \n\t\tArmor_Vehicle_LT, <!-- lightly armored vehicles like swamp speeder, land speeder, and pirate skiff -->\n\t\tArmor_Vehicle, \n\t\tArmor_2M,\n\t\tArmor_T2B,\n\t\tArmor_SPMAT,\n\t\tArmor_ATAA,\n\t\tArmor_T4B, \n\t\tArmor_Turret,\n\t\tArmor_Speeder,\t\t<!-- snowspeeder and bombers -->\n\t\tArmor_Structure, \n\t\tArmor_Wall, \n\t\tArmor_ATAT, \n\t\tArmor_Bomber,\n\t\tArmor_Scout_Bike,\n\t\tArmor_Juggernaut,\n\t\tArmor_Vengeance,\n\t\tArmor_Dark_Trooper,\n\t\tArmor_MC30_Frigate,\n\t\tArmor_Vornskr,\n\t\tArmor_Destroyer_Droid,\n\t\tArmor_Bunker\t\t<!-- Bunkers and pillboxes -->\n\t\tArmor_SSD\t\t\t<!-- Armor for the Executor and other SSDs-->\n\t\t\t\t";

        [TestMethod]
        public void ParseFromString_TestNullEmptyOrWhitespace()
        {
            List<Armour> l0 = ArmourUtility.ParseFromString(null);
            Assert.IsNotNull(l0);
            Assert.IsFalse(l0.Any());
            List<Armour> l1 = ArmourUtility.ParseFromString(string.Empty);
            Assert.IsNotNull(l1);
            Assert.IsFalse(l1.Any());
            List<Armour> l2 = ArmourUtility.ParseFromString("\n \t\r\n");
            Assert.IsNotNull(l2);
            Assert.IsFalse(l2.Any());
        }

        [TestMethod]
        public void ParseFromString_Test()
        {
            List<Armour> l = ArmourUtility.ParseFromString(ARMOUR_STRING);
            Assert.IsNotNull(l);
            Assert.IsTrue(l.Any());
            Assert.AreEqual(53, l.Count);
        }

        [TestClass]
        [TestCategory(TestUtility.TestType.UTILITY)]
        public class EaW
        {
            [TestMethod]
            public void Create_Test()
            {
                ReadOnlyCollection<Armour> damageTypes = ArmourUtility.EaW.GetAllHardCodedTypes();
                Assert.AreEqual(0, damageTypes.Count);
            }

            [TestMethod]
            [DataRow("Damage_Normal", false)]
            [DataRow("Damage_Force_Whirlwind", false)]
            public void IsBuiltinType_TestOverloadArmourType(string dmgTypeId, bool expectedValue)
            {
                Assert.AreEqual(expectedValue, ArmourUtility.EaW.IsBuiltinType(new Armour(dmgTypeId)));
            }

            [TestMethod]
            [DataRow("Damage_Normal", false)]
            [DataRow("Damage_Force_Whirlwind", false)]
            [DataRow(null, false)]
            [DataRow("      ", false)]
            public void IsBuiltinType_TestOverloadString(string dmgTypeId, bool expectedValue)
            {
                Assert.AreEqual(expectedValue, ArmourUtility.EaW.IsBuiltinType(dmgTypeId));
            }
        }

        [TestClass]
        [TestCategory(TestUtility.TestType.UTILITY)]
        public class FoC
        {
            [TestMethod]
            public void Create_Test()
            {
                ReadOnlyCollection<Armour> damageTypes = ArmourUtility.FoC.GetAllHardCodedTypes();
                Assert.AreEqual(0, damageTypes.Count);
            }

            [TestMethod]
            [DataRow("Damage_Normal", false)]
            [DataRow("Damage_Force_Whirlwind", false)]
            public void IsBuiltinType_TestOverloadArmourType(string dmgTypeId, bool expectedValue)
            {
                Assert.AreEqual(expectedValue, ArmourUtility.FoC.IsBuiltinType(new Armour(dmgTypeId)));
            }

            [TestMethod]
            [DataRow("Damage_Normal", false)]
            [DataRow("Damage_Force_Whirlwind", false)]
            [DataRow(null, false)]
            [DataRow("      ", false)]
            public void IsBuiltinType_TestOverloadString(string dmgTypeId, bool expectedValue)
            {
                Assert.AreEqual(expectedValue, ArmourUtility.FoC.IsBuiltinType(dmgTypeId));
            }
        }
    }
}
