using Order.Domain.Interfaces.Repositories.DataConnector;
using System.Data;

namespace Order.Infra.DataConnector
{//nessa camada de Infra se pode implementar com qualquer banco de dados. Pode-se mudar a qualquer momento sem afetar as outras camadas do projeto
    public class SqlConnector : IDbConnector
    {
        public SqlConnector()
        {
        }

        public SqlConnector(string connectionString)
        {

        }
        public IDbConnection dbConnection { get;  set; }

        public IDbTransaction dbTransaction { get;  set; }

        public IDbTransaction BeginTransaction(IsolationLevel isolation)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}
