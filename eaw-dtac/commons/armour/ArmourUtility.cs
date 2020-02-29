using eaw.dtac.Annotations;
using eaw.dtac.commons.game;
using eaw.dtac.data;
using eaw.dtac.data.armour;
using eaw.dtac.petroglyph.xml.gameconstants;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using Serilog;

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
                    foreach (string sepStr in separatedStringAsList.Where(sepStr => !StringUtility.IsNullEmptyOrWhiteSpace(sepStr)))
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
            [NotNull] private static readonly List<Armour> ARMOUR_TYPES = new List<Armour>();

            static EaW()
            {
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
            [NotNull] private static readonly List<Armour> ARMOUR_TYPES = new List<Armour>();

            static FoC()
            {
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

        internal static void CleanArmourDeclaration([NotNull] string gameConstantsFilePath)
        {
            if (StringUtility.IsNullEmptyOrWhiteSpace(gameConstantsFilePath) || !File.Exists(gameConstantsFilePath))
            {
                throw new ArgumentNullException(nameof(gameConstantsFilePath));
            }

            XmlUtility.RemoveValueFromTag(gameConstantsFilePath, Tags.ARMOR_TYPES);
        }

        public static string GetAllAsString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("\n");
            foreach (Armour damage in GlobalStore.ARMOUR_REGISTRY.Where(damage => damage != null && !damage.IsBuiltInType))
            {
                Debug.Assert(damage != null, nameof(commons.damage) + " != null");
                stringBuilder.Append($"\t\t{damage.Name},\n");
            }

            switch (GlobalStore.GAME_MODE)
            {
                case GameMode.EaW:
                    foreach (Armour hardCodedType in EaW.GetAllHardCodedTypes())
                    {
                        Debug.Assert(hardCodedType != null, nameof(hardCodedType) + " != null");
                        stringBuilder.Append($"\t\t{hardCodedType.Name},\n");
                    }

                    break;
                case GameMode.FoC:
                    foreach (Armour hardCodedType in FoC.GetAllHardCodedTypes())
                    {
                        Debug.Assert(hardCodedType != null, nameof(hardCodedType) + " != null");
                        stringBuilder.Append($"\t\t{hardCodedType.Name},\n");
                    }

                    break;
                case GameMode.Undefined:
                    Log.Fatal($"No valid Game Mode was set: {GlobalStore.GAME_MODE}");
                    throw new ArgumentOutOfRangeException($"No valid Game Mode was set: {GlobalStore.GAME_MODE}");
                default:
                    Log.Fatal($"No valid Game Mode was set: {GlobalStore.GAME_MODE}");
                    throw new ArgumentOutOfRangeException($"No valid Game Mode was set: {GlobalStore.GAME_MODE}");
            }

            stringBuilder.Append("\t");
            return stringBuilder.ToString();
        }
    }
}