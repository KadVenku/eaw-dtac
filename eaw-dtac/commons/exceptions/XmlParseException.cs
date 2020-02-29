using System;
using System.Runtime.Serialization;

namespace eaw.dtac.commons.exceptions
{
    public class XmlParseException : Exception
    {
        public XmlParseException()
        {
        }

        public XmlParseException(string message) : base(message)
        {
        }

        public XmlParseException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected XmlParseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
