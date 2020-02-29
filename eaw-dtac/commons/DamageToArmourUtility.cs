using eaw.dtac.Annotations;
using eaw.dtac.commons.exceptions;
using eaw.dtac.data;
using eaw.dtac.data.armour;
using eaw.dtac.data.damage;
using eaw.dtac.petroglyph.xml.gameconstants;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using eaw.dtac.commons.damage;

namespace eaw.dtac.commons
{
    internal static class DamageToArmourUtility
    {
        [NotNull]
        internal static DamageToArmour ParseFromString(string damageToArmourString)
        {
            damageToArmourString = XmlUtility.RemoveComments(damageToArmourString);
            List<string> dta = StringUtility.ParseSeparatedStringToList(damageToArmourString, ',');
            if (dta.Count != 3)
            {
                throw new DamageToArmourDefinitionException($"The {nameof(DamageToArmour)} mod could not be parsed: {damageToArmourString}");
            }

            string damageStr = dta[0]?.Trim();
            string armourStr = dta[1]?.Trim();
            string valStr = dta[2]?.Trim();

            if (StringUtility.IsNullEmptyOrWhiteSpace(damageStr) || StringUtility.IsNullEmptyOrWhiteSpace(armourStr))
            {
                throw new DamageToArmourDefinitionException($"The {nameof(DamageToArmour)} mod could not be parsed: {damageToArmourString}");
            }

            Debug.Assert(valStr != null, $"{nameof(valStr)} != null");
            float value = StringUtility.IsNullEmptyOrWhiteSpace(valStr) ? 0.0f : float.Parse(valStr);
            return new DamageToArmour(new Damage(damageStr), new Armour(armourStr), value);
        }

        internal static DamageToArmour Get([NotNull] string damageId, [NotNull] string armourId)
        {
            if (StringUtility.IsNullEmptyOrWhiteSpace(damageId) || StringUtility.IsNullEmptyOrWhiteSpace(armourId))
            {
                throw new DamageToArmourNotFoundExeption($"No DTA type found for damage {damageId} to armour {armourId}");
            }

            return Get(new Damage(damageId), new Armour(armourId));
        }


        internal static DamageToArmour Get([NotNull] Damage d, [NotNull] Armour a)
        {
            return GlobalStore.GetDamageToArmourMod(d, a);
        }

        [NotNull]
        internal static List<DamageToArmour> GetDamageToArmourMatrixByDamage([NotNull] string damageTypeId)
        {
            return GetDamageToArmourMatrixByDamage(new Damage(damageTypeId));
        }

        [NotNull]
        internal static List<DamageToArmour> GetDamageToArmourMatrixByDamage([NotNull] Damage damageType)
        {
            return GlobalStore.GetDamageToArmourMatrixByDamage(damageType);
        }

        internal static void ScaleBy([NotNull] string damageId, float factor)
        {
            ScaleBy(new Damage(damageId), factor);
        }

        internal static void ScaleBy([NotNull] Damage damage, float factor)
        {
            foreach (DamageToArmour damageToArmour in GetDamageToArmourMatrixByDamage(damage).Where(damageToArmour => damageToArmour != null))
            {
                Debug.Assert(damageToArmour != null, nameof(damageToArmour) + " != null");
                damageToArmour.DamageToArmourFactor *= factor;
            }
        }

        internal static void CleanDamageToArmourDeclaration([NotNull] string gameConstantsFilePath)
        {
            if (StringUtility.IsNullEmptyOrWhiteSpace(gameConstantsFilePath) || !File.Exists(gameConstantsFilePath))
            {
                throw new ArgumentNullException(nameof(gameConstantsFilePath));
            }

            XmlUtility.RemoveTag(gameConstantsFilePath, Tags.DAMAGE_TO_ARMOR_MOD);
        }

        public static IEnumerable<XElement> ParseDamageToArmourMatrixAsXElement()
        {
            List<XElement> elements = new List<XElement>();
            foreach (Damage damage in DamageUtility.GetAll())
            {
                if (damage.IsBuiltInType)
                {
                    elements.AddRange(from damageToArmour in GetDamageToArmourMatrixByDamage(damage) where Math.Abs(damageToArmour.DamageToArmourFactor - 1.0f) > 0.000001f select damageToArmour.ToXElement());
                }
                else
                {
                    elements.AddRange(GetDamageToArmourMatrixByDamage(damage).Select(damageToArmour => damageToArmour.ToXElement()));
                }
            }

            return elements;
        }
    }
}