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

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return string.Equals(Name, other.Name, StringComparison.InvariantCultureIgnoreCase) &&
                   IsBuiltInType == other.IsBuiltInType;
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
            unchecked
            {
                return (StringComparer.InvariantCultureIgnoreCase.GetHashCode(Name) * 397) ^
                       IsBuiltInType.GetHashCode();
            }
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
