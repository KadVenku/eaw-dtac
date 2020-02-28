using eaw.dtac.commons.damage;
using System;

namespace eaw.dtac.data.damage
{
    internal partial class Damage
    {
        internal string Name { get; }

        internal bool IsBuiltInType => DamageUtility.EaW.IsBuiltinType(this) || DamageUtility.FoC.IsBuiltinType(this);

        internal Damage(string name)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name), "The provided argument may never be null.");
            }

            Name = name;
        }
    }
}
