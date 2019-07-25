using System;
using System.Runtime.Serialization;

namespace DGT.Data.Repositories.Exceptions
{
    [Serializable]
    internal class DataLayerException : Exception
    {
        public DataLayerException()
        {
        }

        public DataLayerException(string message) : base(message)
        {
        }

        public DataLayerException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DataLayerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}