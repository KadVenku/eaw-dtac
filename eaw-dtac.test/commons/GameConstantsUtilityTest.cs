using System.IO;
using eaw.dtac.commons;
using eaw.dtac.commons.game;
using eaw.dtac.data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace eaw_dtac.test.commons
{
    [TestClass]
    [TestCategory(TestUtility.TestType.UTILITY)]
    public class GameConstantsUtilityTest
    {
        [TestInitialize]
        public void TestInitialize()
        {
            if (File.Exists(TestUtility.TestData.GameConstantsFile.GetFilePath()))
            {
                File.Delete(TestUtility.TestData.GameConstantsFile.GetFilePath());
            }

            File.WriteAllText(TestUtility.TestData.GameConstantsFile.GetFilePath(), TestUtility.TestData.GameConstantsFile.GetFileContent());
        }

        [TestCleanup]
        public void TestCleanup()
        {
            if (File.Exists(TestUtility.TestData.GameConstantsFile.GetFilePath()))
            {
                File.Delete(TestUtility.TestData.GameConstantsFile.GetFilePath());
            }
        }

        [TestMethod]
        public void LoadFromGameConstantsFile_Test()
        {
            GlobalStore.GAME_MODE = GameMode.EaW;
            GameConstantsUtility.LoadFromGameConstantsFile(TestUtility.TestData.GameConstantsFile.GetFilePath());
            Assert.IsTrue(GlobalStore.GAME_CONSTANTS_LOADED);
        }

        [TestMethod]
        public void SaveToGameConstantsFile_Test()
        {
            GlobalStore.GAME_MODE = GameMode.EaW;
            GameConstantsUtility.LoadFromGameConstantsFile(TestUtility.TestData.GameConstantsFile.GetFilePath());
            Assert.IsTrue(GlobalStore.GAME_CONSTANTS_LOADED);
            GameConstantsUtility.SaveToGameConstantsFile(TestUtility.TestData.GameConstantsFile.GetFilePath(), true);
        }
    }
}