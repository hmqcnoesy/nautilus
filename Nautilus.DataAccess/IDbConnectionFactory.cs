using System.Data;

namespace Nautilus.DataAccess
{
    public interface IDbConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}