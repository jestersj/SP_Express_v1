using SP_Express_v1.DB.Contract;

namespace SP_Express_v1.DB.Concrete;


public class RepoDbSelect : IDbSelect
{
    private readonly string conn;
    
    public RepoDbSelect(string connectionString)
    {
        conn = connectionString;
    }
}