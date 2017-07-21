using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EasyGathering.settings;

namespace Tests
{
    [TestClass]
    public class SettingsManagerTest
    {
        [TestMethod]
        public void SaveLoadSettings()
        {
            int GearSlot = 10;
            Settings s = new Settings();
            s.MinerGearSlot = GearSlot;
            SettingsManager.save("TestSettings.bin", s);

            Settings ns = SettingsManager.load("TestSettings.bin");
            Assert.AreEqual(GearSlot, ns.MinerGearSlot, 0, "Failed to save and load MinerGearSlot!");
        }

        [TestMethod]
        public void LoadBlank()
        {
            Settings newBlank = SettingsManager.load("THISDOESNOTEXIST.bin");
            Assert.AreEqual(-1, newBlank.MinerGearSlot, 0, "Failed to get a blank settings if file does not exist!");
        }
    }
}
