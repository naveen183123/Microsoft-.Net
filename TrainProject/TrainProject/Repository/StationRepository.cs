using Dapper;
using System.Data;
using System.Data.SqlClient;
using Task6.Models;
namespace Task6.Repository
{
    public class StationRepository : IStationRepository
    {
        private readonly IConfiguration _config;
        public StationRepository(IConfiguration config)
        {
            _config = config;
        }
        public IDbConnection connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("mySqlConnection"));
            }
        }
        public async Task<Station> ADDStation(Station station)
        {
            try
            {
                using (IDbConnection con = connection)
                {
                    string sQuery = "SP_STATION";
                    con.Open();
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@ACTION", "E");
                    param.Add("@TrainNo", station.TrainNo);
                    param.Add("@StationNo", station.StationNo);
                    param.Add("@StationName", station.StationName);
                    param.Add("@Date", station.Date);
                    //param.Add("@Time", station.Time);
                    param.Add("@ArrivalTime", station.ArrivalTime);
                    param.Add("@DepatureTime", station.DepatureTime);
                    var result = await con.QueryAsync<Station>(sQuery, param, commandType: CommandType.StoredProcedure);
                    return result.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Station> DeleteStation(int StationNo)
        {
            try
            {
                using (IDbConnection con = connection)
                {
                    string Query = "SP_Station";
                    con.Open();
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@ACTION", "D");
                    param.Add("@StationNo", StationNo);
                    var result = await con.QueryAsync<Station>(Query, param, commandType: CommandType.StoredProcedure);
                    return result.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Station>> GetStation()
        {
            try
            {
                using (IDbConnection con = connection)
                {
                    string Query = "SP_Station";
                    con.Open();
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@ACTION", "A");
                    var result = await con.QueryAsync<Station>(Query, param, commandType: CommandType.StoredProcedure);
                    return result.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Station> GetStationByNo(int StationNo)
        {
            try
            {
                using (IDbConnection con = connection)
                {
                    string Query = "SP_Station";
                    con.Open();
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@ACTION", "G");
                    param.Add("@StationNo", StationNo);
                    var result = await con.QueryAsync<Station>(Query, param, commandType: CommandType.StoredProcedure);
                    return result.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<Station> GetStationList(int TrainNo, string ArrivalTime)
        {
            try
            {
                using (IDbConnection con = connection)
                {
                    string Query = "SP_Station";
                    con.Open();
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@ACTION", "Z");
                    param.Add("@TrainNo", TrainNo);
                    param.Add("@ArrivalTime", ArrivalTime);
                    var result = await con.QueryAsync<Station>(Query, param, commandType: CommandType.StoredProcedure);
                    return result.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<Station> GetTrainList(string StationName, string ArrivalTime)
        {
            try
            {
                using (IDbConnection con = connection)
                {
                    string Query = "SP_Station";
                    con.Open();
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@ACTION", "X");
                    param.Add("@StationName", StationName);
                    param.Add("@ArrivalTime", ArrivalTime);
                    var result = await con.QueryAsync<Station>(Query, param, commandType: CommandType.StoredProcedure);
                    return result.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<Station> GetTrainSchedule(string Date)
        {
            try
            {
                using (IDbConnection con = connection)
                {
                    string Query = "SP_Station";
                    con.Open();
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@ACTION", "V");
                    param.Add("@Date", Date);
                    var result = await con.QueryAsync<Station>(Query, param, commandType: CommandType.StoredProcedure);
                    return result.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}