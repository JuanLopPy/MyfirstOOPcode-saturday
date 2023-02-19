using System;
using System.Runtime.Serialization;

namespace MyfirstOOPcode_saturday
{
    [Serializable]
    internal class monthException : Exception
    {
        public monthException()
        {
        }

        public monthException(string message) : base(message)
        {
        }

        public monthException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected monthException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}