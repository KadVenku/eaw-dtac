using System;

namespace eaw.dtac.data
{
    internal partial class DamageToArmour : IEquatable<DamageToArmour>
    {
        public bool Equals(DamageToArmour other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Damage.Equals(other.Damage) && Armour.Equals(other.Armour);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != typeof(DamageToArmour))
            {
                return false;
            }

            return Equals((DamageToArmour) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Damage.GetHashCode() * 397) ^ Armour.GetHashCode();
            }
        }

        public static bool operator ==(DamageToArmour left, DamageToArmour right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DamageToArmour left, DamageToArmour right)
        {
            return !Equals(left, right);
        }

        public override string ToString()
        {
            return $"{nameof(Damage)}: {Damage}, {nameof(Armour)}: {Armour}, {nameof(DamageToArmourFactor)}: {DamageToArmourFactor}";
        }
    }
}
