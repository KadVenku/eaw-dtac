using System;
using eaw.dtac.data.damage;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace eaw_dtac.test.data.damage
{
    [TestClass]
    [TestCategory(TestUtility.TestType.AUTO_GENERATED)]
    public class DamageType_Auto_Test
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_NullArgument()
        {
            Damage damageType1 = new Damage(null);
        }

        [TestMethod]
        [DataRow("TEST1", "TEST1", true)]
        [DataRow("Test2", "TEST2", true)]
        [DataRow("TEST1", "TEST2", false)]
        [DataRow("TEST2", "Test1", false)]
        public void EqualsComparison(string damageTypeConstructor1, string damageTypeConstructor2, bool expectedResult)
        {
            Damage damageType1 = new Damage(damageTypeConstructor1);
            Damage damageType2 = new Damage(damageTypeConstructor2);
            Assert.AreEqual(expectedResult, damageType1.Equals(damageType2));
        }

        [TestMethod]
        [DataRow("TEST1", "TEST1", true)]
        [DataRow("Test2", "TEST2", true)]
        [DataRow("TEST1", "TEST2", false)]
        [DataRow("TEST2", "Test1", false)]
        public void EqualsComparison_ObjectSuccess(string damageTypeConstructor1, string damageTypeConstructor2,
            bool expectedResult)
        {
            Damage damageType1 = new Damage(damageTypeConstructor1);
            object damageType2 = new Damage(damageTypeConstructor2);
            Assert.AreEqual(expectedResult, damageType1.Equals(damageType2));
        }

        [TestMethod]
        [DataRow("TEST1", "TEST1")]
        [DataRow("Test2", "TEST2")]
        [DataRow("TEST1", "TEST2")]
        [DataRow("TEST2", "Test1")]
        public void EqualsComparison_ObjectFailure(string damageTypeConstructor1, string damageTypeConstructor2)
        {
            Damage damageType1 = new Damage(damageTypeConstructor1);
            object damageType2 = damageTypeConstructor2;
            Assert.IsFalse(damageType1.Equals(damageType2));
        }

        [TestMethod]
        [DataRow("TEST1")]
        [DataRow("Test2")]
        public void EqualsComparison_Null(string damageTypeConstructor1)
        {
            Damage damageType1 = new Damage(damageTypeConstructor1);
            Assert.IsFalse(damageType1.Equals(null));
        }

        [TestMethod]
        [DataRow("TEST1")]
        [DataRow("Test2")]
        public void EqualsComparison_Reference(string damageTypeConstructor1)
        {
            Damage damageType1 = new Damage(damageTypeConstructor1);
            Damage damageType2 = damageType1;
            Assert.IsTrue(damageType1.Equals(damageType2));
        }

        [TestMethod]
        [DataRow("TEST1")]
        [DataRow("Test2")]
        public void EqualsComparison_ReferenceObject(string damageTypeConstructor1)
        {
            Damage damageType1 = new Damage(damageTypeConstructor1);
            object damageType2 = damageType1;
            Assert.IsTrue(damageType1.Equals(damageType2));
        }

        [TestMethod]
        [DataRow("TEST1", "TEST1", true)]
        [DataRow("Test2", "TEST2", true)]
        [DataRow("TEST1", "TEST2", false)]
        [DataRow("TEST2", "Test1", false)]
        public void GetHashCode(string damageTypeConstructor1, string damageTypeConstructor2,
            bool expectedResult)
        {
            Damage damageType1 = new Damage(damageTypeConstructor1);
            Damage damageType2 = new Damage(damageTypeConstructor2);
            Assert.AreEqual(expectedResult, damageType1.GetHashCode() == damageType2.GetHashCode());
        }

        [TestMethod]
        [DataRow("TEST1", "TEST1", true)]
        [DataRow("Test2", "TEST2", true)]
        [DataRow("TEST1", "TEST2", false)]
        [DataRow("TEST2", "Test1", false)]
        public void OpEquality(string damageTypeConstructor1, string damageTypeConstructor2, bool expectedResult)
        {
            Damage damageType1 = new Damage(damageTypeConstructor1);
            Damage damageType2 = new Damage(damageTypeConstructor2);
            Assert.AreEqual(expectedResult, damageType1 == damageType2);
        }
        [TestMethod]
        [DataRow("TEST1", "TEST1", false)]
        [DataRow("Test2", "TEST2", false)]
        [DataRow("TEST1", "TEST2", true)]
        [DataRow("TEST2", "Test1", true)]
        public void OpInequality(string damageTypeConstructor1, string damageTypeConstructor2, bool expectedResult)
        {
            Damage damageType1 = new Damage(damageTypeConstructor1);
            Damage damageType2 = new Damage(damageTypeConstructor2);
            Assert.AreEqual(expectedResult, damageType1 != damageType2);
        }
    }
}
