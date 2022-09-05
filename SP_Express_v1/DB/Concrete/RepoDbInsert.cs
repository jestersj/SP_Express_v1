using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using SP_Express_v1.DB.Contract;
using SP_Express_v1.Models;

namespace SP_Express_v1.DB.Concrete;


public class RepoDbInsert : IDbInsert
{
    private readonly string conn;
    
    public RepoDbInsert(string connectionString)
    {
        conn = connectionString;
    }
    
    /// <summary>
    /// вставка запроса на договор
    /// </summary>
    /// <param name="instance"></param>
    public async Task<int> InsertConsignment(Address instance)
    {
        //dbo.up_ConclusDog_Insert
        //@OrgName VARCHAR(100),@OrgEmail VARCHAR(50),@OrgAdres VARCHAR(255),
        //@OrgINN VARCHAR(20),@OrgNote VARCHAR(255),@id INT OUTPUT

        

        // @AdrFull varchar(150), @CountryISOCode varchar(100), @Country varchar(100),
        // @RegionISOCode varchar(100), @Region varchar(100), @CapitalMarker int,
        // @Lat varchar(100), @Lon varchar(100), @RegionWithType varchar(100), @PostalCode int,
        // @City varchar(100), @CityWithType varchar(100), @Street varchar(100),
        // @StreetWithType varchar(100), @House varchar(100),
        // @Block varchar(100), @Id INT OUTPUT)
        
        
        var p = new DynamicParameters();
        p.Add("@AdrFull", instance.AdrFull, DbType.String, ParameterDirection.Input);
        p.Add("@CountryISOCode", instance.CountryISOCode, DbType.String, ParameterDirection.Input);
        p.Add("@Country", instance.Country, DbType.String, ParameterDirection.Input);
        p.Add("@RegionISOCode", instance.RegionISOCode, DbType.String, ParameterDirection.Input);
        p.Add("@Region", instance.Region, DbType.String, ParameterDirection.Input);
        p.Add("@CapitalMarker", instance.CapitalMarker, DbType.Int16, ParameterDirection.Input);
        p.Add("@Lat", instance.Lat, DbType.String, ParameterDirection.Input);
        p.Add("@Lon", instance.Lon, DbType.String, ParameterDirection.Input);
        p.Add("@RegionWithType", instance.RegionWithType, DbType.String, ParameterDirection.Input);
        p.Add("@PostalCode", instance.PostalCode, DbType.Int64, ParameterDirection.Input);
        p.Add("@City", instance.City, DbType.String, ParameterDirection.Input);
        p.Add("@CityWithType", instance.CityWithType, DbType.String, ParameterDirection.Input);
        p.Add("@Street", instance.Street, DbType.String, ParameterDirection.Input);
        p.Add("@StreetWithType", instance.StreetWithType, DbType.String, ParameterDirection.Input);
        p.Add("@House", instance.House, DbType.String, ParameterDirection.Input);
        p.Add("@Block", instance.Block, DbType.String, ParameterDirection.Input);
        
        p.Add("@id", null, DbType.Int32, ParameterDirection.Output);

        using IDbConnection db = new SqlConnection(conn);
        await db.ExecuteAsync("insert_consignment", p, commandType: CommandType.StoredProcedure);
        var res = p.Get<int>("@id");
        return res;
    }
}
