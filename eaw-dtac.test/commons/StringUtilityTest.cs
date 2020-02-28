using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using eaw.dtac.commons;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace eaw_dtac.test.commons
{
    [TestClass]
    [TestCategory(TestUtility.TestType.UTILITY)]
    public class StringUtilityTest
    {
        private const string TEST_STRING_00 =
            "\t\tDamage_Default, \n\t\tDamage_ATST,\n\t\tDamage_ATAT,\n\t\tDamage_Fighter,\n\t\tDamage_Assault_Frigate,\n\t\tDamage_Diamond_Missile, \n\t\tDamage_IonCannon, \n\t\tDamage_IonCannon_LRG, \n\t\tDamage_Proton_Torp, \n\t\tDamage_Proton_Torp_Light, \n\t\tDamage_Con_Missile, \n\t\tDamage_Turbolaser, \n\t\tDamage_Blaster_Hand, \n\t\tDamage_PLEX, \n\t\tDamage_Sniper, \n\t\tDamage_Lightning, \n\t\tDamage_Lightsaber, \n\t\tDamage_ThermDet, \n\t\tDamage_Wookiee, \n\t\tDamage_Jawa, \n\t\tDamage_StickyBomb,\n\t\tDamage_Hero_StickyBomb,\n\t\tDamage_Blaster_Cannon, \n\t\tDamage_Flak_Pod, \n\t\tDamage_AI_Turret, \n\t\tDamage_AV_Turret,\n\t\tDamage_TIE_Mauler,\n\t\tDamage_2M_Repulsortank,\n\t\tDamage_Laser_GRND, \n\t\tDamage_Proton_GRND, \n\t\tDamage_Con_Missile_GRND, \n\t\tDamage_Con_Missile_T4B,\n\t\tDamage_Con_Grenade, \n\t\tDamage_SPMAT_Grenade, \n\t\tDamage_Bomb, \n\t\tDamage_Hyper_Gun, \n\t\tDamage_Ion_Planet,\n\t\tDamage_Rancor, \n\t\tDamage_Laser_T4B,\n\t\tDamage_Blaster_T2B,\n\t\tDamage_Star_Destroyer,\n\t\tDamage_Calamari_Cruiser,\n\t\tDamage_Station_Laser,\n\t\tDamage_Station_Turbolaser,\n\t\tDamage_Acclamator,\n\t\tDamage_Acclamator_TL,\n\t\tDamage_Interdictor,\n\t\tDamage_Victory_SD,\n\t\tDamage_IPV,\n\t\tDamage_Nebulon_B,\n\t\tDamage_Tartan_Cruiser,\n\t\tDamage_Corellian_Corvette,\n\t\tDamage_Corellian_Gunboat,\n\t\tDamage_Turbo_GRND,\n\t\tDamage_Wall_Destruction,\n\t\tDamage_Self_Destruct,\n        Damage_AWing,\n\t\tDamage_Force_Pike,\n\t\tDamage_BugBite,\n\t\tDamage_StarBase_Self_Destruct,\n\t\tDamage_Sonic_Blaster,\n\t\tDamage_Airspeeder,\n\t\tDamage_Disruptor_Hand,\n\t\tDamage_Pulse_Cannon,\n\t\tDamage_Ion_Cannon_Land,\n\t\tDamage_Droideka_Blaster,\n\t\tDamage_Juggernaut_Turret,\n\t\tDamage_DarkTrooper1_Sword,\n\t\tDamage_DarkTrooper2_Cannon,\n\t\tDamage_Plant_Spike,\n\t\tDamage_Pulse_Cannon_Tank,\n\t\tDamage_Krayt_Damage_Blast,\n\t\tDamage_Mass_Driver_Turret,\n\t\tDamage_Vornskr_Bite,\n\t\tDamage_Exploding_Barrel,\n\t\tDamage_Tyber_Shotgun,\n\t\tDamage_Mass_Driver_Space,\n\t\tDamage_MDU_Rocket,\n\t\tDamage_MDU_Grenade,\n\t\t\n\t\t\n\t\t<!-- PLEASE add your new damage types ABOVE this point.\n\t\t\t The damage types below are from hard-coded damage enumeration. You can specify Armor type for them if you want\n\t\t\t (and understand how and where these are applied).\n\t\t\t In the future, we will merge two system together, but for now we have to have this work-around. \n\t\t\t -Oksana\t\t\t-->\n\t\tDamage_Normal,\n\t\tDamage_Force_Whirlwind,\n\t\tDamage_Force_Telekinesis,\n\t\tDamage_Force_Lightning,\n\t\tDamage_Force_Corruption,\n\t\tDamage_Hard_Point_Self_Destruct,\n\t\tDamage_Fire,\n\t\tDamage_Cable_Attack,\n\t\tDamage_Explosion,\n\t\tDamage_Asteroid,\n\t\tDamage_Cable_Attack_Deployed,\n\t\tDamage_Normal_Deployed,\n\t\tDamage_Vehicle_Thief,\n\t\tDamage_Crush,\n\t\tDamage_Eat,\n\t\tDamage_Redirected,\n\t\tDamage_Wampa,\n        Damage_Infection,\n\t\tDamage_Remote_Bomb,\n\t\tDamage_Drain_Life,\n\n\t\t<!-- DO NOT ADD new damage types after this point -->";

        private readonly List<string> _testList00 = new List<string>
        {
            "Damage_Default",
            "Damage_ATST",
            "Damage_ATAT",
            "Damage_Fighter",
            "Damage_Assault_Frigate",
            "Damage_Diamond_Missile",
            "Damage_IonCannon",
            "Damage_IonCannon_LRG",
            "Damage_Proton_Torp",
            "Damage_Proton_Torp_Light",
            "Damage_Con_Missile",
            "Damage_Turbolaser",
            "Damage_Blaster_Hand",
            "Damage_PLEX",
            "Damage_Sniper",
            "Damage_Lightning",
            "Damage_Lightsaber",
            "Damage_ThermDet",
            "Damage_Wookiee",
            "Damage_Jawa",
            "Damage_StickyBomb",
            "Damage_Hero_StickyBomb",
            "Damage_Blaster_Cannon",
            "Damage_Flak_Pod",
            "Damage_AI_Turret",
            "Damage_AV_Turret",
            "Damage_TIE_Mauler",
            "Damage_2M_Repulsortank",
            "Damage_Laser_GRND",
            "Damage_Proton_GRND",
            "Damage_Con_Missile_GRND",
            "Damage_Con_Missile_T4B",
            "Damage_Con_Grenade",
            "Damage_SPMAT_Grenade",
            "Damage_Bomb",
            "Damage_Hyper_Gun",
            "Damage_Ion_Planet",
            "Damage_Rancor",
            "Damage_Laser_T4B",
            "Damage_Blaster_T2B",
            "Damage_Star_Destroyer",
            "Damage_Calamari_Cruiser",
            "Damage_Station_Laser",
            "Damage_Station_Turbolaser",
            "Damage_Acclamator",
            "Damage_Acclamator_TL",
            "Damage_Interdictor",
            "Damage_Victory_SD",
            "Damage_IPV",
            "Damage_Nebulon_B",
            "Damage_Tartan_Cruiser",
            "Damage_Corellian_Corvette",
            "Damage_Corellian_Gunboat",
            "Damage_Turbo_GRND",
            "Damage_Wall_Destruction",
            "Damage_Self_Destruct",
            "Damage_AWing",
            "Damage_Force_Pike",
            "Damage_BugBite",
            "Damage_StarBase_Self_Destruct",
            "Damage_Sonic_Blaster",
            "Damage_Airspeeder",
            "Damage_Disruptor_Hand",
            "Damage_Pulse_Cannon",
            "Damage_Ion_Cannon_Land",
            "Damage_Droideka_Blaster",
            "Damage_Juggernaut_Turret",
            "Damage_DarkTrooper1_Sword",
            "Damage_DarkTrooper2_Cannon",
            "Damage_Plant_Spike",
            "Damage_Pulse_Cannon_Tank",
            "Damage_Krayt_Damage_Blast",
            "Damage_Mass_Driver_Turret",
            "Damage_Vornskr_Bite",
            "Damage_Exploding_Barrel",
            "Damage_Tyber_Shotgun",
            "Damage_Mass_Driver_Space",
            "Damage_MDU_Rocket",
            "Damage_MDU_Grenade",
            "<!-- PLEASE add your new damage types ABOVE this point.\n\t\t\t The damage types below are from hard-coded damage enumeration. You can specify Armor type for them if you want\n\t\t\t (and understand how and where these are applied).\n\t\t\t In the future",
            "we will merge two system together",
            "but for now we have to have this work-around. \n\t\t\t -Oksana\t\t\t-->\n\t\tDamage_Normal",
            "Damage_Force_Whirlwind",
            "Damage_Force_Telekinesis",
            "Damage_Force_Lightning",
            "Damage_Force_Corruption",
            "Damage_Hard_Point_Self_Destruct",
            "Damage_Fire",
            "Damage_Cable_Attack",
            "Damage_Explosion",
            "Damage_Asteroid",
            "Damage_Cable_Attack_Deployed",
            "Damage_Normal_Deployed",
            "Damage_Vehicle_Thief",
            "Damage_Crush",
            "Damage_Eat",
            "Damage_Redirected",
            "Damage_Wampa",
            "Damage_Infection",
            "Damage_Remote_Bomb",
            "Damage_Drain_Life",
            "<!-- DO NOT ADD new damage types after this point -->",
        };

        [TestMethod]
        public void ParseSeparatedStringToList_TestNullOrEmptyString()
        {
            List<string> l0 = StringUtility.ParseSeparatedStringToList(null);
            Assert.IsNotNull(l0);
            Assert.IsTrue(!l0.Any());
            List<string> l1 = StringUtility.ParseSeparatedStringToList(string.Empty);
            Assert.IsNotNull(l1);
            Assert.IsTrue(!l1.Any());
        }

        [TestMethod]
        public void ParseSeparatedStringToList_Test()
        {
            List<string> l = StringUtility.ParseSeparatedStringToList(TEST_STRING_00);
            Assert.IsNotNull(_testList00);
            Assert.IsNotNull(l);
            Assert.AreEqual(_testList00.Count, l.Count);
            foreach (string s in _testList00)
            {
                bool isPresent = false;
                foreach (string s1 in l)
                {
                    Assert.IsFalse(StringUtility.IsNullEmptyOrWhiteSpace(s1));
                    Debug.Assert(s != null, nameof(s) + " != null");
                    if (!s.Equals(s1, StringComparison.InvariantCultureIgnoreCase))
                    {
                        continue;
                    }

                    isPresent = true;
                    break;
                }

                Assert.IsTrue(isPresent);
            }
        }

        [TestMethod]
        [DataRow(null, true)]
        [DataRow("", true)]
        [DataRow(" \t\r\n", true)]
        [DataRow(" something\t\r\nelse", false)]
        public void IsNullEmptyOrWhiteSpace_TestWithDefaultValue(string s, bool expected)
        {
            Assert.AreEqual(expected, StringUtility.IsNullEmptyOrWhiteSpace(s));
        }

        [TestMethod]
        [DataRow(null, 1, true)]
        [DataRow("", 1, true)]
        [DataRow(" \t\r\n", 2, true)]
        [DataRow(" something\t\r\nelse", 11, false)]
        public void IsNullEmptyOrWhiteSpace_TestWithOffset(string s, int offset, bool expected)
        {
            Assert.AreEqual(expected, StringUtility.IsNullEmptyOrWhiteSpace(s, offset));
        }

        [TestMethod]
        [DataRow(null, 1, 32, true)]
        [DataRow("", 1, 32, true)]
        [DataRow(" \t\r\n", 2, 3, true)]
        [DataRow(" something\t\r\nelse", 11, 15, false)]
        public void IsNullEmptyOrWhiteSpace_TestWithOffsetAndLength(string s, int offset, int length, bool expected)
        {
            Assert.AreEqual(expected, StringUtility.IsNullEmptyOrWhiteSpace(s, offset, length));
        }
    }
}
