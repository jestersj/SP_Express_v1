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
    public async Task<int> InsertConsignment(Consignment instance)
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
        p.Add("@AdrFull1", instance.Adr1.AdrFull, DbType.String, ParameterDirection.Input);
        p.Add("@CountryISOCode1", instance.Adr1.CountryISOCode, DbType.String, ParameterDirection.Input);
        p.Add("@Country1", instance.Adr1.Country, DbType.String, ParameterDirection.Input);
        p.Add("@RegionISOCode1", instance.Adr1.RegionISOCode, DbType.String, ParameterDirection.Input);
        p.Add("@Region1", instance.Adr1.Region, DbType.String, ParameterDirection.Input);
        p.Add("@CapitalMarker1", instance.Adr1.CapitalMarker, DbType.Int16, ParameterDirection.Input);
        p.Add("@Lat1", instance.Adr1.Lat, DbType.String, ParameterDirection.Input);
        p.Add("@Lon1", instance.Adr1.Lon, DbType.String, ParameterDirection.Input);
        p.Add("@RegionWithType1", instance.Adr1.RegionWithType, DbType.String, ParameterDirection.Input);
        p.Add("@PostalCode1", instance.Adr1.PostalCode, DbType.Int64, ParameterDirection.Input);
        p.Add("@City1", instance.Adr1.City, DbType.String, ParameterDirection.Input);
        p.Add("@CityWithType1", instance.Adr1.CityWithType, DbType.String, ParameterDirection.Input);
        p.Add("@Street1", instance.Adr1.Street, DbType.String, ParameterDirection.Input);
        p.Add("@StreetWithType1", instance.Adr1.StreetWithType, DbType.String, ParameterDirection.Input);
        p.Add("@House1", instance.Adr1.House, DbType.String, ParameterDirection.Input);
        p.Add("@Block1", instance.Adr1.Block, DbType.String, ParameterDirection.Input);

        p.Add("@AdrFull2", instance.Adr1.AdrFull, DbType.String, ParameterDirection.Input);
        p.Add("@CountryISOCode2", instance.Adr2.CountryISOCode, DbType.String, ParameterDirection.Input);
        p.Add("@Country2", instance.Adr2.Country, DbType.String, ParameterDirection.Input);
        p.Add("@RegionISOCode2", instance.Adr2.RegionISOCode, DbType.String, ParameterDirection.Input);
        p.Add("@Region2", instance.Adr2.Region, DbType.String, ParameterDirection.Input);
        p.Add("@CapitalMarker2", instance.Adr2.CapitalMarker, DbType.Int16, ParameterDirection.Input);
        p.Add("@Lat2", instance.Adr2.Lat, DbType.String, ParameterDirection.Input);
        p.Add("@Lon2", instance.Adr2.Lon, DbType.String, ParameterDirection.Input);
        p.Add("@RegionWithType2", instance.Adr2.RegionWithType, DbType.String, ParameterDirection.Input);
        p.Add("@PostalCode2", instance.Adr2.PostalCode, DbType.Int64, ParameterDirection.Input);
        p.Add("@City2", instance.Adr2.City, DbType.String, ParameterDirection.Input);
        p.Add("@CityWithType2", instance.Adr2.CityWithType, DbType.String, ParameterDirection.Input);
        p.Add("@Street2", instance.Adr2.Street, DbType.String, ParameterDirection.Input);
        p.Add("@StreetWithType2", instance.Adr2.StreetWithType, DbType.String, ParameterDirection.Input);
        p.Add("@House2", instance.Adr2.House, DbType.String, ParameterDirection.Input);
        p.Add("@Block2", instance.Adr2.Block, DbType.String, ParameterDirection.Input);
        
        p.Add("@FIO1", instance.Info.FIO1, DbType.String, ParameterDirection.Input);
        p.Add("@FIO2", instance.Info.FIO2, DbType.String, ParameterDirection.Input);
        p.Add("@Tel1", instance.Info.Tel1, DbType.String, ParameterDirection.Input);
        p.Add("@Tel2", instance.Info.Tel2, DbType.String, ParameterDirection.Input);
        p.Add("@Office1", instance.Info.Office1, DbType.String, ParameterDirection.Input);
        p.Add("@Office2", instance.Info.Office2, DbType.String, ParameterDirection.Input);
        p.Add("@CompName1", instance.Info.CompName1, DbType.String, ParameterDirection.Input);
        p.Add("@CompName2", instance.Info.CompName2, DbType.String, ParameterDirection.Input);
        p.Add("@Note", instance.Info.Note, DbType.String, ParameterDirection.Input);
        p.Add("@DeliveryExtraInfo", instance.Info.DeliveryExtraInfo, DbType.String, ParameterDirection.Input);
        p.Add("@Description", instance.Info.Description, DbType.String, ParameterDirection.Input);
        p.Add("@DocsOnly", instance.Info.DocsOnly, DbType.Boolean, ParameterDirection.Input);
        p.Add("@Places", instance.Info.Places, DbType.Int32, ParameterDirection.Input);
        p.Add("@Weight", instance.Info.Weight, DbType.Double, ParameterDirection.Input);
        p.Add("@Service", instance.Info.Service, DbType.String, ParameterDirection.Input);
        p.Add("@FromTime", instance.Info.FromTime, DbType.Int32, ParameterDirection.Input);
        p.Add("@ToTime", instance.Info.ToTime, DbType.Int32, ParameterDirection.Input);
        p.Add("@DeclaredCost", instance.Info.DeclaredCost, DbType.Int32, ParameterDirection.Input);
        p.Add("@ActualCost", instance.Info.ActualCost, DbType.Int32, ParameterDirection.Input);

        p.Add("@id", null, DbType.Int32, ParameterDirection.Output);

        using IDbConnection db = new SqlConnection(conn);
        await db.ExecuteAsync("insert_consignment", p, commandType: CommandType.StoredProcedure);
        var res = p.Get<int>("@id");
        return res;
    }
}
