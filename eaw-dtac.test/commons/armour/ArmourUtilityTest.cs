using System.Collections.ObjectModel;
using eaw.dtac.commons.armour;
using eaw.dtac.data.armour;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace eaw_dtac.test.commons.armour
{
    [TestClass]
    [TestCategory(TestUtility.TEST_TYPE_UTILITY)]
    public class ArmourUtilityTest
    {
        [TestClass]
        [TestCategory(TestUtility.TEST_TYPE_UTILITY)]
        public class EaW
        {
            [TestMethod]
            public void Create_Test()
            {
                ReadOnlyCollection<ArmourType> damageTypes = ArmourUtility.EaW.GetAllHardCodedTypes();
                Assert.AreEqual(0, damageTypes.Count);
            }

            [TestMethod]
            [DataRow("Damage_Normal", false)]
            [DataRow("Damage_Force_Whirlwind", false)]
            public void IsBuiltinType_TestOverloadArmourType(string dmgTypeId, bool expectedValue)
            {
                Assert.AreEqual(expectedValue, ArmourUtility.EaW.IsBuiltinType(new ArmourType(dmgTypeId)));
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
        [TestCategory(TestUtility.TEST_TYPE_UTILITY)]
        public class FoC
        {
            [TestMethod]
            public void Create_Test()
            {
                ReadOnlyCollection<ArmourType> damageTypes = ArmourUtility.FoC.GetAllHardCodedTypes();
                Assert.AreEqual(0, damageTypes.Count);
            }

            [TestMethod]
            [DataRow("Damage_Normal", false)]
            [DataRow("Damage_Force_Whirlwind", false)]
            public void IsBuiltinType_TestOverloadArmourType(string dmgTypeId, bool expectedValue)
            {
                Assert.AreEqual(expectedValue, ArmourUtility.FoC.IsBuiltinType(new ArmourType(dmgTypeId)));
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
