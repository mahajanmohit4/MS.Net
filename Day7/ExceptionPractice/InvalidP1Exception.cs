using System;
using System.Runtime.Serialization;

namespace ExceptionHandling2
{
    [Serializable]
    internal class InvalidP1Exception : Exception
    {
        public InvalidP1Exception()
        {
        }

        public InvalidP1Exception(string message) : base(message)
        {
        }

        public InvalidP1Exception(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidP1Exception(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}