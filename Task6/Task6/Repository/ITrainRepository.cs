using System.Data;
using Task6.Models;

namespace Task6.Repository
{
    public interface ITrainRepository
    {
        Task<List<Train>> GetTrain();
        Task<Train> GetTrainByNo(int TrainNo);
        Task<Train> ADDEditTrain(Train train);
        Task<Train> DeleteTrain(int TrainNo);
    }
}