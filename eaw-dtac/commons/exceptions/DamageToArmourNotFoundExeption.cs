using System;
using System.Runtime.Serialization;

namespace eaw.dtac.commons.exceptions
{
    public class DamageToArmourNotFoundExeption : Exception
    {
        public DamageToArmourNotFoundExeption()
        {
        }

        public DamageToArmourNotFoundExeption(string message) : base(message)
        {
        }

        public DamageToArmourNotFoundExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DamageToArmourNotFoundExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}