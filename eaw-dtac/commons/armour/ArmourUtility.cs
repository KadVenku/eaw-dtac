using System.Collections.Generic;
using System.Collections.ObjectModel;
using eaw.dtac.data.armour;

namespace eaw.dtac.commons.armour
{
    internal static class ArmourUtility
    {
        internal static class EaW
        {
            // ReSharper disable once CollectionNeverUpdated.Local
            private static readonly List<ArmourType> ARMOUR_TYPES;

            static EaW()
            {
                ARMOUR_TYPES = new List<ArmourType>();
            }

            internal static ReadOnlyCollection<ArmourType> GetAllHardCodedTypes()
            {
                return ARMOUR_TYPES.AsReadOnly();
            }

            internal static bool IsBuiltinType(ArmourType armourType)
            {
                return ARMOUR_TYPES.Contains(armourType);
            }

            internal static bool IsBuiltinType(string armourTypeId)
            {
                if (string.IsNullOrEmpty(armourTypeId) || string.IsNullOrWhiteSpace(armourTypeId))
                {
                    return false;
                }

                return ARMOUR_TYPES.Contains(new ArmourType(armourTypeId));
            }
        }

        internal static class FoC
        {
            // ReSharper disable once CollectionNeverUpdated.Local
            private static readonly List<ArmourType> ARMOUR_TYPES;

            static FoC()
            {
                ARMOUR_TYPES = new List<ArmourType>();
            }

            internal static ReadOnlyCollection<ArmourType> GetAllHardCodedTypes()
            {
                return ARMOUR_TYPES.AsReadOnly();
            }

            internal static bool IsBuiltinType(ArmourType armourType)
            {
                return ARMOUR_TYPES.Contains(armourType);
            }

            internal static bool IsBuiltinType(string armourTypeId)
            {
                if (string.IsNullOrEmpty(armourTypeId) || string.IsNullOrWhiteSpace(armourTypeId))
                {
                    return false;
                }

                return ARMOUR_TYPES.Contains(new ArmourType(armourTypeId));
            }
        }
    }
}
