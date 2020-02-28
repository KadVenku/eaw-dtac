using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using eaw.dtac.commons.damage;
using eaw.dtac.data.damage;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace eaw_dtac.test.commons.damage
{
    [TestClass]
    [TestCategory(TestUtility.TestType.UTILITY)]
    public class DamageUtilityTest
    {
        private const string DAMAGE_STRING =
            "\t\tDamage_Default, \n\t\tDamage_ATST,\n\t\tDamage_ATAT,\n\t\tDamage_Fighter,\n\t\tDamage_Assault_Frigate,\n\t\tDamage_Diamond_Missile, \n\t\tDamage_IonCannon, \n\t\tDamage_IonCannon_LRG, \n\t\tDamage_Proton_Torp, \n\t\tDamage_Proton_Torp_Light, \n\t\tDamage_Con_Missile, \n\t\tDamage_Turbolaser, \n\t\tDamage_Blaster_Hand, \n\t\tDamage_PLEX, \n\t\tDamage_Sniper, \n\t\tDamage_Lightning, \n\t\tDamage_Lightsaber, \n\t\tDamage_ThermDet, \n\t\tDamage_Wookiee, \n\t\tDamage_Jawa, \n\t\tDamage_StickyBomb,\n\t\tDamage_Hero_StickyBomb,\n\t\tDamage_Blaster_Cannon, \n\t\tDamage_Flak_Pod, \n\t\tDamage_AI_Turret, \n\t\tDamage_AV_Turret,\n\t\tDamage_TIE_Mauler,\n\t\tDamage_2M_Repulsortank,\n\t\tDamage_Laser_GRND, \n\t\tDamage_Proton_GRND, \n\t\tDamage_Con_Missile_GRND, \n\t\tDamage_Con_Missile_T4B,\n\t\tDamage_Con_Grenade, \n\t\tDamage_SPMAT_Grenade, \n\t\tDamage_Bomb, \n\t\tDamage_Hyper_Gun, \n\t\tDamage_Ion_Planet,\n\t\tDamage_Rancor, \n\t\tDamage_Laser_T4B,\n\t\tDamage_Blaster_T2B,\n\t\tDamage_Star_Destroyer,\n\t\tDamage_Calamari_Cruiser,\n\t\tDamage_Station_Laser,\n\t\tDamage_Station_Turbolaser,\n\t\tDamage_Acclamator,\n\t\tDamage_Acclamator_TL,\n\t\tDamage_Interdictor,\n\t\tDamage_Victory_SD,\n\t\tDamage_IPV,\n\t\tDamage_Nebulon_B,\n\t\tDamage_Tartan_Cruiser,\n\t\tDamage_Corellian_Corvette,\n\t\tDamage_Corellian_Gunboat,\n\t\tDamage_Turbo_GRND,\n\t\tDamage_Wall_Destruction,\n\t\tDamage_Self_Destruct,\n        Damage_AWing,\n\t\tDamage_Force_Pike,\n\t\tDamage_BugBite,\n\t\tDamage_StarBase_Self_Destruct,\n\t\tDamage_Sonic_Blaster,\n\t\tDamage_Airspeeder,\n\t\tDamage_Disruptor_Hand,\n\t\tDamage_Pulse_Cannon,\n\t\tDamage_Ion_Cannon_Land,\n\t\tDamage_Droideka_Blaster,\n\t\tDamage_Juggernaut_Turret,\n\t\tDamage_DarkTrooper1_Sword,\n\t\tDamage_DarkTrooper2_Cannon,\n\t\tDamage_Plant_Spike,\n\t\tDamage_Pulse_Cannon_Tank,\n\t\tDamage_Krayt_Damage_Blast,\n\t\tDamage_Mass_Driver_Turret,\n\t\tDamage_Vornskr_Bite,\n\t\tDamage_Exploding_Barrel,\n\t\tDamage_Tyber_Shotgun,\n\t\tDamage_Mass_Driver_Space,\n\t\tDamage_MDU_Rocket,\n\t\tDamage_MDU_Grenade,\n\t\t\n\t\t\n\t\t<!-- PLEASE add your new damage types ABOVE this point.\n\t\t\t The damage types below are from hard-coded damage enumeration. You can specify Armor type for them if you want\n\t\t\t (and understand how and where these are applied).\n\t\t\t In the future, we will merge two system together, but for now we have to have this work-around. \n\t\t\t -Oksana\t\t\t-->\n\t\tDamage_Normal,\n\t\tDamage_Force_Whirlwind,\n\t\tDamage_Force_Telekinesis,\n\t\tDamage_Force_Lightning,\n\t\tDamage_Force_Corruption,\n\t\tDamage_Hard_Point_Self_Destruct,\n\t\tDamage_Fire,\n\t\tDamage_Cable_Attack,\n\t\tDamage_Explosion,\n\t\tDamage_Asteroid,\n\t\tDamage_Cable_Attack_Deployed,\n\t\tDamage_Normal_Deployed,\n\t\tDamage_Vehicle_Thief,\n\t\tDamage_Crush,\n\t\tDamage_Eat,\n\t\tDamage_Redirected,\n\t\tDamage_Wampa\n        Damage_Infection,\n\t\tDamage_Remote_Bomb,\n\t\tDamage_Drain_Life,\n\n\t\t<!-- DO NOT ADD new damage types after this point -->";

        [TestMethod]
        public void ParseFromString_TestNullEmptyOrWhitespace()
        {
            List<Damage> l0 = DamageUtility.ParseFromString(null);
            Assert.IsNotNull(l0);
            Assert.IsFalse(l0.Any());
            List<Damage> l1 = DamageUtility.ParseFromString(string.Empty);
            Assert.IsNotNull(l1);
            Assert.IsFalse(l1.Any());
            List<Damage> l2 = DamageUtility.ParseFromString("\n \t\r\n");
            Assert.IsNotNull(l2);
            Assert.IsFalse(l2.Any());
        }

        [TestMethod]
        public void ParseFromString_Test()
        {
            List<Damage> l = DamageUtility.ParseFromString(DAMAGE_STRING);
            Assert.IsNotNull(l);
            Assert.IsTrue(l.Any());
            Assert.AreEqual(99, l.Count);
        }

        [TestClass]
        [TestCategory(TestUtility.TestType.UTILITY)]
        public class EaWTest
        {
            [TestMethod]
            public void Create_Test()
            {
                ReadOnlyCollection<Damage> damageTypes = DamageUtility.EaW.GetAllHardCodedTypes();
                Assert.IsNotNull(damageTypes);
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
                Assert.AreEqual(expectedValue, DamageUtility.EaW.IsBuiltinType(new Damage(dmgTypeId)));
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
        [TestCategory(TestUtility.TestType.UTILITY)]
        public class FoCTest
        {
            [TestMethod]
            public void Create_Test()
            {
                ReadOnlyCollection<Damage> damageTypes = DamageUtility.FoC.GetAllHardCodedTypes();
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
                Assert.AreEqual(expectedValue, DamageUtility.FoC.IsBuiltinType(new Damage(dmgTypeId)));
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
