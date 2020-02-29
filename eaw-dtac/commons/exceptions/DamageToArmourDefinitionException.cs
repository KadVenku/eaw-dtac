using System;
using System.Runtime.Serialization;

namespace eaw.dtac.commons.exceptions
{
    public class DamageToArmourDefinitionException : Exception
    {
        public DamageToArmourDefinitionException()
        {
        }

        public DamageToArmourDefinitionException(string message) : base(message)
        {
        }

        public DamageToArmourDefinitionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DamageToArmourDefinitionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}