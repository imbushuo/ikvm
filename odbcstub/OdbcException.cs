using System;
using System.Data.Common;
using System.Text;

namespace System.Data.Odbc
{
    [Serializable]
    public sealed class OdbcException : DbException
    {
        public OdbcException(string message) : base(message)
        {
            throw new NotSupportedException();
        }

        public OdbcException(string message, Exception innerException) : base(message, innerException)
        {
            throw new NotSupportedException();
        }

        public OdbcException()
        {
            throw new NotSupportedException();
        }

        private OdbcException(Runtime.Serialization.SerializationInfo serializationInfo, Runtime.Serialization.StreamingContext streamingContext)
        {
            throw new NotImplementedException();
        }

        public OdbcErrorCollection Errors => throw new NotImplementedException();
    }
}
