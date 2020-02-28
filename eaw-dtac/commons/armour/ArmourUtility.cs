using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using eaw.dtac.Annotations;
using eaw.dtac.data.armour;
using eaw.dtac.data.damage;

namespace eaw.dtac.commons.armour
{
    internal static class ArmourUtility
    {
        [NotNull]
        internal static List<Armour> ParseFromString(string inputString)
        {
            List<Armour> armours = new List<Armour>();
            if (StringUtility.IsNullEmptyOrWhiteSpace(inputString))
            {
                return armours;
            }

            inputString = XmlUtility.RemoveComments(inputString);
            if (StringUtility.IsNullEmptyOrWhiteSpace(inputString))
            {
                return armours;
            }

            List<string> inputStringAsList = StringUtility.ParseSeparatedStringToList(inputString, ',');
            for (int i = 0; i < inputStringAsList.Count; i++)
            {
                inputStringAsList[i] = inputStringAsList[i]?.Trim();
            }

            foreach (string inStr in inputStringAsList.Where(inStr => !StringUtility.IsNullEmptyOrWhiteSpace(inStr)))
            {
                Debug.Assert(inStr != null, nameof(inStr) + " != null");
                List<string> separatedStringAsList = StringUtility.ParseSeparatedStringToList(inStr, '\n');
                if (separatedStringAsList.Count == 1)
                {
                    armours.Add(new Armour(inStr.Trim()));
                }
                else
                {
                    foreach (string sepStr in separatedStringAsList.Where(sepStr =>
                        !StringUtility.IsNullEmptyOrWhiteSpace(sepStr)))
                    {
                        Debug.Assert(sepStr != null, nameof(sepStr) + " != null");
                        armours.Add(new Armour(sepStr.Trim()));
                    }
                }
            }

            return armours;
        }

        internal static class EaW
        {
            // ReSharper disable once CollectionNeverUpdated.Local
            [NotNull] private static readonly List<Armour> ARMOUR_TYPES;

            static EaW()
            {
                ARMOUR_TYPES = new List<Armour>();
            }

            [NotNull]
            internal static ReadOnlyCollection<Armour> GetAllHardCodedTypes()
            {
                return ARMOUR_TYPES.AsReadOnly();
            }

            internal static bool IsBuiltinType(Armour armour)
            {
                return ARMOUR_TYPES.Contains(armour);
            }

            internal static bool IsBuiltinType(string armourTypeId)
            {
                if (string.IsNullOrEmpty(armourTypeId) || string.IsNullOrWhiteSpace(armourTypeId))
                {
                    return false;
                }

                return IsBuiltinType(new Armour(armourTypeId));
            }
        }

        internal static class FoC
        {
            // ReSharper disable once CollectionNeverUpdated.Local
            [NotNull] private static readonly List<Armour> ARMOUR_TYPES;

            static FoC()
            {
                ARMOUR_TYPES = new List<Armour>();
            }

            [NotNull]
            internal static ReadOnlyCollection<Armour> GetAllHardCodedTypes()
            {
                return ARMOUR_TYPES.AsReadOnly();
            }

            internal static bool IsBuiltinType(Armour armour)
            {
                return ARMOUR_TYPES.Contains(armour);
            }

            internal static bool IsBuiltinType(string armourTypeId)
            {
                if (string.IsNullOrEmpty(armourTypeId) || string.IsNullOrWhiteSpace(armourTypeId))
                {
                    return false;
                }

                return IsBuiltinType(new Armour(armourTypeId));
            }
        }
    }
}
