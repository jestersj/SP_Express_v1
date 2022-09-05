using System.Data.SqlClient;
using Dapper;

using SP_Express_v1.DB.Contract;


namespace SP_Express_v1.DB.Concrete;


public class RepoDbUpdate : IDbUpdate
{
    private readonly string conn;
    
    public RepoDbUpdate(string connectionString)
    {
        conn = connectionString;
    }
}