using eaw.dtac.commons.armour;
using System;

namespace eaw.dtac.data.armour
{
    internal partial class Armour
    {
        internal string Name { get; }
        internal bool IsBuiltInType =>
            ArmourUtility.EaW.IsBuiltinType(this) ||
            ArmourUtility.FoC.IsBuiltinType(this);

        internal Armour(string name)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name), "The provided argument may never be null.");
            }
            Name = name;
        }
    }
}
