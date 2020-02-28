using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using eaw.dtac.Annotations;
using eaw.dtac.data.damage;

namespace eaw.dtac.commons.damage
{
    internal static class DamageUtility
    {
        [NotNull]
        internal static List<Damage> ParseFromString(string inputString)
        {
            List<Damage> damages = new List<Damage>();
            if (StringUtility.IsNullEmptyOrWhiteSpace(inputString))
            {
                return damages;
            }
            inputString = XmlUtility.RemoveComments(inputString);
            if (StringUtility.IsNullEmptyOrWhiteSpace(inputString))
            {
                return damages;
            }

            List<string> inputStringAsList = StringUtility.ParseSeparatedStringToList(inputString, ',');
            for (int i = 0; i < inputStringAsList.Count; i++)
            {
                inputStringAsList[i] = inputStringAsList[i]?.Trim();
            }

            foreach (string s in inputStringAsList.Where(s => !StringUtility.IsNullEmptyOrWhiteSpace(s)))
            {
                Debug.Assert(s != null, nameof(s) + " != null");
                List<string> separatedStringAsList = StringUtility.ParseSeparatedStringToList(s, '\n');
                if (separatedStringAsList.Count == 1)
                {
                    damages.Add(new Damage(s.Trim()));
                }
                else
                {
                    foreach (string str in separatedStringAsList.Where(str => !StringUtility.IsNullEmptyOrWhiteSpace(str)))
                    {
                        Debug.Assert(str != null, nameof(str) + " != null");
                        damages.Add(new Damage(str.Trim()));
                    }
                }
            }
            return damages;
        }

        internal static class EaW
        {
            private const string DAMAGE_NORMAL = "Damage_Normal";
            private const string DAMAGE_FORCE_WHIRLWIND = "Damage_Force_Whirlwind";
            private const string DAMAGE_FORCE_TELEKINESIS = "Damage_Force_Telekinesis";
            private const string DAMAGE_FORCE_LIGHTNING = "Damage_Force_Lightning";
            private const string DAMAGE_FORCE_CORRUPTION = "Damage_Force_Corruption";
            private const string DAMAGE_HARD_POINT_SELF_DESTRUCT = "Damage_Hard_Point_Self_Destruct";
            private const string DAMAGE_FIRE = "Damage_Fire";
            private const string DAMAGE_CABLE_ATTACK = "Damage_Cable_Attack";
            private const string DAMAGE_EXPLOSION = "Damage_Explosion";
            private const string DAMAGE_ASTEROID = "Damage_Asteroid";
            private const string DAMAGE_CABLE_ATTACK_DEPLOYED = "Damage_Cable_Attack_Deployed";
            private const string DAMAGE_NORMAL_DEPLOYED = "Damage_Normal_Deployed";
            private const string DAMAGE_VEHICLE_THIEF = "Damage_Vehicle_Thief";
            private const string DAMAGE_CRUSH = "Damage_Crush";
            private const string DAMAGE_EAT = "Damage_Eat";
            private const string DAMAGE_REDIRECTED = "Damage_Redirected";
            private const string DAMAGE_WAMPA = "Damage_Wampa";
            [NotNull] private static readonly List<Damage> DAMAGE_TYPES;

            static EaW()
            {
                DAMAGE_TYPES = new List<Damage>
                {
                    new Damage(DAMAGE_NORMAL),
                    new Damage(DAMAGE_FORCE_WHIRLWIND),
                    new Damage(DAMAGE_FORCE_TELEKINESIS),
                    new Damage(DAMAGE_FORCE_LIGHTNING),
                    new Damage(DAMAGE_FORCE_CORRUPTION),
                    new Damage(DAMAGE_HARD_POINT_SELF_DESTRUCT),
                    new Damage(DAMAGE_FIRE),
                    new Damage(DAMAGE_CABLE_ATTACK),
                    new Damage(DAMAGE_EXPLOSION),
                    new Damage(DAMAGE_ASTEROID),
                    new Damage(DAMAGE_CABLE_ATTACK_DEPLOYED),
                    new Damage(DAMAGE_NORMAL_DEPLOYED),
                    new Damage(DAMAGE_VEHICLE_THIEF),
                    new Damage(DAMAGE_CRUSH),
                    new Damage(DAMAGE_EAT),
                    new Damage(DAMAGE_REDIRECTED),
                    new Damage(DAMAGE_WAMPA),
                };
            }

            [NotNull]
            internal static ReadOnlyCollection<Damage> GetAllHardCodedTypes()
            {
                return DAMAGE_TYPES.AsReadOnly();
            }

            internal static bool IsBuiltinType(Damage damage)
            {
                return DAMAGE_TYPES.Contains(damage);
            }

            internal static bool IsBuiltinType(string damageTypeId)
            {
                if (string.IsNullOrEmpty(damageTypeId) || string.IsNullOrWhiteSpace(damageTypeId))
                {
                    return false;
                }

                return IsBuiltinType(new Damage(damageTypeId));
            }
        }

        internal static class FoC
        {
            private const string DAMAGE_NORMAL = "Damage_Normal";
            private const string DAMAGE_FORCE_WHIRLWIND = "Damage_Force_Whirlwind";
            private const string DAMAGE_FORCE_TELEKINESIS = "Damage_Force_Telekinesis";
            private const string DAMAGE_FORCE_LIGHTNING = "Damage_Force_Lightning";
            private const string DAMAGE_FORCE_CORRUPTION = "Damage_Force_Corruption";
            private const string DAMAGE_HARD_POINT_SELF_DESTRUCT = "Damage_Hard_Point_Self_Destruct";
            private const string DAMAGE_FIRE = "Damage_Fire";
            private const string DAMAGE_CABLE_ATTACK = "Damage_Cable_Attack";
            private const string DAMAGE_EXPLOSION = "Damage_Explosion";
            private const string DAMAGE_ASTEROID = "Damage_Asteroid";
            private const string DAMAGE_CABLE_ATTACK_DEPLOYED = "Damage_Cable_Attack_Deployed";
            private const string DAMAGE_NORMAL_DEPLOYED = "Damage_Normal_Deployed";
            private const string DAMAGE_VEHICLE_THIEF = "Damage_Vehicle_Thief";
            private const string DAMAGE_CRUSH = "Damage_Crush";
            private const string DAMAGE_EAT = "Damage_Eat";
            private const string DAMAGE_REDIRECTED = "Damage_Redirected";
            private const string DAMAGE_WAMPA = "Damage_Wampa";
            private const string DAMAGE_INFECTION = "Damage_Infection";
            private const string DAMAGE_REMOTE_BOMB = "Damage_Remote_Bomb";
            private const string DAMAGE_DRAIN_LIFE = "Damage_Drain_Life";
            [NotNull] private static readonly List<Damage> DAMAGE_TYPES;

            static FoC()
            {
                DAMAGE_TYPES = new List<Damage>
                {
                    new Damage(DAMAGE_NORMAL),
                    new Damage(DAMAGE_FORCE_WHIRLWIND),
                    new Damage(DAMAGE_FORCE_TELEKINESIS),
                    new Damage(DAMAGE_FORCE_LIGHTNING),
                    new Damage(DAMAGE_FORCE_CORRUPTION),
                    new Damage(DAMAGE_HARD_POINT_SELF_DESTRUCT),
                    new Damage(DAMAGE_FIRE),
                    new Damage(DAMAGE_CABLE_ATTACK),
                    new Damage(DAMAGE_EXPLOSION),
                    new Damage(DAMAGE_ASTEROID),
                    new Damage(DAMAGE_CABLE_ATTACK_DEPLOYED),
                    new Damage(DAMAGE_NORMAL_DEPLOYED),
                    new Damage(DAMAGE_VEHICLE_THIEF),
                    new Damage(DAMAGE_CRUSH),
                    new Damage(DAMAGE_EAT),
                    new Damage(DAMAGE_REDIRECTED),
                    new Damage(DAMAGE_WAMPA),
                    new Damage(DAMAGE_INFECTION),
                    new Damage(DAMAGE_REMOTE_BOMB),
                    new Damage(DAMAGE_DRAIN_LIFE)
                };
            }

            [NotNull]
            internal static ReadOnlyCollection<Damage> GetAllHardCodedTypes()
            {
                return DAMAGE_TYPES.AsReadOnly();
            }

            internal static bool IsBuiltinType(Damage damage)
            {
                return DAMAGE_TYPES.Contains(damage);
            }

            internal static bool IsBuiltinType(string damageTypeId)
            {
                if (string.IsNullOrEmpty(damageTypeId) || string.IsNullOrWhiteSpace(damageTypeId))
                {
                    return false;
                }

                return IsBuiltinType(new Damage(damageTypeId));
            }
        }
    }
}
