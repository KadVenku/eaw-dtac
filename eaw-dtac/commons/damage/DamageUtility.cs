using System.Collections.Generic;
using System.Collections.ObjectModel;
using eaw.dtac.data.damage;

namespace eaw.dtac.commons.damage
{
    internal static class DamageUtility
    {
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
            private static readonly List<DamageType> DAMAGE_TYPES;

            static EaW()
            {
                DAMAGE_TYPES = new List<DamageType>
                {
                    new DamageType(DAMAGE_NORMAL),
                    new DamageType(DAMAGE_FORCE_WHIRLWIND),
                    new DamageType(DAMAGE_FORCE_TELEKINESIS),
                    new DamageType(DAMAGE_FORCE_LIGHTNING),
                    new DamageType(DAMAGE_FORCE_CORRUPTION),
                    new DamageType(DAMAGE_HARD_POINT_SELF_DESTRUCT),
                    new DamageType(DAMAGE_FIRE),
                    new DamageType(DAMAGE_CABLE_ATTACK),
                    new DamageType(DAMAGE_EXPLOSION),
                    new DamageType(DAMAGE_ASTEROID),
                    new DamageType(DAMAGE_CABLE_ATTACK_DEPLOYED),
                    new DamageType(DAMAGE_NORMAL_DEPLOYED),
                    new DamageType(DAMAGE_VEHICLE_THIEF),
                    new DamageType(DAMAGE_CRUSH),
                    new DamageType(DAMAGE_EAT),
                    new DamageType(DAMAGE_REDIRECTED),
                    new DamageType(DAMAGE_WAMPA),
                };
            }

            internal static ReadOnlyCollection<DamageType> GetAllHardCodedTypes()
            {
                return DAMAGE_TYPES.AsReadOnly();
            }

            internal static bool IsBuiltinType(DamageType damageType)
            {
                return DAMAGE_TYPES.Contains(damageType);
            }

            internal static bool IsBuiltinType(string damageTypeId)
            {
                if (string.IsNullOrEmpty(damageTypeId) || string.IsNullOrWhiteSpace(damageTypeId))
                {
                    return false;
                }

                return DAMAGE_TYPES.Contains(new DamageType(damageTypeId));
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
            private static readonly List<DamageType> DAMAGE_TYPES;

            static FoC()
            {
                DAMAGE_TYPES = new List<DamageType>
                {
                    new DamageType(DAMAGE_NORMAL),
                    new DamageType(DAMAGE_FORCE_WHIRLWIND),
                    new DamageType(DAMAGE_FORCE_TELEKINESIS),
                    new DamageType(DAMAGE_FORCE_LIGHTNING),
                    new DamageType(DAMAGE_FORCE_CORRUPTION),
                    new DamageType(DAMAGE_HARD_POINT_SELF_DESTRUCT),
                    new DamageType(DAMAGE_FIRE),
                    new DamageType(DAMAGE_CABLE_ATTACK),
                    new DamageType(DAMAGE_EXPLOSION),
                    new DamageType(DAMAGE_ASTEROID),
                    new DamageType(DAMAGE_CABLE_ATTACK_DEPLOYED),
                    new DamageType(DAMAGE_NORMAL_DEPLOYED),
                    new DamageType(DAMAGE_VEHICLE_THIEF),
                    new DamageType(DAMAGE_CRUSH),
                    new DamageType(DAMAGE_EAT),
                    new DamageType(DAMAGE_REDIRECTED),
                    new DamageType(DAMAGE_WAMPA),
                    new DamageType(DAMAGE_INFECTION),
                    new DamageType(DAMAGE_REMOTE_BOMB),
                    new DamageType(DAMAGE_DRAIN_LIFE)
                };
            }

            internal static ReadOnlyCollection<DamageType> GetAllHardCodedTypes()
            {
                return DAMAGE_TYPES.AsReadOnly();
            }

            internal static bool IsBuiltinType(DamageType damageType)
            {
                return DAMAGE_TYPES.Contains(damageType);
            }

            internal static bool IsBuiltinType(string damageTypeId)
            {
                if (string.IsNullOrEmpty(damageTypeId) || string.IsNullOrWhiteSpace(damageTypeId))
                {
                    return false;
                }

                return DAMAGE_TYPES.Contains(new DamageType(damageTypeId));
            }
        }
    }
}
