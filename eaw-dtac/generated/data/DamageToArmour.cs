using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using eaw.dtac.Annotations;

// ReSharper disable once CheckNamespace
namespace eaw.dtac.data
{
    internal partial class DamageToArmour : IEquatable<DamageToArmour>, INotifyPropertyChanged
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

            return Damage.Equals(other.Damage) && Armour.Equals(other.Armour) &&
                   DamageToArmourFactor.Equals(other.DamageToArmourFactor);
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
                int hashCode = Damage.GetHashCode();
                hashCode = (hashCode * 397) ^ Armour.GetHashCode();
                return hashCode;
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
            return
                $"{nameof(Damage)}: {Damage}, {nameof(Armour)}: {Armour}, {nameof(DamageToArmourFactor)}: {DamageToArmourFactor}";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
