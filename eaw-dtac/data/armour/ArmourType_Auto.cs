using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("eaw-dtac.test")]

namespace eaw.dtac.data.armour
{
    internal partial class ArmourType : IEquatable<ArmourType>
    {
        public bool Equals(ArmourType other)
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

            if (obj.GetType() != typeof(ArmourType))
            {
                return false;
            }

            return Equals((ArmourType) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (StringComparer.InvariantCultureIgnoreCase.GetHashCode(Name) * 397) ^
                       IsBuiltInType.GetHashCode();
            }
        }

        public static bool operator ==(ArmourType left, ArmourType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ArmourType left, ArmourType right)
        {
            return !Equals(left, right);
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(IsBuiltInType)}: {IsBuiltInType}";
        }
    }
}
