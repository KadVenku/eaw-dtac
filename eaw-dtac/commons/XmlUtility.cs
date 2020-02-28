using System;
using System.Diagnostics;
using eaw.dtac.commons.exceptions;

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
                int commentEndIndex =
                    inputString.IndexOf(XML_COMMENT_CLOSE, commentStartIndex, StringComparison.Ordinal);
                if (commentEndIndex < 0 || commentEndIndex < commentStartIndex)
                {
                    throw new XmlParseException(
                        $"Damage types could not be parsed, please fix the syntax errors in your GameConstants.xml - {nameof(inputString)}:\n{inputString}");
                }

                int length = commentEndIndex - commentStartIndex + XML_COMMENT_CLOSE.Length;
                inputString = inputString.Remove(commentStartIndex, length);
                commentStartIndex = inputString.IndexOf("<!--", StringComparison.Ordinal);
            }

            return inputString;
        }
    }
}
