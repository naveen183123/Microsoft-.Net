using Microsoft.AspNetCore.Mvc;
using Task6.Models;
using Task6.Repository;
namespace Task6.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TrainController : Controller
    {
        private readonly ITrainRepository _TrainRep;
        public TrainController(ITrainRepository trainRepository)
        {
            _TrainRep = trainRepository;
        }
        [HttpGet]
        public async Task<List<Train>> GetTrain()
        {
            return await _TrainRep.GetTrain();
        }
        [HttpGet("{TrainNo}")]
        public async Task<ActionResult<Train>> GetTrainByNo(int TrainNo)
        {
            return await _TrainRep.GetTrainByNo(TrainNo);
        }

        [HttpPost]
        public async Task<ActionResult<Train>> ADDEditTrain([FromBody] Train train)
        {
            if (train == null || !ModelState.IsValid)
            {
                return BadRequest("Invalid State");
            }

            return await _TrainRep.ADDEditTrain(train);
        }

        [HttpDelete("{TrainNo}")]
        public async Task<ActionResult<Train>> DeleteTrain(int TrainNo)
        {
            return await _TrainRep.DeleteTrain(TrainNo);
        }
    }
}