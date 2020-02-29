using eaw.dtac.Annotations;
using eaw.dtac.commons.armour;
using eaw.dtac.commons.damage;
using eaw.dtac.commons.exceptions;
using eaw.dtac.commons.game;
using eaw.dtac.data;
using eaw.dtac.data.armour;
using eaw.dtac.data.damage;
using eaw.dtac.petroglyph.xml.gameconstants;
using Serilog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml.Linq;

namespace eaw.dtac.commons
{
    internal static class GameConstantsUtility
    {
        internal static void LoadFromGameConstantsFile([NotNull] string gameConstantsFilePath)
        {
            if (GlobalStore.GAME_CONSTANTS_LOADED)
            {
                GlobalStore.ClearAll();
            }

            GetAllDamageTypes(gameConstantsFilePath);
            GetAllArmourTypes(gameConstantsFilePath);
            InitializeDamageToArmourMatrix(gameConstantsFilePath);
            GlobalStore.GAME_CONSTANTS_LOADED = true;
        }

        internal static void SaveToGameConstantsFile([NotNull] string gameConstantsFilePath, bool writeDestructive = false)
        {
            if (!writeDestructive)
            {
                BackupGameConstantsFile(gameConstantsFilePath);
            }
            Debug.Assert(gameConstantsFilePath != null, nameof(gameConstantsFilePath) + " != null");
            Debug.Assert(File.Exists(gameConstantsFilePath), nameof(gameConstantsFilePath) + " must exist");
            SaveToGameConstantsFilePrepare(gameConstantsFilePath);
            SaveToGameConstantsFileInternal(gameConstantsFilePath);
        }

        private static void SaveToGameConstantsFileInternal([NotNull] string gameConstantsFilePath)
        {
            XmlUtility.ReplaceValueForTag(gameConstantsFilePath, Tags.DAMAGE_TYPES, DamageUtility.GetAllAsString());
            XmlUtility.ReplaceValueForTag(gameConstantsFilePath, Tags.ARMOR_TYPES, ArmourUtility.GetAllAsString());
            XmlUtility.InsertElement(gameConstantsFilePath, DamageToArmourUtility.ParseDamageToArmourMatrixAsXElement(), Tags.ARMOR_TYPES);
        }

        private static void SaveToGameConstantsFilePrepare([NotNull] string gameConstantsFilePath)
        {
            DamageUtility.CleanDamageDeclaration(gameConstantsFilePath);
            ArmourUtility.CleanArmourDeclaration(gameConstantsFilePath);
            DamageToArmourUtility.CleanDamageToArmourDeclaration(gameConstantsFilePath);
        }

        private static void BackupGameConstantsFile([NotNull] string gameConstantsFilePath)
        {
            if (File.Exists(gameConstantsFilePath))
            {
                File.Copy(gameConstantsFilePath, gameConstantsFilePath + $".{DateTime.Now:yyyyMMddHHmmssffff}.xml");
            }
        }

        private static void InitializeDamageToArmourMatrix(string gameConstantsFilePath)
        {
            foreach (Damage damageType in GlobalStore.DAMAGE_REGISTRY)
            {
                foreach (Armour armourType in GlobalStore.ARMOUR_REGISTRY)
                {
                    GlobalStore.DAMAGE_TO_ARMOUR_REGISTRY.Add(new DamageToArmour(damageType, armourType));
                }
            }

            Debug.Assert(gameConstantsFilePath != null, nameof(gameConstantsFilePath) + " != null");
            Debug.Assert(File.Exists(gameConstantsFilePath), nameof(gameConstantsFilePath) + " must exist");
            ParseAndUpdateDamageToArmourMatrix(gameConstantsFilePath);
        }

        private static void ParseAndUpdateDamageToArmourMatrix(string gameConstantsFilePath)
        {
            Debug.Assert(gameConstantsFilePath != null, nameof(gameConstantsFilePath) + " != null");
            Debug.Assert(File.Exists(gameConstantsFilePath), nameof(gameConstantsFilePath) + " must exist");
            XDocument gameConstantsFile = XDocument.Load(gameConstantsFilePath);
            Debug.Assert(gameConstantsFile.Root != null, "gameConstantsFile.Root != null");
            foreach (XElement xElement in gameConstantsFile.Root.Elements())
            {
                if (!xElement.Name.ToString().Equals(Tags.DAMAGE_TO_ARMOR_MOD, StringComparison.InvariantCultureIgnoreCase))
                {
                    continue;
                }

                DamageToArmour dta = DamageToArmourUtility.ParseFromString(xElement.Value);
                DamageToArmour dtaToUpdate = DamageToArmourUtility.Get(dta.Damage, dta.Armour);
                Debug.Assert(dtaToUpdate != null, nameof(dtaToUpdate) + " != null");
                dtaToUpdate.DamageToArmourFactor = dta.DamageToArmourFactor;
            }
        }

        private static void GetAllDamageTypes([NotNull] string gameConstantsFilePath)
        {
            Debug.Assert(gameConstantsFilePath != null, nameof(gameConstantsFilePath) + " != null");
            Debug.Assert(File.Exists(gameConstantsFilePath), nameof(gameConstantsFilePath) + " must exist");
            ParseDamageTypeDefinition(gameConstantsFilePath);
            CheckHardcodedDamageTypes();
        }

        private static void ParseDamageTypeDefinition(string gameConstantsFilePath)
        {
            Debug.Assert(gameConstantsFilePath != null, nameof(gameConstantsFilePath) + " != null");
            Debug.Assert(File.Exists(gameConstantsFilePath), nameof(gameConstantsFilePath) + " must exist");
            XDocument gameConstantsFile = XDocument.Load(gameConstantsFilePath);
            Debug.Assert(gameConstantsFile.Root != null, "gameConstantsFile.Root != null");
            foreach (XElement xElement in gameConstantsFile.Root.Elements())
            {
                if (!xElement.Name.ToString().Equals(Tags.DAMAGE_TYPES, StringComparison.InvariantCultureIgnoreCase))
                {
                    continue;
                }

                List<Damage> damages = DamageUtility.ParseFromString(xElement.Value);
                foreach (Damage damage in damages)
                {
                    if (GlobalStore.DAMAGE_REGISTRY.Contains(damage))
                    {
                        Debug.Assert(damage != null, nameof(commons.damage) + " != null");
                        Log.Warning(
                            $"Found duplicated damage type definition \"{damage.Name}\" was previously defined.");
                        continue;
                    }

                    GlobalStore.DAMAGE_REGISTRY.Add(damage);
                }

                break;
            }
        }

        private static void CheckHardcodedDamageTypes()
        {
            switch (GlobalStore.GAME_MODE)
            {
                case GameMode.EaW:
                    CheckEaWHardcodedDamageTypes();
                    break;
                case GameMode.FoC:
                    CheckFoCHardcodedDamageTypes();
                    break;
                case GameMode.Undefined:
                    Log.Fatal($"No valid Game Mode was set: {GlobalStore.GAME_MODE}");
                    throw new ArgumentOutOfRangeException($"No valid Game Mode was set: {GlobalStore.GAME_MODE}");
                default:
                    throw new ArgumentOutOfRangeException($"No valid Game Mode was set: {GlobalStore.GAME_MODE}");
            }
        }

        private static void CheckFoCHardcodedDamageTypes()
        {
            foreach (Damage hardCodedDamageType in DamageUtility.FoC.GetAllHardCodedTypes())
            {
                if (GlobalStore.DAMAGE_REGISTRY.Contains(hardCodedDamageType))
                {
                    continue;
                }

                Debug.Assert(hardCodedDamageType != null, nameof(hardCodedDamageType) + " != null");
                Log.Fatal(
                    $"The required damage type \"{hardCodedDamageType.Name}\" was not found in the provided GameConstants file.");
                throw new DamageDefinitionException(
                    $"The required damage type \"{hardCodedDamageType.Name}\" was not found in the provided GameConstants file.");
            }
        }

        private static void CheckEaWHardcodedDamageTypes()
        {
            foreach (Damage hardCodedDamageType in DamageUtility.EaW.GetAllHardCodedTypes())
            {
                if (GlobalStore.DAMAGE_REGISTRY.Contains(hardCodedDamageType))
                {
                    continue;
                }

                Debug.Assert(hardCodedDamageType != null, nameof(hardCodedDamageType) + " != null");
                Log.Fatal(
                    $"The required damage type \"{hardCodedDamageType.Name}\" was not found in the provided GameConstants file.");
                throw new DamageDefinitionException(
                    $"The required damage type \"{hardCodedDamageType.Name}\" was not found in the provided GameConstants file.");
            }
        }

        private static void GetAllArmourTypes([NotNull] string gameConstantsFilePath)
        {
            Debug.Assert(gameConstantsFilePath != null, nameof(gameConstantsFilePath) + " != null");
            Debug.Assert(File.Exists(gameConstantsFilePath), nameof(gameConstantsFilePath) + " must exist");
            ParseArmourTypeDefinition(gameConstantsFilePath);
            CheckHardcodedArmourTypes();
        }

        private static void ParseArmourTypeDefinition(string gameConstantsFilePath)
        {
            Debug.Assert(gameConstantsFilePath != null, nameof(gameConstantsFilePath) + " != null");
            Debug.Assert(File.Exists(gameConstantsFilePath), nameof(gameConstantsFilePath) + " must exist");
            XDocument gameConstantsFile = XDocument.Load(gameConstantsFilePath);
            Debug.Assert(gameConstantsFile.Root != null, "gameConstantsFile.Root != null");
            foreach (XElement xElement in gameConstantsFile.Root.Elements())
            {
                if (!xElement.Name.ToString().Equals(Tags.ARMOR_TYPES, StringComparison.InvariantCultureIgnoreCase))
                {
                    continue;
                }

                List<Armour> damages = ArmourUtility.ParseFromString(xElement.Value);
                foreach (Armour damage in damages)
                {
                    if (GlobalStore.ARMOUR_REGISTRY.Contains(damage))
                    {
                        Debug.Assert(damage != null, nameof(commons.damage) + " != null");
                        Log.Warning(
                            $"Found duplicated damage type definition \"{damage.Name}\" was previously defined.");
                        continue;
                    }

                    GlobalStore.ARMOUR_REGISTRY.Add(damage);
                }

                break;
            }
        }

        private static void CheckHardcodedArmourTypes()
        {
            switch (GlobalStore.GAME_MODE)
            {
                case GameMode.EaW:
                    CheckEaWHardcodedArmourTypes();
                    break;
                case GameMode.FoC:
                    CheckFoCHardcodedArmourTypes();
                    break;
                case GameMode.Undefined:
                    Log.Fatal($"No valid Game Mode was set: {GlobalStore.GAME_MODE}");
                    throw new ArgumentOutOfRangeException($"No valid Game Mode was set: {GlobalStore.GAME_MODE}");
                default:
                    Log.Fatal($"No valid Game Mode was set: {GlobalStore.GAME_MODE}");
                    throw new ArgumentOutOfRangeException($"No valid Game Mode was set: {GlobalStore.GAME_MODE}");
            }
        }

        private static void CheckEaWHardcodedArmourTypes()
        {
            foreach (Armour hardCodedArmourType in ArmourUtility.EaW.GetAllHardCodedTypes())
            {
                if (GlobalStore.ARMOUR_REGISTRY.Contains(hardCodedArmourType))
                {
                    continue;
                }

                Debug.Assert(hardCodedArmourType != null, nameof(hardCodedArmourType) + " != null");
                Log.Fatal(
                    $"The required armour type \"{hardCodedArmourType.Name}\" was not found in the provided GameConstants file.");
                throw new DamageDefinitionException(
                    $"The required armour type \"{hardCodedArmourType.Name}\" was not found in the provided GameConstants file.");
            }
        }

        private static void CheckFoCHardcodedArmourTypes()
        {
            foreach (Armour hardCodedArmourType in ArmourUtility.FoC.GetAllHardCodedTypes())
            {
                if (GlobalStore.ARMOUR_REGISTRY.Contains(hardCodedArmourType))
                {
                    continue;
                }

                Debug.Assert(hardCodedArmourType != null, nameof(hardCodedArmourType) + " != null");
                Log.Fatal(
                    $"The required armour type \"{hardCodedArmourType.Name}\" was not found in the provided GameConstants file.");
                throw new DamageDefinitionException(
                    $"The required armour type \"{hardCodedArmourType.Name}\" was not found in the provided GameConstants file.");
            }
        }
    }
}
