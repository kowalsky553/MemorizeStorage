using Microsoft.AspNetCore.Mvc;
using SquadMemoryService.Models;

namespace SquadMemoryService.Controllers
{
    public class MemoryController
    {
        [HttpGet("{id}", Name = "Get")]
        public Memorize Get(string squadId)
        {

            var memorySrorage = SquadMemoryStorage.GetInstance();
            return memorySrorage.GetMostImportantMemorize(squadId);
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
            var memorize = 
        }
    }
}
