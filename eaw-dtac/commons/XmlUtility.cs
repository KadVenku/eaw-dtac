using eaw.dtac.Annotations;
using eaw.dtac.commons.exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Xml.Linq;

namespace eaw.dtac.commons
{
    internal static class XmlUtility
    {
        private const string XML_COMMENT_OPEN = "<!--";
        private const string XML_COMMENT_CLOSE = "-->";

        internal static string RemoveComments(string inputString)
        {
            if (StringUtility.IsNullEmptyOrWhiteSpace(inputString))
            {
                return string.Empty;
            }

            Debug.Assert(inputString != null, nameof(inputString) + " != null");
            int commentStartIndex = inputString.IndexOf(XML_COMMENT_OPEN, StringComparison.Ordinal);
            while (commentStartIndex >= 0)
            {
                int commentEndIndex = inputString.IndexOf(XML_COMMENT_CLOSE, commentStartIndex, StringComparison.Ordinal);
                if (commentEndIndex < 0 || commentEndIndex < commentStartIndex)
                {
                    throw new XmlParseException($"Damage types could not be parsed, please fix the syntax errors in your GameConstants.xml - {nameof(inputString)}:\n{inputString}");
                }

                int length = commentEndIndex - commentStartIndex + XML_COMMENT_CLOSE.Length;
                inputString = inputString.Remove(commentStartIndex, length);
                commentStartIndex = inputString.IndexOf("<!--", StringComparison.Ordinal);
            }

            return inputString;
        }

        internal static void Save([NotNull] string filePath, [NotNull] XDocument file)
        {
            using (StringWriter writer = new Utf8StringWriter())
            {
                file.Save(writer);
                File.WriteAllText(filePath, writer.ToString());
            }
        }

        internal static void ReplaceValueForTag([NotNull] string filePath, [NotNull] string tag, string value, bool updateAllOccurrences = false)
        {
            XDocument file = XDocument.Load(filePath);
            if (file.Root != null)
            {
                ReplaceValueForTagInternal(file.Root.Elements(), tag, value, updateAllOccurrences);
            }

            Save(filePath, file);
        }

        // ReSharper disable once CognitiveComplexity
        private static void ReplaceValueForTagInternal([NotNull] IEnumerable<XElement> elements, [NotNull] string tag, string value, bool updateAllOccurrences)
        {
            foreach (XElement element in elements)
            {
                if (element == null)
                {
                    continue;
                }

                if (element.Name.ToString().Equals(tag, StringComparison.InvariantCultureIgnoreCase))
                {
                    // ReSharper disable once AssignNullToNotNullAttribute
                    element.Value = StringUtility.IsNullEmptyOrWhiteSpace(value) ? string.Empty : value;
                    if (!updateAllOccurrences)
                    {
                        break;
                    }
                }

                if (element.HasElements)
                {
                    ReplaceValueForTagInternal(element.Elements(), tag, value, updateAllOccurrences);
                }
            }
        }

        internal static void RemoveValueFromTag([NotNull] string filePath, [NotNull] string tag)
        {
            XDocument file = XDocument.Load(filePath);
            if (file.Root != null)
            {
                RemoveValueFromTagInternal(file.Root.Elements(), tag);
            }

            Save(filePath, file);
        }

        private static void RemoveValueFromTagInternal([NotNull] IEnumerable<XElement> elements, string tag)
        {
            foreach (XElement element in elements)
            {
                if (element == null)
                {
                    continue;
                }

                if (element.Name.ToString().Equals(tag, StringComparison.InvariantCultureIgnoreCase))
                {
                    element.Value = string.Empty;
                }

                if (element.HasElements)
                {
                    RemoveValueFromTagInternal(element.Elements(), tag);
                }
            }
        }

        internal static void RemoveTag([NotNull] string filePath, [NotNull] string tag)
        {
            XDocument file = XDocument.Load(filePath);
            if (file.Root != null)
            {
                file.Root.Elements(tag)?.Remove();
                RemoveTagInternal(file.Root.Elements(), tag);
            }

            Save(filePath, file);
        }

        private static void RemoveTagInternal([NotNull] IEnumerable<XElement> elements, [NotNull] string tag)
        {
            foreach (XElement element in elements)
            {
                if (element == null)
                {
                    continue;
                }

                element.Elements(tag).Remove();

                if (element.HasElements)
                {
                    RemoveTagInternal(element.Elements(), tag);
                }
            }
        }

        internal sealed class Utf8StringWriter : StringWriter
        {
            public override Encoding Encoding => Encoding.UTF8;
        }

        public static void InsertElement([NotNull] string filePath, [NotNull] XElement elementToInsert, string afterTag = "")
        {
            InsertElement(filePath, new List<XElement> {elementToInsert}, afterTag);
        }


        internal static void InsertElement([NotNull] string filePath, [NotNull] IEnumerable<XElement> elementsToInsert, string afterTag = "", bool insertOnlyOnce = true)
        {
            bool insertAfter = !StringUtility.IsNullEmptyOrWhiteSpace(afterTag);
            XDocument file = XDocument.Load(filePath);
            if (file.Root != null)
            {
                if (insertAfter)
                {
                    XElement ele = file.Root.Element(afterTag);
                    if (ele != null)
                    {
                        ele.AddAfterSelf(elementsToInsert);
                        if (insertOnlyOnce)
                        {
                            Save(filePath, file);
                            return;
                        }
                    }
                    InsertElementAfterInternal(file.Root.Elements(), elementsToInsert, afterTag, insertOnlyOnce);
                }
                else
                {
                    foreach (XElement element in elementsToInsert)
                    {
                        file.Root.Add(element);
                    }
                }
            }

            Save(filePath, file);
        }

        private static void InsertElementAfterInternal([NotNull] IEnumerable<XElement> file, [NotNull] IEnumerable<XElement> elementsToInsert, [NotNull] string afterTag, bool insertOnlyOnce = true)
        {
            foreach (XElement element in file)
            {
                XElement ele = element.Element(afterTag);
                if (ele != null)
                {
                    ele.Element(afterTag)?.AddAfterSelf(elementsToInsert);
                    if (insertOnlyOnce)
                    {
                        return;
                    }
                }

                if (element.HasElements)
                {
                    InsertElementAfterInternal(element.Elements(), elementsToInsert, afterTag);
                }
            }
        }
    }
}