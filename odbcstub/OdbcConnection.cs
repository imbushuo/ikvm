using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace System.Data.Odbc
{
    public sealed class OdbcConnection : DbConnection, ICloneable
    {
        public OdbcConnection()
        {
            throw new NotImplementedException();
        }

        public OdbcConnection(string connectionString)
        {
            throw new NotImplementedException();
        }

        public override string ConnectionString { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string Database => throw new NotImplementedException();

        public override string DataSource => throw new NotImplementedException();

        public override string ServerVersion => throw new NotImplementedException();

        public override ConnectionState State => throw new NotImplementedException();

        public override void ChangeDatabase(string databaseName)
        {
            throw new NotImplementedException();
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public override void Close()
        {
            throw new NotImplementedException();
        }

        public override void Open()
        {
            throw new NotImplementedException();
        }

        protected override DbTransaction BeginDbTransaction(IsolationLevel isolationLevel)
        {
            throw new NotImplementedException();
        }

        protected override DbCommand CreateDbCommand()
        {
            throw new NotImplementedException();
        }

        public new OdbcCommand CreateCommand()
        {
            throw new NotImplementedException();
        }

        public string Driver => throw new NotImplementedException();
    }
}
