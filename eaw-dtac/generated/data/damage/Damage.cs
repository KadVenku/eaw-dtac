using System;

// ReSharper disable once CheckNamespace
namespace eaw.dtac.data.damage
{
    internal partial class Damage : IEquatable<Damage>
    {
        public bool Equals(Damage other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            return ReferenceEquals(this, other) ||
                   string.Equals(Name, other.Name, StringComparison.InvariantCultureIgnoreCase);
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

            return obj.GetType() == typeof(Damage) && Equals((Damage) obj);
        }

        public override int GetHashCode()
        {
            return (Name != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(Name) : 0);
        }

        public static bool operator ==(Damage left, Damage right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Damage left, Damage right)
        {
            return !Equals(left, right);
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(IsBuiltInType)}: {IsBuiltInType}";
        }
    }
}
