using System;

namespace eaw.dtac.data.damage
{
    internal partial class DamageType : IEquatable<DamageType>
    {
        public bool Equals(DamageType other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            return ReferenceEquals(this, other) || string.Equals(Name, other.Name, StringComparison.InvariantCultureIgnoreCase);
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

            return obj.GetType() == typeof(DamageType) && Equals((DamageType) obj);
        }

        public override int GetHashCode()
        {
            return (Name != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(Name) : 0);
        }

        public static bool operator ==(DamageType left, DamageType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DamageType left, DamageType right)
        {
            return !Equals(left, right);
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(IsBuiltInType)}: {IsBuiltInType}";
        }
    }
}
