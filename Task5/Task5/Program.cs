using System;
using System.Linq;
using Dapper;
using System.Data.SqlClient;
namespace Task5
{
    public class Train
    {
        public int TrainNo { get; set; }
        public String TrainName { get; set; }
        public override string ToString()
        {
            return $"{TrainNo} {TrainName}";
        }
        
        static void Main(String[] args)
        {
            var ConnectionString= @"Server=NAVEEN-VAKAMALL;Database=TrainDB;Trusted_Connection=True;";
            int InsertTrain(Train tra)
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    var affectedRows = connection.Execute("Insert into Train (TrainName,TrainNo ) values (@Name, @Marks)", new {Name = Train.TrainName, Marks = Train.TrainNo });
                    connection.Close();
                    return affectedRows;
                }
            }
            using var Connection = new SqlConnection(ConnectionString);
            Connection.Open();
            var Trains = Connection.Query<Train>("").ToList();
            Trains.ForEach(tr => Console.WriteLine(tr));
        }

    }

}