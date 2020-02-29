using System;
using System.Runtime.Serialization;

namespace eaw.dtac.commons.exceptions
{
    public class DTATypeNotFoundException : Exception
    {
        public DTATypeNotFoundException()
        {
        }

        public DTATypeNotFoundException(string message) : base(message)
        {
        }

        public DTATypeNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DTATypeNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}