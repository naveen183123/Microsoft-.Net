using System.Data;
using Task6.Models;

namespace Task6.Repository
{
    public interface IStationRepository
    {
        Task<List<Station>> GetStation();
        Task<Station> GetStationByNo(int StationNo);
        Task<Station> ADDStation(Station station);
        Task<Station> DeleteStation(int StationNo);
        Task<Station> GetTrainList(string StationName, string Time);
        Task<Station> GetStationList(int TrainNo, string Time);
        Task<Station> GetTrainSchedule (string Date);
    }
}