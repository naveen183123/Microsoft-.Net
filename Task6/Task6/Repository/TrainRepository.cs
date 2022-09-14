using System.Data;
using System.Data.SqlClient;
using Task6.Models;
using Dapper;
namespace Task6.Repository
{
    public class TrainRepository : ITrainRepository
    {
        private readonly IConfiguration _config;
        public TrainRepository(IConfiguration config)
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
        public async Task<Train> ADDEditTrain(Train train)
        {
            try
            {
                using (IDbConnection con = connection)
                {
                    string sQuery = "SP_Train";
                    con.Open();
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@ACTION", "E");
                    param.Add("@TrainNo", train.TrainNo);
                    param.Add("@TrainName", train.TrainName);
                    var result = await con.QueryAsync<Train>(sQuery, param, commandType: CommandType.StoredProcedure);
                    return result.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Train> DeleteTrain(int TrainNo)
        {
            try
            {
                using (IDbConnection con = connection)
                {
                    string Query = "SP_Train";
                    con.Open();
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@ACTION", "D");
                    param.Add("@TrainNo", TrainNo);
                    var result = await con.QueryAsync<Train>(Query, param, commandType: CommandType.StoredProcedure);
                    return result.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<Train>> GetTrain()
        {
            try
            {
                using (IDbConnection con = connection)
                {
                    string Query = "SP_Train";
                    con.Open();
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@ACTION", "A");
                    var result = await con.QueryAsync<Train>(Query,param,commandType: CommandType.StoredProcedure);
                    return result.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<Train> GetTrainByNo(int TrainNo)
        {
            try
            {
                using (IDbConnection con = connection)
                {
                    string sQuery = "SP_Train";
                    con.Open();
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@ACTION", "G");
                    param.Add("@TrainNo", TrainNo);
                    var result = await con.QueryAsync<Train>(sQuery, param, commandType: CommandType.StoredProcedure);
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