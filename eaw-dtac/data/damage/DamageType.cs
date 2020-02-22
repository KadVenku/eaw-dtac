using System;
using System.Runtime.CompilerServices;
using eaw.dtac.commons.damage;

[assembly: InternalsVisibleTo("eaw-dtac.test")]

namespace eaw.dtac.data.damage
{
    internal partial class DamageType
    {
        internal string Name { get; }

        internal bool IsBuiltInType =>
            DamageUtility.EaW.IsBuiltinType(this) ||
            DamageUtility.FoC.IsBuiltinType(this);

        internal DamageType(string name)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name), "The provided argument may never be null.");
            }

            Name = name;
        }
    }
}
