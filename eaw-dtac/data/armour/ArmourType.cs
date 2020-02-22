using System;
using System.Runtime.CompilerServices;
using eaw.dtac.commons.armour;

[assembly: InternalsVisibleTo("eaw-dtac.test")]

namespace eaw.dtac.data.armour
{
    internal partial class ArmourType
    {
        internal string Name { get; }
        internal bool IsBuiltInType =>
            ArmourUtility.EaW.IsBuiltinType(this) ||
            ArmourUtility.FoC.IsBuiltinType(this);

        internal ArmourType(string name)
        {
            if (string.IsNullOrEmpty(name)||string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name), "The provided argument may never be null.");
            }
            Name = name;
        }
    }
}
