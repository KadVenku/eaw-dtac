using System.Xml.Linq;
using eaw.dtac.Annotations;
using eaw.dtac.data.armour;
using eaw.dtac.data.damage;
using eaw.dtac.petroglyph.xml.gameconstants;
using PropertyChanged;

namespace eaw.dtac.data
{
    internal partial class DamageToArmour
    {
        [DoNotNotify]
        [NotNull]
        internal Damage Damage { get; }

        [DoNotNotify]
        [NotNull]
        internal Armour Armour { get; }

        internal float DamageToArmourFactor { get; set; }

        internal string Description { get; set; }

        internal DamageToArmour(Damage damage, Armour armour, float damageToArmourFactor = 1.0f)
        {
            Damage = damage ?? throw new System.ArgumentNullException(nameof(damage));
            Armour = armour ?? throw new System.ArgumentNullException(nameof(armour));
            DamageToArmourFactor = damageToArmourFactor;
        }

        internal XElement ToXElement()
        {
            return new XElement(Tags.DAMAGE_TO_ARMOR_MOD) {Value = $"{Damage.Name}, {Armour.Name}, {DamageToArmourFactor}"};
        }
    }
}