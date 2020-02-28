using eaw.dtac.data;
using eaw.dtac.data.armour;
using eaw.dtac.data.damage;
using eaw_dtac.test.data.damage;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace eaw_dtac.test.data
{
    [TestClass]
    [TestCategory(TestUtility.TestType.AUTO_GENERATED)]
    public class DamageToArmour_Auto_Test
    {
        [TestMethod]
        [DataRow("DMG_TEST1", "DMG_TEST2", "AMR_TEST1", "AMR_TEST2", false)]
        [DataRow("DMG_TEST1", "DMG_TEST1", "AMR_TEST1", "AMR_TEST1", true)]
        public void EqualsComparison_Test(string dmgId1, string dmgId2, string amrId1, string armId2, bool expected)
        {
            Damage dmgType1 = new Damage(dmgId1);
            Damage dmgType2 = new Damage(dmgId2);
            Armour amrType1 = new Armour(amrId1);
            Armour amrType2 = new Armour(armId2);
            DamageToArmour dmgtoA1 = new DamageToArmour(dmgType1, amrType1);
            DamageToArmour dmgtoA2 = new DamageToArmour(dmgType2, amrType2);
            Assert.AreEqual(expected, dmgtoA1.Equals(dmgtoA2));
        }

        [TestMethod]
        [DataRow("DMG_TEST1", "AMR_TEST1", false)]
        public void EqualsComparison_Test_Null(string dmgId1, string amrId1, bool expected)
        {
            Damage dmgType1 = new Damage(dmgId1);
            Armour amrType1 = new Armour(amrId1);
            DamageToArmour dmgtoA1 = new DamageToArmour(dmgType1, amrType1);
            Assert.AreEqual(expected, dmgtoA1.Equals(null));
        }
    }
}
