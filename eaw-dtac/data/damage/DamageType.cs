using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("eaw-dtac.test")]

namespace eaw.dtac.data.damage
{
    internal partial class DamageType
    {
        internal string Name { get; }
        internal bool IsBuiltInType { get; }

        internal DamageType(string name, bool isBuiltInType = false)
        {
            if (string.IsNullOrEmpty(name)||string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name), "The provided argument may never be null.");
            }
            Name = name;
            IsBuiltInType = isBuiltInType;
        }
    }
}
