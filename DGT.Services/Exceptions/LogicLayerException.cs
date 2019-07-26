using System;
using System.Runtime.Serialization;

namespace DGT.Services.Exceptions
{
    [Serializable]
    internal class LogicLayerException : Exception
    {
        public LogicLayerException()
        {
        }

        public LogicLayerException(string message) : base(message)
        {
        }

        public LogicLayerException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected LogicLayerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}