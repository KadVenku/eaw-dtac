using System;
using System.Runtime.Serialization;

namespace eaw.dtac.commons.exceptions
{
    public class DamageDefinitionException : Exception
    {
        public DamageDefinitionException()
        {
        }

        public DamageDefinitionException(string message) : base(message)
        {
        }

        public DamageDefinitionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DamageDefinitionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}