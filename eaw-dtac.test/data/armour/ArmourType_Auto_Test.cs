using System;
using eaw.dtac.data.armour;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace eaw_dtac.test.data.armour
{
    [TestClass]
    [TestCategory(TestUtility.TEST_TYPE_AUTO_GENERATED)]
    public class ArmourType_Auto_Test
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_NullArgument()
        {
            ArmourType armourType1 = new ArmourType(null);
        }

        [TestMethod]
        [DataRow("TEST1", "TEST1", true)]
        [DataRow("Test2", "TEST2", true)]
        [DataRow("TEST1", "TEST2", false)]
        [DataRow("TEST2", "Test1", false)]
        public void EqualsComparison(string armourTypeConstructor1, string armourTypeConstructor2, bool expectedResult)
        {
            ArmourType armourType1 = new ArmourType(armourTypeConstructor1);
            ArmourType armourType2 = new ArmourType(armourTypeConstructor2);
            Assert.AreEqual(expectedResult, armourType1.Equals(armourType2));
        }

        [TestMethod]
        [DataRow("TEST1", "TEST1", true)]
        [DataRow("Test2", "TEST2", true)]
        [DataRow("TEST1", "TEST2", false)]
        [DataRow("TEST2", "Test1", false)]
        public void EqualsComparison_ObjectSuccess(string armourTypeConstructor1, string armourTypeConstructor2,
            bool expectedResult)
        {
            ArmourType armourType1 = new ArmourType(armourTypeConstructor1);
            object armourType2 = new ArmourType(armourTypeConstructor2);
            Assert.AreEqual(expectedResult, armourType1.Equals(armourType2));
        }

        [TestMethod]
        [DataRow("TEST1", "TEST1")]
        [DataRow("Test2", "TEST2")]
        [DataRow("TEST1", "TEST2")]
        [DataRow("TEST2", "Test1")]
        public void EqualsComparison_ObjectFailure(string armourTypeConstructor1, string armourTypeConstructor2)
        {
            ArmourType armourType1 = new ArmourType(armourTypeConstructor1);
            object armourType2 = armourTypeConstructor2;
            Assert.IsFalse(armourType1.Equals(armourType2));
        }

        [TestMethod]
        [DataRow("TEST1")]
        [DataRow("Test2")]
        public void EqualsComparison_Null(string armourTypeConstructor1)
        {
            ArmourType armourType1 = new ArmourType(armourTypeConstructor1);
            Assert.IsFalse(armourType1.Equals(null));
        }

        [TestMethod]
        [DataRow("TEST1")]
        [DataRow("Test2")]
        public void EqualsComparison_Reference(string armourTypeConstructor1)
        {
            ArmourType armourType1 = new ArmourType(armourTypeConstructor1);
            ArmourType armourType2 = armourType1;
            Assert.IsTrue(armourType1.Equals(armourType2));
        }

        [TestMethod]
        [DataRow("TEST1")]
        [DataRow("Test2")]
        public void EqualsComparison_ReferenceObject(string armourTypeConstructor1)
        {
            ArmourType armourType1 = new ArmourType(armourTypeConstructor1);
            object armourType2 = armourType1;
            Assert.IsTrue(armourType1.Equals(armourType2));
        }

        [TestMethod]
        [DataRow("TEST1", "TEST1", true)]
        [DataRow("Test2", "TEST2", true)]
        [DataRow("TEST1", "TEST2", false)]
        [DataRow("TEST2", "Test1", false)]
        public void GetHashCode(string armourTypeConstructor1, string armourTypeConstructor2,
            bool expectedResult)
        {
            ArmourType armourType1 = new ArmourType(armourTypeConstructor1);
            ArmourType armourType2 = new ArmourType(armourTypeConstructor2);
            Assert.AreEqual(expectedResult, armourType1.GetHashCode() == armourType2.GetHashCode());
        }

        [TestMethod]
        [DataRow("TEST1", "TEST1", true)]
        [DataRow("Test2", "TEST2", true)]
        [DataRow("TEST1", "TEST2", false)]
        [DataRow("TEST2", "Test1", false)]
        public void OpEquality(string armourTypeConstructor1, string armourTypeConstructor2, bool expectedResult)
        {
            ArmourType armourType1 = new ArmourType(armourTypeConstructor1);
            ArmourType armourType2 = new ArmourType(armourTypeConstructor2);
            Assert.AreEqual(expectedResult, armourType1 == armourType2);
        }
        [TestMethod]
        [DataRow("TEST1", "TEST1", false)]
        [DataRow("Test2", "TEST2", false)]
        [DataRow("TEST1", "TEST2", true)]
        [DataRow("TEST2", "Test1", true)]
        public void OpInequality(string armourTypeConstructor1, string armourTypeConstructor2, bool expectedResult)
        {
            ArmourType armourType1 = new ArmourType(armourTypeConstructor1);
            ArmourType armourType2 = new ArmourType(armourTypeConstructor2);
            Assert.AreEqual(expectedResult, armourType1 != armourType2);
        }
    }
}
