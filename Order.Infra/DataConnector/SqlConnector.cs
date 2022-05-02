using Order.Domain.Interfaces.Repositories.DataConnector;
using System.Data;
using System.Data.SqlClient;

namespace Order.Infra.DataConnector
{//nessa camada de Infra se pode implementar com qualquer banco de dados. Pode-se mudar a qualquer momento sem afetar as outras camadas do projeto
    public class SqlConnector : IDbConnector
    {
        public SqlConnector()
        {
        }

        public SqlConnector(string connectionString)
        {
            dbConnection = SqlClientFactory.Instance.CreateConnection();
            dbConnection.ConnectionString = connectionString;
        }
        public IDbConnection dbConnection { get;  set; }

        public IDbTransaction dbTransaction { get;  set; }

        public IDbTransaction BeginTransaction(IsolationLevel isolation)
        {
            if (dbTransaction != null)
            {
                return dbTransaction;
            }

            if (dbConnection.State == ConnectionState.Closed)
            {
                dbConnection.Open();
            }

            return (dbTransaction = dbConnection.BeginTransaction(isolation));
        }

        public void Dispose()
        {
            dbConnection?.Dispose();
            dbTransaction?.Dispose();
        }
    }
}
