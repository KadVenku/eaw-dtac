using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace eaw_dtac.test.commons
{
    [TestClass]
    public class DamageToArmourUtilityTest
    {
        [TestInitialize]
        public void TestInitialize()
        {
            if (File.Exists(TestUtility.TestData.GameConstantsFile.GetFilePath()))
            {
                File.Delete(TestUtility.TestData.GameConstantsFile.GetFilePath());
            }

            File.WriteAllText(TestUtility.TestData.GameConstantsFile.GetFilePath(),
                TestUtility.TestData.GameConstantsFile.GetFileContent());
        }

        [TestCleanup]
        public void TestCleanup()
        {
            if (File.Exists(TestUtility.TestData.GameConstantsFile.GetFilePath()))
            {
                File.Delete(TestUtility.TestData.GameConstantsFile.GetFilePath());
            }
        }


    }
}
