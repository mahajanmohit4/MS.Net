using System;
using System.Runtime.Serialization;

namespace ExceptionEx
{
    [Serializable]
    internal class InvalidBasicException : Exception
    {
        public InvalidBasicException()
        {
        }

        public InvalidBasicException(string message) : base(message)
        {
        }

        public InvalidBasicException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidBasicException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}