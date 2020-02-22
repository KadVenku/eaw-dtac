using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using eaw.dtac.commons.damage;
using eaw.dtac.data.damage;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace eaw_dtac.test.commons.damage
{
    [TestClass]
    [TestCategory(TestUtility.TEST_TYPE_UTILITY)]
    public class DamageUtilityTest
    {
        [TestClass]
        [TestCategory(TestUtility.TEST_TYPE_UTILITY)]
        public class EaWTest
        {
            [TestMethod]
            public void Create_Test()
            {
                ReadOnlyCollection<DamageType> damageTypes = DamageUtility.EaW.GetAllHardCodedTypes();
                Assert.AreEqual(17, damageTypes.Count);
            }

            [TestMethod]
            [DataRow("Damage_Normal", true)]
            [DataRow("Damage_Force_Whirlwind", true)]
            [DataRow("Damage_Force_Telekinesis", true)]
            [DataRow("Damage_Force_Lightning", true)]
            [DataRow("Damage_Force_Corruption", true)]
            [DataRow("Damage_Hard_Point_Self_Destruct", true)]
            [DataRow("Damage_Fire", true)]
            [DataRow("Damage_Cable_Attack", true)]
            [DataRow("Damage_Explosion", true)]
            [DataRow("Damage_Asteroid", true)]
            [DataRow("Damage_Cable_Attack_Deployed", true)]
            [DataRow("Damage_Normal_Deployed", true)]
            [DataRow("Damage_Vehicle_Thief", true)]
            [DataRow("Damage_Crush", true)]
            [DataRow("Damage_Eat", true)]
            [DataRow("Damage_Redirected", true)]
            [DataRow("Damage_Wampa", true)]
            [DataRow("DMG_WEIRD", false)]
            [DataRow("Damage!", false)]
            public void IsBuiltinType_TestOverloadDamageType(string dmgTypeId, bool expectedValue)
            {
                Assert.AreEqual(expectedValue, DamageUtility.EaW.IsBuiltinType(new DamageType(dmgTypeId)));
            }

            [TestMethod]
            [DataRow("Damage_Normal", true)]
            [DataRow("Damage_Force_Whirlwind", true)]
            [DataRow("Damage_Force_Telekinesis", true)]
            [DataRow("Damage_Force_Lightning", true)]
            [DataRow("Damage_Force_Corruption", true)]
            [DataRow("Damage_Hard_Point_Self_Destruct", true)]
            [DataRow("Damage_Fire", true)]
            [DataRow("Damage_Cable_Attack", true)]
            [DataRow("Damage_Explosion", true)]
            [DataRow("Damage_Asteroid", true)]
            [DataRow("Damage_Cable_Attack_Deployed", true)]
            [DataRow("Damage_Normal_Deployed", true)]
            [DataRow("Damage_Vehicle_Thief", true)]
            [DataRow("Damage_Crush", true)]
            [DataRow("Damage_Eat", true)]
            [DataRow("Damage_Redirected", true)]
            [DataRow("Damage_Wampa", true)]
            [DataRow("DMG_WEIRD", false)]
            [DataRow("Damage!", false)]
            [DataRow(null, false)]
            [DataRow("      ", false)]
            public void IsBuiltinType_TestOverloadString(string dmgTypeId, bool expectedValue)
            {
                Assert.AreEqual(expectedValue, DamageUtility.EaW.IsBuiltinType(dmgTypeId));
            }
        }

        [TestClass]
        [TestCategory(TestUtility.TEST_TYPE_UTILITY)]
        public class FoCTest
        {
            [TestMethod]
            public void Create_Test()
            {
                ReadOnlyCollection<DamageType> damageTypes = DamageUtility.FoC.GetAllHardCodedTypes();
                Assert.AreEqual(20, damageTypes.Count);
            }

            [TestMethod]
            [DataRow("Damage_Normal", true)]
            [DataRow("Damage_Force_Whirlwind", true)]
            [DataRow("Damage_Force_Telekinesis", true)]
            [DataRow("Damage_Force_Lightning", true)]
            [DataRow("Damage_Force_Corruption", true)]
            [DataRow("Damage_Hard_Point_Self_Destruct", true)]
            [DataRow("Damage_Fire", true)]
            [DataRow("Damage_Cable_Attack", true)]
            [DataRow("Damage_Explosion", true)]
            [DataRow("Damage_Asteroid", true)]
            [DataRow("Damage_Cable_Attack_Deployed", true)]
            [DataRow("Damage_Normal_Deployed", true)]
            [DataRow("Damage_Vehicle_Thief", true)]
            [DataRow("Damage_Crush", true)]
            [DataRow("Damage_Eat", true)]
            [DataRow("Damage_Redirected", true)]
            [DataRow("Damage_Wampa", true)]
            [DataRow("Damage_Infection", true)]
            [DataRow("Damage_Remote_Bomb", true)]
            [DataRow("Damage_Drain_Life", true)]
            [DataRow("DMG_WEIRD", false)]
            [DataRow("Damage!", false)]
            public void IsBuiltinType_TestOverloadDamageType(string dmgTypeId, bool expectedValue)
            {
                Assert.AreEqual(expectedValue, DamageUtility.FoC.IsBuiltinType(new DamageType(dmgTypeId)));
            }

            [TestMethod]
            [DataRow("Damage_Normal", true)]
            [DataRow("Damage_Force_Whirlwind", true)]
            [DataRow("Damage_Force_Telekinesis", true)]
            [DataRow("Damage_Force_Lightning", true)]
            [DataRow("Damage_Force_Corruption", true)]
            [DataRow("Damage_Hard_Point_Self_Destruct", true)]
            [DataRow("Damage_Fire", true)]
            [DataRow("Damage_Cable_Attack", true)]
            [DataRow("Damage_Explosion", true)]
            [DataRow("Damage_Asteroid", true)]
            [DataRow("Damage_Cable_Attack_Deployed", true)]
            [DataRow("Damage_Normal_Deployed", true)]
            [DataRow("Damage_Vehicle_Thief", true)]
            [DataRow("Damage_Crush", true)]
            [DataRow("Damage_Eat", true)]
            [DataRow("Damage_Redirected", true)]
            [DataRow("Damage_Wampa", true)]
            [DataRow("Damage_Infection", true)]
            [DataRow("Damage_Remote_Bomb", true)]
            [DataRow("Damage_Drain_Life", true)]
            [DataRow("DMG_WEIRD", false)]
            [DataRow("Damage!", false)]
            [DataRow(null, false)]
            [DataRow("      ", false)]
            public void IsBuiltinType_TestOverloadString(string dmgTypeId, bool expectedValue)
            {
                Assert.AreEqual(expectedValue, DamageUtility.FoC.IsBuiltinType(dmgTypeId));
            }
        }
    }
}
