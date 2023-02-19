using System;
using System.Runtime.Serialization;

namespace MyfirstOOPcode_saturday
{
    [Serializable]
    internal class yearException : Exception
    {
        public yearException()
        {
        }

        public yearException(string message) : base(message)
        {
        }

        public yearException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected yearException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}