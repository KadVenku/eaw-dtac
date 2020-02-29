using System.Collections.Generic;
using System.Diagnostics;
using eaw.dtac.Annotations;
using eaw.dtac.commons.exceptions;
using eaw.dtac.commons.game;
using eaw.dtac.data.armour;
using eaw.dtac.data.damage;

namespace eaw.dtac.data
{
    internal static class GlobalStore
    {
        internal static GameMode GAME_MODE = GameMode.Undefined;
        internal static bool GAME_CONSTANTS_LOADED = false;
        [NotNull] internal static readonly List<DamageToArmour> DAMAGE_TO_ARMOUR_REGISTRY = new List<DamageToArmour>();
        [NotNull] internal static readonly List<Damage> DAMAGE_REGISTRY = new List<Damage>();
        [NotNull] internal static readonly List<Armour> ARMOUR_REGISTRY = new List<Armour>();

        internal static void ClearAll()
        {
            DAMAGE_TO_ARMOUR_REGISTRY.Clear();
            DAMAGE_REGISTRY.Clear();
            ARMOUR_REGISTRY.Clear();
        }

        [NotNull]
        internal static List<DamageToArmour> GetDamageToArmourMatrixByDamage([NotNull] Damage damageType)
        {
            List<DamageToArmour> damageToArmourMatrix = new List<DamageToArmour>();
            foreach (DamageToArmour damageToArmour in DAMAGE_TO_ARMOUR_REGISTRY)
            {
                Debug.Assert(damageToArmour != null, nameof(damageToArmour) + " != null");
                if (damageToArmour.Damage == damageType)
                {
                    damageToArmourMatrix.Add(damageToArmour);
                }
            }

            return damageToArmourMatrix;
        }

        internal static DamageToArmour GetDamageToArmourMod([NotNull] Damage d, [NotNull] Armour a)
        {
            foreach (DamageToArmour damageToArmour in DAMAGE_TO_ARMOUR_REGISTRY)
            {
                Debug.Assert(damageToArmour != null, nameof(damageToArmour) + " != null");
                if (damageToArmour.Damage == d && damageToArmour.Armour == a)
                {
                    return damageToArmour;
                }
            }

            throw new DamageToArmourNotFoundExeption($"No DTA type found for damage {d} to armour {a}");
        }
    }
}
