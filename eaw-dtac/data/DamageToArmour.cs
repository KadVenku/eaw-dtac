using System.Runtime.CompilerServices;
using eaw.dtac.data.armour;
using eaw.dtac.data.damage;

[assembly: InternalsVisibleTo("eaw-dtac.test")]

namespace eaw.dtac.data
{
    internal partial class DamageToArmour
    {
        internal DamageType Damage { get; }
        internal ArmourType Armour { get; }
        internal float DamageToArmourFactor { get; set; }

        internal DamageToArmour(DamageType damage, ArmourType armour, float damageToArmourFactor = 1.0f)
        {
            Damage = damage;
            Armour = armour;
            DamageToArmourFactor = damageToArmourFactor;
        }
    }
}
