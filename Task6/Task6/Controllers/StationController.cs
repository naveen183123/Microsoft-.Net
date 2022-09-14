using Microsoft.AspNetCore.Mvc;
using Task6.Models;
using Task6.Repository;

namespace Task6.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StationController : Controller
    {
        private readonly IStationRepository _StationRep;
        public StationController(IStationRepository stationRepository)
        {
            _StationRep = stationRepository;
        }
        [HttpGet]
        public async Task<List<Station>> GetStation()
        {
            return await _StationRep.GetStation();
        }
        [HttpGet("{StationNo}")]
        public async Task<ActionResult<Station>> GetStationByNo(int StationNo)
        {
            return await _StationRep.GetStationByNo(StationNo);
        }

        [HttpPost]
        public async Task<ActionResult<Station>> ADDStation([FromBody] Station station)
        {
            if (station == null || !ModelState.IsValid)
            {
                return BadRequest("Invalid State");
            }
            return await _StationRep.ADDStation(station);
        }

        [HttpDelete("{StationNo}")]
        public async Task<ActionResult<Station>> DeleteStation(int StationNo)
        {
            return await _StationRep.DeleteStation(StationNo);
        }
        [HttpGet("{TrainNo}/{Time}")]
        public async Task<ActionResult<Station>> GetStationList(int TrainNo, string Time)
        {
            return await _StationRep.GetStationList(TrainNo,Time);
        }
        [HttpGet("{StationName}/{Time}")]
        public async Task<ActionResult<Station>> GetTrainList(string StationName, string Time)
        {
            return await _StationRep.GetTrainList(StationName, Time);
        }
        [HttpGet("{Date}")]
        public async Task<ActionResult<Station>> GetTrainSchedule(string Date)
        {
            return await _StationRep.GetTrainSchedule(Date);
        }
    }
}