using System;

// ReSharper disable once CheckNamespace
namespace eaw.dtac.data.armour
{
    internal partial class Armour : IEquatable<Armour>
    {
        public bool Equals(Armour other)
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

            if (obj.GetType() != typeof(Armour))
            {
                return false;
            }

            return Equals((Armour) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (StringComparer.InvariantCultureIgnoreCase.GetHashCode(Name) * 397) ^
                       IsBuiltInType.GetHashCode();
            }
        }

        public static bool operator ==(Armour left, Armour right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Armour left, Armour right)
        {
            return !Equals(left, right);
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(IsBuiltInType)}: {IsBuiltInType}";
        }
    }
}
