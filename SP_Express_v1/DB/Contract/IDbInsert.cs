using SP_Express_v1.Models;

namespace SP_Express_v1.DB.Contract;


public interface IDbInsert
{
    public Task<int> InsertConsignment(Address instance);
}
